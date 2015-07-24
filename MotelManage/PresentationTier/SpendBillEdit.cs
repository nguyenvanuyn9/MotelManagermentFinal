using Microsoft.Reporting.WinForms;
using MotelManage.BusinessLogicTier;
using MotelManage.DataTransferObject;
using MotelManage.Reports;
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
    public partial class SpendBillEdit : Form
    {

        protected BillSpend objBillSpend = new BillSpend();
        protected BillSpendBLT billBLTEdit = new BillSpendBLT();
        public SpendBillEdit()
        {
            InitializeComponent();
        }

        public SpendBillEdit(BillSpend c)
        {
            InitializeComponent();
            this.objBillSpend = c;
           // date.Format = DateTimePickerFormat.Custom;
           // this.date.CustomFormat = "MM-dd-yyyy";
            if (this.objBillSpend != null)
            {
                this.id.Text = c.Id;
                this.reason.Text = c.Expenses;
                this.receiver.Text = c.Receiver;
                this.note.Text = c.Note;
                this.reason.Text = c.Expenses;
                this.date.Value = c.Dateestablish;
               
            }
        }

        private void saveEditSpend_Click(object sender, EventArgs e)
        {
            if (this.reason.Text == "" )
            {
                MessageBox.Show("You must edit all filed required");
            }
            else
            {

                this.objBillSpend.Expenses = this.reason.Text;
                this.objBillSpend.Receiver = this.receiver.Text;
                this.objBillSpend.Note = this.note.Text;
                bool flagUpdate = this.billBLTEdit.updateBillSpend(objBillSpend);
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

        private void cancelSpend_Click(object sender, EventArgs e)
        {
            SpendBillList spendList = new SpendBillList();
            spendList.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ReportDataSource source = new ReportDataSource();
            ReportViewer reportViewer = new ReportViewer();

            source.Name = "DataSet1";
            source.Value = null;


  
            //   reportViewer.Reset();
            // reportViewer.LocalReport.DataSources.Clear();
            reportViewer.LocalReport.ReportPath = "../../Reports/ReportSpend.rdlc";
            ReportParameter rp = new ReportParameter();
             rp.Name = "id";
            rp.Values.Add(objBillSpend.Id);
            ReportParameter rp1 = new ReportParameter("dateestablish",objBillSpend.Dateestablish.ToShortDateString(), true);
            ReportParameter rp2 = new ReportParameter("expenseds", this.objBillSpend.Expenses, true);
            ReportParameter rp3 = new ReportParameter("total", this.objBillSpend.Total.ToString(), true);
            ReportParameter rp4 = new ReportParameter("note", this.objBillSpend.Note, true);
            ReportParameter rp5 = new ReportParameter("receiver", this.objBillSpend.Receiver, true);
            ReportParameter[] parameter = new ReportParameter[] { rp, rp2, rp1, rp3, rp4, rp5 };

           // reportViewer.LocalReport.SetParameters(parameter);
            // reportViewer.LocalReport.DataSources.Add(source);
            ReportSpend form = new ReportSpend(parameter);
            form.Show();
            
        }
       

      

      
    }
}
