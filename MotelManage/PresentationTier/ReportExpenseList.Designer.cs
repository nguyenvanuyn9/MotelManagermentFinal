namespace MotelManage.PresentationTier
{
    partial class ReportExpenseList
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
            this.gridviewReportExpense = new System.Windows.Forms.DataGridView();
            this.dateSet = new System.Windows.Forms.DateTimePicker();
            this.tbTotalMoney = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btDetail = new System.Windows.Forms.Button();
            this.tbReportID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewReportExpense)).BeginInit();
            this.SuspendLayout();
            // 
            // gridviewReportExpense
            // 
            this.gridviewReportExpense.AllowUserToAddRows = false;
            this.gridviewReportExpense.AllowUserToDeleteRows = false;
            this.gridviewReportExpense.AllowUserToResizeColumns = false;
            this.gridviewReportExpense.AllowUserToResizeRows = false;
            this.gridviewReportExpense.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridviewReportExpense.Location = new System.Drawing.Point(24, 129);
            this.gridviewReportExpense.Name = "gridviewReportExpense";
            this.gridviewReportExpense.ReadOnly = true;
            this.gridviewReportExpense.Size = new System.Drawing.Size(579, 263);
            this.gridviewReportExpense.TabIndex = 5;
            this.gridviewReportExpense.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridviewReportExpense_CellClick);
            this.gridviewReportExpense.SelectionChanged += new System.EventHandler(this.gridviewReportExpense_SelectionChanged);
            // 
            // dateSet
            // 
            this.dateSet.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateSet.Location = new System.Drawing.Point(408, 8);
            this.dateSet.Name = "dateSet";
            this.dateSet.Size = new System.Drawing.Size(170, 20);
            this.dateSet.TabIndex = 2;
            // 
            // tbTotalMoney
            // 
            this.tbTotalMoney.Location = new System.Drawing.Point(140, 45);
            this.tbTotalMoney.Margin = new System.Windows.Forms.Padding(2);
            this.tbTotalMoney.MaxLength = 18;
            this.tbTotalMoney.Name = "tbTotalMoney";
            this.tbTotalMoney.Size = new System.Drawing.Size(154, 20);
            this.tbTotalMoney.TabIndex = 1;
            this.tbTotalMoney.Text = "0";
            this.tbTotalMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbTotalMoney.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTotalMoney_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 48);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 55;
            this.label4.Text = "Total money";
            // 
            // btDetail
            // 
            this.btDetail.Location = new System.Drawing.Point(502, 85);
            this.btDetail.Margin = new System.Windows.Forms.Padding(2);
            this.btDetail.Name = "btDetail";
            this.btDetail.Size = new System.Drawing.Size(76, 27);
            this.btDetail.TabIndex = 4;
            this.btDetail.Text = "Detail";
            this.btDetail.UseVisualStyleBackColor = true;
            this.btDetail.Click += new System.EventHandler(this.btDetail_Click);
            // 
            // tbReportID
            // 
            this.tbReportID.Location = new System.Drawing.Point(140, 8);
            this.tbReportID.Margin = new System.Windows.Forms.Padding(2);
            this.tbReportID.MaxLength = 10;
            this.tbReportID.Name = "tbReportID";
            this.tbReportID.Size = new System.Drawing.Size(153, 20);
            this.tbReportID.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(336, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 54;
            this.label2.Text = "Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 53;
            this.label1.Text = "Report Expense ID";
            // 
            // btSearch
            // 
            this.btSearch.Location = new System.Drawing.Point(381, 85);
            this.btSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(76, 27);
            this.btSearch.TabIndex = 3;
            this.btSearch.Text = "Search";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // ReportExpenseList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 400);
            this.Controls.Add(this.gridviewReportExpense);
            this.Controls.Add(this.dateSet);
            this.Controls.Add(this.tbTotalMoney);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btDetail);
            this.Controls.Add(this.tbReportID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReportExpenseList";
            this.Text = "ReportExpenseList";
            this.Load += new System.EventHandler(this.ReportExpenseList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridviewReportExpense)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridviewReportExpense;
        private System.Windows.Forms.DateTimePicker dateSet;
        private System.Windows.Forms.TextBox tbTotalMoney;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btDetail;
        private System.Windows.Forms.TextBox tbReportID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btSearch;
    }
}