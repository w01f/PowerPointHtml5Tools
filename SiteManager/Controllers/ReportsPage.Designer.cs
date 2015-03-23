namespace SiteManager.Controllers
{
	sealed partial class ReportsPage
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.splitContainerControl = new DevExpress.XtraEditors.SplitContainerControl();
			this.pnCustomFilter = new System.Windows.Forms.Panel();
			this.pnFilterButtons = new System.Windows.Forms.Panel();
			this.gbDate = new System.Windows.Forms.GroupBox();
			this.labelControlDateEnd = new DevExpress.XtraEditors.LabelControl();
			this.dateEditEnd = new DevExpress.XtraEditors.DateEdit();
			this.labelControlDateStart = new DevExpress.XtraEditors.LabelControl();
			this.dateEditStart = new DevExpress.XtraEditors.DateEdit();
			this.simpleButtonLoadData = new DevExpress.XtraEditors.SimpleButton();
			this.styleController = new DevExpress.XtraEditors.StyleController();
			((System.ComponentModel.ISupportInitialize)(this.splitContainerControl)).BeginInit();
			this.splitContainerControl.SuspendLayout();
			this.pnFilterButtons.SuspendLayout();
			this.gbDate.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dateEditEnd.Properties.CalendarTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dateEditEnd.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dateEditStart.Properties.CalendarTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dateEditStart.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.styleController)).BeginInit();
			this.SuspendLayout();
			// 
			// splitContainerControl
			// 
			this.splitContainerControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainerControl.Location = new System.Drawing.Point(0, 0);
			this.splitContainerControl.Name = "splitContainerControl";
			this.splitContainerControl.Panel1.Controls.Add(this.pnCustomFilter);
			this.splitContainerControl.Panel1.Controls.Add(this.pnFilterButtons);
			this.splitContainerControl.Panel1.Controls.Add(this.gbDate);
			this.splitContainerControl.Panel1.MinSize = 250;
			this.splitContainerControl.Panel1.Padding = new System.Windows.Forms.Padding(5);
			this.splitContainerControl.Panel1.Text = "Panel1";
			this.splitContainerControl.Panel2.Text = "Panel2";
			this.splitContainerControl.Size = new System.Drawing.Size(833, 619);
			this.splitContainerControl.SplitterPosition = 250;
			this.splitContainerControl.TabIndex = 18;
			this.splitContainerControl.Text = "splitContainerControl1";
			// 
			// pnCustomFilter
			// 
			this.pnCustomFilter.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnCustomFilter.Location = new System.Drawing.Point(5, 149);
			this.pnCustomFilter.Name = "pnCustomFilter";
			this.pnCustomFilter.Size = new System.Drawing.Size(240, 465);
			this.pnCustomFilter.TabIndex = 18;
			// 
			// pnFilterButtons
			// 
			this.pnFilterButtons.Controls.Add(this.simpleButtonLoadData);
			this.pnFilterButtons.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnFilterButtons.Location = new System.Drawing.Point(5, 103);
			this.pnFilterButtons.Name = "pnFilterButtons";
			this.pnFilterButtons.Size = new System.Drawing.Size(240, 46);
			this.pnFilterButtons.TabIndex = 19;
			// 
			// gbDate
			// 
			this.gbDate.Controls.Add(this.labelControlDateEnd);
			this.gbDate.Controls.Add(this.dateEditEnd);
			this.gbDate.Controls.Add(this.labelControlDateStart);
			this.gbDate.Controls.Add(this.dateEditStart);
			this.gbDate.Dock = System.Windows.Forms.DockStyle.Top;
			this.gbDate.Location = new System.Drawing.Point(5, 5);
			this.gbDate.Name = "gbDate";
			this.gbDate.Size = new System.Drawing.Size(240, 98);
			this.gbDate.TabIndex = 17;
			this.gbDate.TabStop = false;
			this.gbDate.Text = "Date range";
			// 
			// labelControlDateEnd
			// 
			this.labelControlDateEnd.Location = new System.Drawing.Point(10, 63);
			this.labelControlDateEnd.Name = "labelControlDateEnd";
			this.labelControlDateEnd.Size = new System.Drawing.Size(58, 16);
			this.labelControlDateEnd.StyleController = this.styleController;
			this.labelControlDateEnd.TabIndex = 3;
			this.labelControlDateEnd.Text = "End Date:";
			// 
			// dateEditEnd
			// 
			this.dateEditEnd.EditValue = null;
			this.dateEditEnd.Location = new System.Drawing.Point(100, 60);
			this.dateEditEnd.Name = "dateEditEnd";
			this.dateEditEnd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.dateEditEnd.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
			this.dateEditEnd.Properties.DisplayFormat.FormatString = "MM/dd/yyyy";
			this.dateEditEnd.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
			this.dateEditEnd.Properties.EditFormat.FormatString = "MM/dd/yyyy";
			this.dateEditEnd.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
			this.dateEditEnd.Size = new System.Drawing.Size(132, 22);
			this.dateEditEnd.StyleController = this.styleController;
			this.dateEditEnd.TabIndex = 2;
			// 
			// labelControlDateStart
			// 
			this.labelControlDateStart.Location = new System.Drawing.Point(10, 24);
			this.labelControlDateStart.Name = "labelControlDateStart";
			this.labelControlDateStart.Size = new System.Drawing.Size(63, 16);
			this.labelControlDateStart.StyleController = this.styleController;
			this.labelControlDateStart.TabIndex = 1;
			this.labelControlDateStart.Text = "Start Date:";
			// 
			// dateEditStart
			// 
			this.dateEditStart.EditValue = null;
			this.dateEditStart.Location = new System.Drawing.Point(100, 21);
			this.dateEditStart.Name = "dateEditStart";
			this.dateEditStart.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.dateEditStart.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
			this.dateEditStart.Properties.DisplayFormat.FormatString = "MM/dd/yyyy";
			this.dateEditStart.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
			this.dateEditStart.Properties.EditFormat.FormatString = "MM/dd/yyyy";
			this.dateEditStart.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
			this.dateEditStart.Size = new System.Drawing.Size(132, 22);
			this.dateEditStart.StyleController = this.styleController;
			this.dateEditStart.TabIndex = 0;
			// 
			// simpleButtonLoadData
			// 
			this.simpleButtonLoadData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.simpleButtonLoadData.Location = new System.Drawing.Point(10, 7);
			this.simpleButtonLoadData.Name = "simpleButtonLoadData";
			this.simpleButtonLoadData.Size = new System.Drawing.Size(222, 33);
			this.simpleButtonLoadData.StyleController = this.styleController;
			this.simpleButtonLoadData.TabIndex = 0;
			this.simpleButtonLoadData.Text = "Load Data";
			this.simpleButtonLoadData.Click += new System.EventHandler(this.simpleButtonLoadData_Click);
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
			// ReportsPage
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.Controls.Add(this.splitContainerControl);
			this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Name = "ReportsPage";
			this.Size = new System.Drawing.Size(833, 619);
			((System.ComponentModel.ISupportInitialize)(this.splitContainerControl)).EndInit();
			this.splitContainerControl.ResumeLayout(false);
			this.pnFilterButtons.ResumeLayout(false);
			this.gbDate.ResumeLayout(false);
			this.gbDate.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dateEditEnd.Properties.CalendarTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dateEditEnd.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dateEditStart.Properties.CalendarTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dateEditStart.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.styleController)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraEditors.SplitContainerControl splitContainerControl;
		private System.Windows.Forms.Panel pnCustomFilter;
		private System.Windows.Forms.Panel pnFilterButtons;
		private System.Windows.Forms.GroupBox gbDate;
		private DevExpress.XtraEditors.LabelControl labelControlDateEnd;
		private DevExpress.XtraEditors.DateEdit dateEditEnd;
		private DevExpress.XtraEditors.LabelControl labelControlDateStart;
		private DevExpress.XtraEditors.DateEdit dateEditStart;
		private DevExpress.XtraEditors.SimpleButton simpleButtonLoadData;
		private DevExpress.XtraEditors.StyleController styleController;
	}
}
