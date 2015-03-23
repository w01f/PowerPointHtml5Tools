namespace SiteManager.PresentationLayer.Progress
{
    partial class FormProgress
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
			this.laProgress = new System.Windows.Forms.Label();
			this.progressPanel = new DevExpress.XtraWaitForm.ProgressPanel();
			this.SuspendLayout();
			// 
			// laProgress
			// 
			this.laProgress.BackColor = System.Drawing.Color.Transparent;
			this.laProgress.Dock = System.Windows.Forms.DockStyle.Fill;
			this.laProgress.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.laProgress.ForeColor = System.Drawing.Color.Black;
			this.laProgress.Location = new System.Drawing.Point(0, 0);
			this.laProgress.Name = "laProgress";
			this.laProgress.Size = new System.Drawing.Size(314, 49);
			this.laProgress.TabIndex = 2;
			this.laProgress.Text = "Loading data...";
			this.laProgress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.laProgress.UseMnemonic = false;
			this.laProgress.UseWaitCursor = true;
			// 
			// progressPanel
			// 
			this.progressPanel.Appearance.BackColor = System.Drawing.Color.Transparent;
			this.progressPanel.Appearance.Options.UseBackColor = true;
			this.progressPanel.AppearanceCaption.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.progressPanel.AppearanceCaption.Options.UseFont = true;
			this.progressPanel.AppearanceCaption.Options.UseTextOptions = true;
			this.progressPanel.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.progressPanel.AppearanceDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.progressPanel.AppearanceDescription.Options.UseFont = true;
			this.progressPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
			this.progressPanel.Caption = "Process Sites...";
			this.progressPanel.Description = "";
			this.progressPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.progressPanel.ImageHorzOffset = 20;
			this.progressPanel.Location = new System.Drawing.Point(2, 2);
			this.progressPanel.Name = "progressPanel";
			this.progressPanel.ShowDescription = false;
			this.progressPanel.Size = new System.Drawing.Size(257, 67);
			this.progressPanel.TabIndex = 4;
			this.progressPanel.TextHorzOffset = 30;
			// 
			// FormProgress
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(261, 71);
			this.ControlBox = false;
			this.Controls.Add(this.progressPanel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormProgress";
			this.Opacity = 0.8D;
			this.Padding = new System.Windows.Forms.Padding(2);
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "ProgressForm";
			this.Shown += new System.EventHandler(this.FormProgress_Shown);
			this.ResumeLayout(false);

        }

        #endregion

		public System.Windows.Forms.Label laProgress;
		private DevExpress.XtraWaitForm.ProgressPanel progressPanel;

	}
}