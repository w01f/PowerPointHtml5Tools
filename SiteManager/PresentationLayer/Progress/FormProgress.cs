using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiteManager.PresentationLayer.Progress
{
	public partial class FormProgress : Form
	{
		public FormProgress()
		{
			InitializeComponent();
			TopMost = true;
			if ((CreateGraphics()).DpiX > 96)
			{
				laProgress.Font = new Font(laProgress.Font.FontFamily, laProgress.Font.Size - 2, laProgress.Font.Style);
			}
		}

		private void FormProgress_Shown(object sender, EventArgs e)
		{
			laProgress.Focus();
		}

		public static void RunProcessWithProgress(string title, Form parent, Action process, Action afterComplete = null)
		{
			using (var formProgress = new FormProgress())
			{
				formProgress.progressPanel.Caption = title;
				formProgress.Shown += async (sender, args) =>
				{
					var form = (Form)sender;
					await Task.Run(process);
					if (afterComplete != null)
						afterComplete();
					parent.Invoke(new MethodInvoker(form.Close));
				};
				formProgress.ShowDialog(parent);
			}
		}
	}
}