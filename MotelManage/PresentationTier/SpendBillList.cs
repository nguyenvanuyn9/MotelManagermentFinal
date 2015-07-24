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
    public partial class SpendBillList : Form
    {
        protected BillSpendBLT billList = new BillSpendBLT();
        protected DataTable dt;
        protected BillSpend d = new BillSpend();
        public SpendBillList()
        {
            InitializeComponent();
            reset();
        }
        public void reset()
        {
            this.receiver.Text = string.Empty;
            this.reason.Text = string.Empty;
            this.id.Text = string.Empty;  
        }

    
        private void dataCellSpend_Click(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            if (rowindex > -1)
            {
                this.id.Text = dataSpend.Rows[rowindex].Cells[0].Value.ToString();
                this.reason.Text = dataSpend.Rows[rowindex].Cells[2].Value.ToString();
                this.date.Value = DateTime.Parse(dataSpend.Rows[rowindex].Cells[1].Value.ToString());
                this.receiver.Text = dataSpend.Rows[rowindex].Cells[3].Value.ToString();
                d.Id = dataSpend.Rows[rowindex].Cells[0].Value.ToString();
                d.Dateestablish = DateTime.Parse(dataSpend.Rows[rowindex].Cells[1].Value.ToString());
                d.Expenses = dataSpend.Rows[rowindex].Cells[2].Value.ToString();
                d.Receiver = dataSpend.Rows[rowindex].Cells[3].Value.ToString();
                d.Total = Decimal.Parse(dataSpend.Rows[rowindex].Cells[4].Value.ToString());
                d.Note = dataSpend.Rows[rowindex].Cells[5].Value.ToString();
            }
        }

        private void searchSpend_Click(object sender, EventArgs e)
        {
            if (this.id.Text != string.Empty)
            {
                dt = billList.searchListBillSpend(this.id.Text.ToString());
            }
            else if (this.receiver.Text != string.Empty)
            {
                dt = billList.searchListBillSpend(this.receiver.Text.ToString());
            }
            else
            {
                dt = billList.getListBillSpend();
            }
            this.dataSpend.DataSource = dt;
        }

        private void delSpend_Click(object sender, EventArgs e)
        {
            int index = dataSpend.CurrentRow.Index;
            string id = dataSpend.Rows[index].Cells[0].Value.ToString();
            bool flag = billList.deleteBillSpend(id);
            if (flag == true)
            {
                dt = billList.getListBillSpend();
                this.dataSpend.DataSource = dt;
                MessageBox.Show("Delete SpendBill Success");
                reset();
            }
            else
            {
                MessageBox.Show("Delete SpendBill Fail");
            }
        }

        private void addSpend_Click(object sender, EventArgs e)
        {

            SpendBillAdd billAdd = new SpendBillAdd();
            this.Hide();
            reset();
            billAdd.Show();
        }

        private void SpendBillListLoad(object sender, EventArgs e)
        {

            dt = billList.getListBillSpend();
            dataSpend.DataSource = dt;
            int size = dt.Rows.Count;
            if (size > 0)
            {

                int rowindex = dataSpend.CurrentRow.Index;
                if (rowindex > -1)
                {
                    //id AS [Bill ID] , dateestablish AS [Date], expenses AS [Reason] ,receiver AS [Receiver] , total AS [Total] , note AS [Note]
                    d.Id = dataSpend.Rows[rowindex].Cells[0].Value.ToString();
                    d.Dateestablish = DateTime.Parse(dataSpend.Rows[rowindex].Cells[1].Value.ToString());
                    d.Expenses = dataSpend.Rows[rowindex].Cells[2].Value.ToString();
                    d.Receiver = dataSpend.Rows[rowindex].Cells[3].Value.ToString();
                    d.Total = Decimal.Parse(dataSpend.Rows[rowindex].Cells[4].Value.ToString());
                    d.Note = dataSpend.Rows[rowindex].Cells[5].Value.ToString();
                }
            }
        }

        private void editSpend_Click(object sender, EventArgs e)
        {

            SpendBillEdit spendEdit = new SpendBillEdit(d);
           
            reset();
            this.Hide();
            spendEdit.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            reset();
        }
    }
}
