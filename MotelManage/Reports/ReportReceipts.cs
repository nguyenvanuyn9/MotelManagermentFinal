using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MotelManage.Reports
{
    public partial class ReportReceipts : Form
    {
        ReportParameter[] temp = new ReportParameter[]{};
        public ReportReceipts()
        {
            InitializeComponent();
        }
        public ReportReceipts(ReportParameter[] r)
        {
            InitializeComponent();
            temp = r;
        }
        private void ReportReceipts_Load(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.SetParameters(temp);
            this.reportViewer1.RefreshReport();
        }
    }
}
