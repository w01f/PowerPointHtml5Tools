using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Limilabs.FTP.Client;

namespace iSpringSiteTuner
{
	class SiteFolder
	{
		private const string SourceFolderSuffix = "_cwl";
		private const string WebContentSuffix = "(Web)";

		private const string AdvertiserFileName = "advertiser.txt";
		private const string DestinationFileName = "destination.txt";
		private const string EmailFileName = "email.txt";
		private const string LogFileName = "log.txt";
		private const string IdFileName = "id.txt";

		private const string OriginalIndexFileName = "index.html";
		private const string PublicIndexFileName = "public.html";
		private const string LoginIndexFileName = "login.html";
		private const string DataFolderName = "data";
		private const string ActivityRegularFileName = "activity-regular.js";
		private const string ActivityLoginFileName = "activity-login.js";
		private const string JqueryFileName = "jquery.js";
		private const string JsonFileName = "json.js";
		private const string MetroNotificationScriptFileName = "metro-notification.js";
		private const string MetroNotificationStyleFileName = "metro-notification.css";
		private const string FontAwesomeStyleFileName = "font-awesome.css";

		private const string SitePathPlaceHolder = "{:siteUrl}";
		private const string EmailPlaceHolder = "{:emails}";
		private const string AdvertiserPlaceHolder = "{:advertiser}";
		private const string FileNamePlaceHolder = "{:file}";

		private const string SiteRootFolder = "html5link";
		private const string FtpRootFolder = "public_html/html5link";


		private readonly string _sourcePath;

		private string _advertiserName;
		private string _webLocationFolderName;
		private string _id;
		private readonly List<string> _emails = new List<string>();

		private string Name
		{
			get
			{
				return Path.GetFileName(_sourcePath)
					.Replace(SourceFolderSuffix, String.Empty)
					.Replace(String.Format("_{0}", _id), String.Empty)
					.Replace(String.Format("{0}_", _webLocationFolderName), String.Empty);
			}
		}

		private string WebContentFolderName
		{
			get { return String.Format("{0} {1}", Name, WebContentSuffix); }
		}

		public SiteFolder(string sourcePath)
		{
			_sourcePath = sourcePath;
			LoadId();
			LoadAdvertiser();
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
				containedFiles.Any(f => String.Equals(Path.GetFileName(f), IdFileName)) &&
				containedFiles.Any(f => String.Equals(Path.GetFileName(f), AdvertiserFileName)) &&
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
					.Replace(")", "") + _id)
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

				File.WriteAllText(Path.Combine(dataFolderPath, MetroNotificationScriptFileName), Properties.Resources.MetroNotificationScriptFileContent);
				processLog.AppendLine(String.Format("File added {0}", MetroNotificationScriptFileName));

				File.WriteAllText(Path.Combine(dataFolderPath, MetroNotificationStyleFileName), Properties.Resources.MetroNotificationStyleFileContent);
				processLog.AppendLine(String.Format("File added {0}", MetroNotificationStyleFileName));

				File.WriteAllText(Path.Combine(dataFolderPath, FontAwesomeStyleFileName), Properties.Resources.FontAwesomeStyleContent);
				processLog.AppendLine(String.Format("File added {0}", FontAwesomeStyleFileName));

				var activityRegularFileContent = Properties.Resources.ActivityRegularFileContent;
				activityRegularFileContent = activityRegularFileContent.Replace(SitePathPlaceHolder, connection.Url);
				activityRegularFileContent = activityRegularFileContent.Replace(EmailPlaceHolder, String.Join(";", _emails));
				activityRegularFileContent = activityRegularFileContent.Replace(AdvertiserPlaceHolder, _advertiserName.Replace("'", @"\'"));
				File.WriteAllText(Path.Combine(dataFolderPath, ActivityRegularFileName), activityRegularFileContent);
				processLog.AppendLine(String.Format("File added {0}", ActivityRegularFileName));

				var activityLoginFileContent = Properties.Resources.ActivityLoginFileContent;
				activityLoginFileContent = activityLoginFileContent.Replace(AdvertiserPlaceHolder, _advertiserName.Replace("'", @"\'"));
				activityLoginFileContent = activityLoginFileContent.Replace(FileNamePlaceHolder, String.Format("{0}.pptx", Name));
				File.WriteAllText(Path.Combine(dataFolderPath, ActivityLoginFileName), activityLoginFileContent);
				processLog.AppendLine(String.Format("File added {0}", ActivityLoginFileName));

				File.WriteAllText(Path.Combine(destinationFolderPath, LoginIndexFileName), Properties.Resources.LoginIndexFileContent);
				processLog.AppendLine(String.Format("File added {0}", LoginIndexFileName));

				var originalIndexFilePath = Path.Combine(destinationFolderPath, OriginalIndexFileName);
				var publicIndexFilePath = Path.Combine(destinationFolderPath, PublicIndexFileName);
				if (!File.Exists(originalIndexFilePath))
					throw new FileNotFoundException(String.Format("Site Index file not found"));

				var indexFileContent = File.ReadAllText(originalIndexFilePath);
				File.Delete(originalIndexFilePath);

				var originalHeadContent = String.Empty;
				var matches = Regex.Matches(indexFileContent, @"<head>([.\S+\n\r\s]*?)<\/head>");
				if (matches.Count > 0 && matches[0].Groups.Count > 1)
					originalHeadContent = matches[0].Groups[1].Value;
				if (!String.IsNullOrEmpty(originalHeadContent))
				{
					if (!originalHeadContent.Contains(Properties.Resources.PublicIndexScriptIncludePart))
					{
						var modifiedHeadContent = String.Format("{0}{2}{1}", originalHeadContent, Properties.Resources.PublicIndexScriptIncludePart, Environment.NewLine);
						File.WriteAllText(publicIndexFilePath, indexFileContent.Replace(originalHeadContent, modifiedHeadContent));
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
					String.Format("HTML5 presentation ready for {0}", _advertiserName),
					String.Format("Your HTML5 Web Link is ready for: {0}{3}{3}" +
								  "Public URL{3}{1}{3}{3}" +
								  "Client Login URL{3}{2}{3}{3}" +
								  "*Please Note:{3}You will receive a confirmation email each time someone views this presentation.{3}{3}{3}" +
								  "If you have any technical issues with your HTML5 web link, then email:{3}billy@adSALESapps.com",
						_advertiserName,
						String.Format("{0}/{1}/{2}/{3}/{4}", connection.Url, SiteRootFolder, _webLocationFolderName, convertedFolderName, PublicIndexFileName),
						String.Format("{0}/{1}/{2}/{3}/{4}", connection.Url, SiteRootFolder, _webLocationFolderName, convertedFolderName, LoginIndexFileName),
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

		private void LoadId()
		{
			var idFile = Path.Combine(_sourcePath, IdFileName);
			if (!File.Exists(idFile))
				throw new FileNotFoundException(String.Format("{0} not found", IdFileName));
			_id = File.ReadAllText(idFile);
		}

		private void LoadAdvertiser()
		{
			var advertiserSettingsFile = Path.Combine(_sourcePath, AdvertiserFileName);
			if (!File.Exists(advertiserSettingsFile))
				throw new FileNotFoundException(String.Format("{0} not found", AdvertiserFileName));
			_advertiserName = File.ReadAllText(advertiserSettingsFile);
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
	}
}
