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
    public class ReceiptDAT : DataBases
    {
        public bool addReceipt(Receipts c)
        {
            try
            {
                int param = 7;

                string[] name = new string[param];
                object[] value = new object[param];

                name[0] = "@dateestablish"; value[0] = c.Dateestablish;
                name[1] = "@reason"; value[1] = c.Reason;
                name[2] = "@total"; value[2] = c.Total;
                name[3] = "@contractid"; value[3] = c.Contractid;
                name[4] = "@billid"; value[4] = c.Billid;
                name[5] = "@customername"; value[5] = c.Customername;
                name[6] = "@note"; value[6] = c.Contents;

                int result = this.Update("receipts_Insert", name, value, param);
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

        public bool deleteReceipts(String id)
        {
            try
            {
                SqlParameter[] para = new SqlParameter[1];
                para[0] = new SqlParameter("@id", id);

                int result = this.ExecuteNonQuery("Delete from receipts where id = @id", para);
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

        public bool updateReceipts(Receipts c)
        {
            try
            {

                string sql = "Update receipts set dateestablish =('" + c.Dateestablish + "'), reason =('" + c.Reason + "'),  total =('" + c.Total + "'),  contractid =('" + c.Contractid + "') ,  billid =('" + c.Billid + "') ,  customername =('" + c.Customername + "') ,  contents =('" + c.Contents + "') where id = ('" + c.Id.Trim() + "')";
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
        //search theo id, customer name , contractid, dateestablish
        public DataTable searchListReceipts(String str)
        {
            try
            {
                // string sql = "select * from debt where contractid = " + str;

                string sql = "select id AS [Receipt ID] , dateestablish AS [DATE], reason AS [REASON] , total AS [TOTAL] , contractid AS [CONTRACT ID], billid AS [BILL ID] , customername AS [Customer] ,contents AS [Content] from receipts where customername like '%" + str + "%'" + "OR id like '%" + str + "%'" + "OR dateestablish like '%" + str + "%'" + "OR contractid like '%" + str + "%'" + "OR billid like '%" + str + "%'";
                return this.LoadDataTable(sql);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message = {1}", ex.Message);
            }
            return null;
        }


        public DataTable getListReceipts()
        {
            try
            {
                string sql = "select id AS [Receipt ID] , dateestablish AS [DATE], reason AS [REASON] , total AS [TOTAL] , contractid AS [CONTRACT ID], billid AS [BILL ID] , customername AS [Customer] ,contents AS [Content] from receipts";
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
