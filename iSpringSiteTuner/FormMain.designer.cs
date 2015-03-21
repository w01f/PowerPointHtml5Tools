﻿namespace iSpringSiteTuner
{
	partial class FormMain
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.labelControlSiteUrl = new DevExpress.XtraEditors.LabelControl();
			this.styleController = new DevExpress.XtraEditors.StyleController(this.components);
			this.simpleButtonApply = new DevExpress.XtraEditors.SimpleButton();
			this.defaultLookAndFeel = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
			this.comboBoxEditSiteUrl = new DevExpress.XtraEditors.ComboBoxEdit();
			this.buttonEditConversionBin = new DevExpress.XtraEditors.ButtonEdit();
			this.labelControlConversionBin = new DevExpress.XtraEditors.LabelControl();
			this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
			this.barButtonItemSave = new DevExpress.XtraBars.BarButtonItem();
			this.barEditItemSites = new DevExpress.XtraBars.BarEditItem();
			this.barButtonItemSourceFile = new DevExpress.XtraBars.BarButtonItem();
			this.barButtonGroupFiles = new DevExpress.XtraBars.BarButtonGroup();
			this.barButtonItemOpenLibrary = new DevExpress.XtraBars.BarButtonItem();
			this.barButtonItemOpenLastYearPageViews = new DevExpress.XtraBars.BarButtonItem();
			this.barButtonItemShutdown = new DevExpress.XtraBars.BarButtonItem();
			this.barEditItemFolder = new DevExpress.XtraBars.BarEditItem();
			this.barButtonItemShowSettings = new DevExpress.XtraBars.BarButtonItem();
			this.barButtonGroup1 = new DevExpress.XtraBars.BarButtonGroup();
			this.ribbonPageHome = new DevExpress.XtraBars.Ribbon.RibbonPage();
			this.ribbonPageGroupSiteSettings = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPageGroupActions = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.buttonEditUploadPath = new DevExpress.XtraEditors.ButtonEdit();
			this.labelControlUploadPath = new DevExpress.XtraEditors.LabelControl();
			((System.ComponentModel.ISupportInitialize)(this.styleController)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.comboBoxEditSiteUrl.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.buttonEditConversionBin.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.buttonEditUploadPath.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// labelControlSiteUrl
			// 
			this.labelControlSiteUrl.Location = new System.Drawing.Point(12, 116);
			this.labelControlSiteUrl.Name = "labelControlSiteUrl";
			this.labelControlSiteUrl.Size = new System.Drawing.Size(68, 16);
			this.labelControlSiteUrl.StyleController = this.styleController;
			this.labelControlSiteUrl.TabIndex = 0;
			this.labelControlSiteUrl.Text = "Hosting Url:";
			// 
			// styleController
			// 
			this.styleController.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.styleController.Appearance.Options.UseFont = true;
			this.styleController.AppearanceDisabled.Font = new System.Drawing.Font("Arial", 9.75F);
			this.styleController.AppearanceDisabled.Options.UseFont = true;
			this.styleController.AppearanceDropDown.Font = new System.Drawing.Font("Arial", 9.75F);
			this.styleController.AppearanceDropDown.Options.UseFont = true;
			this.styleController.AppearanceDropDownHeader.Font = new System.Drawing.Font("Arial", 9.75F);
			this.styleController.AppearanceDropDownHeader.Options.UseFont = true;
			this.styleController.AppearanceFocused.Font = new System.Drawing.Font("Arial", 9.75F);
			this.styleController.AppearanceFocused.Options.UseFont = true;
			this.styleController.AppearanceReadOnly.Font = new System.Drawing.Font("Arial", 9.75F);
			this.styleController.AppearanceReadOnly.Options.UseFont = true;
			// 
			// simpleButtonApply
			// 
			this.simpleButtonApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.simpleButtonApply.Location = new System.Drawing.Point(84, 158);
			this.simpleButtonApply.Name = "simpleButtonApply";
			this.simpleButtonApply.Size = new System.Drawing.Size(277, 32);
			this.simpleButtonApply.StyleController = this.styleController;
			this.simpleButtonApply.TabIndex = 4;
			this.simpleButtonApply.Text = "Run Sites Configuration Process...";
			this.simpleButtonApply.Click += new System.EventHandler(this.simpleButtonRunProcess_Click);
			// 
			// defaultLookAndFeel
			// 
			this.defaultLookAndFeel.LookAndFeel.SkinName = "Office 2013";
			// 
			// comboBoxEditSiteUrl
			// 
			this.comboBoxEditSiteUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.comboBoxEditSiteUrl.Location = new System.Drawing.Point(135, 113);
			this.comboBoxEditSiteUrl.Name = "comboBoxEditSiteUrl";
			this.comboBoxEditSiteUrl.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.comboBoxEditSiteUrl.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
			this.comboBoxEditSiteUrl.Size = new System.Drawing.Size(303, 22);
			this.comboBoxEditSiteUrl.StyleController = this.styleController;
			this.comboBoxEditSiteUrl.TabIndex = 3;
			this.comboBoxEditSiteUrl.Validating += new System.ComponentModel.CancelEventHandler(this.comboBoxEditSiteUrl_Validating);
			// 
			// buttonEditConversionBin
			// 
			this.buttonEditConversionBin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonEditConversionBin.Location = new System.Drawing.Point(135, 37);
			this.buttonEditConversionBin.Name = "buttonEditConversionBin";
			this.buttonEditConversionBin.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
			this.buttonEditConversionBin.Size = new System.Drawing.Size(303, 22);
			this.buttonEditConversionBin.StyleController = this.styleController;
			this.buttonEditConversionBin.TabIndex = 1;
			this.buttonEditConversionBin.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.buttonEditPath_ButtonClick);
			this.buttonEditConversionBin.Validating += new System.ComponentModel.CancelEventHandler(this.buttonEditPath_Validating);
			// 
			// labelControlConversionBin
			// 
			this.labelControlConversionBin.Location = new System.Drawing.Point(12, 40);
			this.labelControlConversionBin.Name = "labelControlConversionBin";
			this.labelControlConversionBin.Size = new System.Drawing.Size(90, 16);
			this.labelControlConversionBin.StyleController = this.styleController;
			this.labelControlConversionBin.TabIndex = 6;
			this.labelControlConversionBin.Text = "Conversion Bin:";
			// 
			// ribbonControl
			// 
			this.ribbonControl.ApplicationButtonText = null;
			this.ribbonControl.ButtonGroupsVertAlign = DevExpress.Utils.VertAlignment.Center;
			this.ribbonControl.ExpandCollapseItem.Id = 0;
			this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.barButtonItemSave,
            this.barEditItemSites,
            this.barButtonItemSourceFile,
            this.barButtonGroupFiles,
            this.barButtonItemOpenLibrary,
            this.barButtonItemOpenLastYearPageViews,
            this.barButtonItemShutdown,
            this.barEditItemFolder,
            this.barButtonItemShowSettings,
            this.barButtonGroup1});
			this.ribbonControl.Location = new System.Drawing.Point(0, 0);
			this.ribbonControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.ribbonControl.MaxItemId = 1;
			this.ribbonControl.MdiMergeStyle = DevExpress.XtraBars.Ribbon.RibbonMdiMergeStyle.Never;
			this.ribbonControl.Name = "ribbonControl";
			this.ribbonControl.PageCategoryAlignment = DevExpress.XtraBars.Ribbon.RibbonPageCategoryAlignment.Left;
			this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPageHome});
			this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2007;
			this.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
			this.ribbonControl.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
			this.ribbonControl.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
			this.ribbonControl.ShowToolbarCustomizeItem = false;
			this.ribbonControl.Size = new System.Drawing.Size(445, 32);
			this.ribbonControl.Toolbar.ShowCustomizeItem = false;
			this.ribbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
			// 
			// barButtonItemSave
			// 
			this.barButtonItemSave.Caption = "Save";
			this.barButtonItemSave.Id = 1;
			this.barButtonItemSave.Name = "barButtonItemSave";
			// 
			// barEditItemSites
			// 
			this.barEditItemSites.Caption = "Site              ";
			this.barEditItemSites.Edit = null;
			this.barEditItemSites.Id = 2;
			this.barEditItemSites.Name = "barEditItemSites";
			this.barEditItemSites.Width = 300;
			// 
			// barButtonItemSourceFile
			// 
			this.barButtonItemSourceFile.Caption = "Open Source Excel File";
			this.barButtonItemSourceFile.Id = 3;
			this.barButtonItemSourceFile.Name = "barButtonItemSourceFile";
			// 
			// barButtonGroupFiles
			// 
			this.barButtonGroupFiles.Caption = "Files";
			this.barButtonGroupFiles.Id = 4;
			this.barButtonGroupFiles.Name = "barButtonGroupFiles";
			this.barButtonGroupFiles.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
			// 
			// barButtonItemOpenLibrary
			// 
			this.barButtonItemOpenLibrary.Caption = "Open Site Folder";
			this.barButtonItemOpenLibrary.Id = 5;
			this.barButtonItemOpenLibrary.Name = "barButtonItemOpenLibrary";
			// 
			// barButtonItemOpenLastYearPageViews
			// 
			this.barButtonItemOpenLastYearPageViews.Caption = "Open Last Year Page Views";
			this.barButtonItemOpenLastYearPageViews.Id = 6;
			this.barButtonItemOpenLastYearPageViews.Name = "barButtonItemOpenLastYearPageViews";
			// 
			// barButtonItemShutdown
			// 
			this.barButtonItemShutdown.Caption = "Shutdown";
			this.barButtonItemShutdown.Id = 9;
			this.barButtonItemShutdown.Name = "barButtonItemShutdown";
			// 
			// barEditItemFolder
			// 
			this.barEditItemFolder.Caption = "Sites Folder:";
			this.barEditItemFolder.Edit = null;
			this.barEditItemFolder.Id = 11;
			this.barEditItemFolder.Name = "barEditItemFolder";
			this.barEditItemFolder.Width = 300;
			// 
			// barButtonItemShowSettings
			// 
			this.barButtonItemShowSettings.Caption = "Pacing\r\nand\r\nHyperlinks";
			this.barButtonItemShowSettings.Id = 12;
			this.barButtonItemShowSettings.Name = "barButtonItemShowSettings";
			this.barButtonItemShowSettings.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
			// 
			// barButtonGroup1
			// 
			this.barButtonGroup1.Caption = "barButtonGroup1";
			this.barButtonGroup1.Id = 14;
			this.barButtonGroup1.Name = "barButtonGroup1";
			this.barButtonGroup1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
			// 
			// ribbonPageHome
			// 
			this.ribbonPageHome.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupSiteSettings,
            this.ribbonPageGroupActions});
			this.ribbonPageHome.Name = "ribbonPageHome";
			this.ribbonPageHome.Text = "Home";
			// 
			// ribbonPageGroupSiteSettings
			// 
			this.ribbonPageGroupSiteSettings.AllowMinimize = false;
			this.ribbonPageGroupSiteSettings.AllowTextClipping = false;
			this.ribbonPageGroupSiteSettings.ItemLinks.Add(this.barEditItemFolder);
			this.ribbonPageGroupSiteSettings.ItemLinks.Add(this.barEditItemSites);
			this.ribbonPageGroupSiteSettings.ItemLinks.Add(this.barButtonItemSave);
			this.ribbonPageGroupSiteSettings.ItemLinks.Add(this.barButtonItemSourceFile, true);
			this.ribbonPageGroupSiteSettings.ItemLinks.Add(this.barButtonItemOpenLibrary);
			this.ribbonPageGroupSiteSettings.ItemLinks.Add(this.barButtonItemOpenLastYearPageViews);
			this.ribbonPageGroupSiteSettings.ItemLinks.Add(this.barButtonItemShowSettings, true);
			this.ribbonPageGroupSiteSettings.Name = "ribbonPageGroupSiteSettings";
			this.ribbonPageGroupSiteSettings.ShowCaptionButton = false;
			this.ribbonPageGroupSiteSettings.Text = "Site Settings";
			// 
			// ribbonPageGroupActions
			// 
			this.ribbonPageGroupActions.ItemLinks.Add(this.barButtonItemShutdown);
			this.ribbonPageGroupActions.Name = "ribbonPageGroupActions";
			this.ribbonPageGroupActions.ShowCaptionButton = false;
			// 
			// buttonEditUploadPath
			// 
			this.buttonEditUploadPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonEditUploadPath.Location = new System.Drawing.Point(135, 75);
			this.buttonEditUploadPath.Name = "buttonEditUploadPath";
			this.buttonEditUploadPath.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
			this.buttonEditUploadPath.Size = new System.Drawing.Size(303, 22);
			this.buttonEditUploadPath.StyleController = this.styleController;
			this.buttonEditUploadPath.TabIndex = 2;
			this.buttonEditUploadPath.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.buttonEditPath_ButtonClick);
			this.buttonEditUploadPath.Validating += new System.ComponentModel.CancelEventHandler(this.buttonEditPath_Validating);
			// 
			// labelControlUploadPath
			// 
			this.labelControlUploadPath.Location = new System.Drawing.Point(12, 78);
			this.labelControlUploadPath.Name = "labelControlUploadPath";
			this.labelControlUploadPath.Size = new System.Drawing.Size(84, 16);
			this.labelControlUploadPath.StyleController = this.styleController;
			this.labelControlUploadPath.TabIndex = 9;
			this.labelControlUploadPath.Text = "Upload Folder:";
			// 
			// FormMain
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(445, 202);
			this.Controls.Add(this.buttonEditUploadPath);
			this.Controls.Add(this.labelControlUploadPath);
			this.Controls.Add(this.buttonEditConversionBin);
			this.Controls.Add(this.labelControlConversionBin);
			this.Controls.Add(this.comboBoxEditSiteUrl);
			this.Controls.Add(this.simpleButtonApply);
			this.Controls.Add(this.labelControlSiteUrl);
			this.Controls.Add(this.ribbonControl);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormMain";
			this.Ribbon = this.ribbonControl;
			this.RibbonVisibility = DevExpress.XtraBars.Ribbon.RibbonVisibility.Hidden;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "iSpring Site Tuner";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
			this.Load += new System.EventHandler(this.FormMain_Load);
			((System.ComponentModel.ISupportInitialize)(this.styleController)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.comboBoxEditSiteUrl.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.buttonEditConversionBin.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.buttonEditUploadPath.Properties)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExpress.XtraEditors.LabelControl labelControlSiteUrl;
		private DevExpress.XtraEditors.StyleController styleController;
		private DevExpress.XtraEditors.SimpleButton simpleButtonApply;
		private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel;
		private DevExpress.XtraEditors.ComboBoxEdit comboBoxEditSiteUrl;
		private DevExpress.XtraEditors.ButtonEdit buttonEditConversionBin;
		private DevExpress.XtraEditors.LabelControl labelControlConversionBin;
		private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
		private DevExpress.XtraBars.BarButtonItem barButtonItemSave;
		private DevExpress.XtraBars.BarEditItem barEditItemSites;
		private DevExpress.XtraBars.BarButtonItem barButtonItemSourceFile;
		private DevExpress.XtraBars.BarButtonGroup barButtonGroupFiles;
		private DevExpress.XtraBars.BarButtonItem barButtonItemOpenLibrary;
		private DevExpress.XtraBars.BarButtonItem barButtonItemOpenLastYearPageViews;
		private DevExpress.XtraBars.BarButtonItem barButtonItemShutdown;
		private DevExpress.XtraBars.BarEditItem barEditItemFolder;
		private DevExpress.XtraBars.BarButtonItem barButtonItemShowSettings;
		private DevExpress.XtraBars.BarButtonGroup barButtonGroup1;
		private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageHome;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupSiteSettings;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupActions;
		private DevExpress.XtraEditors.ButtonEdit buttonEditUploadPath;
		private DevExpress.XtraEditors.LabelControl labelControlUploadPath;
	}
}

