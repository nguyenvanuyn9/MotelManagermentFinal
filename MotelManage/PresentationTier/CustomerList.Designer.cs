namespace MotelManage.PresentationTier
{
    partial class CustomerList
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
            this.dataCustomerList = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.idCustomer = new System.Windows.Forms.TextBox();
            this.nameCustomer = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.TextBox();
            this.aaa = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataCustomerList)).BeginInit();
            this.SuspendLayout();
            // 
            // dataCustomerList
            // 
            this.dataCustomerList.AccessibleRole = System.Windows.Forms.AccessibleRole.Link;
            this.dataCustomerList.AllowUserToAddRows = false;
            this.dataCustomerList.AllowUserToDeleteRows = false;
            this.dataCustomerList.AllowUserToResizeColumns = false;
            this.dataCustomerList.AllowUserToResizeRows = false;
            this.dataCustomerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCustomerList.Location = new System.Drawing.Point(9, 154);
            this.dataCustomerList.Margin = new System.Windows.Forms.Padding(2);
            this.dataCustomerList.Name = "dataCustomerList";
            this.dataCustomerList.ReadOnly = true;
            this.dataCustomerList.RowTemplate.Height = 24;
            this.dataCustomerList.Size = new System.Drawing.Size(830, 320);
            this.dataCustomerList.TabIndex = 0;
            this.dataCustomerList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataCustomerList_CellClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(616, 107);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 27);
            this.button1.TabIndex = 1;
            this.button1.Text = "Edit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.editCustomer_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(440, 107);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(76, 27);
            this.button2.TabIndex = 2;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.add_cus);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(764, 107);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(76, 27);
            this.button3.TabIndex = 3;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.del_customer);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name";
            // 
            // idCustomer
            // 
            this.idCustomer.Location = new System.Drawing.Point(197, 11);
            this.idCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.idCustomer.Name = "idCustomer";
            this.idCustomer.Size = new System.Drawing.Size(170, 20);
            this.idCustomer.TabIndex = 7;
            // 
            // nameCustomer
            // 
            this.nameCustomer.Location = new System.Drawing.Point(197, 41);
            this.nameCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.nameCustomer.Name = "nameCustomer";
            this.nameCustomer.Size = new System.Drawing.Size(170, 20);
            this.nameCustomer.TabIndex = 8;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(261, 107);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(76, 27);
            this.button4.TabIndex = 10;
            this.button4.Text = "Search";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.search_cusClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(452, 14);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Phone";
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(596, 11);
            this.phone.Margin = new System.Windows.Forms.Padding(2);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(170, 20);
            this.phone.TabIndex = 8;
            // 
            // aaa
            // 
            this.aaa.AutoSize = true;
            this.aaa.Location = new System.Drawing.Point(452, 47);
            this.aaa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.aaa.Name = "aaa";
            this.aaa.Size = new System.Drawing.Size(45, 13);
            this.aaa.TabIndex = 5;
            this.aaa.Text = "Address";
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(596, 44);
            this.address.Margin = new System.Windows.Forms.Padding(2);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(170, 20);
            this.address.TabIndex = 8;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(99, 107);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 11;
            this.button5.Text = "Reset";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.resetCustomerList);
            // 
            // CustomerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 484);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.address);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.aaa);
            this.Controls.Add(this.nameCustomer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.idCustomer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataCustomerList);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CustomerList";
            this.Text = "CustomerList";
            this.Load += new System.EventHandler(this.CustomerList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataCustomerList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataCustomerList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox idCustomer;
        private System.Windows.Forms.TextBox nameCustomer;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.Label aaa;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.Button button5;
    }
}