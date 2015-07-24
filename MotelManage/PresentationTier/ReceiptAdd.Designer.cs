namespace MotelManage.PresentationTier
{
    partial class ReceiptAdd
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
            this.contractCombo = new System.Windows.Forms.ComboBox();
            this.note = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dateReceipt = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.TextBox();
            this.billCombo = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.reason = new System.Windows.Forms.TextBox();
            this.customerName = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // contractCombo
            // 
            this.contractCombo.FormattingEnabled = true;
            this.contractCombo.Location = new System.Drawing.Point(109, 11);
            this.contractCombo.Margin = new System.Windows.Forms.Padding(2);
            this.contractCombo.Name = "contractCombo";
            this.contractCombo.Size = new System.Drawing.Size(151, 21);
            this.contractCombo.TabIndex = 1;
            this.contractCombo.SelectionChangeCommitted += new System.EventHandler(this.contract_Change);
            // 
            // note
            // 
            this.note.Location = new System.Drawing.Point(76, 133);
            this.note.Margin = new System.Windows.Forms.Padding(2);
            this.note.Name = "note";
            this.note.Size = new System.Drawing.Size(418, 140);
            this.note.TabIndex = 2;
            this.note.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(423, 294);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 19);
            this.button1.TabIndex = 3;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.save);
            // 
            // dateReceipt
            // 
            this.dateReceipt.Location = new System.Drawing.Point(338, 6);
            this.dateReceipt.Margin = new System.Windows.Forms.Padding(2);
            this.dateReceipt.Name = "dateReceipt";
            this.dateReceipt.Size = new System.Drawing.Size(158, 20);
            this.dateReceipt.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(283, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 47);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Customer name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 122);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Note";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(284, 40);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Bill Id";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(285, 72);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Total";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 19);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Contract Id";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 79);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Reason";
            // 
            // total
            // 
            this.total.Location = new System.Drawing.Point(336, 69);
            this.total.Margin = new System.Windows.Forms.Padding(2);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(158, 20);
            this.total.TabIndex = 12;
            // 
            // billCombo
            // 
            this.billCombo.FormattingEnabled = true;
            this.billCombo.Location = new System.Drawing.Point(338, 37);
            this.billCombo.Margin = new System.Windows.Forms.Padding(2);
            this.billCombo.Name = "billCombo";
            this.billCombo.Size = new System.Drawing.Size(156, 21);
            this.billCombo.TabIndex = 13;
            this.billCombo.SelectionChangeCommitted += new System.EventHandler(this.billID_Change);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(16, 294);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(56, 19);
            this.button3.TabIndex = 15;
            this.button3.Text = "Print";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // reason
            // 
            this.reason.Location = new System.Drawing.Point(108, 72);
            this.reason.Margin = new System.Windows.Forms.Padding(2);
            this.reason.Name = "reason";
            this.reason.Size = new System.Drawing.Size(151, 20);
            this.reason.TabIndex = 16;
            // 
            // customerName
            // 
            this.customerName.Location = new System.Drawing.Point(108, 40);
            this.customerName.Margin = new System.Windows.Forms.Padding(2);
            this.customerName.Name = "customerName";
            this.customerName.Size = new System.Drawing.Size(150, 20);
            this.customerName.TabIndex = 18;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(319, 294);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 19);
            this.button2.TabIndex = 19;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.cancel_ReceiptAdd);
            // 
            // ReceiptAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 323);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.customerName);
            this.Controls.Add(this.reason);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.billCombo);
            this.Controls.Add(this.total);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateReceipt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.note);
            this.Controls.Add(this.contractCombo);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ReceiptAdd";
            this.Text = "Receipt Add";
            this.Load += new System.EventHandler(this.ReceiptAdd_Loaded);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox contractCombo;
        private System.Windows.Forms.RichTextBox note;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateReceipt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox total;
        private System.Windows.Forms.ComboBox billCombo;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox reason;
        private System.Windows.Forms.TextBox customerName;
        private System.Windows.Forms.Button button2;
    }
}