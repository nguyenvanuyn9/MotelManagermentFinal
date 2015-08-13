namespace MotelManage.PresentationTier
{
    partial class ReportEvenue
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
            this.btReport = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dateReport = new System.Windows.Forms.DateTimePicker();
            this.btSave = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // btReport
            // 
            this.btReport.Location = new System.Drawing.Point(473, 14);
            this.btReport.Margin = new System.Windows.Forms.Padding(2);
            this.btReport.Name = "btReport";
            this.btReport.Size = new System.Drawing.Size(56, 19);
            this.btReport.TabIndex = 0;
            this.btReport.Text = "Report";
            this.btReport.UseVisualStyleBackColor = true;
            this.btReport.Click += new System.EventHandler(this.btReport_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 13);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date:";
            // 
            // dateReport
            // 
            this.dateReport.CustomFormat = "MMMM yyyy";
            this.dateReport.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateReport.Location = new System.Drawing.Point(285, 12);
            this.dateReport.Margin = new System.Windows.Forms.Padding(2);
            this.dateReport.Name = "dateReport";
            this.dateReport.Size = new System.Drawing.Size(149, 20);
            this.dateReport.TabIndex = 4;
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(527, 395);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 23);
            this.btSave.TabIndex = 8;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(639, 395);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(75, 23);
            this.btExit.TabIndex = 8;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(11, 58);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(705, 315);
            this.reportViewer1.TabIndex = 9;
            // 
            // ReportEvenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 442);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.dateReport);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btReport);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ReportEvenue";
            this.Text = "ReportEvenue";
            this.Load += new System.EventHandler(this.ReportEvenue_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btReport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateReport;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btExit;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}