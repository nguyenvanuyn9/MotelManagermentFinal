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
    public partial class ReportExpenseDetail : Form
    {

        ReportExpenseBLT reportExpenseBLT;
        ReportExpenses reportExpense;


        public ReportExpenseDetail(ReportExpenses reportExpense)
        {
            InitializeComponent();

            this.gridviewDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            this.tbReportID.Enabled = false;
            this.tbTotalMoney.Enabled = false;
            this.dateSet.Enabled = false;

            this.reportExpense = reportExpense;
            reportExpenseBLT = new ReportExpenseBLT();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();

            ReportExpenseList newform = new ReportExpenseList();
            newform.Show();
        }

        private void ReportExpenseDetail_Load(object sender, EventArgs e)
        {
            //Load report ..
            this.tbReportID.Text = reportExpense.Id;
            this.dateSet.Value = Convert.ToDateTime(reportExpense.Date);
            this.tbTotalMoney.Text = reportExpense.Total.ToString();

            this.gridviewDetail.DataSource = reportExpenseBLT.getListReportDeTail(reportExpense.Id);
        }
    }
}
