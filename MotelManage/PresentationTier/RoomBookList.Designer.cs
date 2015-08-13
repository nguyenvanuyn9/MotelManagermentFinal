namespace MotelManage.PresentationTier
{
    partial class RoomBookList
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
            this.cbCustomer = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateBegin = new System.Windows.Forms.DateTimePicker();
            this.cbRoom = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gridRoomBook = new System.Windows.Forms.DataGridView();
            this.btSearch = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.dateEnd = new System.Windows.Forms.DateTimePicker();
            this.tbNote = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbDeposit = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbStatusRoomBook = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridRoomBook)).BeginInit();
            this.SuspendLayout();
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(103, 11);
            this.tbID.Margin = new System.Windows.Forms.Padding(2);
            this.tbID.MaxLength = 10;
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(151, 20);
            this.tbID.TabIndex = 0;
            // 
            // cbCustomer
            // 
            this.cbCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCustomer.FormattingEnabled = true;
            this.cbCustomer.Location = new System.Drawing.Point(103, 72);
            this.cbCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.cbCustomer.Name = "cbCustomer";
            this.cbCustomer.Size = new System.Drawing.Size(151, 21);
            this.cbCustomer.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 40);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 46;
            this.label8.Text = "Room";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 76);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 45;
            this.label7.Text = "Customer";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(278, 40);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "Note";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 144);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "Begin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(278, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "End";
            // 
            // dateBegin
            // 
            this.dateBegin.Location = new System.Drawing.Point(103, 138);
            this.dateBegin.Margin = new System.Windows.Forms.Padding(2);
            this.dateBegin.Name = "dateBegin";
            this.dateBegin.Size = new System.Drawing.Size(151, 20);
            this.dateBegin.TabIndex = 4;
            // 
            // cbRoom
            // 
            this.cbRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRoom.FormattingEnabled = true;
            this.cbRoom.Location = new System.Drawing.Point(103, 40);
            this.cbRoom.Margin = new System.Windows.Forms.Padding(2);
            this.cbRoom.Name = "cbRoom";
            this.cbRoom.Size = new System.Drawing.Size(151, 21);
            this.cbRoom.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Id";
            // 
            // gridRoomBook
            // 
            this.gridRoomBook.AllowUserToAddRows = false;
            this.gridRoomBook.AllowUserToDeleteRows = false;
            this.gridRoomBook.AllowUserToResizeColumns = false;
            this.gridRoomBook.AllowUserToResizeRows = false;
            this.gridRoomBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridRoomBook.Location = new System.Drawing.Point(9, 252);
            this.gridRoomBook.Margin = new System.Windows.Forms.Padding(2);
            this.gridRoomBook.Name = "gridRoomBook";
            this.gridRoomBook.ReadOnly = true;
            this.gridRoomBook.RowTemplate.Height = 24;
            this.gridRoomBook.Size = new System.Drawing.Size(790, 181);
            this.gridRoomBook.TabIndex = 12;
            this.gridRoomBook.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridRoomBook_CellClick);
            this.gridRoomBook.SelectionChanged += new System.EventHandler(this.gridRoomBook_SelectionChanged);
            // 
            // btSearch
            // 
            this.btSearch.Location = new System.Drawing.Point(207, 210);
            this.btSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(76, 27);
            this.btSearch.TabIndex = 8;
            this.btSearch.Text = "Search";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(534, 210);
            this.btDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(76, 27);
            this.btDelete.TabIndex = 11;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(319, 210);
            this.btAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(76, 27);
            this.btAdd.TabIndex = 9;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(427, 210);
            this.btEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(76, 27);
            this.btEdit.TabIndex = 10;
            this.btEdit.Text = "Edit";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // dateEnd
            // 
            this.dateEnd.Location = new System.Drawing.Point(335, 10);
            this.dateEnd.Margin = new System.Windows.Forms.Padding(2);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(151, 20);
            this.dateEnd.TabIndex = 6;
            // 
            // tbNote
            // 
            this.tbNote.Location = new System.Drawing.Point(335, 40);
            this.tbNote.MaxLength = 200;
            this.tbNote.Multiline = true;
            this.tbNote.Name = "tbNote";
            this.tbNote.Size = new System.Drawing.Size(151, 147);
            this.tbNote.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 175);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "Deposit";
            // 
            // tbDeposit
            // 
            this.tbDeposit.Location = new System.Drawing.Point(103, 167);
            this.tbDeposit.MaxLength = 18;
            this.tbDeposit.Name = "tbDeposit";
            this.tbDeposit.Size = new System.Drawing.Size(151, 20);
            this.tbDeposit.TabIndex = 5;
            this.tbDeposit.Text = "0\r\n";
            this.tbDeposit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbDeposit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDeposit_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 107);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 45;
            this.label5.Text = "Status";
            // 
            // cbStatusRoomBook
            // 
            this.cbStatusRoomBook.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatusRoomBook.FormattingEnabled = true;
            this.cbStatusRoomBook.Location = new System.Drawing.Point(103, 103);
            this.cbStatusRoomBook.Margin = new System.Windows.Forms.Padding(2);
            this.cbStatusRoomBook.Name = "cbStatusRoomBook";
            this.cbStatusRoomBook.Size = new System.Drawing.Size(151, 21);
            this.cbStatusRoomBook.TabIndex = 3;
            // 
            // RoomBookList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 459);
            this.Controls.Add(this.tbDeposit);
            this.Controls.Add(this.tbNote);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.gridRoomBook);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.cbStatusRoomBook);
            this.Controls.Add(this.cbCustomer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateEnd);
            this.Controls.Add(this.dateBegin);
            this.Controls.Add(this.cbRoom);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RoomBookList";
            this.Text = "RoomBookList";
            this.Load += new System.EventHandler(this.RoomBookList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridRoomBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.ComboBox cbCustomer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateBegin;
        private System.Windows.Forms.ComboBox cbRoom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridRoomBook;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.DateTimePicker dateEnd;
        private System.Windows.Forms.TextBox tbNote;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbDeposit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbStatusRoomBook;
    }
}