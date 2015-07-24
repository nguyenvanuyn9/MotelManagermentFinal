namespace MotelManage.PresentationTier
{
    partial class ReceiptList
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
            this.curtomerName = new System.Windows.Forms.TextBox();
            this.receiptID = new System.Windows.Forms.TextBox();
            this.reason = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateValue = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataReceiptList = new System.Windows.Forms.DataGridView();
            this.contractID = new System.Windows.Forms.TextBox();
            this.billID = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataReceiptList)).BeginInit();
            this.SuspendLayout();
            // 
            // curtomerName
            // 
            this.curtomerName.Location = new System.Drawing.Point(105, 67);
            this.curtomerName.Margin = new System.Windows.Forms.Padding(2);
            this.curtomerName.Name = "curtomerName";
            this.curtomerName.Size = new System.Drawing.Size(151, 20);
            this.curtomerName.TabIndex = 33;
            // 
            // receiptID
            // 
            this.receiptID.Location = new System.Drawing.Point(105, 10);
            this.receiptID.Margin = new System.Windows.Forms.Padding(2);
            this.receiptID.Name = "receiptID";
            this.receiptID.Size = new System.Drawing.Size(151, 20);
            this.receiptID.TabIndex = 32;
            // 
            // reason
            // 
            this.reason.Location = new System.Drawing.Point(105, 37);
            this.reason.Margin = new System.Windows.Forms.Padding(2);
            this.reason.Name = "reason";
            this.reason.ReadOnly = true;
            this.reason.Size = new System.Drawing.Size(151, 20);
            this.reason.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 38);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Reason";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(280, 39);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Contract Id";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(280, 73);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Bill Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 67);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Customer name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(280, 8);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Date";
            // 
            // dateValue
            // 
            this.dateValue.Enabled = false;
            this.dateValue.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateValue.Location = new System.Drawing.Point(346, 8);
            this.dateValue.Margin = new System.Windows.Forms.Padding(2);
            this.dateValue.Name = "dateValue";
            this.dateValue.Size = new System.Drawing.Size(158, 20);
            this.dateValue.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Id";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(170, 100);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(76, 27);
            this.button4.TabIndex = 37;
            this.button4.Text = "Search";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.searchReceipt_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(497, 100);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(76, 27);
            this.button3.TabIndex = 36;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.del_Receipts);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(282, 100);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(76, 27);
            this.button2.TabIndex = 35;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.add_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(390, 100);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 27);
            this.button1.TabIndex = 34;
            this.button1.Text = "Edit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.editReceipt_Click);
            // 
            // dataReceiptList
            // 
            this.dataReceiptList.AllowUserToAddRows = false;
            this.dataReceiptList.AllowUserToDeleteRows = false;
            this.dataReceiptList.AllowUserToResizeColumns = false;
            this.dataReceiptList.AllowUserToResizeRows = false;
            this.dataReceiptList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataReceiptList.Location = new System.Drawing.Point(9, 141);
            this.dataReceiptList.Margin = new System.Windows.Forms.Padding(2);
            this.dataReceiptList.Name = "dataReceiptList";
            this.dataReceiptList.RowTemplate.Height = 24;
            this.dataReceiptList.Size = new System.Drawing.Size(564, 144);
            this.dataReceiptList.TabIndex = 38;
            this.dataReceiptList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.receiptCell_Click);
            // 
            // contractID
            // 
            this.contractID.Location = new System.Drawing.Point(346, 38);
            this.contractID.Name = "contractID";
            this.contractID.Size = new System.Drawing.Size(158, 20);
            this.contractID.TabIndex = 39;
            // 
            // billID
            // 
            this.billID.Location = new System.Drawing.Point(346, 70);
            this.billID.Name = "billID";
            this.billID.Size = new System.Drawing.Size(158, 20);
            this.billID.TabIndex = 39;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(60, 100);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 40;
            this.button5.Text = "Reset";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // ReceiptList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 288);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.billID);
            this.Controls.Add(this.contractID);
            this.Controls.Add(this.dataReceiptList);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.curtomerName);
            this.Controls.Add(this.receiptID);
            this.Controls.Add(this.reason);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateValue);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ReceiptList";
            this.Text = "Receipts";
            this.Load += new System.EventHandler(this.ReceiptList_Loaded);
            ((System.ComponentModel.ISupportInitialize)(this.dataReceiptList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox curtomerName;
        private System.Windows.Forms.TextBox receiptID;
        private System.Windows.Forms.TextBox reason;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataReceiptList;
        private System.Windows.Forms.TextBox contractID;
        private System.Windows.Forms.TextBox billID;
        private System.Windows.Forms.Button button5;
    }
}