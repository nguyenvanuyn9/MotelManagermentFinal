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
    public partial class ReceiptAdd : Form
    {
        protected ReceiptsBLT receiptBLT = new ReceiptsBLT();
        protected ContractBLT contractBLT = new ContractBLT();
        protected TollBillsBLT tollBillsBLT = new TollBillsBLT();
        protected Receipts r = new Receipts();
        public ReceiptAdd()
        {
            InitializeComponent();
        }

        private void ReceiptAdd_Loaded(object sender, EventArgs e)
        {
            DataSet dtContract = contractBLT.getComboContractData();
            this.contractCombo.DataSource = dtContract.Tables[0];
            contractCombo.ValueMember = "id";
            contractCombo.DisplayMember = "id";
           contractCombo.Text = "---Select -----";
        }

        private void contractList_Click(object sender, EventArgs e)
        {
            string value = contractCombo.SelectedValue.ToString();
          
            MessageBox.Show("Value" + value);
        }

        private void contract_Change(object sender, EventArgs e)
        {
            string value = contractCombo.SelectedValue.ToString();
            if (!value.Contains("No Choice"))
            {
                DataSet dtBill = tollBillsBLT.getComboTollBillData(value);
                this.billCombo.DataSource = dtBill.Tables[0];
                billCombo.ValueMember = "id";
                billCombo.DisplayMember = "id";
                billCombo.Text = "---Select -----";
            }
           // MessageBox.Show("Value" + value);
        }

      


   

        private void save(object sender, EventArgs e)
        {
           
             string valueContract = contractCombo.SelectedValue.ToString();
            decimal d = 0;
            if ((!valueContract.Contains("No Choice")) && (this.customerName.Text != "") && (decimal.TryParse(total.Text, out d)))
            {
                r.Dateestablish = this.dateReceipt.Value;
                r.Reason = this.reason.Text;
                r.Customername = this.customerName.Text;
                r.Billid = "" ;
                r.Contractid = valueContract;
                r.Contents = this.note.Text.ToString();     
                r.Total = d;
                Boolean flagInsert = receiptBLT.addReceipts(r);
                if (flagInsert == true)
                {
                    MessageBox.Show("Insert Success");
                }
                else {
                    MessageBox.Show("Insert Failed");
                  
                }
            }
            else 
            {
                //invalid
                MessageBox.Show("Please enter a valid Value");
            }
        }

        private void billID_Change(object sender, EventArgs e)
        {

            string value =this.billCombo.SelectedValue.ToString();
            if (!value.Contains("No Choice"))
            {
                decimal total = tollBillsBLT.getTotalByTollBillId(value);
                this.total.Text = total.ToString();
            }
            else
            {
                this.total.Text = string.Empty;
            }
            

        }

        private void cancel_ReceiptAdd(object sender, EventArgs e)
        {
            ReceiptList receiptList = new ReceiptList();
            receiptList.Show();
            this.Visible = false;
        }

       

    }
}
