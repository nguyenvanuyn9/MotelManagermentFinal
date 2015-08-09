using Microsoft.Reporting.WinForms;
using MotelManage.BusinessLogicTier;
using MotelManage.DataTransferObject;
using MotelManage.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MotelManage.PresentationTier
{
    public partial class ReceiptEdit : Form
    {
        protected ReceiptsBLT receiptBLT = new ReceiptsBLT();
        protected DataTable dt;
        protected Receipts objectReceipt = new Receipts();
        public ReceiptEdit()
        {
            InitializeComponent();
        }
        public ReceiptEdit(Receipts c)
        {
            InitializeComponent();
            this.objectReceipt = c;
           // date.Format = DateTimePickerFormat.Custom;
           // this.date.CustomFormat = "MM-dd-yyyy";
            if (this.objectReceipt != null)
            {

                this.id.Text = this.objectReceipt.Id;
                this.reason.Text = this.objectReceipt.Reason;
                this.contractId.Text = this.objectReceipt.Contractid;
                this.customer.Text = this.objectReceipt.Customername;
                this.date.Text = this.objectReceipt.Dateestablish;
                this.note.Text = this.objectReceipt.Contents;
                this.total.Text = this.objectReceipt.Total.ToString();
                this.billID.Text = this.objectReceipt.Billid.ToString();
            }
        }

        private void saveReceiptEdit(object sender, EventArgs e)
        {
           
            if ( this.customer.Text == ""  || (this.reason.Text == ""))
            {
                MessageBox.Show("You must edit all filed required");
            }
            else
            {
                
                this.objectReceipt.Customername = this.customer.Text;
                this.objectReceipt.Contents = this.note.Text;
                this.objectReceipt.Reason = this.reason.Text;
                bool flagUpdate = this.receiptBLT.updateReceipts(objectReceipt);
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

        private void printReceipt(object sender, EventArgs e)
        {
          ReportDataSource source = new ReportDataSource();
            ReportViewer reportViewer = new ReportViewer();
           
            source.Name = "DataSet1";
            source.Value = null;


            ReportParameter p1 = new ReportParameter("test1", "ASV");
         //   reportViewer.Reset();
           // reportViewer.LocalReport.DataSources.Clear();
          reportViewer.LocalReport.ReportPath = "../../Reports/ReportReceipts.rdlc";
          ReportParameter rp = new ReportParameter();
          rp.Name = "id";
          rp.Values.Add(objectReceipt.Id);
          ReportParameter rp1 = new ReportParameter("contractid", objectReceipt.Contractid, true);
          ReportParameter rp2 = new ReportParameter("dateestablish", this.objectReceipt.Dateestablish, true);
          ReportParameter rp3 = new ReportParameter("billid", this.objectReceipt.Billid, true);
          ReportParameter rp4 = new ReportParameter("customername", this.objectReceipt.Customername, true);
          ReportParameter rp5 = new ReportParameter("total", this.objectReceipt.Total.ToString(), true);
          ReportParameter rp6 = new ReportParameter("reason", this.objectReceipt.Reason, true);
          ReportParameter rp7 = new ReportParameter("note", this.objectReceipt.Contents, true);
          ReportParameter[] parameter = new ReportParameter[] { rp, rp2, rp1, rp3, rp4, rp5, rp6, rp7 };
         // reportViewer.LocalReport.SetParameters(p);
          // reportViewer.LocalReport.DataSources.Add(source);

          ReportReceipts form = new ReportReceipts(parameter);
            form.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReceiptList receiptList = new ReceiptList();
            receiptList.Show();
            this.Hide();
        }
    }
}
