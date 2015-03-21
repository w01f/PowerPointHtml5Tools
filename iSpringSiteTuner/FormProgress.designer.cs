namespace iSpringSiteTuner
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProgress));
			this.progressPanel = new DevExpress.XtraWaitForm.ProgressPanel();
			this.SuspendLayout();
			// 
			// progressPanel
			// 
			this.progressPanel.Appearance.BackColor = System.Drawing.Color.Transparent;
			this.progressPanel.Appearance.Options.UseBackColor = true;
			this.progressPanel.AppearanceCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.progressPanel.AppearanceCaption.Options.UseFont = true;
			this.progressPanel.AppearanceDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.progressPanel.AppearanceDescription.Options.UseFont = true;
			this.progressPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
			this.progressPanel.Caption = "Process Sites...";
			this.progressPanel.Description = "";
			this.progressPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.progressPanel.ImageHorzOffset = 10;
			this.progressPanel.Location = new System.Drawing.Point(0, 0);
			this.progressPanel.Name = "progressPanel";
			this.progressPanel.ShowDescription = false;
			this.progressPanel.Size = new System.Drawing.Size(262, 73);
			this.progressPanel.TabIndex = 3;
			this.progressPanel.TextHorzOffset = 30;
			// 
			// FormProgress
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(262, 73);
			this.ControlBox = false;
			this.Controls.Add(this.progressPanel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormProgress";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Online Overnights";
			this.TopMost = true;
			this.ResumeLayout(false);

        }

        #endregion

		private DevExpress.XtraWaitForm.ProgressPanel progressPanel;

	}
}