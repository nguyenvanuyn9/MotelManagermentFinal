namespace MotelManage.PresentationTier
{
    partial class RoomBookSearch
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
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbRoom = new System.Windows.Forms.ComboBox();
            this.dgvRoomBook = new System.Windows.Forms.DataGridView();
            this.clCustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clRoomName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clRoomType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDateBooked = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDateExpire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clBail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtBookedId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerDateBooked = new System.Windows.Forms.DateTimePicker();
            this.lblDateTimePicker = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomBook)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(315, 24);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 46;
            this.label8.Text = "Room";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 58);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 45;
            this.label7.Text = "Customer name";
            // 
            // cmbRoom
            // 
            this.cmbRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoom.FormattingEnabled = true;
            this.cmbRoom.Location = new System.Drawing.Point(360, 21);
            this.cmbRoom.Margin = new System.Windows.Forms.Padding(2);
            this.cmbRoom.Name = "cmbRoom";
            this.cmbRoom.Size = new System.Drawing.Size(167, 21);
            this.cmbRoom.TabIndex = 39;
            // 
            // dgvRoomBook
            // 
            this.dgvRoomBook.AllowUserToAddRows = false;
            this.dgvRoomBook.AllowUserToDeleteRows = false;
            this.dgvRoomBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoomBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clCustomerName,
            this.clRoomName,
            this.clRoomType,
            this.clDateBooked,
            this.clDateExpire,
            this.clBail,
            this.clNote});
            this.dgvRoomBook.Location = new System.Drawing.Point(0, 93);
            this.dgvRoomBook.Margin = new System.Windows.Forms.Padding(2);
            this.dgvRoomBook.MultiSelect = false;
            this.dgvRoomBook.Name = "dgvRoomBook";
            this.dgvRoomBook.ReadOnly = true;
            this.dgvRoomBook.RowTemplate.Height = 24;
            this.dgvRoomBook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRoomBook.Size = new System.Drawing.Size(560, 118);
            this.dgvRoomBook.TabIndex = 53;
            // 
            // clCustomerName
            // 
            this.clCustomerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.clCustomerName.DataPropertyName = "Customer";
            this.clCustomerName.HeaderText = "Customer name";
            this.clCustomerName.Name = "clCustomerName";
            this.clCustomerName.ReadOnly = true;
            this.clCustomerName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clCustomerName.Width = 77;
            // 
            // clRoomName
            // 
            this.clRoomName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.clRoomName.DataPropertyName = "Room";
            this.clRoomName.HeaderText = "Room name";
            this.clRoomName.Name = "clRoomName";
            this.clRoomName.ReadOnly = true;
            this.clRoomName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clRoomName.Width = 63;
            // 
            // clRoomType
            // 
            this.clRoomType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.clRoomType.DataPropertyName = "RoomTypeName";
            this.clRoomType.HeaderText = "Room type";
            this.clRoomType.Name = "clRoomType";
            this.clRoomType.ReadOnly = true;
            this.clRoomType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clRoomType.Width = 58;
            // 
            // clDateBooked
            // 
            this.clDateBooked.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.clDateBooked.DataPropertyName = "BEGINDATE";
            this.clDateBooked.HeaderText = "Date booked";
            this.clDateBooked.Name = "clDateBooked";
            this.clDateBooked.ReadOnly = true;
            this.clDateBooked.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clDateBooked.Width = 68;
            // 
            // clDateExpire
            // 
            this.clDateExpire.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.clDateExpire.DataPropertyName = "ENDDATE";
            this.clDateExpire.HeaderText = "Expire date";
            this.clDateExpire.Name = "clDateExpire";
            this.clDateExpire.ReadOnly = true;
            this.clDateExpire.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clDateExpire.Width = 59;
            // 
            // clBail
            // 
            this.clBail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.clBail.DataPropertyName = "DEPOSIT";
            this.clBail.HeaderText = "Bail";
            this.clBail.Name = "clBail";
            this.clBail.ReadOnly = true;
            this.clBail.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clBail.Width = 30;
            // 
            // clNote
            // 
            this.clNote.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.clNote.DataPropertyName = "Note";
            this.clNote.HeaderText = "Note";
            this.clNote.Name = "clNote";
            this.clNote.ReadOnly = true;
            this.clNote.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clNote.Width = 36;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(395, 52);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(91, 27);
            this.btnSearch.TabIndex = 57;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(321, 227);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(76, 27);
            this.btnCancel.TabIndex = 60;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(156, 227);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(2);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(76, 27);
            this.btnSelect.TabIndex = 59;
            this.btnSelect.Text = "Ok";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(111, 55);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(167, 20);
            this.txtCustomerName.TabIndex = 61;
            // 
            // txtBookedId
            // 
            this.txtBookedId.Location = new System.Drawing.Point(111, 21);
            this.txtBookedId.Name = "txtBookedId";
            this.txtBookedId.Size = new System.Drawing.Size(167, 20);
            this.txtBookedId.TabIndex = 63;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 62;
            this.label1.Text = "Booked id";
            // 
            // dateTimePickerDateBooked
            // 
            this.dateTimePickerDateBooked.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDateBooked.Location = new System.Drawing.Point(396, 55);
            this.dateTimePickerDateBooked.Name = "dateTimePickerDateBooked";
            this.dateTimePickerDateBooked.Size = new System.Drawing.Size(167, 20);
            this.dateTimePickerDateBooked.TabIndex = 64;
            // 
            // lblDateTimePicker
            // 
            this.lblDateTimePicker.AutoSize = true;
            this.lblDateTimePicker.Location = new System.Drawing.Point(315, 58);
            this.lblDateTimePicker.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDateTimePicker.Name = "lblDateTimePicker";
            this.lblDateTimePicker.Size = new System.Drawing.Size(69, 13);
            this.lblDateTimePicker.TabIndex = 66;
            this.lblDateTimePicker.Text = "Date booked";
            // 
            // RoomBookSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 265);
            this.Controls.Add(this.lblDateTimePicker);
            this.Controls.Add(this.dateTimePickerDateBooked);
            this.Controls.Add(this.txtBookedId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvRoomBook);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbRoom);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RoomBookSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Search room book";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbRoom;
        private System.Windows.Forms.DataGridView dgvRoomBook;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtBookedId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateBooked;
        private System.Windows.Forms.Label lblDateTimePicker;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clRoomName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clRoomType;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDateBooked;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDateExpire;
        private System.Windows.Forms.DataGridViewTextBoxColumn clBail;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNote;
    }
}