using MotelManage.BusinessLogicTier;
using MotelManage.DataTransferObject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MotelManage.PresentationTier
{
    public partial class CustomerAdd : Form
    {
        protected Customer objCustomer = new Customer();
        protected CustomerBLT customerBLTEdit = new CustomerBLT();
        public CustomerAdd()
        {
            InitializeComponent();
        }
     

        private void edit_cus(object sender, EventArgs e)
        {
            if (this.addressCustomerEdit.Text == ""  || this.nameCustomerEdit.Text == "" || this.cmndCustomerEdit.Text == "" || this.phoneCustomerEdit.Text == "")
            {
                MessageBox.Show("You must edit all filed required");
            }
            else 
            {
                this.objCustomer.Name = this.nameCustomerEdit.Text;
                this.objCustomer.Cmnd = this.cmndCustomerEdit.Text;
                this.objCustomer.Phonenumber = int.Parse(this.phoneCustomerEdit.Text.ToString());
                this.objCustomer.Adress = this.addressCustomerEdit.Text;
                this.objCustomer.Commit = this.subCheck.Checked;
                bool flagUpdate = this.customerBLTEdit.addCustomer(objCustomer);
                if (flagUpdate == true)
                {
                    MessageBox.Show("Insert Success");
                }
                else {
                    MessageBox.Show("Insert Fail Try Again !");
                }
            }
        }
        public void reset()
        { 
            
        
        }

        private void cancel_EditCus(object sender, EventArgs e)
        {
            CustomerList cus = new CustomerList();
            cus.Show();
            this.Visible = false;
        }
    }
}
