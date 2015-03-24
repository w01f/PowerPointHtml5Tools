using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DropBoxUploader.Business;
using DropBoxUploader.Interops;

namespace DropBoxUploader
{
	public partial class FormFileDescription : RibbonForm
	{
		private readonly string _filePath;
		private bool _processValidation;

		public FormFileDescription(string filePath)
		{
			InitializeComponent();
			_filePath = filePath;
			labelControlFileName.Text = String.Format(labelControlFileName.Text, Path.GetFileName(_filePath));
			if (!String.IsNullOrEmpty(Properties.Settings.Default.Email))
			{
				textEditEmail1.EditValue = Properties.Settings.Default.Email;
				textEditEmail2.EditValue = Properties.Settings.Default.Email;
			}
			textEditHidden.Focus();
		}

		public FileDescription GetFileDescription()
		{
			return new FileDescription
			{
				FilePath = _filePath,
				Advertiser = textEditAdvertiser.EditValue as String,
				UserEmail = textEditEmail1.EditValue as String,
			};
		}

		private void textEditAdvertiser_Validating(object sender, CancelEventArgs e)
		{
			var edit = sender as BaseEdit;
			var value = edit.EditValue as String;
			if (value == null)
			{
				edit.ErrorText = "Empty value is not allowed";
				if (_processValidation)
					e.Cancel = true;
			}
		}

		private void textEditEmail1_Validating(object sender, CancelEventArgs e)
		{
			var edit = sender as BaseEdit;
			var value = edit.EditValue as String;
			if (value == null)
			{
				edit.ErrorText = "Empty value is not allowed";
				if (_processValidation)
					e.Cancel = true;
			}
		}

		private void textEditEmail2_Validating(object sender, CancelEventArgs e)
		{
			var edit = sender as BaseEdit;
			var value = edit.EditValue as String;
			if (value == null)
			{
				edit.ErrorText = "Empty value is not allowed";
				if (_processValidation)
					e.Cancel = true;
			}

			var originalEmail = textEditEmail1.EditValue as String;
			if (!String.Equals(value, originalEmail, StringComparison.OrdinalIgnoreCase))
			{
				edit.ErrorText = "Type same emaill address in both Email fields";
				if (_processValidation)
					e.Cancel = true;
			}
		}

		private void simpleButtonSend_Click(object sender, EventArgs e)
		{
			_processValidation = true;
			textEditAdvertiser.Focus();
			textEditEmail1.Focus();
			textEditEmail2.Focus();

			var valid = ValidateChildren();
			_processValidation = false;
			if (!valid) return;
			
			Properties.Settings.Default.Email = textEditEmail1.EditValue as String;
			Properties.Settings.Default.Save();
			
			DialogResult = DialogResult.OK;
			Close();
		}

		private void FormFileDescription_Shown(object sender, EventArgs e)
		{
			WinAPIHelper.ShowWindow(Handle, WindowShowStyle.ShowNormal);
			WinAPIHelper.MakeTopMost(Handle); WinAPIHelper.MakeNormal(Handle);
			uint lpdwProcessId;
			WinAPIHelper.AttachThreadInput(WinAPIHelper.GetCurrentThreadId(), WinAPIHelper.GetWindowThreadProcessId(WinAPIHelper.GetForegroundWindow(), out lpdwProcessId), true);
			WinAPIHelper.SetForegroundWindow(Handle);
			WinAPIHelper.AttachThreadInput(WinAPIHelper.GetCurrentThreadId(), WinAPIHelper.GetWindowThreadProcessId(WinAPIHelper.GetForegroundWindow(), out lpdwProcessId), false);
		}
	}
}
