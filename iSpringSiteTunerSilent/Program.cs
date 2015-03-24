using System;
using System.Diagnostics;
using System.IO;

namespace iSpringSiteTunerSilent
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			var siteTuner = Path.Combine(Path.GetDirectoryName(typeof(Program).Assembly.Location), "iSpringTuner.exe");
			if (!File.Exists(siteTuner)) return;
			try
			{
				var process = new Process();
				process.StartInfo.FileName = siteTuner;
				process.StartInfo.Arguments = "silent";
				process.Start();
			}
			catch { }
		}
	}
}
