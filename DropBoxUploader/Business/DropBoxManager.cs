using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Reflection;
using System.Text;
using AppLimit.CloudComputing.SharpBox;
using AppLimit.CloudComputing.SharpBox.StorageProvider.DropBox;

namespace DropBoxUploader.Business
{
	internal class DropBoxManager
	{
		private const string SecurityTokenFileName = "SharpDropBox.Token";
		private const string FtpDestinationFileName = "destination.txt";
		private const string AdvertiserFileName = "advertiser.txt";
		private const string EmailFileName = "email.txt";

		private const string NotificationRecipientsFileName = "notification_recipients.txt";
		private const string SMTPAddress = "smtp.office365.com";
		private const string SMTPLogin = "clientweblink@adsalesapps.com";
		private const string SMTPPassword = "CamNewton34";


		private static readonly DropBoxManager _instance = new DropBoxManager();

		public static DropBoxManager Instance
		{
			get { return _instance; }
		}

		private DropBoxManager() { }

		public bool UploadFile(FileDescription fileDescription)
		{
			var appRootFolderPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

			var ftpDestinationName = String.Empty;
			var ftpDestinationFilePath = Path.Combine(appRootFolderPath, FtpDestinationFileName);
			if (File.Exists(ftpDestinationFilePath))
				ftpDestinationName = File.ReadAllText(ftpDestinationFilePath).Trim();

			var fileSetName = String.Format("{0}{1}_cwl",
				!String.IsNullOrEmpty(ftpDestinationName) ? String.Format("{0}_", ftpDestinationName) : String.Empty,
				Path.GetFileNameWithoutExtension(fileDescription.FilePath));

			try
			{
				var dropBoxStorage = new CloudStorage();
				var dropBoxConfig = (DropBoxConfiguration)CloudStorage.GetCloudConfigurationEasy(nSupportedCloudConfigurations.DropBox);


				ICloudStorageAccessToken accessToken;
				using (var fs = File.Open(
					Path.Combine(appRootFolderPath, SecurityTokenFileName),
					FileMode.Open,
					FileAccess.Read,
					FileShare.None))
				{
					accessToken = dropBoxStorage.DeserializeSecurityToken(fs);
				}
				dropBoxStorage.Open(dropBoxConfig, accessToken);
				var dropBoxRootFolder = dropBoxStorage.GetRoot();



				var destinationFolder = dropBoxStorage.GetFolder(fileSetName, dropBoxRootFolder, false) ??
					dropBoxStorage.CreateFolder(fileSetName, dropBoxRootFolder);

				dropBoxStorage.UploadFile(fileDescription.FilePath, destinationFolder);
				dropBoxStorage.UploadFile(ftpDestinationFilePath, destinationFolder);
				dropBoxStorage.UploadFile(new MemoryStream(Encoding.Default.GetBytes(fileDescription.Advertiser)), AdvertiserFileName, destinationFolder);
				dropBoxStorage.UploadFile(new MemoryStream(Encoding.Default.GetBytes(fileDescription.UserEmail)), EmailFileName, destinationFolder);

				dropBoxStorage.Close();
			}
			catch (Exception ex)
			{
				File.WriteAllText("error.txt", String.Format("{0}{1}{2}", ex.Message, ex.StackTrace, Environment.NewLine));
				return false;
			}

			var notificationRecipients = String.Empty;
			var notificationRecipientsFilePath = Path.Combine(appRootFolderPath, NotificationRecipientsFileName);
			if (File.Exists(notificationRecipientsFilePath))
				notificationRecipients = String.Join("; ", File.ReadAllText(notificationRecipientsFilePath).Trim().Split(';').Select(item => item.Trim()).Where(item => !String.IsNullOrEmpty(item)));
			if (!String.IsNullOrEmpty(notificationRecipients))
			{
				try
				{
					using (var client = new SmtpClient())
					using (var mail = new MailMessage(SMTPLogin, notificationRecipients))
					{
						client.Port = 587;
						client.Credentials = new NetworkCredential(SMTPLogin, SMTPPassword);
						client.Host = SMTPAddress;
						client.DeliveryMethod = SmtpDeliveryMethod.Network;
						client.EnableSsl = true;

						mail.Subject = String.Format("Client Weblink Alert: {0}", fileSetName);
						mail.Body = String.Format("{0}{4}{1}{4}{2}{4}{3}",
							fileSetName,
							fileDescription.Advertiser,
							ftpDestinationName,
							fileDescription.UserEmail,
							Environment.NewLine);

						client.Send(mail);
					}
				}
				catch (Exception ex)
				{
					File.WriteAllText("error.txt", String.Format("{0}{1}{2}", ex.Message, ex.StackTrace, Environment.NewLine));
				}
			}
			return true;
		}
	}
}
