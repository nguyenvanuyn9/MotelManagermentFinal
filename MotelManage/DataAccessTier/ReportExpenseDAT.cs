using MotelManage.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MotelManage.DataAccessTier
{
    class ReportExpenseDAT : DataBases
    {

        public DataTable GetReportExpense(int month, int year)
        {
            try
            {
                SqlParameter[] para = new SqlParameter[2];

                para[0] = new SqlParameter("@p_month", month);
                para[1] = new SqlParameter("@p_year", year);


                DataTable lst = LoadDataTableStoreProcedure("Report_Expense", para);
                return lst;
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return null;
        }

        public DataTable addReportExpense(ReportExpenses report, XElement xml)
        {
            try
            {
                string[] names = new string[3];
                object[] values = new object[3];

                names[0] = "@p_DATE"; values[0] = report.Date;
                names[1] = "@p_TOTAL"; values[1] = report.Total;
                names[2] = "@p_XML_DATA"; values[2] = xml.ToString();


                return this.ExcuteStoreProcedure("REPORTEXPENSE_Ins", names, values);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message = {1}", ex.Message);
                // System.Diagnostics.Debug.Write("Message = {1}", ex.Message);
            }

            return null;
        }

        public DataTable getListData()
        {
            try
            {
                string sql = "select ID, DATE, TOTAL" +
                             " from REPORTEXPENSE";

                return this.LoadDataTable(sql);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message = {1}", ex.Message);
            }
            return null;
        }

        public DataTable SearchReportExpense(ReportExpenses reportExpense)
        {
            try
            {
                SqlParameter[] para = new SqlParameter[3];

                para[0] = new SqlParameter("@p_id", reportExpense.Id);
                para[1] = new SqlParameter("@p_date", reportExpense.Date);
                para[2] = new SqlParameter("@p_total", reportExpense.Total);


                DataTable lstRoomBook = LoadDataTableStoreProcedure("ReportExpense_Search", para);
                return lstRoomBook;
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return null;
        }


        public DataTable getListReportDeTail(String id)
        {
            try
            {
                string sql = "select RP.id AS 'ID', RP.reportexpenseid AS 'REPORTEXPENSE', RP.receiver AS 'RECEIVER', RP.price AS 'PRICE' " +
                             "from reportexpensedetail RP " +
                             "WHERE RP.reportexpenseid='" + id + "'";
                return this.LoadDataTable(sql);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message = {1}", ex.Message);
            }
            return null;
        }
    
    
    }
}
