namespace MotelManage.PresentationTier
{
    partial class TollBillEdit
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtDiscountMoney = new System.Windows.Forms.TextBox();
            this.txtPriceRoom = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRoom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTotalMoneyService = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDebt = new System.Windows.Forms.TextBox();
            this.btnPayment = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblServiceNoteId = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtContractId = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dateTimePickerDateNoteService = new System.Windows.Forms.DateTimePicker();
            this.dgvServiceNoteDetail = new System.Windows.Forms.DataGridView();
            this.clServiceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNumberOld = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNumberNew = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNumberUsed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTotalMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiceNoteDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(93, 354);
            this.txtNote.Margin = new System.Windows.Forms.Padding(2);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(212, 32);
            this.txtNote.TabIndex = 33;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(93, 228);
            this.txtId.Margin = new System.Windows.Forms.Padding(2);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(159, 20);
            this.txtId.TabIndex = 32;
            // 
            // txtDiscountMoney
            // 
            this.txtDiscountMoney.Location = new System.Drawing.Point(423, 322);
            this.txtDiscountMoney.Margin = new System.Windows.Forms.Padding(2);
            this.txtDiscountMoney.Name = "txtDiscountMoney";
            this.txtDiscountMoney.Size = new System.Drawing.Size(182, 20);
            this.txtDiscountMoney.TabIndex = 31;
            this.txtDiscountMoney.Text = "0";
            this.txtDiscountMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPriceRoom
            // 
            this.txtPriceRoom.Location = new System.Drawing.Point(423, 228);
            this.txtPriceRoom.Margin = new System.Windows.Forms.Padding(2);
            this.txtPriceRoom.Name = "txtPriceRoom";
            this.txtPriceRoom.ReadOnly = true;
            this.txtPriceRoom.Size = new System.Drawing.Size(182, 20);
            this.txtPriceRoom.TabIndex = 28;
            this.txtPriceRoom.Text = "0";
            this.txtPriceRoom.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 294);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Contract Id";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(334, 231);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Room Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(334, 294);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Debt";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 366);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Note";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 262);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Date";
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Enabled = false;
            this.dateTimePickerDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDate.Location = new System.Drawing.Point(93, 259);
            this.dateTimePickerDate.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(159, 20);
            this.dateTimePickerDate.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 231);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Id";
            // 
            // txtRoom
            // 
            this.txtRoom.Location = new System.Drawing.Point(94, 322);
            this.txtRoom.Margin = new System.Windows.Forms.Padding(2);
            this.txtRoom.Name = "txtRoom";
            this.txtRoom.ReadOnly = true;
            this.txtRoom.Size = new System.Drawing.Size(158, 20);
            this.txtRoom.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 325);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Name room";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(334, 262);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 36;
            this.label8.Text = "Service sumary";
            // 
            // txtTotalMoneyService
            // 
            this.txtTotalMoneyService.Location = new System.Drawing.Point(423, 259);
            this.txtTotalMoneyService.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotalMoneyService.Name = "txtTotalMoneyService";
            this.txtTotalMoneyService.ReadOnly = true;
            this.txtTotalMoneyService.Size = new System.Drawing.Size(182, 20);
            this.txtTotalMoneyService.TabIndex = 37;
            this.txtTotalMoneyService.Text = "0";
            this.txtTotalMoneyService.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(334, 325);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 13);
            this.label9.TabIndex = 38;
            this.label9.Text = "Discount money";
            // 
            // txtDebt
            // 
            this.txtDebt.Location = new System.Drawing.Point(423, 291);
            this.txtDebt.Margin = new System.Windows.Forms.Padding(2);
            this.txtDebt.Name = "txtDebt";
            this.txtDebt.ReadOnly = true;
            this.txtDebt.Size = new System.Drawing.Size(182, 20);
            this.txtDebt.TabIndex = 39;
            this.txtDebt.Text = "0";
            this.txtDebt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnPayment
            // 
            this.btnPayment.Location = new System.Drawing.Point(327, 411);
            this.btnPayment.Margin = new System.Windows.Forms.Padding(2);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(92, 33);
            this.btnPayment.TabIndex = 40;
            this.btnPayment.Text = "Payment";
            this.btnPayment.UseVisualStyleBackColor = true;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(12, 411);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(102, 33);
            this.btnPrint.TabIndex = 41;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(434, 411);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(103, 33);
            this.btnSave.TabIndex = 42;
            this.btnSave.Text = "Save tollbills";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblServiceNoteId
            // 
            this.lblServiceNoteId.AutoSize = true;
            this.lblServiceNoteId.Location = new System.Drawing.Point(9, 13);
            this.lblServiceNoteId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblServiceNoteId.Name = "lblServiceNoteId";
            this.lblServiceNoteId.Size = new System.Drawing.Size(95, 13);
            this.lblServiceNoteId.TabIndex = 44;
            this.lblServiceNoteId.Text = "Services note ( id=";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(334, 365);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 13);
            this.label11.TabIndex = 46;
            this.label11.Text = "Total must pay";
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtTotal.ForeColor = System.Drawing.Color.Red;
            this.txtTotal.Location = new System.Drawing.Point(423, 354);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(182, 32);
            this.txtTotal.TabIndex = 45;
            this.txtTotal.Text = "0";
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(551, 411);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(63, 33);
            this.btnClose.TabIndex = 47;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtContractId
            // 
            this.txtContractId.Location = new System.Drawing.Point(93, 291);
            this.txtContractId.Margin = new System.Windows.Forms.Padding(2);
            this.txtContractId.Name = "txtContractId";
            this.txtContractId.ReadOnly = true;
            this.txtContractId.Size = new System.Drawing.Size(158, 20);
            this.txtContractId.TabIndex = 48;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(425, 13);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 13);
            this.label12.TabIndex = 50;
            this.label12.Text = "Date note service";
            // 
            // dateTimePickerDateNoteService
            // 
            this.dateTimePickerDateNoteService.Enabled = false;
            this.dateTimePickerDateNoteService.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDateNoteService.Location = new System.Drawing.Point(521, 9);
            this.dateTimePickerDateNoteService.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerDateNoteService.Name = "dateTimePickerDateNoteService";
            this.dateTimePickerDateNoteService.Size = new System.Drawing.Size(98, 20);
            this.dateTimePickerDateNoteService.TabIndex = 52;
            // 
            // dgvServiceNoteDetail
            // 
            this.dgvServiceNoteDetail.AllowUserToAddRows = false;
            this.dgvServiceNoteDetail.AllowUserToDeleteRows = false;
            this.dgvServiceNoteDetail.AllowUserToResizeRows = false;
            this.dgvServiceNoteDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvServiceNoteDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServiceNoteDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clServiceName,
            this.clNumberOld,
            this.clNumberNew,
            this.clNumberUsed,
            this.clUnit,
            this.clPrice,
            this.clTotalMoney});
            this.dgvServiceNoteDetail.Location = new System.Drawing.Point(10, 33);
            this.dgvServiceNoteDetail.Margin = new System.Windows.Forms.Padding(2);
            this.dgvServiceNoteDetail.MultiSelect = false;
            this.dgvServiceNoteDetail.Name = "dgvServiceNoteDetail";
            this.dgvServiceNoteDetail.ReadOnly = true;
            this.dgvServiceNoteDetail.RowTemplate.Height = 24;
            this.dgvServiceNoteDetail.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvServiceNoteDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvServiceNoteDetail.Size = new System.Drawing.Size(608, 180);
            this.dgvServiceNoteDetail.TabIndex = 53;
            // 
            // clServiceName
            // 
            this.clServiceName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.clServiceName.DataPropertyName = "ServiceName";
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.Color.Black;
            this.clServiceName.DefaultCellStyle = dataGridViewCellStyle22;
            this.clServiceName.HeaderText = "Service name";
            this.clServiceName.Name = "clServiceName";
            this.clServiceName.ReadOnly = true;
            this.clServiceName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clServiceName.Width = 97;
            // 
            // clNumberOld
            // 
            this.clNumberOld.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.clNumberOld.DataPropertyName = "Numberold";
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.Black;
            this.clNumberOld.DefaultCellStyle = dataGridViewCellStyle23;
            this.clNumberOld.HeaderText = "Number old";
            this.clNumberOld.Name = "clNumberOld";
            this.clNumberOld.ReadOnly = true;
            this.clNumberOld.Width = 86;
            // 
            // clNumberNew
            // 
            this.clNumberNew.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.clNumberNew.DataPropertyName = "Numbernew";
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.Black;
            this.clNumberNew.DefaultCellStyle = dataGridViewCellStyle24;
            this.clNumberNew.HeaderText = "Number new";
            this.clNumberNew.Name = "clNumberNew";
            this.clNumberNew.ReadOnly = true;
            this.clNumberNew.Width = 92;
            // 
            // clNumberUsed
            // 
            this.clNumberUsed.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.clNumberUsed.DataPropertyName = "NumberUsed";
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle25.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.Color.Black;
            this.clNumberUsed.DefaultCellStyle = dataGridViewCellStyle25;
            this.clNumberUsed.HeaderText = "Number used";
            this.clNumberUsed.Name = "clNumberUsed";
            this.clNumberUsed.ReadOnly = true;
            this.clNumberUsed.Width = 95;
            // 
            // clUnit
            // 
            this.clUnit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.clUnit.DataPropertyName = "Unit";
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle26.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.Color.Black;
            this.clUnit.DefaultCellStyle = dataGridViewCellStyle26;
            this.clUnit.HeaderText = "Unit";
            this.clUnit.Name = "clUnit";
            this.clUnit.ReadOnly = true;
            this.clUnit.Width = 51;
            // 
            // clPrice
            // 
            this.clPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.clPrice.DataPropertyName = "Price";
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle27.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.Black;
            this.clPrice.DefaultCellStyle = dataGridViewCellStyle27;
            this.clPrice.HeaderText = "Price";
            this.clPrice.Name = "clPrice";
            this.clPrice.ReadOnly = true;
            this.clPrice.Width = 56;
            // 
            // clTotalMoney
            // 
            this.clTotalMoney.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.clTotalMoney.DataPropertyName = "Total";
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle28.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle28.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.Color.Black;
            this.clTotalMoney.DefaultCellStyle = dataGridViewCellStyle28;
            this.clTotalMoney.HeaderText = "Total money";
            this.clTotalMoney.Name = "clTotalMoney";
            this.clTotalMoney.ReadOnly = true;
            this.clTotalMoney.Width = 90;
            // 
            // TollBillEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 461);
            this.Controls.Add(this.dgvServiceNoteDetail);
            this.Controls.Add(this.dateTimePickerDateNoteService);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtContractId);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblServiceNoteId);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnPayment);
            this.Controls.Add(this.txtDebt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTotalMoneyService);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtRoom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtDiscountMoney);
            this.Controls.Add(this.txtPriceRoom);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePickerDate);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TollBillEdit";
            this.Text = "TollBillEdit";
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiceNoteDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtDiscountMoney;
        private System.Windows.Forms.TextBox txtPriceRoom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRoom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTotalMoneyService;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDebt;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblServiceNoteId;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtContractId;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateNoteService;
        private System.Windows.Forms.DataGridView dgvServiceNoteDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn clServiceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNumberOld;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNumberNew;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNumberUsed;
        private System.Windows.Forms.DataGridViewTextBoxColumn clUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTotalMoney;
    }
}