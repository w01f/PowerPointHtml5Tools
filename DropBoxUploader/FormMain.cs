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

		public FormMain()
		{
			InitializeComponent();
		}

		private async void UploadFile(FileDescription fileDescription)
		{
			Invoke(new MethodInvoker(() => pnProgress.BringToFront()));
			var result = false;
			await Task.Run(() => result = DropBoxManager.Instance.UploadFile(fileDescription));
			Invoke(new MethodInvoker(() =>
			{
				simpleButtonUpload.BringToFront();
				if (result)
				{
					using (var form = new FormSuccess(fileDescription.Advertiser))
					{
						form.ShowDialog();
						Close();
					}
				}
				else
					MessageBox.Show("Error occured while uploading file. Contanct your system adminisrator.", "ClientWebLink", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

		#region Form Visualization
		private void FormMain_Shown(object sender, EventArgs e)
		{
			Left = Screen.PrimaryScreen.Bounds.Right - Width - 10;
			Top = Screen.PrimaryScreen.Bounds.Bottom - Height - 40;
		}
		#endregion
	}
}
