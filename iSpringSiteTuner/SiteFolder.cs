using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using Limilabs.FTP.Client;

namespace iSpringSiteTuner
{
	class SiteFolder
	{
		private const string SourceFolderSuffix = "_cwl";
		private const string WebContentSuffix = "(Web)";

		private const string DestinationFileName = "destination.txt";
		private const string EmailFileName = "email.txt";
		private const string LogFileName = "log.txt";

		private const string IndexFileName = "index.html";
		private const string DataFolderName = "data";
		private const string ActivityFileName = "activity.js";
		private const string JqueryFileName = "jquery.js";
		private const string JsonFileName = "json.js";

		private const string SitePathPlaceHolder = "{:siteUrl}";
		private const string EmailPlaceHolder = "{:emails}";

		private const string SiteRootFolder = "html5link";
		private const string FtpRootFolder = "public_html/html5link";


		private readonly string _sourcePath;

		private string _webLocationFolderName;
		private readonly List<string> _emails = new List<string>();

		private string Name
		{
			get { return Path.GetFileName(_sourcePath).Replace(SourceFolderSuffix, String.Empty); }
		}

		private string WebContentFolderName
		{
			get { return String.Format("{0} {1}", Name, WebContentSuffix); }
		}

		public SiteFolder(string sourcePath)
		{
			_sourcePath = sourcePath;
			LoadEmailSettings();
			LoadWebLocationFolderName();
		}

		public static bool IsSiteFolder(string folderPath)
		{
			var folderName = Path.GetFileName(folderPath).ToLower();
			if (!folderName.Contains(SourceFolderSuffix))
				return false;
			var containedFiles = Directory.GetFiles(folderPath).ToList();
			return Directory.GetDirectories(folderPath, String.Format("*{0}", WebContentSuffix)).Any() &&
				containedFiles.Any(f => String.Equals(Path.GetFileName(f), DestinationFileName)) &&
				containedFiles.Any(f => String.Equals(Path.GetFileName(f), EmailFileName));
		}

		public bool Process(
			string uploadPath,
			ConnectionSettings connection)
		{
			var processLog = new StringBuilder();

			var uploadGroupPath = Path.Combine(uploadPath, _webLocationFolderName);
			if (!Directory.Exists(uploadGroupPath))
				Directory.CreateDirectory(uploadGroupPath);
			var uploadSitePath = Path.Combine(uploadGroupPath, Path.GetFileName(_sourcePath));

			var currentFolder = _sourcePath;
			bool completedSuccessFully;
			try
			{
				processLog.AppendLine(String.Format("iSpring tune process started at folder {0}", _sourcePath));

				var webContentPath = Path.Combine(_sourcePath, WebContentFolderName);
				var convertedFolderName = (WebContentFolderName.Replace("   ", " ")
					.Replace("  ", " ")
					.Replace(" ", "_")
					.Replace("(", "")
					.Replace(")", "") + GenerateRandomNameSuffix())
					.ToLower();

				var destinationFolderPath = Path.Combine(_sourcePath, convertedFolderName);
				if (!String.Equals(webContentPath, destinationFolderPath, StringComparison.OrdinalIgnoreCase))
				{
					try
					{
						Directory.Move(webContentPath, destinationFolderPath);
					}
					catch (Exception ex)
					{
						throw new UnauthorizedAccessException(String.Format("Error while change folder name with {0}{1}{2}", convertedFolderName, ex.Message, Environment.NewLine));
					}
				}

				processLog.AppendLine(String.Format("Folder name changed with {0}", convertedFolderName));

				var dataFolderPath = Path.Combine(destinationFolderPath, DataFolderName);
				if (!Directory.Exists(dataFolderPath))
					throw new FileNotFoundException(String.Format("Site Data folder {0} not found", dataFolderPath));

				File.WriteAllText(Path.Combine(dataFolderPath, JqueryFileName), Properties.Resources.JQueryFileContent);
				processLog.AppendLine(String.Format("File added {0}", JqueryFileName));

				File.WriteAllText(Path.Combine(dataFolderPath, JsonFileName), Properties.Resources.JSonFileContent);
				processLog.AppendLine(String.Format("File added {0}", JsonFileName));

				var activityFileContent = Properties.Resources.ActivityFileContent;
				activityFileContent = activityFileContent.Replace(SitePathPlaceHolder, connection.Url);
				activityFileContent = activityFileContent.Replace(EmailPlaceHolder, String.Join(";", _emails));
				File.WriteAllText(Path.Combine(dataFolderPath, ActivityFileName), activityFileContent);
				processLog.AppendLine(String.Format("File added {0}", ActivityFileName));

				var indexFilePath = Path.Combine(destinationFolderPath, IndexFileName);
				if (!File.Exists(indexFilePath))
					throw new FileNotFoundException(String.Format("Site Index file not found"));

				var indexFileContent = File.ReadAllText(indexFilePath);

				var originalHeadContent = String.Empty;
				var matches = Regex.Matches(indexFileContent, @"<head>([.\S+\n\r\s]*?)<\/head>");
				if (matches.Count > 0 && matches[0].Groups.Count > 1)
					originalHeadContent = matches[0].Groups[1].Value;
				if (!String.IsNullOrEmpty(originalHeadContent))
				{
					if (!originalHeadContent.Contains(Properties.Resources.IndexScriptIncludePart))
					{
						var modifiedHeadContent = String.Format("{0}{2}{1}", originalHeadContent, Properties.Resources.IndexScriptIncludePart, Environment.NewLine);
						File.WriteAllText(indexFilePath, indexFileContent.Replace(originalHeadContent, modifiedHeadContent));
					}
				}
				processLog.AppendLine("Web Folder html file new code added");

				Directory.Move(_sourcePath, uploadSitePath);
				currentFolder = uploadSitePath;
				processLog.AppendLine(String.Format("CWL PACK Moved to Upload folder ({0})", uploadSitePath));

				using (var ftp = new Ftp())
				{
					ftp.Connect(connection.FtpUrl);
					ftp.Login(connection.Login, connection.Password);

					ftp.ChangeFolder(FtpRootFolder);
					ftp.CreateFolder(_webLocationFolderName);
					ftp.ChangeFolder(_webLocationFolderName);
					ftp.CreateFolder(convertedFolderName);
					ftp.UploadFiles(convertedFolderName, Path.Combine(uploadSitePath, convertedFolderName));

					ftp.Close();
				}
				processLog.AppendLine("Web Folder uploaded with web services to clientweblink.com");

				OutlookHelper.Instance.SendMessage(
					"HTML5 presentation ready",
					String.Format("Your HTML5 Presentation link is ready:{1}{1}{0}",
						String.Format("{0}/{1}/{2}/{3}/{4}", connection.Url, SiteRootFolder, _webLocationFolderName, convertedFolderName, IndexFileName),
						Environment.NewLine),
					_emails);
				processLog.AppendLine(String.Format("Confirmation email with URL sent to {0}", String.Join(";", _emails)));

				processLog.AppendLine("iSpring tune process completed successfully");
				completedSuccessFully = true;
			}
			catch (Exception ex)
			{
				processLog.AppendLine("iSpring tune process completed unsuccessfully");
				processLog.AppendLine(ex.Message);
				processLog.AppendLine(ex.StackTrace);
				completedSuccessFully = false;
			}
			finally
			{
				var logFilePath = Path.Combine(currentFolder, LogFileName);
				File.WriteAllText(logFilePath, processLog.ToString());
			}
			return completedSuccessFully;
		}

