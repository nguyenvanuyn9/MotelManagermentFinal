namespace MotelManage.PresentationTier
{
    partial class ReportBaseForm
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
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewer
            // 
            this.reportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer.Location = new System.Drawing.Point(0, 0);
            this.reportViewer.AllowDrop = true;
            this.reportViewer.AutoScroll = true;
            this.reportViewer.AutoSize = true;
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.Size = new System.Drawing.Size(660, 600);
            this.reportViewer.TabIndex = 0;
            // 
            // ReportBaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 600);
            this.Controls.Add(this.reportViewer);
            this.Name = "ReportBaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportBaseForm";
            this.ResumeLayout(false);

            this.PerformLayout();
        }

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;

        #endregion
    }
}