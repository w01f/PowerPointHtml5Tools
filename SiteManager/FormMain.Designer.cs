namespace SiteManager
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
			this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
			this.barCheckItemReportsRawData = new DevExpress.XtraBars.BarCheckItem();
			this.ribbonPageReports = new DevExpress.XtraBars.Ribbon.RibbonPage();
			this.ribbonPageGroupReports = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.styleController = new DevExpress.XtraEditors.StyleController();
			this.defaultLookAndFeel = new DevExpress.LookAndFeel.DefaultLookAndFeel();
			this.pnContainer = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.styleController)).BeginInit();
			this.SuspendLayout();
			// 
			// ribbonControl
			// 
			this.ribbonControl.ApplicationButtonText = null;
			this.ribbonControl.ButtonGroupsVertAlign = DevExpress.Utils.VertAlignment.Center;
			this.ribbonControl.ExpandCollapseItem.Id = 0;
			this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.barCheckItemReportsRawData});
			this.ribbonControl.Location = new System.Drawing.Point(0, 0);
			this.ribbonControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.ribbonControl.MaxItemId = 8;
			this.ribbonControl.MdiMergeStyle = DevExpress.XtraBars.Ribbon.RibbonMdiMergeStyle.Never;
			this.ribbonControl.Name = "ribbonControl";
			this.ribbonControl.PageCategoryAlignment = DevExpress.XtraBars.Ribbon.RibbonPageCategoryAlignment.Left;
			this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPageReports});
			this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
			this.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
			this.ribbonControl.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
			this.ribbonControl.ShowToolbarCustomizeItem = false;
			this.ribbonControl.Size = new System.Drawing.Size(860, 147);
			this.ribbonControl.Toolbar.ShowCustomizeItem = false;
			this.ribbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
			this.ribbonControl.SelectedPageChanging += new DevExpress.XtraBars.Ribbon.RibbonPageChangingEventHandler(this.ribbonControl_SelectedPageChanging);
			// 
			// barCheckItemReportsRawData
			// 
			this.barCheckItemReportsRawData.Caption = "RawData";
			this.barCheckItemReportsRawData.Checked = true;
			this.barCheckItemReportsRawData.Id = 7;
			this.barCheckItemReportsRawData.Name = "barCheckItemReportsRawData";
			this.barCheckItemReportsRawData.Tag = "999";
			// 
			// ribbonPageReports
			// 
			this.ribbonPageReports.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupReports});
			this.ribbonPageReports.Name = "ribbonPageReports";
			this.ribbonPageReports.Text = "Reports";
			// 
			// ribbonPageGroupReports
			// 
			this.ribbonPageGroupReports.ItemLinks.Add(this.barCheckItemReportsRawData);
			this.ribbonPageGroupReports.Name = "ribbonPageGroupReports";
			this.ribbonPageGroupReports.ShowCaptionButton = false;
			this.ribbonPageGroupReports.Text = "Reports";
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
			// pnContainer
			// 
			this.pnContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnContainer.Location = new System.Drawing.Point(0, 147);
			this.pnContainer.Name = "pnContainer";
			this.pnContainer.Size = new System.Drawing.Size(860, 497);
			this.pnContainer.TabIndex = 1;
			// 
			// FormMain
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(860, 644);
			this.Controls.Add(this.pnContainer);
			this.Controls.Add(this.ribbonControl);
			this.Name = "FormMain";
			this.Ribbon = this.ribbonControl;
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Site Manager";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.styleController)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
		private DevExpress.XtraEditors.StyleController styleController;
		private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel;
		private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageReports;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupReports;
		public DevExpress.XtraBars.BarCheckItem barCheckItemReportsRawData;
		public System.Windows.Forms.Panel pnContainer;
	}
}

