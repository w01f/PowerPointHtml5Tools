namespace DropBoxUploader
{
	partial class FormFileDescription
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
			this.styleController = new DevExpress.XtraEditors.StyleController();
			this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
			this.simpleButtonSend = new DevExpress.XtraEditors.SimpleButton();
			this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
			this.labelControlTitle = new DevExpress.XtraEditors.LabelControl();
			this.textEditAdvertiser = new DevExpress.XtraEditors.TextEdit();
			this.textEditEmail1 = new DevExpress.XtraEditors.TextEdit();
			this.textEditEmail2 = new DevExpress.XtraEditors.TextEdit();
			this.labelControlFileName = new DevExpress.XtraEditors.LabelControl();
			this.textEditHidden = new DevExpress.XtraEditors.TextEdit();
			((System.ComponentModel.ISupportInitialize)(this.styleController)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textEditAdvertiser.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textEditEmail1.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textEditEmail2.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textEditHidden.Properties)).BeginInit();
			this.SuspendLayout();
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
			this.ribbonControl.Size = new System.Drawing.Size(437, 32);
			this.ribbonControl.Toolbar.ShowCustomizeItem = false;
			this.ribbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
			// 
			// simpleButtonSend
			// 
			this.simpleButtonSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.simpleButtonSend.Location = new System.Drawing.Point(303, 299);
			this.simpleButtonSend.Name = "simpleButtonSend";
			this.simpleButtonSend.Size = new System.Drawing.Size(122, 37);
			this.simpleButtonSend.StyleController = this.styleController;
			this.simpleButtonSend.TabIndex = 6;
			this.simpleButtonSend.Text = "Send";
			this.simpleButtonSend.Click += new System.EventHandler(this.simpleButtonSend_Click);
			// 
			// pictureBoxLogo
			// 
			this.pictureBoxLogo.Image = global::DropBoxUploader.Properties.Resources.Logo;
			this.pictureBoxLogo.Location = new System.Drawing.Point(12, 39);
			this.pictureBoxLogo.Name = "pictureBoxLogo";
			this.pictureBoxLogo.Size = new System.Drawing.Size(80, 69);
			this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBoxLogo.TabIndex = 2;
			this.pictureBoxLogo.TabStop = false;
			// 
			// labelControlTitle
			// 
			this.labelControlTitle.AllowHtmlString = true;
			this.labelControlTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.labelControlTitle.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.labelControlTitle.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
			this.labelControlTitle.Location = new System.Drawing.Point(110, 39);
			this.labelControlTitle.Name = "labelControlTitle";
			this.labelControlTitle.Size = new System.Drawing.Size(315, 69);
			this.labelControlTitle.StyleController = this.styleController;
			this.labelControlTitle.TabIndex = 1;
			this.labelControlTitle.Text = "<size=+5>Create an <b>HTML5 Web Link</b> for</size>\r\n<size=+5>your Client Present" +
    "ation...</size>";
			// 
			// textEditAdvertiser
			// 
			this.textEditAdvertiser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textEditAdvertiser.Location = new System.Drawing.Point(12, 169);
			this.textEditAdvertiser.MenuManager = this.ribbonControl;
			this.textEditAdvertiser.Name = "textEditAdvertiser";
			this.textEditAdvertiser.Properties.NullText = "Type the Advertiser name here...";
			this.textEditAdvertiser.Size = new System.Drawing.Size(413, 22);
			this.textEditAdvertiser.StyleController = this.styleController;
			this.textEditAdvertiser.TabIndex = 3;
			this.textEditAdvertiser.Validating += new System.ComponentModel.CancelEventHandler(this.textEditAdvertiser_Validating);
			// 
			// textEditEmail1
			// 
			this.textEditEmail1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textEditEmail1.Location = new System.Drawing.Point(12, 225);
			this.textEditEmail1.MenuManager = this.ribbonControl;
			this.textEditEmail1.Name = "textEditEmail1";
			this.textEditEmail1.Properties.NullText = "Type your email address here...";
			this.textEditEmail1.Size = new System.Drawing.Size(413, 22);
			this.textEditEmail1.StyleController = this.styleController;
			this.textEditEmail1.TabIndex = 4;
			this.textEditEmail1.Validating += new System.ComponentModel.CancelEventHandler(this.textEditEmail1_Validating);
			// 
			// textEditEmail2
			// 
			this.textEditEmail2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textEditEmail2.Location = new System.Drawing.Point(12, 253);
			this.textEditEmail2.MenuManager = this.ribbonControl;
			this.textEditEmail2.Name = "textEditEmail2";
			this.textEditEmail2.Properties.NullText = "Type your email address AGAIN...";
			this.textEditEmail2.Size = new System.Drawing.Size(413, 22);
			this.textEditEmail2.StyleController = this.styleController;
			this.textEditEmail2.TabIndex = 5;
			this.textEditEmail2.Validating += new System.ComponentModel.CancelEventHandler(this.textEditEmail2_Validating);
			// 
			// labelControlFileName
			// 
			this.labelControlFileName.AllowHtmlString = true;
			this.labelControlFileName.Location = new System.Drawing.Point(12, 128);
			this.labelControlFileName.Name = "labelControlFileName";
			this.labelControlFileName.Size = new System.Drawing.Size(126, 19);
			this.labelControlFileName.StyleController = this.styleController;
			this.labelControlFileName.TabIndex = 2;
			this.labelControlFileName.Text = "<size=+2><b>Presentation:</b> {0}</size>";
			// 
			// textEditHidden
			// 
			this.textEditHidden.Location = new System.Drawing.Point(-10, -10);
			this.textEditHidden.MenuManager = this.ribbonControl;
			this.textEditHidden.Name = "textEditHidden";
			this.textEditHidden.Size = new System.Drawing.Size(10, 20);
			this.textEditHidden.TabIndex = 0;
			// 
			// FormFileDescription
			// 
			this.Appearance.Options.UseFont = true;
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(437, 348);
			this.Controls.Add(this.textEditHidden);
			this.Controls.Add(this.labelControlFileName);
			this.Controls.Add(this.textEditEmail2);
			this.Controls.Add(this.textEditEmail1);
			this.Controls.Add(this.textEditAdvertiser);
			this.Controls.Add(this.labelControlTitle);
			this.Controls.Add(this.pictureBoxLogo);
			this.Controls.Add(this.simpleButtonSend);
			this.Controls.Add(this.ribbonControl);
			this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormFileDescription";
			this.Ribbon = this.ribbonControl;
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ClientWebLink";
			this.Shown += new System.EventHandler(this.FormFileDescription_Shown);
			((System.ComponentModel.ISupportInitialize)(this.styleController)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textEditAdvertiser.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textEditEmail1.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textEditEmail2.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textEditHidden.Properties)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExpress.XtraEditors.StyleController styleController;
		private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
		private DevExpress.XtraEditors.SimpleButton simpleButtonSend;
		private System.Windows.Forms.PictureBox pictureBoxLogo;
		private DevExpress.XtraEditors.LabelControl labelControlTitle;
		private DevExpress.XtraEditors.TextEdit textEditAdvertiser;
		private DevExpress.XtraEditors.TextEdit textEditEmail1;
		private DevExpress.XtraEditors.TextEdit textEditEmail2;
		private DevExpress.XtraEditors.LabelControl labelControlFileName;
		private DevExpress.XtraEditors.TextEdit textEditHidden;
	}
}