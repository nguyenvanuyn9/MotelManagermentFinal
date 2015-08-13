namespace MotelManage.PresentationTier
{
    partial class ReportEvenueDetail
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
            this.btnExit = new System.Windows.Forms.Button();
            this.dateSet = new System.Windows.Forms.DateTimePicker();
            this.tbTotalMoney = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbReportID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gridviewDetail = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(482, 331);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(162, 27);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dateSet
            // 
            this.dateSet.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateSet.Location = new System.Drawing.Point(422, 22);
            this.dateSet.Name = "dateSet";
            this.dateSet.Size = new System.Drawing.Size(170, 20);
            this.dateSet.TabIndex = 2;
            // 
            // tbTotalMoney
            // 
            this.tbTotalMoney.Location = new System.Drawing.Point(154, 59);
            this.tbTotalMoney.Margin = new System.Windows.Forms.Padding(2);
            this.tbTotalMoney.MaxLength = 18;
            this.tbTotalMoney.Name = "tbTotalMoney";
            this.tbTotalMoney.Size = new System.Drawing.Size(154, 20);
            this.tbTotalMoney.TabIndex = 1;
            this.tbTotalMoney.Text = "0";
            this.tbTotalMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 62);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 53353;
            this.label4.Text = "Total money";
            // 
            // tbReportID
            // 
            this.tbReportID.Location = new System.Drawing.Point(154, 22);
            this.tbReportID.Margin = new System.Windows.Forms.Padding(2);
            this.tbReportID.MaxLength = 10;
            this.tbReportID.Name = "tbReportID";
            this.tbReportID.Size = new System.Drawing.Size(153, 20);
            this.tbReportID.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(350, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 53352;
            this.label2.Text = "Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 53351;
            this.label1.Text = "Report Evenue ID";
            // 
            // gridviewDetail
            // 
            this.gridviewDetail.AllowUserToAddRows = false;
            this.gridviewDetail.AllowUserToDeleteRows = false;
            this.gridviewDetail.AllowUserToResizeColumns = false;
            this.gridviewDetail.AllowUserToResizeRows = false;
            this.gridviewDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridviewDetail.Location = new System.Drawing.Point(12, 95);
            this.gridviewDetail.Name = "gridviewDetail";
            this.gridviewDetail.ReadOnly = true;
            this.gridviewDetail.Size = new System.Drawing.Size(637, 215);
            this.gridviewDetail.TabIndex = 3;
            // 
            // ReportEvenueDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 369);
            this.Controls.Add(this.gridviewDetail);
            this.Controls.Add(this.dateSet);
            this.Controls.Add(this.tbTotalMoney);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbReportID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReportEvenueDetail";
            this.Text = "ReportEvenueDetail";
            this.Load += new System.EventHandler(this.ReportEvenueDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridviewDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DateTimePicker dateSet;
        private System.Windows.Forms.TextBox tbTotalMoney;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbReportID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridviewDetail;
    }
}