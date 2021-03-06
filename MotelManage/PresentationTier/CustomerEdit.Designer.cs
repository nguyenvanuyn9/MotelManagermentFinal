﻿namespace MotelManage.PresentationTier
{
    partial class CustomerEdit
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
            this.saveCustomerEdit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.idCustomerEdit = new System.Windows.Forms.TextBox();
            this.nameCustomerEdit = new System.Windows.Forms.TextBox();
            this.cmndCustomerEdit = new System.Windows.Forms.TextBox();
            this.phoneCustomerEdit = new System.Windows.Forms.TextBox();
            this.addressCustomerEdit = new System.Windows.Forms.TextBox();
            this.resetCustomerEdit = new System.Windows.Forms.Button();
            this.submitCus = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // saveCustomerEdit
            // 
            this.saveCustomerEdit.Location = new System.Drawing.Point(333, 209);
            this.saveCustomerEdit.Margin = new System.Windows.Forms.Padding(2);
            this.saveCustomerEdit.Name = "saveCustomerEdit";
            this.saveCustomerEdit.Size = new System.Drawing.Size(76, 27);
            this.saveCustomerEdit.TabIndex = 3;
            this.saveCustomerEdit.Text = "Save Edit";
            this.saveCustomerEdit.UseVisualStyleBackColor = true;
            this.saveCustomerEdit.Click += new System.EventHandler(this.edit_cus);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 84);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "CMND";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 147);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Adress";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 117);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Phone number";
            // 
            // idCustomerEdit
            // 
            this.idCustomerEdit.Location = new System.Drawing.Point(122, 20);
            this.idCustomerEdit.Margin = new System.Windows.Forms.Padding(2);
            this.idCustomerEdit.Name = "idCustomerEdit";
            this.idCustomerEdit.Size = new System.Drawing.Size(148, 20);
            this.idCustomerEdit.TabIndex = 9;
            // 
            // nameCustomerEdit
            // 
            this.nameCustomerEdit.Location = new System.Drawing.Point(122, 52);
            this.nameCustomerEdit.Margin = new System.Windows.Forms.Padding(2);
            this.nameCustomerEdit.Name = "nameCustomerEdit";
            this.nameCustomerEdit.Size = new System.Drawing.Size(198, 20);
            this.nameCustomerEdit.TabIndex = 10;
            // 
            // cmndCustomerEdit
            // 
            this.cmndCustomerEdit.Location = new System.Drawing.Point(122, 84);
            this.cmndCustomerEdit.Margin = new System.Windows.Forms.Padding(2);
            this.cmndCustomerEdit.Name = "cmndCustomerEdit";
            this.cmndCustomerEdit.Size = new System.Drawing.Size(148, 20);
            this.cmndCustomerEdit.TabIndex = 11;
            // 
            // phoneCustomerEdit
            // 
            this.phoneCustomerEdit.Location = new System.Drawing.Point(122, 116);
            this.phoneCustomerEdit.Margin = new System.Windows.Forms.Padding(2);
            this.phoneCustomerEdit.Name = "phoneCustomerEdit";
            this.phoneCustomerEdit.Size = new System.Drawing.Size(157, 20);
            this.phoneCustomerEdit.TabIndex = 12;
            // 
            // addressCustomerEdit
            // 
            this.addressCustomerEdit.Location = new System.Drawing.Point(122, 147);
            this.addressCustomerEdit.Margin = new System.Windows.Forms.Padding(2);
            this.addressCustomerEdit.Name = "addressCustomerEdit";
            this.addressCustomerEdit.Size = new System.Drawing.Size(301, 20);
            this.addressCustomerEdit.TabIndex = 13;
            // 
            // resetCustomerEdit
            // 
            this.resetCustomerEdit.Location = new System.Drawing.Point(217, 211);
            this.resetCustomerEdit.Name = "resetCustomerEdit";
            this.resetCustomerEdit.Size = new System.Drawing.Size(75, 25);
            this.resetCustomerEdit.TabIndex = 14;
            this.resetCustomerEdit.Text = "Cancel";
            this.resetCustomerEdit.UseVisualStyleBackColor = true;
            this.resetCustomerEdit.Click += new System.EventHandler(this.cancel_EditCus);
            // 
            // submitCus
            // 
            this.submitCus.AutoSize = true;
            this.submitCus.Location = new System.Drawing.Point(122, 186);
            this.submitCus.Name = "submitCus";
            this.submitCus.Size = new System.Drawing.Size(15, 14);
            this.submitCus.TabIndex = 15;
            this.submitCus.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Submit";
            // 
            // CustomerEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 271);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.submitCus);
            this.Controls.Add(this.resetCustomerEdit);
            this.Controls.Add(this.addressCustomerEdit);
            this.Controls.Add(this.phoneCustomerEdit);
            this.Controls.Add(this.cmndCustomerEdit);
            this.Controls.Add(this.nameCustomerEdit);
            this.Controls.Add(this.idCustomerEdit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveCustomerEdit);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CustomerEdit";
            this.Text = "CustomerEdit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveCustomerEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox idCustomerEdit;
        private System.Windows.Forms.TextBox nameCustomerEdit;
        private System.Windows.Forms.TextBox cmndCustomerEdit;
        private System.Windows.Forms.TextBox phoneCustomerEdit;
        private System.Windows.Forms.TextBox addressCustomerEdit;
        private System.Windows.Forms.Button resetCustomerEdit;
        private System.Windows.Forms.CheckBox submitCus;
        private System.Windows.Forms.Label label6;
    }
}