using System;
using System.Windows.Forms;

namespace iSpringSiteTuner
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main(string[] args)
		{
			var silent = args != null && args.Length > 0 && args[0].ToUpper().Equals("SILENT");
			if (!silent)
			{
				Application.EnableVisualStyles();
				Application.SetCompatibleTextRenderingDefault(false);
				Application.Run(new FormMain());
			}
			else
				AppManager.ProcessSitesSilent();
		}
	}
}
