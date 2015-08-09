namespace MotelManage.PresentationTier
{
    partial class ContractList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.dgvContract = new System.Windows.Forms.DataGridView();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerDateBegin = new System.Windows.Forms.DateTimePicker();
            this.txtPriceRoom = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbContractStatus = new System.Windows.Forms.ComboBox();
            this.txtCustomerId = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.cmbRoom = new System.Windows.Forms.ComboBox();
            this.clID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clRoomName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPriceRoom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDateBegin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clIsValid = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContract)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(18, 147);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(76, 27);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(358, 147);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(76, 27);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(129, 147);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(76, 27);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(245, 147);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(76, 27);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // dgvContract
            // 
            this.dgvContract.AllowUserToAddRows = false;
            this.dgvContract.AllowUserToDeleteRows = false;
            this.dgvContract.AllowUserToResizeRows = false;
            this.dgvContract.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvContract.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContract.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clID,
            this.clCustomerName,
            this.clRoomName,
            this.clPriceRoom,
            this.clDateBegin,
            this.clNote,
            this.clIsValid});
            this.dgvContract.Location = new System.Drawing.Point(0, 189);
            this.dgvContract.Margin = new System.Windows.Forms.Padding(2);
            this.dgvContract.MultiSelect = false;
            this.dgvContract.Name = "dgvContract";
            this.dgvContract.ReadOnly = true;
            this.dgvContract.RowTemplate.Height = 24;
            this.dgvContract.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvContract.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContract.Size = new System.Drawing.Size(589, 222);
            this.dgvContract.TabIndex = 11;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(103, 15);
            this.txtId.Margin = new System.Windows.Forms.Padding(2);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(170, 20);
            this.txtId.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 48);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Customer name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(306, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Date begin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Contract Id";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(308, 48);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Customer Id";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(477, 147);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(76, 27);
            this.btnRefresh.TabIndex = 10;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 79);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Room";
            // 
            // dateTimePickerDateBegin
            // 
            this.dateTimePickerDateBegin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDateBegin.Location = new System.Drawing.Point(387, 15);
            this.dateTimePickerDateBegin.Name = "dateTimePickerDateBegin";
            this.dateTimePickerDateBegin.Size = new System.Drawing.Size(170, 20);
            this.dateTimePickerDateBegin.TabIndex = 2;
            // 
            // txtPriceRoom
            // 
            this.txtPriceRoom.Location = new System.Drawing.Point(387, 77);
            this.txtPriceRoom.Margin = new System.Windows.Forms.Padding(2);
            this.txtPriceRoom.Name = "txtPriceRoom";
            this.txtPriceRoom.Size = new System.Drawing.Size(170, 20);
            this.txtPriceRoom.TabIndex = 32;
            this.txtPriceRoom.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(308, 79);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Price room";
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(103, 108);
            this.txtNote.Margin = new System.Windows.Forms.Padding(2);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(170, 20);
            this.txtNote.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 111);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "Note";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(308, 111);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 36;
            this.label8.Text = "Status";
            // 
            // cmbContractStatus
            // 
            this.cmbContractStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbContractStatus.FormattingEnabled = true;
            this.cmbContractStatus.Location = new System.Drawing.Point(387, 108);
            this.cmbContractStatus.Name = "cmbContractStatus";
            this.cmbContractStatus.Size = new System.Drawing.Size(170, 21);
            this.cmbContractStatus.TabIndex = 37;
            // 
            // txtCustomerId
            // 
            this.txtCustomerId.Location = new System.Drawing.Point(387, 45);
            this.txtCustomerId.Margin = new System.Windows.Forms.Padding(2);
            this.txtCustomerId.Name = "txtCustomerId";
            this.txtCustomerId.Size = new System.Drawing.Size(170, 20);
            this.txtCustomerId.TabIndex = 38;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(103, 45);
            this.txtCustomerName.Margin = new System.Windows.Forms.Padding(2);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(170, 20);
            this.txtCustomerName.TabIndex = 39;
            // 
            // cmbRoom
            // 
            this.cmbRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoom.FormattingEnabled = true;
            this.cmbRoom.Location = new System.Drawing.Point(103, 75);
            this.cmbRoom.Name = "cmbRoom";
            this.cmbRoom.Size = new System.Drawing.Size(170, 21);
            this.cmbRoom.TabIndex = 40;
            // 
            // clID
            // 
            this.clID.DataPropertyName = "ID";
            this.clID.HeaderText = "Contract ID";
            this.clID.Name = "clID";
            this.clID.ReadOnly = true;
            this.clID.Width = 86;
            // 
            // clCustomerName
            // 
            this.clCustomerName.DataPropertyName = "CustomerName";
            this.clCustomerName.HeaderText = "Customer";
            this.clCustomerName.Name = "clCustomerName";
            this.clCustomerName.ReadOnly = true;
            this.clCustomerName.Width = 76;
            // 
            // clRoomName
            // 
            this.clRoomName.DataPropertyName = "RoomName";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.clRoomName.DefaultCellStyle = dataGridViewCellStyle1;
            this.clRoomName.HeaderText = "Room";
            this.clRoomName.Name = "clRoomName";
            this.clRoomName.ReadOnly = true;
            this.clRoomName.Width = 60;
            // 
            // clPriceRoom
            // 
            this.clPriceRoom.DataPropertyName = "PriceRoom";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.clPriceRoom.DefaultCellStyle = dataGridViewCellStyle2;
            this.clPriceRoom.HeaderText = "Price room";
            this.clPriceRoom.Name = "clPriceRoom";
            this.clPriceRoom.ReadOnly = true;
            this.clPriceRoom.Width = 82;
            // 
            // clDateBegin
            // 
            this.clDateBegin.DataPropertyName = "BeginDate";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.clDateBegin.DefaultCellStyle = dataGridViewCellStyle3;
            this.clDateBegin.HeaderText = "Date begin";
            this.clDateBegin.Name = "clDateBegin";
            this.clDateBegin.ReadOnly = true;
            this.clDateBegin.Width = 84;
            // 
            // clNote
            // 
            this.clNote.DataPropertyName = "Note";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.clNote.DefaultCellStyle = dataGridViewCellStyle4;
            this.clNote.HeaderText = "Note";
            this.clNote.Name = "clNote";
            this.clNote.ReadOnly = true;
            this.clNote.Width = 55;
            // 
            // clIsValid
            // 
            this.clIsValid.DataPropertyName = "IsValid";
            this.clIsValid.HeaderText = "Is Valid";
            this.clIsValid.Name = "clIsValid";
            this.clIsValid.ReadOnly = true;
            this.clIsValid.Width = 47;
            // 
            // ContractList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 411);
            this.Controls.Add(this.cmbRoom);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.txtCustomerId);
            this.Controls.Add(this.cmbContractStatus);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPriceRoom);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePickerDateBegin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.dgvContract);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "ContractList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List contract";
            ((System.ComponentModel.ISupportInitialize)(this.dgvContract)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateBegin;
        private System.Windows.Forms.DataGridView dgvContract;
        private System.Windows.Forms.TextBox txtPriceRoom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbContractStatus;
        private System.Windows.Forms.TextBox txtCustomerId;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.ComboBox cmbRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn clID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clRoomName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPriceRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDateBegin;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNote;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clIsValid;
    }
}