		private void LoadEmailSettings()
		{
			var emailSettingsFile = Path.Combine(_sourcePath, EmailFileName);
			if (!File.Exists(emailSettingsFile))
				throw new FileNotFoundException(String.Format("{0} not found", EmailFileName));
			_emails.Clear();
			_emails.AddRange(File.ReadAllText(emailSettingsFile).Split(';').Select(item => item.Trim()).Where(item => !String.IsNullOrEmpty(item)));
		}

		private void LoadWebLocationFolderName()
		{
			var destinationSettingsFile = Path.Combine(_sourcePath, DestinationFileName);
			if (!File.Exists(destinationSettingsFile))
				throw new FileNotFoundException(String.Format("{0} not found", DestinationFileName));
			_webLocationFolderName = File.ReadAllText(destinationSettingsFile);
		}

		private static string GenerateRandomNameSuffix()
		{
			const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
			const string digits = "0123456789";
			var random = new Random();
			return String.Format("{0}{1}{2}",
				new String(Enumerable.Repeat(chars, 2).Select(s => s[random.Next(s.Length)]).ToArray()),
				new String(Enumerable.Repeat(digits, 3).Select(s => s[random.Next(s.Length)]).ToArray()),
				new String(Enumerable.Repeat(chars, 2).Select(s => s[random.Next(s.Length)]).ToArray()));
		}

		private static void DeleteFolder(string folderPath)
		{
			try
			{
				foreach (var subFolderPath in Directory.GetDirectories(folderPath))
					DeleteFolder(subFolderPath);
				foreach (var filePath in Directory.GetFiles(folderPath))
				{
					try
					{
						if (File.Exists(filePath))
						{
							File.SetAttributes(filePath, FileAttributes.Normal);
							File.Delete(filePath);
						}
					}
					catch
					{
						try
						{
							Thread.Sleep(100);
							if (File.Exists(filePath))
								File.Delete(filePath);
						}
						catch { }
					}
				}
				try
				{
					if (Directory.Exists(folderPath))
						Directory.Delete(folderPath, false);
				}
				catch
				{
					try
					{
						Thread.Sleep(100);
						if (Directory.Exists(folderPath))
							Directory.Delete(folderPath, false);
					}
					catch { }
				}
			}
			catch { }
		}
	}
}
