namespace MotelManage.PresentationTier
{
    partial class ServiceNoteEdit
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgvServiceNoteDetail = new System.Windows.Forms.DataGridView();
            this.clServiceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNumberOld = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNumberNew = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNumberUsed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTotalMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtContractID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotalMoney = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.cmbRoom = new System.Windows.Forms.ComboBox();
            this.btnSaveAndExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiceNoteDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(129, 329);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(162, 27);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            this.dgvServiceNoteDetail.Location = new System.Drawing.Point(0, 109);
            this.dgvServiceNoteDetail.Margin = new System.Windows.Forms.Padding(2);
            this.dgvServiceNoteDetail.MultiSelect = false;
            this.dgvServiceNoteDetail.Name = "dgvServiceNoteDetail";
            this.dgvServiceNoteDetail.RowTemplate.Height = 24;
            this.dgvServiceNoteDetail.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvServiceNoteDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvServiceNoteDetail.Size = new System.Drawing.Size(628, 210);
            this.dgvServiceNoteDetail.TabIndex = 4;
            this.dgvServiceNoteDetail.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvServiceNoteDetail_CellDoubleClick);
            this.dgvServiceNoteDetail.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvServiceNoteDetail_CellEndEdit);
            this.dgvServiceNoteDetail.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvServiceNoteDetail_EditingControlShowing);
            // 
            // clServiceName
            // 
            this.clServiceName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.clServiceName.DataPropertyName = "ServiceName";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.clServiceName.DefaultCellStyle = dataGridViewCellStyle1;
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.clNumberOld.DefaultCellStyle = dataGridViewCellStyle2;
            this.clNumberOld.HeaderText = "Number old";
            this.clNumberOld.Name = "clNumberOld";
            this.clNumberOld.Width = 86;
            // 
            // clNumberNew
            // 
            this.clNumberNew.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.clNumberNew.DataPropertyName = "Numbernew";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.clNumberNew.DefaultCellStyle = dataGridViewCellStyle3;
            this.clNumberNew.HeaderText = "Number new";
            this.clNumberNew.Name = "clNumberNew";
            this.clNumberNew.Width = 92;
            // 
            // clNumberUsed
            // 
            this.clNumberUsed.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.clNumberUsed.DataPropertyName = "NumberUsed";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.clNumberUsed.DefaultCellStyle = dataGridViewCellStyle4;
            this.clNumberUsed.HeaderText = "Number used";
            this.clNumberUsed.Name = "clNumberUsed";
            this.clNumberUsed.Width = 95;
            // 
            // clUnit
            // 
            this.clUnit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.clUnit.DataPropertyName = "Unit";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.clUnit.DefaultCellStyle = dataGridViewCellStyle5;
            this.clUnit.HeaderText = "Unit";
            this.clUnit.Name = "clUnit";
            this.clUnit.ReadOnly = true;
            this.clUnit.Width = 51;
            // 
            // clPrice
            // 
            this.clPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.clPrice.DataPropertyName = "Price";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.clPrice.DefaultCellStyle = dataGridViewCellStyle6;
            this.clPrice.HeaderText = "Price";
            this.clPrice.Name = "clPrice";
            this.clPrice.ReadOnly = true;
            this.clPrice.Width = 56;
            // 
            // clTotalMoney
            // 
            this.clTotalMoney.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.clTotalMoney.DataPropertyName = "Total";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            this.clTotalMoney.DefaultCellStyle = dataGridViewCellStyle7;
            this.clTotalMoney.HeaderText = "Total money";
            this.clTotalMoney.Name = "clTotalMoney";
            this.clTotalMoney.ReadOnly = true;
            this.clTotalMoney.Width = 90;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(103, 15);
            this.txtId.Margin = new System.Windows.Forms.Padding(2);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(170, 20);
            this.txtId.TabIndex = 10000;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(300, 48);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Contract ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Service note ID";
            // 
            // txtContractID
            // 
            this.txtContractID.Location = new System.Drawing.Point(387, 45);
            this.txtContractID.Margin = new System.Windows.Forms.Padding(2);
            this.txtContractID.Name = "txtContractID";
            this.txtContractID.ReadOnly = true;
            this.txtContractID.Size = new System.Drawing.Size(170, 20);
            this.txtContractID.TabIndex = 3333;
            this.txtContractID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 48);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Room";
            // 
            // txtTotalMoney
            // 
            this.txtTotalMoney.Location = new System.Drawing.Point(387, 76);
            this.txtTotalMoney.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotalMoney.Name = "txtTotalMoney";
            this.txtTotalMoney.ReadOnly = true;
            this.txtTotalMoney.Size = new System.Drawing.Size(170, 20);
            this.txtTotalMoney.TabIndex = 53333;
            this.txtTotalMoney.Text = "0";
            this.txtTotalMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(300, 79);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Total money";
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDate.Location = new System.Drawing.Point(103, 76);
            this.dateTimePickerDate.MaxDate = new System.DateTime(2015, 7, 23, 0, 0, 0, 0);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(170, 20);
            this.dateTimePickerDate.TabIndex = 3;
            this.dateTimePickerDate.Value = new System.DateTime(2015, 7, 23, 0, 0, 0, 0);
            // 
            // cmbRoom
            // 
            this.cmbRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoom.FormattingEnabled = true;
            this.cmbRoom.Location = new System.Drawing.Point(103, 45);
            this.cmbRoom.Name = "cmbRoom";
            this.cmbRoom.Size = new System.Drawing.Size(170, 21);
            this.cmbRoom.TabIndex = 2;
            this.cmbRoom.SelectedIndexChanged += new System.EventHandler(this.cmbRoom_SelectedIndexChanged);
            // 
            // btnSaveAndExport
            // 
            this.btnSaveAndExport.Location = new System.Drawing.Point(317, 329);
            this.btnSaveAndExport.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveAndExport.Name = "btnSaveAndExport";
            this.btnSaveAndExport.Size = new System.Drawing.Size(162, 27);
            this.btnSaveAndExport.TabIndex = 53334;
            this.btnSaveAndExport.Text = "Save and Export to TollBills";
            this.btnSaveAndExport.UseVisualStyleBackColor = true;
            this.btnSaveAndExport.Click += new System.EventHandler(this.btnSaveAndExport_Click);
            // 
            // ServiceNoteEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 367);
            this.Controls.Add(this.btnSaveAndExport);
            this.Controls.Add(this.cmbRoom);
            this.Controls.Add(this.dateTimePickerDate);
            this.Controls.Add(this.txtTotalMoney);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtContractID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvServiceNoteDetail);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "ServiceNoteEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit service note";
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiceNoteDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvServiceNoteDetail;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtContractID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTotalMoney;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clServiceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNumberOld;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNumberNew;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNumberUsed;
        private System.Windows.Forms.DataGridViewTextBoxColumn clUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTotalMoney;
        private System.Windows.Forms.ComboBox cmbRoom;
        private System.Windows.Forms.Button btnSaveAndExport;
    }
}