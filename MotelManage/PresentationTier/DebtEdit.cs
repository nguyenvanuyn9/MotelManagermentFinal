using MotelManage.BusinessLogicTier;
using MotelManage.DataTransferObject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MotelManage.PresentationTier
{
    public partial class DebtEdit : Form
    {
        protected DebtBLT debtBLT = new DebtBLT();
        protected Debt objectDebt = new Debt();
       
        public DebtEdit()
        {
            InitializeComponent();
        }
        public DebtEdit(Debt c)
        {
            InitializeComponent();
            this.objectDebt = c;
           // date.Format = DateTimePickerFormat.Custom;
           // this.date.CustomFormat = "MM-dd-yyyy";
            if (this.objectDebt != null)
            {
               
                this.idDebt.Text = c.Id.ToString();
                this.ctrID.Text = c.Contractid;
                this.debt.Text = c.DebtUnitldate.ToString();
                this.date.Value = c.DateSet;
                this.note.Text = c.Node;
            }
        }

        private void saveedit_Debt(object sender, EventArgs e)
        {

            decimal d = 0;
            if (this.date.Value == null || this.debt.Text == "" || (decimal.TryParse(debt.Text, out d)))
            {
                MessageBox.Show("You must edit all filed required");
            }
            else 
            {
                 this.objectDebt.DateSet = this.date.Value;
                this.objectDebt.Node = this.note.Text;
                this.objectDebt.DebtUnitldate = decimal.Parse(this.debt.Text.ToString());
                
                bool flagUpdate = this.debtBLT.updateDebt(objectDebt);
                if (flagUpdate == true)
                {
                    MessageBox.Show("Update Success");
                }
                else
                {
                    MessageBox.Show("Update Fail Try Again !");
                }


            }
        }

    
    }
}
