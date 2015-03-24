namespace DropBoxUploader
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
			this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
			this.styleController = new DevExpress.XtraEditors.StyleController();
			this.defaultLookAndFeel = new DevExpress.LookAndFeel.DefaultLookAndFeel();
			this.simpleButtonUpload = new DevExpress.XtraEditors.SimpleButton();
			this.notifyIcon = new System.Windows.Forms.NotifyIcon();
			this.contextMenuStripTray = new System.Windows.Forms.ContextMenuStrip();
			this.uploadPresentationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.separatorToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.progressPanel = new DevExpress.XtraWaitForm.ProgressPanel();
			this.pnProgress = new System.Windows.Forms.Panel();
			this.labelControlProgressTitle = new DevExpress.XtraEditors.LabelControl();
			((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.styleController)).BeginInit();
			this.contextMenuStripTray.SuspendLayout();
			this.pnProgress.SuspendLayout();
			this.SuspendLayout();
			// 
			// ribbonControl
			// 
			this.ribbonControl.ApplicationButtonText = null;
			this.ribbonControl.ButtonGroupsVertAlign = DevExpress.Utils.VertAlignment.Center;
			this.ribbonControl.ExpandCollapseItem.Id = 0;
			this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem});
			this.ribbonControl.Location = new System.Drawing.Point(0, 0);
			this.ribbonControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.ribbonControl.MaxItemId = 1;
			this.ribbonControl.MdiMergeStyle = DevExpress.XtraBars.Ribbon.RibbonMdiMergeStyle.Never;
			this.ribbonControl.Name = "ribbonControl";
			this.ribbonControl.PageCategoryAlignment = DevExpress.XtraBars.Ribbon.RibbonPageCategoryAlignment.Left;
			this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2007;
			this.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
			this.ribbonControl.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
			this.ribbonControl.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
			this.ribbonControl.ShowToolbarCustomizeItem = false;
			this.ribbonControl.Size = new System.Drawing.Size(249, 32);
			this.ribbonControl.Toolbar.ShowCustomizeItem = false;
			this.ribbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
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
			// defaultLookAndFeel
			// 
			this.defaultLookAndFeel.LookAndFeel.SkinName = "Office 2013";
			// 
			// simpleButtonUpload
			// 
			this.simpleButtonUpload.AllowDrop = true;
			this.simpleButtonUpload.Dock = System.Windows.Forms.DockStyle.Fill;
			this.simpleButtonUpload.Image = global::DropBoxUploader.Properties.Resources.Logo;
			this.simpleButtonUpload.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
			this.simpleButtonUpload.Location = new System.Drawing.Point(0, 32);
			this.simpleButtonUpload.Name = "simpleButtonUpload";
			this.simpleButtonUpload.Size = new System.Drawing.Size(249, 164);
			this.simpleButtonUpload.TabIndex = 2;
			this.simpleButtonUpload.Click += new System.EventHandler(this.OnFileUploadClick);
			this.simpleButtonUpload.DragDrop += new System.Windows.Forms.DragEventHandler(this.simpleButtonUpload_DragDrop);
			this.simpleButtonUpload.DragOver += new System.Windows.Forms.DragEventHandler(this.simpleButtonUpload_DragOver);
			// 
			// notifyIcon
			// 
			this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
			this.notifyIcon.BalloonTipTitle = "WebClientLink";
			this.notifyIcon.ContextMenuStrip = this.contextMenuStripTray;
			this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
			this.notifyIcon.Text = "WebClientLink";
			this.notifyIcon.Visible = true;
			this.notifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseClick);
			// 
			// contextMenuStripTray
			// 
			this.contextMenuStripTray.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uploadPresentationToolStripMenuItem,
            this.separatorToolStripMenuItem,
            this.exitToolStripMenuItem});
			this.contextMenuStripTray.Name = "contextMenuStripTray";
			this.contextMenuStripTray.Size = new System.Drawing.Size(191, 54);
			// 
			// uploadPresentationToolStripMenuItem
			// 
			this.uploadPresentationToolStripMenuItem.Name = "uploadPresentationToolStripMenuItem";
			this.uploadPresentationToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
			this.uploadPresentationToolStripMenuItem.Text = "Upload Presentation...";
			this.uploadPresentationToolStripMenuItem.Click += new System.EventHandler(this.OnFileUploadClick);
			// 
			// separatorToolStripMenuItem
			// 
			this.separatorToolStripMenuItem.Name = "separatorToolStripMenuItem";
			this.separatorToolStripMenuItem.Size = new System.Drawing.Size(187, 6);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// progressPanel
			// 
			this.progressPanel.Appearance.BackColor = System.Drawing.Color.Transparent;
			this.progressPanel.Appearance.Options.UseBackColor = true;
			this.progressPanel.Appearance.Options.UseTextOptions = true;
			this.progressPanel.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.progressPanel.AppearanceCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.progressPanel.AppearanceCaption.Options.UseFont = true;
			this.progressPanel.AppearanceCaption.Options.UseTextOptions = true;
			this.progressPanel.AppearanceCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.progressPanel.AppearanceDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.progressPanel.AppearanceDescription.Options.UseFont = true;
			this.progressPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.progressPanel.Caption = "";
			this.progressPanel.Description = "";
			this.progressPanel.Dock = System.Windows.Forms.DockStyle.Left;
			this.progressPanel.ImageHorzOffset = 10;
			this.progressPanel.Location = new System.Drawing.Point(0, 0);
			this.progressPanel.Name = "progressPanel";
			this.progressPanel.ShowCaption = false;
			this.progressPanel.ShowDescription = false;
			this.progressPanel.Size = new System.Drawing.Size(70, 164);
			this.progressPanel.TabIndex = 4;
			this.progressPanel.TextHorzOffset = 30;
			// 
			// pnProgress
			// 
			this.pnProgress.Controls.Add(this.labelControlProgressTitle);
			this.pnProgress.Controls.Add(this.progressPanel);
			this.pnProgress.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnProgress.Location = new System.Drawing.Point(0, 32);
			this.pnProgress.Name = "pnProgress";
			this.pnProgress.Size = new System.Drawing.Size(249, 164);
			this.pnProgress.TabIndex = 6;
			// 
			// labelControlProgressTitle
			// 
			this.labelControlProgressTitle.AllowHtmlString = true;
			this.labelControlProgressTitle.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.labelControlProgressTitle.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
			this.labelControlProgressTitle.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelControlProgressTitle.Location = new System.Drawing.Point(70, 0);
			this.labelControlProgressTitle.Name = "labelControlProgressTitle";
			this.labelControlProgressTitle.Size = new System.Drawing.Size(179, 164);
			this.labelControlProgressTitle.StyleController = this.styleController;
			this.labelControlProgressTitle.TabIndex = 5;
			this.labelControlProgressTitle.Text = "<size=+2>Uploading your PPT file \r\nto the HTML5 server…</size>\r\n\r\n<i>After the se" +
    "rver creates your URL, you will receive it in an email…</i>\r\n";
			// 
			// FormMain
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(249, 196);
			this.Controls.Add(this.simpleButtonUpload);
			this.Controls.Add(this.pnProgress);
			this.Controls.Add(this.ribbonControl);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormMain";
			this.Opacity = 0.75D;
			this.Ribbon = this.ribbonControl;
			this.Text = "ClientWebLink";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
			this.Shown += new System.EventHandler(this.FormMain_Shown);
			this.ClientSizeChanged += new System.EventHandler(this.FormMain_ClientSizeChanged);
			((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.styleController)).EndInit();
			this.contextMenuStripTray.ResumeLayout(false);
			this.pnProgress.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
		private DevExpress.XtraEditors.StyleController styleController;
		private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel;
		private DevExpress.XtraEditors.SimpleButton simpleButtonUpload;
		private System.Windows.Forms.NotifyIcon notifyIcon;
		private System.Windows.Forms.ContextMenuStrip contextMenuStripTray;
		private System.Windows.Forms.ToolStripMenuItem uploadPresentationToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator separatorToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private DevExpress.XtraWaitForm.ProgressPanel progressPanel;
		private System.Windows.Forms.Panel pnProgress;
		private DevExpress.XtraEditors.LabelControl labelControlProgressTitle;
	}
}

