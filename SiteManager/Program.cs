using System;
using System.Threading;
using System.Windows.Forms;
using SiteManager.Controllers;

namespace SiteManager
{
	static class Program
	{
		private static Mutex _mutex;
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			bool firstInstance;
			_mutex = new Mutex(false, "Local\\ClientWebLinksSiteManagerApplication", out firstInstance);
			if (firstInstance)
			{
				Application.EnableVisualStyles();
				Application.SetCompatibleTextRenderingDefault(false);
				MainController.Instance.RunApplication();
			}
			else
				MainController.Instance.ActivateApplication();
		}
	}
}
