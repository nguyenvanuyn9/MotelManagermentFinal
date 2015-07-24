namespace MotelManage.PresentationTier
{
    partial class DebtEdit
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
            this.button2 = new System.Windows.Forms.Button();
            this.idDebt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateDebt = new System.Windows.Forms.Label();
            this.debt = new System.Windows.Forms.TextBox();
            this.noteDebt = new System.Windows.Forms.Label();
            this.note = new System.Windows.Forms.TextBox();
            this.ctrID = new System.Windows.Forms.TextBox();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(162, 181);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(76, 27);
            this.button2.TabIndex = 47;
            this.button2.Text = "Save Edit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.saveedit_Debt);
            // 
            // idDebt
            // 
            this.idDebt.Location = new System.Drawing.Point(68, 14);
            this.idDebt.Margin = new System.Windows.Forms.Padding(2);
            this.idDebt.Name = "idDebt";
            this.idDebt.ReadOnly = true;
            this.idDebt.Size = new System.Drawing.Size(170, 20);
            this.idDebt.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 71);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "Debt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Contract Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "Id";
            // 
            // dateDebt
            // 
            this.dateDebt.AutoSize = true;
            this.dateDebt.Location = new System.Drawing.Point(6, 100);
            this.dateDebt.Name = "dateDebt";
            this.dateDebt.Size = new System.Drawing.Size(30, 13);
            this.dateDebt.TabIndex = 49;
            this.dateDebt.Text = "Date";
            // 
            // debt
            // 
            this.debt.Location = new System.Drawing.Point(68, 71);
            this.debt.Name = "debt";
            this.debt.Size = new System.Drawing.Size(170, 20);
            this.debt.TabIndex = 50;
          
            // 
            // noteDebt
            // 
            this.noteDebt.AutoSize = true;
            this.noteDebt.Location = new System.Drawing.Point(9, 133);
            this.noteDebt.Name = "noteDebt";
            this.noteDebt.Size = new System.Drawing.Size(30, 13);
            this.noteDebt.TabIndex = 51;
            this.noteDebt.Text = "Note";
            // 
            // note
            // 
            this.note.Location = new System.Drawing.Point(68, 133);
            this.note.Name = "note";
            this.note.Size = new System.Drawing.Size(170, 20);
            this.note.TabIndex = 52;
            this.note.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ctrID
            // 
            this.ctrID.Location = new System.Drawing.Point(68, 42);
            this.ctrID.Name = "ctrID";
            this.ctrID.ReadOnly = true;
            this.ctrID.Size = new System.Drawing.Size(170, 20);
            this.ctrID.TabIndex = 53;
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(68, 100);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(170, 20);
            this.date.TabIndex = 54;
            // 
            // DebtEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 219);
            this.Controls.Add(this.date);
            this.Controls.Add(this.ctrID);
            this.Controls.Add(this.note);
            this.Controls.Add(this.noteDebt);
            this.Controls.Add(this.debt);
            this.Controls.Add(this.dateDebt);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.idDebt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DebtEdit";
            this.Text = "DeptEdit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox idDebt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label dateDebt;
        private System.Windows.Forms.TextBox debt;
        private System.Windows.Forms.Label noteDebt;
        private System.Windows.Forms.TextBox note;
        private System.Windows.Forms.TextBox ctrID;
        private System.Windows.Forms.DateTimePicker date;
    }
}