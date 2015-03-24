using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars.Ribbon;
using DropBoxUploader.Business;

namespace DropBoxUploader
{
	public partial class FormMain : RibbonForm
	{
		private const string PowerPointExtension = ".pptx";
		private const string PowerPointExtensionLegacy = ".ppt";

		private bool _firstClose = true;
		public FormMain()
		{
			InitializeComponent();
		}

		private async void UploadFile(FileDescription fileDescription)
		{
			Invoke(new MethodInvoker(() =>
			{
				pnProgress.BringToFront();
				ShowTooltip(String.Format("Start uploading {0}...", fileDescription.FilePath));
			}));
			var result = false;
			await Task.Run(() => result = DropBoxManager.Instance.UploadFile(fileDescription));
			Invoke(new MethodInvoker(() =>
			{
				simpleButtonUpload.BringToFront();
				if (result)
					ShowTooltip(String.Format("{0} uploaded...", fileDescription.FilePath));
				else
					ShowTooltip(String.Format("Error occured while uploading {0}. Try again or contact your system administrator...", fileDescription.FilePath), ToolTipIcon.Warning);
			}));
		}

		private DialogResult GetFileDescription(string filePath, out FileDescription description)
		{
			using (var form = new FormFileDescription(filePath))
			{
				var result = form.ShowDialog(this);
				description = form.GetFileDescription();
				return result;
			}
		}

		private void OnFileUploadClick(object sender, EventArgs e)
		{
			using (var dialog = new OpenFileDialog())
			{
				dialog.Title = "Select PowerPoint Presentation";
				dialog.Filter = String.Format("PowerPoint Files|*{0};*{1}",PowerPointExtension,PowerPointExtensionLegacy);
				dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
				if (dialog.ShowDialog() != DialogResult.OK) return;
				FileDescription fileDescription;
				if (GetFileDescription(dialog.FileName, out fileDescription) != DialogResult.OK) return;
				UploadFile(fileDescription);
			}
		}

		private void simpleButtonUpload_DragOver(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop))
				e.Effect = DragDropEffects.Copy;
		}

		private void simpleButtonUpload_DragDrop(object sender, DragEventArgs e)
		{
			var handles = (string[])e.Data.GetData(DataFormats.FileDrop, false);
			var filePath = handles.FirstOrDefault(path =>
				File.Exists(path) &&
				(String.Equals(Path.GetExtension(path), PowerPointExtension, StringComparison.OrdinalIgnoreCase) ||
				 String.Equals(Path.GetExtension(path), PowerPointExtensionLegacy, StringComparison.OrdinalIgnoreCase)));
			if (String.IsNullOrEmpty(filePath)) return;
			FileDescription fileDescription;
			if (GetFileDescription(filePath, out fileDescription) != DialogResult.OK) return;
			UploadFile(fileDescription);
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		#region Form Visualization
		private void FormMain_Shown(object sender, EventArgs e)
		{
			Left = Screen.PrimaryScreen.Bounds.Right - Width - 10;
			Top = Screen.PrimaryScreen.Bounds.Bottom - Height - 40;
		}

		private void FormMain_ClientSizeChanged(object sender, EventArgs e)
		{
			if (WindowState == FormWindowState.Minimized)
				ShowInTaskbar = false;
			else
				ShowInTaskbar = true;
		}

		private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (e.CloseReason != CloseReason.UserClosing) return;
			e.Cancel = true;
			WindowState = FormWindowState.Minimized;
			if (_firstClose)
			{
				ShowTooltip("Click on tray icon to show window...");
				_firstClose = false;
			}
		}

		private void notifyIcon_MouseClick(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
				WindowState = FormWindowState.Normal;
		}

		public void ShowTooltip(string tooltipText, ToolTipIcon icon = ToolTipIcon.Info)
		{
			notifyIcon.BalloonTipIcon = icon;
			notifyIcon.BalloonTipText = tooltipText;
			notifyIcon.ShowBalloonTip(2000);
		}
		#endregion
	}
}
