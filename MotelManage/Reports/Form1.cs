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
    public partial class Form1 : Form
    {
        ReportParameter temp = new ReportParameter();
        public Form1()
        {
            InitializeComponent();
        }

        public Form1(ReportParameter r)
        {
            InitializeComponent();
            temp = r;
          
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           // ReportDataSource source = new ReportDataSource();
          

           // source.Name = "DataSet1";
           // source.Value = null;


          //  ReportParameter p1 = new ReportParameter("test1", "ASV");
            //   reportViewer.Reset();
            // reportViewer.LocalReport.DataSources.Clear();
           // reportViewer1.LocalReport.ReportPath = "../../Reports/Report1.rdlc";
          //  ReportParameter p = new ReportParameter();
          //  p.Name = "test1";
          //  p.Values.Add("ABC");
          //  reportViewer1.LocalReport.SetParameters(p);
          //  reportViewer1.LocalReport.DataSources.Add(source);
            reportViewer1.LocalReport.SetParameters(temp);
            this.reportViewer1.RefreshReport();

           
        }
    }
}
