namespace MotelManage.PresentationTier
{
    partial class DebtList
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
            this.ctrID = new System.Windows.Forms.TextBox();
            this.idDebtList = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.searchDebt = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.editDebt = new System.Windows.Forms.Button();
            this.dataDebtList = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataDebtList)).BeginInit();
            this.SuspendLayout();
            // 
            // ctrID
            // 
            this.ctrID.Location = new System.Drawing.Point(64, 37);
            this.ctrID.Margin = new System.Windows.Forms.Padding(2);
            this.ctrID.Name = "ctrID";
            this.ctrID.Size = new System.Drawing.Size(170, 20);
            this.ctrID.TabIndex = 48;
            // 
            // idDebtList
            // 
            this.idDebtList.Location = new System.Drawing.Point(64, 9);
            this.idDebtList.Margin = new System.Windows.Forms.Padding(2);
            this.idDebtList.Name = "idDebtList";
            this.idDebtList.Size = new System.Drawing.Size(170, 20);
            this.idDebtList.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-1, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 46;
            this.label2.Text = "Contract ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "Id";
            // 
            // searchDebt
            // 
            this.searchDebt.Location = new System.Drawing.Point(141, 80);
            this.searchDebt.Margin = new System.Windows.Forms.Padding(2);
            this.searchDebt.Name = "searchDebt";
            this.searchDebt.Size = new System.Drawing.Size(76, 27);
            this.searchDebt.TabIndex = 44;
            this.searchDebt.Text = "Search";
            this.searchDebt.UseVisualStyleBackColor = true;
            this.searchDebt.Click += new System.EventHandler(this.searchDebtList_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(364, 80);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(76, 27);
            this.button3.TabIndex = 43;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.del_Debt);
            // 
            // editDebt
            // 
            this.editDebt.Location = new System.Drawing.Point(257, 80);
            this.editDebt.Margin = new System.Windows.Forms.Padding(2);
            this.editDebt.Name = "editDebt";
            this.editDebt.Size = new System.Drawing.Size(76, 27);
            this.editDebt.TabIndex = 41;
            this.editDebt.Text = "Edit";
            this.editDebt.UseVisualStyleBackColor = true;
            this.editDebt.Click += new System.EventHandler(this.editDebt_click);
            // 
            // dataDebtList
            // 
            this.dataDebtList.AllowUserToAddRows = false;
            this.dataDebtList.AllowUserToDeleteRows = false;
            this.dataDebtList.AllowUserToResizeColumns = false;
            this.dataDebtList.AllowUserToResizeRows = false;
            this.dataDebtList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDebtList.Location = new System.Drawing.Point(9, 124);
            this.dataDebtList.Margin = new System.Windows.Forms.Padding(2);
            this.dataDebtList.Name = "dataDebtList";
            this.dataDebtList.RowTemplate.Height = 24;
            this.dataDebtList.Size = new System.Drawing.Size(445, 162);
            this.dataDebtList.TabIndex = 40;
            this.dataDebtList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataDebt_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(37, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 49;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DebtList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 293);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ctrID);
            this.Controls.Add(this.idDebtList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchDebt);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.editDebt);
            this.Controls.Add(this.dataDebtList);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DebtList";
            this.Text = "Debt List";
            this.Load += new System.EventHandler(this.DebtList_Loaded);
            ((System.ComponentModel.ISupportInitialize)(this.dataDebtList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ctrID;
        private System.Windows.Forms.TextBox idDebtList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchDebt;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button editDebt;
        private System.Windows.Forms.DataGridView dataDebtList;
        private System.Windows.Forms.Button button1;
    }
}