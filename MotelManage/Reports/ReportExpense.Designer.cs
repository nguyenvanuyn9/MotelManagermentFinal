namespace MotelManage.Reports
{
    partial class ReportExpense
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
            this.dateReport = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btReport = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // dateReport
            // 
            this.dateReport.CustomFormat = "MMMM yyyy";
            this.dateReport.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateReport.Location = new System.Drawing.Point(301, 23);
            this.dateReport.Margin = new System.Windows.Forms.Padding(2);
            this.dateReport.Name = "dateReport";
            this.dateReport.Size = new System.Drawing.Size(149, 20);
            this.dateReport.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Date:";
            // 
            // btReport
            // 
            this.btReport.Location = new System.Drawing.Point(489, 25);
            this.btReport.Margin = new System.Windows.Forms.Padding(2);
            this.btReport.Name = "btReport";
            this.btReport.Size = new System.Drawing.Size(56, 19);
            this.btReport.TabIndex = 5;
            this.btReport.Text = "Report";
            this.btReport.UseVisualStyleBackColor = true;
            this.btReport.Click += new System.EventHandler(this.btReport_Click);
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(656, 422);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(75, 23);
            this.btExit.TabIndex = 9;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(544, 422);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 23);
            this.btSave.TabIndex = 10;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(12, 49);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(772, 367);
            this.reportViewer1.TabIndex = 11;
            // 
            // ReportExpense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 458);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.dateReport);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btReport);
            this.Name = "ReportExpense";
            this.Text = "ReportExpense";
            this.Load += new System.EventHandler(this.ReportExpense_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateReport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btReport;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btSave;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}