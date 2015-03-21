using System;

namespace iSpringSiteTuner
{
	class ConnectionSettings
	{
		public string Url { get; set; }
		public string Login { get; set; }
		public string Password { get; set; }

		public string FtpUrl
		{
			get { return Url.Replace("http://", String.Empty); }
		}

		public override string ToString()
		{
			return Url;
		}
	}
}
