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
    public class DebtDAT : DataBases
    {
        public bool addDebt(Debt c)
        {
            try
            {
                int param = 4;

                string[] name = new string[param];
                object[] value = new object[param];

                name[0] = "@contractid"; value[0] = c.Contractid;
                name[1] = "@dateSet"; value[1] = c.DateSet;
                name[2] = "@debtuntildate"; value[2] = c.DebtUnitldate;
                name[3] = "@note"; value[3] = c.Node;

                int result = this.Update("debt_Insert", name, value, param);
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

        public bool deleteDebt(String id)
        {
            try
            {
                SqlParameter[] para = new SqlParameter[1];
                para[0] = new SqlParameter("@id", id);

                int result = this.ExecuteNonQuery("Delete from debt where id = @id", para);
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

        public bool updateDebt(Debt c)
        {
            try
            {

                string sql = " Set dateformat dmy Update debt set contractid =('" + c.Contractid + "'), date =('" + c.DateSet + "'),  debtuntildate =('" + c.DebtUnitldate + "'),  note =('" + c.Node + "') where id = ('" + c.Id.Trim() + "')";
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

        public DataTable searchListDebt(String str )
        {
            try
            {
               // string sql = "select * from debt where contractid = " + str;

                string sql = "select id AS [Debt ID] , contractid AS [Contract ID] , date AS [Date],debtuntildate AS [Total Debt] ,note AS [Note] from debt where contractid like '%" + str + "%'" + "OR id like '%" + str + "%'" + "OR date like '%" + str + "%'";
                return this.LoadDataTable(sql);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message = {1}", ex.Message);
            }
            return null;
        }


        public DataTable getListDebt()
        {
            try
            {
                string sql = "select id AS [Debt ID] , contractid AS [Contract ID] , date AS [Date],debtuntildate AS [Total Debt] ,note AS [Note] from debt";
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
