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

    public partial class DebtList : Form
    {
        protected DebtBLT debtList = new DebtBLT();
        protected DataTable dt;
        protected Debt d = new Debt();
        protected ContractBLT contractBLT = new ContractBLT();
        public DebtList()
        {
            InitializeComponent();
            reset();
        }

        private void DebtList_Loaded(object sender, EventArgs e)
        {
            dt = debtList.getListDebt();
            dataDebtList.DataSource = dt;
            int size = dt.Rows.Count;
            if (size > 0)
            {

                int rowindex = dataDebtList.CurrentRow.Index;
            if ( rowindex > -1)
            {
                d.Id = dataDebtList.Rows[rowindex].Cells[0].Value.ToString();
                d.Contractid = dataDebtList.Rows[rowindex].Cells[1].Value.ToString();
                d.DateSet = dataDebtList.Rows[rowindex].Cells[2].Value.ToString();
                d.DebtUntildate = Decimal.Parse(dataDebtList.Rows[rowindex].Cells[3].Value.ToString());
                d.Note = dataDebtList.Rows[rowindex].Cells[4].Value.ToString();
            }
            }
        }
        public void reset()
        {
            this.idDebtList.Text = string.Empty;
            this.ctrID.Text = string.Empty;
        }

        private void dataDebt_Click(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
           if (index > -1)
           { 
                string id = dataDebtList.Rows[index].Cells[0].Value.ToString();
                string contractId = dataDebtList.Rows[index].Cells[1].Value.ToString();
                this.idDebtList.Text = id;
                this.ctrID.Text = contractId;
                d.Id = dataDebtList.Rows[index].Cells[0].Value.ToString();
                d.Contractid = dataDebtList.Rows[index].Cells[1].Value.ToString();
                d.DateSet = dataDebtList.Rows[index].Cells[2].Value.ToString();
                d.DebtUntildate = Decimal.Parse(dataDebtList.Rows[index].Cells[3].Value.ToString());
                d.Note = dataDebtList.Rows[index].Cells[4].Value.ToString();
           } 
        }

        private void searchDebtList_Click(object sender, EventArgs e)
        {
            if (this.idDebtList.Text != string.Empty)
            {
                dt = debtList.searchListDebt(this.idDebtList.Text.ToString());
            }
            else if (this.ctrID.Text != string.Empty)
            {
                dt = debtList.searchListDebt(this.ctrID.Text.ToString());
            }
            else {
                dt = debtList.getListDebt();
            }
            this.dataDebtList.DataSource = dt;
        }

        private void del_Debt(object sender, EventArgs e)
        {

            int index = dataDebtList.CurrentRow.Index;
            string id = dataDebtList.Rows[index].Cells[0].Value.ToString();
             string contractid = dataDebtList.Rows[index].Cells[1].Value.ToString();
            //kiem tra tinh trang hop dong 
            //neu hop dong con dang su dung khong duoc xoa
             bool validContract = contractBLT.isValid(contractid);
             if (validContract == true)
             {
                 MessageBox.Show("You can't delete Debt When Contract is Valid");
             }
             else
             {
                 bool flag = debtList.deleteDebt(id);
                 if (flag == true)
                 {
                     dt = debtList.getListDebt();
                     dataDebtList.DataSource = dt;
                     MessageBox.Show("Delete Debt Success");
                     reset();
                 }
                 else
                 {
                     MessageBox.Show("Delete Debt Fail");
                 }
             }
        }

        private void editDebt_click(object sender, EventArgs e)
        {
            Debt temp = new Debt();
            temp = d;
            DebtEdit debtEdit = new DebtEdit(temp);
            reset();
            debtEdit.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reset();
        }
    }
}
