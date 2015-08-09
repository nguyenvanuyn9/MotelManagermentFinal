namespace MotelManage.PresentationTier
{
    partial class TollBillList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtDebt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTotalMoneyService = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtContractId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtDiscountMoney = new System.Windows.Forms.TextBox();
            this.txtPriceRoom = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbRoom = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTollBills = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dateTimePickerNoteService = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.clId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clContractId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clRoomName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clRoomPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clServiceSumMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDateServiceNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDebt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDiscountMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTollBills)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDebt
            // 
            this.txtDebt.Location = new System.Drawing.Point(431, 113);
            this.txtDebt.Margin = new System.Windows.Forms.Padding(2);
            this.txtDebt.Name = "txtDebt";
            this.txtDebt.ReadOnly = true;
            this.txtDebt.Size = new System.Drawing.Size(182, 20);
            this.txtDebt.TabIndex = 8;
            this.txtDebt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(329, 146);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 13);
            this.label9.TabIndex = 62;
            this.label9.Text = "Discount money";
            // 
            // txtTotalMoneyService
            // 
            this.txtTotalMoneyService.Location = new System.Drawing.Point(431, 81);
            this.txtTotalMoneyService.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotalMoneyService.Name = "txtTotalMoneyService";
            this.txtTotalMoneyService.ReadOnly = true;
            this.txtTotalMoneyService.Size = new System.Drawing.Size(182, 20);
            this.txtTotalMoneyService.TabIndex = 7;
            this.txtTotalMoneyService.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(329, 84);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 13);
            this.label8.TabIndex = 60;
            this.label8.Text = "Service sum money";
            // 
            // txtContractId
            // 
            this.txtContractId.Location = new System.Drawing.Point(79, 111);
            this.txtContractId.Margin = new System.Windows.Forms.Padding(2);
            this.txtContractId.Name = "txtContractId";
            this.txtContractId.Size = new System.Drawing.Size(158, 20);
            this.txtContractId.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 84);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 58;
            this.label4.Text = "Name room";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(79, 18);
            this.txtId.Margin = new System.Windows.Forms.Padding(2);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(159, 20);
            this.txtId.TabIndex = 0;
            // 
            // txtDiscountMoney
            // 
            this.txtDiscountMoney.Location = new System.Drawing.Point(431, 143);
            this.txtDiscountMoney.Margin = new System.Windows.Forms.Padding(2);
            this.txtDiscountMoney.Name = "txtDiscountMoney";
            this.txtDiscountMoney.ReadOnly = true;
            this.txtDiscountMoney.Size = new System.Drawing.Size(182, 20);
            this.txtDiscountMoney.TabIndex = 9;
            this.txtDiscountMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPriceRoom
            // 
            this.txtPriceRoom.Location = new System.Drawing.Point(431, 50);
            this.txtPriceRoom.Margin = new System.Windows.Forms.Padding(2);
            this.txtPriceRoom.Name = "txtPriceRoom";
            this.txtPriceRoom.ReadOnly = true;
            this.txtPriceRoom.Size = new System.Drawing.Size(182, 20);
            this.txtPriceRoom.TabIndex = 6;
            this.txtPriceRoom.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 114);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 53;
            this.label7.Text = "Contract Id";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(329, 53);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 52;
            this.label6.Text = "Room Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(329, 116);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 51;
            this.label5.Text = "Debt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 49;
            this.label2.Text = "Date";
            // 
            // cmbRoom
            // 
            this.cmbRoom.FormattingEnabled = true;
            this.cmbRoom.Location = new System.Drawing.Point(79, 80);
            this.cmbRoom.Margin = new System.Windows.Forms.Padding(2);
            this.cmbRoom.Name = "cmbRoom";
            this.cmbRoom.Size = new System.Drawing.Size(159, 21);
            this.cmbRoom.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "Id";
            // 
            // dgvTollBills
            // 
            this.dgvTollBills.AllowUserToAddRows = false;
            this.dgvTollBills.AllowUserToDeleteRows = false;
            this.dgvTollBills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTollBills.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clId,
            this.clContractId,
            this.clRoomName,
            this.clDate,
            this.clRoomPrice,
            this.clServiceSumMoney,
            this.clDateServiceNote,
            this.clDebt,
            this.clDiscountMoney,
            this.clTotal,
            this.clNote});
            this.dgvTollBills.Location = new System.Drawing.Point(0, 252);
            this.dgvTollBills.Margin = new System.Windows.Forms.Padding(2);
            this.dgvTollBills.MultiSelect = false;
            this.dgvTollBills.Name = "dgvTollBills";
            this.dgvTollBills.ReadOnly = true;
            this.dgvTollBills.RowTemplate.Height = 24;
            this.dgvTollBills.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTollBills.Size = new System.Drawing.Size(946, 275);
            this.dgvTollBills.TabIndex = 16;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(27, 210);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(76, 27);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(391, 210);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(76, 27);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.Location = new System.Drawing.Point(147, 210);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(76, 27);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(268, 210);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(76, 27);
            this.btnEdit.TabIndex = 13;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(512, 210);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(76, 27);
            this.btnRefresh.TabIndex = 15;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(329, 176);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 73;
            this.label3.Text = "Total";
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(79, 141);
            this.txtNote.Margin = new System.Windows.Forms.Padding(2);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(226, 52);
            this.txtNote.TabIndex = 4;
            this.txtNote.Text = "Tôi là Nguyễn Văn Uy. Hiện đang là sinh viên năm cuối khoa Công Nghệ Phần Mềm, tr" +
    "ường Đại học Công Nghệ Thông Tin";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(431, 173);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(182, 20);
            this.txtTotal.TabIndex = 10;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 176);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 70;
            this.label10.Text = "Note";
            // 
            // dateTimePickerNoteService
            // 
            this.dateTimePickerNoteService.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerNoteService.Location = new System.Drawing.Point(431, 18);
            this.dateTimePickerNoteService.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerNoteService.MaxDate = new System.DateTime(2015, 7, 27, 0, 0, 0, 0);
            this.dateTimePickerNoteService.Name = "dateTimePickerNoteService";
            this.dateTimePickerNoteService.Size = new System.Drawing.Size(182, 20);
            this.dateTimePickerNoteService.TabIndex = 5;
            this.dateTimePickerNoteService.Value = new System.DateTime(2015, 7, 27, 0, 0, 0, 0);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(329, 21);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 13);
            this.label11.TabIndex = 75;
            this.label11.Text = "Date note service";
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDate.Location = new System.Drawing.Point(79, 49);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(159, 20);
            this.dateTimePickerDate.TabIndex = 76;
            // 
            // clId
            // 
            this.clId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.clId.DataPropertyName = "ID";
            this.clId.HeaderText = "Id";
            this.clId.Name = "clId";
            this.clId.ReadOnly = true;
            this.clId.Width = 41;
            // 
            // clContractId
            // 
            this.clContractId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.clContractId.DataPropertyName = "CONTRACTID";
            this.clContractId.HeaderText = "Contract id";
            this.clContractId.Name = "clContractId";
            this.clContractId.ReadOnly = true;
            this.clContractId.Width = 83;
            // 
            // clRoomName
            // 
            this.clRoomName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.clRoomName.DataPropertyName = "ROOMNAME";
            this.clRoomName.HeaderText = "Room";
            this.clRoomName.Name = "clRoomName";
            this.clRoomName.ReadOnly = true;
            this.clRoomName.Width = 60;
            // 
            // clDate
            // 
            this.clDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.clDate.DataPropertyName = "DATETOLL";
            this.clDate.HeaderText = "Date";
            this.clDate.Name = "clDate";
            this.clDate.ReadOnly = true;
            this.clDate.Width = 55;
            // 
            // clRoomPrice
            // 
            this.clRoomPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.clRoomPrice.DataPropertyName = "PRICEROOM";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.clRoomPrice.DefaultCellStyle = dataGridViewCellStyle16;
            this.clRoomPrice.HeaderText = "Room price";
            this.clRoomPrice.Name = "clRoomPrice";
            this.clRoomPrice.ReadOnly = true;
            this.clRoomPrice.Width = 79;
            // 
            // clServiceSumMoney
            // 
            this.clServiceSumMoney.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.clServiceSumMoney.DataPropertyName = "SERVICESUMMONEY";
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.clServiceSumMoney.DefaultCellStyle = dataGridViewCellStyle17;
            this.clServiceSumMoney.HeaderText = "Service sum money";
            this.clServiceSumMoney.Name = "clServiceSumMoney";
            this.clServiceSumMoney.ReadOnly = true;
            this.clServiceSumMoney.Width = 86;
            // 
            // clDateServiceNote
            // 
            this.clDateServiceNote.DataPropertyName = "DATESERVICENOTE";
            this.clDateServiceNote.HeaderText = "Date note service";
            this.clDateServiceNote.Name = "clDateServiceNote";
            this.clDateServiceNote.ReadOnly = true;
            // 
            // clDebt
            // 
            this.clDebt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.clDebt.DataPropertyName = "DEBTUNTILDATE";
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.clDebt.DefaultCellStyle = dataGridViewCellStyle18;
            this.clDebt.HeaderText = "Debt";
            this.clDebt.Name = "clDebt";
            this.clDebt.ReadOnly = true;
            this.clDebt.Width = 55;
            // 
            // clDiscountMoney
            // 
            this.clDiscountMoney.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.clDiscountMoney.DataPropertyName = "DISCOUNTMONEY";
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.clDiscountMoney.DefaultCellStyle = dataGridViewCellStyle19;
            this.clDiscountMoney.HeaderText = "Discount Money";
            this.clDiscountMoney.Name = "clDiscountMoney";
            this.clDiscountMoney.ReadOnly = true;
            // 
            // clTotal
            // 
            this.clTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.clTotal.DataPropertyName = "TOTAL";
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.clTotal.DefaultCellStyle = dataGridViewCellStyle20;
            this.clTotal.HeaderText = "Total";
            this.clTotal.Name = "clTotal";
            this.clTotal.ReadOnly = true;
            this.clTotal.Width = 56;
            // 
            // clNote
            // 
            this.clNote.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.clNote.DataPropertyName = "NOTE";
            this.clNote.HeaderText = "Note";
            this.clNote.Name = "clNote";
            this.clNote.ReadOnly = true;
            this.clNote.Width = 55;
            // 
            // TollBillList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 527);
            this.Controls.Add(this.dateTimePickerDate);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dateTimePickerNoteService);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.dgvTollBills);
            this.Controls.Add(this.txtDebt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTotalMoneyService);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtContractId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtDiscountMoney);
            this.Controls.Add(this.txtPriceRoom);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbRoom);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TollBillList";
            this.Text = "List tollbills";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTollBills)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDebt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTotalMoneyService;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtContractId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtDiscountMoney;
        private System.Windows.Forms.TextBox txtPriceRoom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbRoom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvTollBills;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateTimePickerNoteService;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clContractId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clRoomName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clRoomPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clServiceSumMoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDateServiceNote;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDebt;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDiscountMoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNote;
    }
}