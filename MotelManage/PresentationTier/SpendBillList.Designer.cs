namespace MotelManage.PresentationTier
{
    partial class SpendBillList
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
            this.id = new System.Windows.Forms.TextBox();
            this.reason = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataSpend = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.receiver = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataSpend)).BeginInit();
            this.SuspendLayout();
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(104, 10);
            this.id.Margin = new System.Windows.Forms.Padding(2);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(151, 20);
            this.id.TabIndex = 47;
            // 
            // reason
            // 
            this.reason.Location = new System.Drawing.Point(333, 41);
            this.reason.Margin = new System.Windows.Forms.Padding(2);
            this.reason.Name = "reason";
            this.reason.ReadOnly = true;
            this.reason.Size = new System.Drawing.Size(158, 20);
            this.reason.TabIndex = 46;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(278, 41);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 44;
            this.label8.Text = "Reason";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(278, 8);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Date";
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(333, 6);
            this.date.Margin = new System.Windows.Forms.Padding(2);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(158, 20);
            this.date.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "Spend Bill ID";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(140, 83);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(76, 27);
            this.button4.TabIndex = 52;
            this.button4.Text = "Search";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.searchSpend_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(467, 83);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(76, 27);
            this.button3.TabIndex = 51;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.delSpend_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(252, 83);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(76, 27);
            this.button2.TabIndex = 50;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.addSpend_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(360, 83);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 27);
            this.button1.TabIndex = 49;
            this.button1.Text = "Edit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.editSpend_Click);
            // 
            // dataSpend
            // 
            this.dataSpend.AllowUserToAddRows = false;
            this.dataSpend.AllowUserToDeleteRows = false;
            this.dataSpend.AllowUserToResizeColumns = false;
            this.dataSpend.AllowUserToResizeRows = false;
            this.dataSpend.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSpend.Location = new System.Drawing.Point(9, 126);
            this.dataSpend.Margin = new System.Windows.Forms.Padding(2);
            this.dataSpend.Name = "dataSpend";
            this.dataSpend.RowTemplate.Height = 24;
            this.dataSpend.Size = new System.Drawing.Size(534, 214);
            this.dataSpend.TabIndex = 48;
            this.dataSpend.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataCellSpend_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 44);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Receiver";
            // 
            // receiver
            // 
            this.receiver.Location = new System.Drawing.Point(104, 40);
            this.receiver.Margin = new System.Windows.Forms.Padding(2);
            this.receiver.Name = "receiver";
            this.receiver.Size = new System.Drawing.Size(151, 20);
            this.receiver.TabIndex = 47;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(44, 85);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 53;
            this.button5.Text = "Reset";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // SpendBillList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 350);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataSpend);
            this.Controls.Add(this.receiver);
            this.Controls.Add(this.id);
            this.Controls.Add(this.reason);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.date);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SpendBillList";
            this.Text = "SpendBillList";
            this.Load += new System.EventHandler(this.SpendBillListLoad);
            ((System.ComponentModel.ISupportInitialize)(this.dataSpend)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox reason;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataSpend;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox receiver;
        private System.Windows.Forms.Button button5;
    }
}