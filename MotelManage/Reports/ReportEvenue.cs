using Microsoft.Reporting.WinForms;
using MotelManage.BusinessLogicTier;
using System;
using System.Data;
using System.Windows.Forms;
using System.IO;
using System.Web;
using System.Xml.Linq;
using MotelManage.DataTransferObject;

namespace MotelManage.PresentationTier
{
    public partial class ReportEvenue: Form
    {
        ReportEvenueBLT reportEvenueBLT;
        DataTable dt;

        public ReportEvenue()
        {
            InitializeComponent();

            reportEvenueBLT = new ReportEvenueBLT();
        }

        private void ReportEvenue_Load(object sender, EventArgs e)
        {
            showReport();
        }

        private void showReport()
        {
            string exeFolder = Path.GetDirectoryName(Application.StartupPath);
            string reportPath = Path.Combine(exeFolder, @"..\Reports\ReportEvenue.rdlc");

            //reset
             this.reportViewer1.Reset();

            //datasource
            int month = this.dateReport.Value.Month;
            int year = this.dateReport.Value.Year;

            dt = reportEvenueBLT.GetReportEvenue(month, year);

            ReportDataSource source = new ReportDataSource("DataSet1", dt);
            this.reportViewer1.LocalReport.DataSources.Add(source);


            this.reportViewer1.LocalReport.ReportPath = reportPath;

             ReportParameter[] rp = new ReportParameter[2];
             rp[0] = new ReportParameter("month", month.ToString());
             rp[1] = new ReportParameter("year", year.ToString());

             this.reportViewer1.LocalReport.SetParameters(rp);

            //reresher
             this.reportViewer1.RefreshReport();
        }

        private void btReport_Click(object sender, EventArgs e)
        {
            showReport();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            //Calculate total
            Double tongTien = 0.0;
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow item in dt.Rows)
                {
                    tongTien += Convert.ToDouble(item["total"]);
                }
            }

            //Save
            try
            {
                XElement xmlData = ConvertToXmlData();

                //Get Value from Report -->> Out
                ReportEvenues report = new ReportEvenues()
                {
                    Id = "",
                    Date = DateTime.Now.ToString("MM/dd/yyyy"),
                    Total = Decimal.Parse(tongTien.ToString())
                };

                 //Insert
                 string id;

                 if (reportEvenueBLT.addReportEvenue(report, xmlData, out id))//
                    {
                        MessageBox.Show("Save report succedd!");
                    }
                    else
                        MessageBox.Show("Save fail! Try again later.");
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private XElement ConvertToXmlData()
        {
            XElement XmlData = null;
            try
            {
                if (dt.Rows.Count > 0)
                {
                    DataTable table = dt;

                    XmlData = new XElement(new XElement("Root"));

                    foreach (DataRow item in dt.Rows)
                    {
                       
                            XElement xml = new XElement("XmlData");

                            xml.Add(new XElement("CONTRACTID", item["contractid"].ToString()));

                            xml.Add(new XElement("PRICE", item["total"].ToString().Replace(',', '.')));

                            XmlData.Add(xml);
                       
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return XmlData;
        }
    }
}
