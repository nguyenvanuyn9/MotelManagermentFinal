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
    public class RoomTypeDAT : DataBases
    {
        public RoomTypeDAT()
        {
            //this.roomtype = new RoomTypeDAT();
        }

        public DataTable getListData()
        {
            try
            {
                string sql = "select * from roomtype";
                return this.LoadDataTable(sql);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message = {1}", ex.Message);
            }
            return null;
        }

        public DataTable getListRoomTypeById(string id)
        {
            try
            {
                string sql = "Select * from roomtype where id = " + id;
                return this.LoadDataTable(sql);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message = {1}", ex.Message);
            }
            return null;

        }

        public DataTable addRoomType(RoomType rt)
        {
            try
            {
                int param = 4;

                string[] name = new string[param];
                object[] value = new object[param];

                name[0] = "@p_NAME"; value[0] = rt.Name;
                name[1] = "@p_PRICE"; value[1] = rt.Price;
                name[2] = "@p_DEPOSIT"; value[2] = rt.Deposit;
                name[3] = "@p_NOTE"; value[3] = rt.Note;

                return this.ExcuteStoreProcedure("ROOMTYPE_Ins", name, value);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message = {1}", ex.Message);
            }

            return null;
        }

        public bool deleteRoomType(String id)
        {
            try
            {
                SqlParameter[] para = new SqlParameter[1];
                para[0] = new SqlParameter("@id", id);

                int result = this.ExecuteNonQuery("Delete from roomtype where id = @id", para);
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

        public bool updateRoomType(RoomType rt)
        {
            try
            {
                string sql = "Update roomtype set name = N'" + rt.Name + "', price = " + rt.Price.ToString().Replace(',', '.') + ",  deposit = " + rt.Deposit.ToString().Replace(',', '.') + ",  note = N'" + rt.Note + "' where id = '" + rt.Id.Trim() + "'";
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

        public DataTable searchRoomType(RoomType rt)
        {
            try
            {
                string[] names = new string[6];
                object[] values = new object[6];

                names[0] = "@p_ID"; values[0] = rt.Id;
                names[1] = "@p_NAME"; values[1] = rt.Name;
                names[2] = "@p_PRICE"; values[2] = rt.Price;
                names[3] = "@p_DEPOSIT"; values[3] = rt.Deposit;
                names[4] = "@p_NOTE"; values[4] = rt.Note;
                names[5] = "@p_TOP"; values[5] = 0;

                return this.ExcuteStoreProcedure("ROOMTYPE_Search", names, values);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message = {1}", ex.Message);
            }

            return null;
        }
    }
}
