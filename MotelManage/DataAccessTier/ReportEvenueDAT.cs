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
    class ReportEvenueDAT : DataBases
    {

        public DataTable Report_Evenue(int month, int year)
        {
            try
            {
                SqlParameter[] para = new SqlParameter[2];

                para[0] = new SqlParameter("@p_month", month);
                para[1] = new SqlParameter("@p_year", year);


                DataTable lstRoomBook = LoadDataTableStoreProcedure("Report_Evenue", para);
                return lstRoomBook;
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return null;
        }
    
        public DataTable addReportEvenue(ReportEvenues report, XElement xml)
        {
            try
            {
                string[] names = new string[3];
                object[] values = new object[3];
            
                names[0] = "@p_DATE"; values[0] = report.Date;
                names[1] = "@p_TOTAL"; values[1] = report.Total;
                names[2] = "@p_XML_DATA"; values[2] = xml.ToString();


                return this.ExcuteStoreProcedure("REPORTEVENUE_Ins", names, values);
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
                             " from REPORTREVENUE" ;
                           
                return this.LoadDataTable(sql);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message = {1}", ex.Message);
            }
            return null;
        }


        public DataTable SearchReportEvenue(ReportEvenues reportEvenue)
        {
            try
            {
                SqlParameter[] para = new SqlParameter[3];

                para[0] = new SqlParameter("@p_id", reportEvenue.Id);
                para[1] = new SqlParameter("@p_date", reportEvenue.Date);
                para[2] = new SqlParameter("@p_total", reportEvenue.Total);


                DataTable lstRoomBook = LoadDataTableStoreProcedure("ReportEvenue_Search", para);
                return lstRoomBook;
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return null;
        }

        public DataTable getListReportDeTail(String id )
        {
            try
            {
                string sql = "select RP.ID, RP.REPORTREVENUEID, CUS.NAME AS 'CUSTOMER', RP.PRICE " +
                             "from REPORTREVENUEDETAIL RP " +
                             "LEFT JOIN CONTRACT CT " +
                             "ON RP.CONTRACTID = CT.ID " +
                             "LEFT JOIN CUSTOMER CUS " +
                             "ON CUS.ID = CT.CUSTOMERID " +
                             "WHERE RP.REPORTREVENUEID='" + id  +"'";
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
