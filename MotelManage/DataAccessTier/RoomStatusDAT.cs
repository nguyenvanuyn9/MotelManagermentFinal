using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using MotelManage.DataTransferObject;

namespace MotelManage.DataAccessTier
{
    class RoomStatusDAT : DataBases
    {

        public RoomStatusDAT()
        {
         
        }

        public DataTable getListData()
        {
            try
            {
                return this.LoadDataTable("SELECT id AS 'Mã trạng thái', name AS 'Tên trạng thái' FROM roomstatus");
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message = {1}", ex.Message);
            }
            return null;
        }

        public bool addRoomStatus(RoomStatus roomStatus)
        {
            try
            {
                int param = 1;

                string[] name = new string[param];
                object[] value = new object[param];

                name[0] = "@name"; value[0] = roomStatus.Name;

                int result = this.Update("RoomStatus_Insert", name, value, param);
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

        public bool deleteRoomStatus(String id)
        {
            try
            {
                SqlParameter[] para = new SqlParameter[1];
                para[0] = new SqlParameter("@id", id);

                int result = this.ExecuteNonQuery("DELETE FROM roomstatus WHERE id = @id", para);
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

        public bool updateRoomStatus(RoomStatus roomStatus)
        {
            try
            {
                SqlParameter[] para = new SqlParameter[2];
                para[0] = new SqlParameter("@id", roomStatus.Id);
                para[1] = new SqlParameter("@name", roomStatus.Name);

                int result = this.ExecuteNonQuery("UPDATE roomstatus  SET name=@name WHERE id = @id", para);
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

        public DataTable SearchRoomStatus(RoomStatus roomStatus)
        {
            try
            {
                SqlParameter[] para = new SqlParameter[2];
                para[0] = new SqlParameter("@p_id", roomStatus.Id);
                para[1] = new SqlParameter("@p_name", roomStatus.Name);

                DataTable lstRoomStatus = LoadDataTableStoreProcedure("Roomstatus_Search", para);
                return lstRoomStatus;
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return null;
        }

        public int checkIsUsed(String status)
        {
            int count = -1;
            DataTable result;

            try
            {
                string sql = "Select count(*) from room where statusID='" + status + "'";

                result = this.LoadDataTable(sql);

                count = Convert.ToInt32(result.Rows[0][0].ToString());

                return count;

            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message = {1}", ex.Message);
            }
            return -1;
        }

        public int checkDuplidateName(String name)
        {
            int count = -1;
            DataTable result;

            try
            {
                string sql = "Select count(*) from roomstatus where name='" + name + "'";

                result = this.LoadDataTable(sql);

                count = Convert.ToInt32(result.Rows[0][0].ToString());

                return count;

            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message = {1}", ex.Message);
            }
            return -1;
        }
    }
}
