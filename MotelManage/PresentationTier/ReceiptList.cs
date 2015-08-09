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
    public partial class ReceiptList : Form
    {
        protected ReceiptsBLT receiptBLT = new ReceiptsBLT();
        protected DataTable dt;
        protected Receipts r = new Receipts();
        public ReceiptList()
        {
            InitializeComponent();
            reset();
        }
        public void reset()
        {
            this.reason.Text = string.Empty;
            this.receiptID.Text = string.Empty;
            this.contractID.Text = string.Empty;
            this.curtomerName.Text = string.Empty;
            this.billID.Text = string.Empty;
        }

        private void ReceiptList_Loaded(object sender, EventArgs e)
        {
            dt = receiptBLT.getListReceipts();
            this.dataReceiptList.DataSource = dt;
            int size = dt.Rows.Count;
            if (size > 0)
            {

                int rowindex = dataReceiptList.CurrentRow.Index;
                if (rowindex > -1)
                {
                    r.Id = dataReceiptList.Rows[rowindex].Cells[0].Value.ToString();
                    r.Dateestablish = dataReceiptList.Rows[rowindex].Cells[1].Value.ToString();
                    r.Reason = dataReceiptList.Rows[rowindex].Cells[2].Value.ToString();
                    r.Total = Decimal.Parse(dataReceiptList.Rows[rowindex].Cells[3].Value.ToString());
                    r.Contractid = dataReceiptList.Rows[rowindex].Cells[4].Value.ToString();
                    r.Billid = dataReceiptList.Rows[rowindex].Cells[5].Value.ToString();
                    r.Customername = dataReceiptList.Rows[rowindex].Cells[6].Value.ToString();
                    r.Contents = dataReceiptList.Rows[rowindex].Cells[7].Value.ToString();
                }
            }
        }

        private void receiptCell_Click(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
           
            if(index > -1)
            { 
                this.reason.Text = dataReceiptList.Rows[index].Cells[2].Value.ToString();
                this.receiptID.Text = dataReceiptList.Rows[index].Cells[0].Value.ToString();
                this.contractID.Text = dataReceiptList.Rows[index].Cells[4].Value.ToString();
                this.curtomerName.Text = dataReceiptList.Rows[index].Cells[7].Value.ToString();
                this.billID.Text = dataReceiptList.Rows[index].Cells[5].Value.ToString();
                this.dateValue.Value = DateTime.Parse(dataReceiptList.Rows[index].Cells[1].Value.ToString());
                r.Id = dataReceiptList.Rows[index].Cells[0].Value.ToString();
                r.Dateestablish = dataReceiptList.Rows[index].Cells[1].Value.ToString();
                r.Reason = dataReceiptList.Rows[index].Cells[2].Value.ToString();
                r.Total = Decimal.Parse(dataReceiptList.Rows[index].Cells[3].Value.ToString());
                r.Contractid = dataReceiptList.Rows[index].Cells[4].Value.ToString();
                r.Billid = dataReceiptList.Rows[index].Cells[5].Value.ToString();
                r.Customername = dataReceiptList.Rows[index].Cells[6].Value.ToString();
                r.Contents = dataReceiptList.Rows[index].Cells[7].Value.ToString();
            }
        }

        private void searchReceipt_Click(object sender, EventArgs e)
        {
            if (this.contractID.Text != string.Empty)
            {
                dt = receiptBLT.searchListReceipts(this.contractID.Text.ToString());
            }
            else if (this.billID.Text != string.Empty)
            {
                dt = receiptBLT.searchListReceipts(this.billID.Text.ToString());
            }
            else if ( this.curtomerName.Text != string.Empty)
            {
                dt = receiptBLT.searchListReceipts(this.curtomerName.Text.ToString());
            }
            else if (this.receiptID.Text != string.Empty)
            {
                dt = receiptBLT.searchListReceipts(this.receiptID.Text.ToString());
            }
            else 
            {
                dt = receiptBLT.getListReceipts();
            }

            this.dataReceiptList.DataSource = dt;
        }

        private void del_Receipts(object sender, EventArgs e)
        {
            int index = dataReceiptList.CurrentRow.Index;
            string id = dataReceiptList.Rows[index].Cells[0].Value.ToString();
            bool flag = receiptBLT.deleteReceipts(id);
            if (flag == true)
            {
                dt = receiptBLT.getListReceipts();
                this.dataReceiptList.DataSource = dt;
                MessageBox.Show("Delete Receipt Success");
            }
            else
            {
                MessageBox.Show("Delete Receipt Fail");
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            ReceiptAdd receiptAdd = new ReceiptAdd();
            reset();
            receiptAdd.Show();
            this.Visible = false;
        }

        private void editReceipt_Click(object sender, EventArgs e)
        {
            ReceiptEdit receiptEdit = new ReceiptEdit(r);
            receiptEdit.Show();
            this.Hide();
            reset();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            reset();
        }
    }
}
