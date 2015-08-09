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
        public delegate void EditCompleteDelegate(String customerId, string customerName);

        public EditCompleteDelegate EditCompletedHandler;

        protected Customer objCustomer = new Customer();
        protected CustomerBLT customerBLT = new CustomerBLT();
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
                this.objCustomer.Phonenumber = this.phoneCustomerEdit.Text;
                this.objCustomer.Address = this.addressCustomerEdit.Text;
                this.objCustomer.Commit = this.subCheck.Checked;
                string cusId;
                if (this.customerBLT.addCustomer(objCustomer, out cusId))
                {
                    MessageBox.Show("Insert Success");
                    EditCompletedHandler(cusId, nameCustomerEdit.Text);
                    this.Close();
                }
                else
                {
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
