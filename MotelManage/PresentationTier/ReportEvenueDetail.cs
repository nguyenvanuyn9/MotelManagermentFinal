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
    public partial class ReportEvenueDetail : Form
    {
        ReportEvenueBLT reportEvenueBLT;
        ReportEvenues reportEvenue;


        public ReportEvenueDetail(ReportEvenues reportEvenue)
        {
            InitializeComponent();
            this.gridviewDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            this.tbReportID.Enabled = false;
            this.tbTotalMoney.Enabled = false;
            this.dateSet.Enabled = false;

            this.reportEvenue = reportEvenue;
            reportEvenueBLT = new ReportEvenueBLT();
        }

        private void ReportEvenueDetail_Load(object sender, EventArgs e)
        {
            //Load report ..
            this.tbReportID.Text = reportEvenue.Id;
            this.dateSet.Value = Convert.ToDateTime(reportEvenue.Date);
            this.tbTotalMoney.Text = reportEvenue.Total.ToString();

            this.gridviewDetail.DataSource = reportEvenueBLT.getListReportDeTail(reportEvenue.Id);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();

            ReportEvenueList newform = new ReportEvenueList();
            newform.Show();
        }
    }
}
