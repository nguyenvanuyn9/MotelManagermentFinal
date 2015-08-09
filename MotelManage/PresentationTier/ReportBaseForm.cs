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

namespace MotelManage.PresentationTier
{
    public partial class ReportBaseForm : Form
    {
        ReportParameter[] reportParameter = new ReportParameter[] { };
        DataTable dataTable = new DataTable();
        public ReportBaseForm(string titleReportForm, string reportEmbeddedResource, ReportParameter[] r, DataTable dataTable)
        {
            InitializeComponent();
            Text = titleReportForm;
            reportParameter = r;
            this.dataTable = dataTable;
            reportViewer.LocalReport.ReportEmbeddedResource = reportEmbeddedResource;
            Load += ReportBaseForm_Load;
        }

        private void ReportBaseForm_Load(object sender, EventArgs e)
        {
            ReportDataSource dataSource = new ReportDataSource("DataSet1", dataTable);
            this.reportViewer.LocalReport.DataSources.Add(dataSource);
            this.reportViewer.LocalReport.SetParameters(reportParameter);
            this.reportViewer.RefreshReport();
        }
    }
}
