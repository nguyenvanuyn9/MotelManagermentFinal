namespace MotelManage.PresentationTier
{
    partial class ReceiptEdit
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.TextBox();
            this.reason = new System.Windows.Forms.TextBox();
            this.contractId = new System.Windows.Forms.TextBox();
            this.customer = new System.Windows.Forms.TextBox();
            this.date = new System.Windows.Forms.TextBox();
            this.billID = new System.Windows.Forms.TextBox();
            this.total = new System.Windows.Forms.TextBox();
            this.note = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(438, 294);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 19);
            this.button1.TabIndex = 3;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.saveReceiptEdit);
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
            this.label3.Location = new System.Drawing.Point(16, 81);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Customer name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 140);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Note";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(283, 44);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Bill Id";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(282, 81);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Total";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 47);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Contract Id";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 111);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Reason";
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
            this.button3.Click += new System.EventHandler(this.printReceipt);
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(108, 9);
            this.id.Margin = new System.Windows.Forms.Padding(2);
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Size = new System.Drawing.Size(151, 20);
            this.id.TabIndex = 17;
            // 
            // reason
            // 
            this.reason.Location = new System.Drawing.Point(108, 108);
            this.reason.Name = "reason";
            this.reason.Size = new System.Drawing.Size(373, 20);
            this.reason.TabIndex = 18;
            // 
            // contractId
            // 
            this.contractId.Location = new System.Drawing.Point(108, 44);
            this.contractId.Name = "contractId";
            this.contractId.ReadOnly = true;
            this.contractId.Size = new System.Drawing.Size(151, 20);
            this.contractId.TabIndex = 18;
            // 
            // customer
            // 
            this.customer.Location = new System.Drawing.Point(108, 78);
            this.customer.Name = "customer";
            this.customer.Size = new System.Drawing.Size(151, 20);
            this.customer.TabIndex = 18;
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(330, 6);
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.Size = new System.Drawing.Size(151, 20);
            this.date.TabIndex = 18;
            // 
            // billID
            // 
            this.billID.Location = new System.Drawing.Point(330, 37);
            this.billID.Name = "billID";
            this.billID.ReadOnly = true;
            this.billID.Size = new System.Drawing.Size(151, 20);
            this.billID.TabIndex = 18;
            // 
            // total
            // 
            this.total.Location = new System.Drawing.Point(330, 74);
            this.total.Name = "total";
            this.total.ReadOnly = true;
            this.total.Size = new System.Drawing.Size(151, 20);
            this.total.TabIndex = 18;
            // 
            // note
            // 
            this.note.Location = new System.Drawing.Point(108, 140);
            this.note.Name = "note";
            this.note.Size = new System.Drawing.Size(373, 136);
            this.note.TabIndex = 19;
            this.note.Text = "";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(330, 294);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 19);
            this.button2.TabIndex = 20;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ReceiptEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 323);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.note);
            this.Controls.Add(this.billID);
            this.Controls.Add(this.customer);
            this.Controls.Add(this.date);
            this.Controls.Add(this.contractId);
            this.Controls.Add(this.total);
            this.Controls.Add(this.reason);
            this.Controls.Add(this.id);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ReceiptEdit";
            this.Text = "ReceiptEdit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox reason;
        private System.Windows.Forms.TextBox contractId;
        private System.Windows.Forms.TextBox customer;
        private System.Windows.Forms.TextBox date;
        private System.Windows.Forms.TextBox billID;
        private System.Windows.Forms.TextBox total;
        private System.Windows.Forms.RichTextBox note;
        private System.Windows.Forms.Button button2;
    }
}