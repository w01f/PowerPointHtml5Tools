using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Xml;
using iSpringSiteTuner.Properties;

namespace iSpringSiteTuner
{
	static class AppManager
	{
		private const string SitesSourceFileName = "Sites.xml";
		
		public static bool ProcessSites(
			string conversionBinPath,
			string uploadPath,
			ConnectionSettings connection)
		{
			var result = true;
			foreach (var siteFolder in Directory.GetDirectories(conversionBinPath)
				.Where(SiteFolder.IsSiteFolder)
				.Select(item => new SiteFolder(item)))
			{
				result &= siteFolder.Process(uploadPath, connection);
			}
			return result;
		}

		public static void ProcessSitesSilent()
		{
			var conversionBinPath = Settings.Default.ConversionBinPath;
			var uploadPath = Settings.Default.UploadFolderPath;
			var connectionSettings = GetSites().FirstOrDefault();
			if (!String.IsNullOrEmpty(conversionBinPath) &&
			    !String.IsNullOrEmpty(uploadPath) &&
			    connectionSettings != null)
				ProcessSites(conversionBinPath, uploadPath, connectionSettings);
		}

		public static IEnumerable<ConnectionSettings> GetSites()
		{
			var rootPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
			var filePath = Path.Combine(rootPath, SitesSourceFileName);
			if (!File.Exists(filePath)) return new ConnectionSettings[] { };
			var document = new XmlDocument();
			document.Load(filePath);
			return document
				.SelectNodes(@"/Sites/Site")
				.OfType<XmlNode>()
				.Select(node => new ConnectionSettings
				{
					Url = node.SelectSingleNode(@"Url").InnerText,
					Login = node.SelectSingleNode(@"User").InnerText,
					Password = node.SelectSingleNode(@"Password").InnerText
				});
		}
	}
}
