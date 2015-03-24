using System;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;

namespace DropBoxUploader
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			var args = Environment.GetCommandLineArgs();
			var controller = new SingleInstanceController();
			controller.Run(args);
		}
	}

	class SingleInstanceController : WindowsFormsApplicationBase
	{
		public SingleInstanceController()
		{
			IsSingleInstance = true;
			StartupNextInstance += OnStartupNextInstance;
		}

		private void OnStartupNextInstance(object sender, StartupNextInstanceEventArgs e)
		{
			var form = (FormMain)MainForm;
			form.WindowState = FormWindowState.Normal;
		}

		protected override void OnCreateMainForm()
		{
			MainForm = new FormMain();
		}
	}
}
