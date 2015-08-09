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
    public class ServiceDAT : DataBases
    {
        public ServiceDAT()
        {
            //this.Service = new ServiceDAT();
        }

        public DataTable getListService()
        {
            try
            {
                string sql = "select * from Service";
                return this.LoadDataTable(sql);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message = {1}", ex.Message);
            }
            return null;
        }

        public DataTable getListServiceWithContractDetail(string contractId)
        {
            try
            {
                string sql = "SELECT CTRD.ID AS CONTRACTDETAILID, SVC.ID AS SERVICEID, SVC.NAME, SVC.UNIT, SVC.PRICE, DBO.CHECK_CONTRACTDETAILID(CTRD.ID) AS ISVALID "
                                + "FROM SERVICE SVC "
                                + "LEFT JOIN ( SELECT * FROM CONTRACTDETAIL WHERE CONTRACTID = '" + contractId + "') CTRD "
                                + "ON CTRD.SERVICEID = SVC.ID";

                return this.LoadDataTable(sql);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message = {1}", ex.Message);
            }
            return null;
        }

        public DataTable getListServiceById(string id)
        {
            try
            {
                string sql = "Select * from Service where id = " + id;
                return this.LoadDataTable(sql);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message = {1}", ex.Message);
            }
            return null;

        }

        public DataTable addService(Service rt)
        {
            try
            {
                int param = 3;

                string[] name = new string[param];
                object[] value = new object[param];

                name[0] = "@p_NAME"; value[0] = rt.Name;
                name[1] = "@p_PRICE"; value[1] = rt.Price;
                name[2] = "@p_UNIT"; value[2] = rt.Unit;

                return this.ExcuteStoreProcedure("Service_Ins", name, value);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message = {1}", ex.Message);
            }

            return null;
        }

        public bool deleteService(String id)
        {
            try
            {
                SqlParameter[] para = new SqlParameter[1];
                para[0] = new SqlParameter("@id", id);

                int result = this.ExecuteNonQuery("Delete from Service where id = @id", para);
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

        public bool updateService(Service rt)
        {
            try
            {
                string sql = "Update Service set name = N'" + rt.Name + "', price = " + rt.Price.ToString().Replace(',', '.') + ",  unit = " + rt.Unit + "' where id = '" + rt.Id.Trim() + "'";
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

        public DataTable searchService(Service rt)
        {
            try
            {
                string[] names = new string[5];
                object[] values = new object[5];

                names[0] = "@p_ID"; values[0] = rt.Id;
                names[1] = "@p_NAME"; values[1] = rt.Name;
                names[2] = "@p_PRICE"; values[2] = rt.Price;
                names[3] = "@p_UNIT"; values[3] = rt.Unit;
                names[4] = "@p_TOP"; values[4] = 0;

                return this.ExcuteStoreProcedure("Service_Search", names, values);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message = {1}", ex.Message);
            }

            return null;
        }
    }
}
