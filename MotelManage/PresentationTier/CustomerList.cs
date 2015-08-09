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
    public partial class CustomerList : Form
    {
        protected CustomerBLT customerBLT = new CustomerBLT();
        protected String mKH = string.Empty;
        protected DataTable dt;
        protected Customer c = new Customer();
        public CustomerList()
        {
            InitializeComponent();
            reset();
         
        }

        private void CustomerList_Load(object sender, EventArgs e)
        {
           dt = customerBLT.getListCustomer();
            dataCustomerList.DataSource = dt;
            int size = dt.Rows.Count;
            if (size > 0)
            {

                mKH = dataCustomerList.Rows[0].Cells[0].Value.ToString();
                c.Id = dataCustomerList.Rows[0].Cells[0].Value.ToString();
                c.Name = dataCustomerList.Rows[0].Cells[1].Value.ToString();
                c.Cmnd = dataCustomerList.Rows[0].Cells[2].Value.ToString();
                c.Phonenumber = dataCustomerList.Rows[0].Cells[3].Value.ToString();
                c.Address = dataCustomerList.Rows[0].Cells[4].Value.ToString();
                c.Commit = bool.Parse(dataCustomerList.Rows[0].Cells[5].Value.ToString());
            }
   
            this.dataCustomerList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
         
        }

       

        private void dataCustomerList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Index = e.RowIndex;
            if (Index > -1)
            {
               // int Row = dataCustomerList.Rows.Count;

                string textId = dataCustomerList.Rows[Index].Cells[0].Value.ToString();
                string textName = dataCustomerList.Rows[Index].Cells[1].Value.ToString();
               
                    this.idCustomer.Text = textId;
                    this.nameCustomer.Text = textName;
                    this.phone.Text = dataCustomerList.Rows[Index].Cells[3].Value.ToString();
                    this.address.Text = dataCustomerList.Rows[Index].Cells[4].Value.ToString(); 
                    c.Id = dataCustomerList.Rows[Index].Cells[0].Value.ToString();
                    c.Name = dataCustomerList.Rows[Index].Cells[1].Value.ToString();
                    c.Cmnd = dataCustomerList.Rows[Index].Cells[2].Value.ToString();
                    c.Phonenumber = dataCustomerList.Rows[Index].Cells[3].Value.ToString();
                    c.Address = dataCustomerList.Rows[Index].Cells[4].Value.ToString();
                    c.Commit = bool.Parse(dataCustomerList.Rows[Index].Cells[5].Value.ToString());
                    mKH = textId;

                
            }

           
        }

        

        private void editCustomer_Click(object sender, EventArgs e)
        {
            if (mKH == string.Empty)
            {
                MessageBox.Show(" You do not choice any Customer To Edit");
                
            }
            else
            {
               
                reset();
                CustomerEdit cusEdit = new CustomerEdit(c);
                cusEdit.Show();
                this.Visible = false;
            }

        }

        private void search_cusClicked(object sender, EventArgs e)
        {
            if (this.idCustomer.Text != "")
            {
                dt = customerBLT.getListCustomerById(this.idCustomer.Text.ToString());
            }
            else if ((this.nameCustomer.Text == ""))
            {
                dt = customerBLT.getListCustomerById(this.nameCustomer.Text.ToString());
            }
            else if ((this.phone.Text != "") )
            {
                dt = customerBLT.getListCustomerById(this.phone.Text.ToString());
            }
            else if ((this.address.Text != ""))
            {
                dt = customerBLT.getListCustomerById(this.address.Text.ToString());
            }
            else {
                dt = customerBLT.getListCustomer();
            }
            
            this.dataCustomerList.DataSource = dt;
        }

        private void del_customer(object sender, EventArgs e)
        {
            if (mKH == string.Empty)
            {
                MessageBox.Show("You do not choice customer");
            }
            else
            {
                bool flag = customerBLT.deleteCustomer(mKH);
                if (flag == true)
                {
                    dt = customerBLT.getListCustomer();
                    this.dataCustomerList.DataSource = dt;
                    MessageBox.Show("Delete Customer Success");
                    reset();
                }
                else
                {
                    MessageBox.Show("Delete Customer Fail");
                }
            }
        }
        public void reset()
        {
            this.idCustomer.Text = "";
            this.nameCustomer.Text = "";
            this.address.Text = "";
            this.phone.Text = "";
        }

        private void add_cus(object sender, EventArgs e)
        {
            reset();
            CustomerAdd csAdd = new CustomerAdd();
            csAdd.Show();
            this.Visible = false;
        }

        private void resetCustomerList(object sender, EventArgs e)
        {
            reset();
        }
        
    }
}
