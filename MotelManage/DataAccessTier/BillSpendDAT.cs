using MotelManage.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotelManage.DataAccessTier
{
    public class BillSpendDAT : DataBases
    {
        public bool addBillSpend(BillSpend c)
        {
            try
            {
                int param = 5;

                string[] name = new string[param];
                object[] value = new object[param];

                name[0] = "@dateestablish"; value[0] = c.Dateestablish;
                name[1] = "@expenseds"; value[1] = c.Expenses;
                name[2] = "@total"; value[2] = c.Total;
                name[3] = "@note"; value[3] = c.Note;
                name[4] = "@receiver"; value[4] = c.Receiver;
                int result = this.Update("billspend_Insert", name, value, param);
                if (result != 0)
                {
                    return true;
                }
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message = {1}", ex.Message);
            }

            return false;
        }

        public bool deleteBillSpend(String id)
        {
            try
            {
                SqlParameter[] para = new SqlParameter[1];
                para[0] = new SqlParameter("@id", id);

                int result = this.ExecuteNonQuery("Delete from billspend where id = @id", para);
                if (result != 0)
                {
                    return true;
                }
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message = {1}", ex.Message);
            }
            return false;
        }

        public bool updateBillSpend(BillSpend c)
        {
            try
            {

                string sql = "Update billspend set dateestablish =('" + c.Dateestablish + "'), expenses =('" + c.Expenses + "'),  total =('" + c.Total + "'),  note =('" + c.Note + "'),  receiver =('" + c.Receiver + "') where id = ('" + c.Id.Trim() + "')";
                int result = this.ExecuteNonQuery(sql);
                if (result != 0)
                {
                    return true;
                }
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message = {1}", ex.Message);
            }
            return false;
        }

        public DataTable searchListBillSpend(String str)
        {
            try
            {
                // string sql = "select * from debt where contractid = " + str;

                string sql = "select id AS [Bill ID] , dateestablish AS [Date], expenses AS [Reason] , receiver AS [Receiver] , total AS [Total] , note AS [Note] from billspend where receiver like '%" + str + "%'" + "OR id like '%" + str + "%'";
                return this.LoadDataTable(sql);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message = {1}", ex.Message);
            }
            return null;
        }

        public DataTable getListBillSpend()
        {
            try
            {
                string sql = "select id AS [Bill ID] , dateestablish AS [Date], expenses AS [Reason] ,receiver AS [Receiver] , total AS [Total] , note AS [Note] from billspend";
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
