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
    public partial class SpendBillAdd : Form
    {

        protected BillSpend objBillSpend = new BillSpend();
        protected BillSpendBLT billBLTEdit = new BillSpendBLT();
        public SpendBillAdd()
        {
            InitializeComponent();
        }

        private void save_SpendBillAdd(object sender, EventArgs e)
        {

            decimal d = 0;
            // (decimal.TryParse(total.Text, out d))
            if ( this.reason.Text == "" ||!(decimal.TryParse(total.Text, out d))|| this.receiver.Text == "")
            {
                MessageBox.Show("You must edit all filed required");
            }
            else
            {
                this.objBillSpend.Dateestablish = this.date.Value;
                this.objBillSpend.Expenses = this.reason.Text;
                this.objBillSpend.Total = d;
                this.objBillSpend.Note = this.note.Text;
                this.objBillSpend.Receiver = this.receiver.Text;
                bool flagUpdate = this.billBLTEdit.addBillSpend(objBillSpend);
                if (flagUpdate == true)
                {
                    MessageBox.Show("Insert Success");
                }
                else
                {
                    MessageBox.Show("Insert Fail Try Again !");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SpendBillList spendList = new SpendBillList();
            spendList.Show();
            this.Hide();

        }

      
    }
}
