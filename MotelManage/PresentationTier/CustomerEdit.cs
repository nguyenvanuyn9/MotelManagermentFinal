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
    public partial class CustomerEdit : Form
    {
        public delegate void EditCompleteDelegate(string customerId, string customerName);

        public EditCompleteDelegate EditCompletedHandler;

        protected Customer objCustomer = new Customer();
        protected CustomerBLT customerBLTEdit = new CustomerBLT();
        public CustomerEdit()
        {
            InitializeComponent();
        }
        public CustomerEdit(Customer c)
        {

            InitializeComponent();
            this.objCustomer = c;
            if (objCustomer != null)
            {
                this.idCustomerEdit.Text = c.Id;
                this.idCustomerEdit.ReadOnly = true;
                this.nameCustomerEdit.Text = c.Name;
                this.cmndCustomerEdit.Text = c.Cmnd;
                this.phoneCustomerEdit.Text = c.Phonenumber.ToString();
                this.addressCustomerEdit.Text = c.Address;
                this.submitCus.Checked = c.Commit;
            }
        }

        private void edit_cus(object sender, EventArgs e)
        {
            if (this.addressCustomerEdit.Text == "" || this.idCustomerEdit.Text == "" || this.nameCustomerEdit.Text == "" || this.cmndCustomerEdit.Text == "" || this.phoneCustomerEdit.Text == "")
            {
                MessageBox.Show("You must edit all filed required");
            }
            else 
            {
                this.objCustomer.Name = this.nameCustomerEdit.Text;
                this.objCustomer.Cmnd = this.cmndCustomerEdit.Text;
                this.objCustomer.Phonenumber = this.phoneCustomerEdit.Text;
                this.objCustomer.Address = this.addressCustomerEdit.Text;
                this.objCustomer.Commit = this.submitCus.Checked;
                bool flagUpdate = this.customerBLTEdit.updateCustomer(objCustomer);
                if (flagUpdate == true)
                {
                    MessageBox.Show("Update Success");
                    EditCompletedHandler(idCustomerEdit.Text, nameCustomerEdit.Text);
                    this.Close();
                }
                else {
                    MessageBox.Show("Update Fail Try Again !");
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
