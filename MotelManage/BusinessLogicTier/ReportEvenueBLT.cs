using MotelManage.DataAccessTier;
using MotelManage.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MotelManage.BusinessLogicTier
{
    class ReportEvenueBLT
    {
        private ReportEvenueDAT reportEvenueDAT;

        public ReportEvenueBLT()
        {
            this.reportEvenueDAT = new ReportEvenueDAT();
        }

        public DataTable GetReportEvenue(int month, int year)
        {

            try
            {

                DataTable table = reportEvenueDAT.Report_Evenue(month, year);

                return table;
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return null;
        }


        public bool addReportEvenue(ReportEvenues rt, XElement xml, out string ReportEvenueId)
        {
            var result = reportEvenueDAT.addReportEvenue(rt, xml);
            if (result.Rows[0].ItemArray[0].ToString() == "0")
            {
               ReportEvenueId = result.Rows[0].ItemArray[1].ToString();
                return true;
            }
            ReportEvenueId = "";
            return false;
        }

        public DataTable getListData()
        {
            DataTable table = reportEvenueDAT.getListData();

            return table;
        }

        public DataTable SearchReportEvenue(ReportEvenues reportEvenue)
        {

            try
            {

                DataTable table = reportEvenueDAT.SearchReportEvenue(reportEvenue);
                return table;
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return null;
        }

        public DataTable getListReportDeTail(String id)
        {
            DataTable table = reportEvenueDAT.getListReportDeTail(id);

            return table;
        }
    
    }
}
