namespace MotelManage.PresentationTier
{
    partial class RoomList
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
            this.gridRoomList = new System.Windows.Forms.DataGridView();
            this.btSearch = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.cbtype = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridRoomList)).BeginInit();
            this.SuspendLayout();
            // 
            // gridRoomList
            // 
            this.gridRoomList.AllowUserToAddRows = false;
            this.gridRoomList.AllowUserToDeleteRows = false;
            this.gridRoomList.AllowUserToResizeColumns = false;
            this.gridRoomList.AllowUserToResizeRows = false;
            this.gridRoomList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridRoomList.Location = new System.Drawing.Point(9, 169);
            this.gridRoomList.Margin = new System.Windows.Forms.Padding(2);
            this.gridRoomList.Name = "gridRoomList";
            this.gridRoomList.ReadOnly = true;
            this.gridRoomList.RowTemplate.Height = 24;
            this.gridRoomList.Size = new System.Drawing.Size(668, 240);
            this.gridRoomList.TabIndex = 8;
            this.gridRoomList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridRoomList_CellClick);
            this.gridRoomList.SelectionChanged += new System.EventHandler(this.gridRoomList_SelectionChanged);
            // 
            // btSearch
            // 
            this.btSearch.Location = new System.Drawing.Point(273, 127);
            this.btSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(76, 27);
            this.btSearch.TabIndex = 4;
            this.btSearch.Text = "Search";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(600, 127);
            this.btDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(76, 27);
            this.btDelete.TabIndex = 7;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(385, 127);
            this.btAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(76, 27);
            this.btAdd.TabIndex = 5;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(493, 127);
            this.btEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(76, 27);
            this.btEdit.TabIndex = 6;
            this.btEdit.Text = "Edit";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Name";
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(88, 25);
            this.tbID.Margin = new System.Windows.Forms.Padding(2);
            this.tbID.MaxLength = 10;
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(170, 20);
            this.tbID.TabIndex = 0;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(88, 54);
            this.tbName.Margin = new System.Windows.Forms.Padding(2);
            this.tbName.MaxLength = 100;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(170, 20);
            this.tbName.TabIndex = 1;
            // 
            // cbStatus
            // 
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(385, 25);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(184, 21);
            this.cbStatus.TabIndex = 2;
            // 
            // cbtype
            // 
            this.cbtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbtype.FormattingEnabled = true;
            this.cbtype.Location = new System.Drawing.Point(385, 54);
            this.cbtype.Name = "cbtype";
            this.cbtype.Size = new System.Drawing.Size(184, 21);
            this.cbtype.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(314, 33);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(314, 57);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Type";
            // 
            // RoomList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 418);
            this.Controls.Add(this.cbtype);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.gridRoomList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RoomList";
            this.Text = "RoomList";
            this.Load += new System.EventHandler(this.RoomList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridRoomList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridRoomList;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.ComboBox cbtype;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}