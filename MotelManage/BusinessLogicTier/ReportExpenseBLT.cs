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
    class ReportExpenseBLT
    {
        private ReportExpenseDAT reportExpenseDAT;

        public ReportExpenseBLT()
        {
            this.reportExpenseDAT = new ReportExpenseDAT();
        }

        public DataTable GetReportExpense(int month, int year)
        {
            try
            {

                DataTable table = reportExpenseDAT.GetReportExpense(month, year);

                return table;
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return null;
        }

        public bool addReportExpense(ReportExpenses rt, XElement xml, out string ReportExpenseId)
        {
            var result = reportExpenseDAT.addReportExpense(rt, xml);
            if (result.Rows[0].ItemArray[0].ToString() == "0")
            {
                ReportExpenseId = result.Rows[0].ItemArray[1].ToString();
                return true;
            }
            ReportExpenseId = "";
            return false;
        }

        public DataTable getListData()
        {
            DataTable table = reportExpenseDAT.getListData();

            return table;
        }

        public DataTable SearchReportExpense(ReportExpenses reportExpense)
        {

            try
            {

                DataTable table = reportExpenseDAT.SearchReportExpense(reportExpense);
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
            DataTable table = reportExpenseDAT.getListReportDeTail(id);

            return table;
        }
    }
}
