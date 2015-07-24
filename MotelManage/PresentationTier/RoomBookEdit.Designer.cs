namespace MotelManage.PresentationTier
{
    partial class RoomBookEdit
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
            this.tbID = new System.Windows.Forms.TextBox();
            this.btSave = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateEnd = new System.Windows.Forms.DateTimePicker();
            this.btExit = new System.Windows.Forms.Button();
            this.tbNote = new System.Windows.Forms.RichTextBox();
            this.cbCustomer = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbRoom = new System.Windows.Forms.ComboBox();
            this.dateBegin = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.tbDeposit = new System.Windows.Forms.TextBox();
            this.cbStatusRoomBook = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(104, 10);
            this.tbID.Margin = new System.Windows.Forms.Padding(2);
            this.tbID.MaxLength = 10;
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(151, 20);
            this.tbID.TabIndex = 36;
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(317, 218);
            this.btSave.Margin = new System.Windows.Forms.Padding(2);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(56, 19);
            this.btSave.TabIndex = 34;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 38);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Room";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 75);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Customer";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(279, 38);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Note";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 142);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Begin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(279, 8);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "End";
            // 
            // dateEnd
            // 
            this.dateEnd.Location = new System.Drawing.Point(334, 6);
            this.dateEnd.Margin = new System.Windows.Forms.Padding(2);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(158, 20);
            this.dateEnd.TabIndex = 23;
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(407, 218);
            this.btExit.Margin = new System.Windows.Forms.Padding(2);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(56, 19);
            this.btExit.TabIndex = 22;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // tbNote
            // 
            this.tbNote.Location = new System.Drawing.Point(334, 38);
            this.tbNote.Margin = new System.Windows.Forms.Padding(2);
            this.tbNote.MaxLength = 200;
            this.tbNote.Name = "tbNote";
            this.tbNote.Size = new System.Drawing.Size(156, 124);
            this.tbNote.TabIndex = 21;
            this.tbNote.Text = "";
            // 
            // cbCustomer
            // 
            this.cbCustomer.FormattingEnabled = true;
            this.cbCustomer.Location = new System.Drawing.Point(104, 72);
            this.cbCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.cbCustomer.Name = "cbCustomer";
            this.cbCustomer.Size = new System.Drawing.Size(151, 21);
            this.cbCustomer.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Id";
            // 
            // cbRoom
            // 
            this.cbRoom.FormattingEnabled = true;
            this.cbRoom.Location = new System.Drawing.Point(104, 38);
            this.cbRoom.Margin = new System.Windows.Forms.Padding(2);
            this.cbRoom.Name = "cbRoom";
            this.cbRoom.Size = new System.Drawing.Size(151, 21);
            this.cbRoom.TabIndex = 20;
            // 
            // dateBegin
            // 
            this.dateBegin.Location = new System.Drawing.Point(104, 142);
            this.dateBegin.Margin = new System.Windows.Forms.Padding(2);
            this.dateBegin.Name = "dateBegin";
            this.dateBegin.Size = new System.Drawing.Size(151, 20);
            this.dateBegin.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 177);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Deposit";
            // 
            // tbDeposit
            // 
            this.tbDeposit.Location = new System.Drawing.Point(104, 177);
            this.tbDeposit.MaxLength = 18;
            this.tbDeposit.Name = "tbDeposit";
            this.tbDeposit.Size = new System.Drawing.Size(151, 20);
            this.tbDeposit.TabIndex = 37;
            this.tbDeposit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDeposit_KeyPress);
            // 
            // cbStatusRoomBook
            // 
            this.cbStatusRoomBook.FormattingEnabled = true;
            this.cbStatusRoomBook.Location = new System.Drawing.Point(104, 108);
            this.cbStatusRoomBook.Margin = new System.Windows.Forms.Padding(2);
            this.cbStatusRoomBook.Name = "cbStatusRoomBook";
            this.cbStatusRoomBook.Size = new System.Drawing.Size(151, 21);
            this.cbStatusRoomBook.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 111);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Status";
            // 
            // RoomBookEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 252);
            this.Controls.Add(this.tbDeposit);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateBegin);
            this.Controls.Add(this.dateEnd);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.tbNote);
            this.Controls.Add(this.cbStatusRoomBook);
            this.Controls.Add(this.cbRoom);
            this.Controls.Add(this.cbCustomer);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RoomBookEdit";
            this.Text = "RoomBook Edit";
            this.Load += new System.EventHandler(this.RoomBookEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateEnd;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.RichTextBox tbNote;
        private System.Windows.Forms.ComboBox cbCustomer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbRoom;
        private System.Windows.Forms.DateTimePicker dateBegin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbDeposit;
        private System.Windows.Forms.ComboBox cbStatusRoomBook;
        private System.Windows.Forms.Label label5;
    }
}