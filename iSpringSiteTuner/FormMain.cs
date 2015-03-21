﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using iSpringSiteTuner.Properties;

namespace iSpringSiteTuner
{
	public partial class FormMain : RibbonForm
	{
		private const string SitesSourceFileName = "Sites.xml";

		private readonly string _rootPath;
		private bool _processValidation;
		public FormMain()
		{
			_rootPath = Path.GetDirectoryName(GetType().Assembly.Location);
			InitializeComponent();
		}

		private IEnumerable<ConnectionSettings> GetSites()
		{
			var filePath = Path.Combine(_rootPath, SitesSourceFileName);
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


		private bool ProcessSites()
		{
			var conversionBinPath = buttonEditConversionBin.EditValue as String;
			var uploadPath = buttonEditUploadPath.EditValue as String;
			var connection = comboBoxEditSiteUrl.EditValue as ConnectionSettings;
			var result = true;
			foreach (var siteFolder in Directory.GetDirectories(conversionBinPath)
				.Where(SiteFolder.IsSiteFolder)
				.Select(item => new SiteFolder(item)))
			{
				result &= siteFolder.Process(uploadPath, connection);
			}
			return result;
		}

		private void FormMain_Load(object sender, EventArgs e)
		{
			var conversionBinPath = Settings.Default.ConversionBinPath;
			if (!String.IsNullOrEmpty(conversionBinPath))
				buttonEditConversionBin.EditValue = conversionBinPath;

			var uploadPath = Settings.Default.UploadFolderPath;
			if (!String.IsNullOrEmpty(uploadPath))
				buttonEditUploadPath.EditValue = uploadPath;

			comboBoxEditSiteUrl.Properties.Items.AddRange(GetSites().ToArray());
			if (comboBoxEditSiteUrl.Properties.Items.Count > 0)
				comboBoxEditSiteUrl.SelectedIndex = 0;
		}

		private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
		{
			var conversionBinPath = buttonEditConversionBin.EditValue as String;
			if (!String.IsNullOrEmpty(conversionBinPath))
				Settings.Default.ConversionBinPath = conversionBinPath;

			var uploadPath = buttonEditUploadPath.EditValue as String;
			if (!String.IsNullOrEmpty(uploadPath))
				Settings.Default.UploadFolderPath = uploadPath;

			Settings.Default.Save();
		}

		private void simpleButtonRunProcess_Click(object sender, EventArgs e)
		{
			_processValidation = true;
			buttonEditConversionBin.Focus();
			buttonEditUploadPath.Focus();
			comboBoxEditSiteUrl.Focus();

			_processValidation = true;
			var valid = ValidateChildren();
			_processValidation = false;
			if (!valid)
				return;

			var result = false;
			Enabled = false;
			using (var form = new FormProgress())
			{
				form.Shown += async (o, args) =>
				{
					await Task.Run(() =>
					{
						result = ProcessSites();
					});
					form.Close();
				};
				form.ShowDialog(this);
			}
			Enabled = true;

			if (result)
				MessageBox.Show(this, "Sites modified successfully", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
			else
				MessageBox.Show(this, "Not all sites was modified sucessfully. See error logs for details", Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}

		private void buttonEditPath_Validating(object sender, System.ComponentModel.CancelEventArgs e)
		{
			var edit = sender as BaseEdit;
			var value = edit.EditValue as String;
			if (String.IsNullOrEmpty(value))
			{
				edit.ErrorText = "Empty value is not allowed";
				if (_processValidation)
					e.Cancel = true;
				return;
			}
			if (!Directory.Exists(value))
			{
				edit.ErrorText = "Seleced folder does not exist";
				if (_processValidation)
					e.Cancel = true;
				return;
			}
		}

		private void comboBoxEditSiteUrl_Validating(object sender, System.ComponentModel.CancelEventArgs e)
		{
			var edit = sender as BaseEdit;
			var value = edit.EditValue as ConnectionSettings;
			if (value == null)
			{
				edit.ErrorText = "Empty value is not allowed";
				if (_processValidation)
					e.Cancel = true;
				return;
			}
		}

		private void buttonEditPath_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
		{
			var buttonEdit = (ButtonEdit)sender;
			using (var dialog = new FolderBrowserDialog())
			{
				dialog.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
				if (dialog.ShowDialog() == DialogResult.OK)
					buttonEdit.EditValue = dialog.SelectedPath;
			}
		}
	}
}
