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
    class RoomBookDAT : DataBases
    {

        public RoomBookDAT()
        {
         
        }

        public DataTable getListData()
        {
            try
            {
                string sql = "select RB.ID, RB.BEGINDATE, RB.ENDDATE, R.NAME AS 'ROOM', C.NAME AS 'CUSTOMER', RSS.NAME AS 'STATUS', RB.NOTE, RB.DEPOSIT " +
                             "from ROOMBOOK RB " +
                             "LEFT JOIN ROOM R " +
                             "ON RB.ROOMID = R.ID " +
                             "LEFT JOIN CUSTOMER C " +
                             "ON RB.CUSTOMERID =C.ID "+
                             "LEFT JOIN ROOMBOOKSTATUS RSS " +
                            "ON RB.ROOMBOOKSTATUSID =RSS.ID ";
                return this.LoadDataTable(sql);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message = {1}", ex.Message);
            }
            return null;
        }


        public bool addRoomBook(RoomBook roomBook)
        {
            try
            {
                int param = 7;

                string[] name = new string[param];
                object[] value = new object[param];

                name[0] = "@begindate"; value[0] = roomBook.Begindate;
                name[1] = "@enddate"; value[1] = roomBook.Enddate;
                name[2] = "@roomid"; value[2] = roomBook.Roomid;
                name[3] = "@customeid"; value[3] = roomBook.Customerid;

                name[4] = "@roombookStatusId"; value[4] = roomBook.RoomBookStatusid;


                name[5] = "@note"; value[5] = roomBook.Note;
                name[6] = "@deposit"; value[6] = roomBook.Deposit;


                int result = this.Update("RoomBook_Insert", name, value, param);
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


        public bool deleteRoomBook(String id)
        {
            try
            {
                SqlParameter[] para = new SqlParameter[1];
                para[0] = new SqlParameter("@id", id);

                int result = this.ExecuteNonQuery("DELETE FROM roombook WHERE id = @id", para);
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

        public bool updateRoomBook(RoomBook roomBook)
        {
            try
            {
                SqlParameter[] para = new SqlParameter[8];
                para[0] = new SqlParameter("@id", roomBook.Id);
                para[1] = new SqlParameter("@begin", roomBook.Begindate);
                para[2] = new SqlParameter("@end", roomBook.Enddate);
                para[3] = new SqlParameter("@roomid", roomBook.Roomid);
                para[4] = new SqlParameter("@customerid", roomBook.Customerid);
                para[5] = new SqlParameter("@roombookStatusId", roomBook.RoomBookStatusid);
                para[6] = new SqlParameter("@note", roomBook.Note);
                para[7] = new SqlParameter("@deposit", roomBook.Deposit);



                int result = this.ExecuteNonQuery("UPDATE roombook SET begindate=@begin, enddate=@end, roomid=@roomid, customerid=@customerid, roombookstatusid= @roombookStatusId, note=@note, deposit=@deposit WHERE id = @id", para);
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

        public DataTable SearchRoomBook(RoomBook roomBook)
        {
            try
            {
                SqlParameter[] para = new SqlParameter[8];

                para[0] = new SqlParameter("@p_id", roomBook.Id);
                para[1] = new SqlParameter("@p_begindate", roomBook.Begindate);
                para[2] = new SqlParameter("@p_enddate", roomBook.Enddate);
                para[3] = new SqlParameter("@p_roomid", roomBook.Roomid);
                para[4] = new SqlParameter("@p_customerid", roomBook.Customerid);

                para[5] = new SqlParameter("@p_roombookStatusId", roomBook.RoomBookStatusid);

                para[6] = new SqlParameter("@p_note", roomBook.Note);
                para[7] = new SqlParameter("@p_deposit", roomBook.Deposit);

                DataTable lstRoomBook = LoadDataTableStoreProcedure("RoomBook_Search", para);
                return lstRoomBook;
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return null;
        }


        //=========================================
        public DataTable getListRoom()
        {
            try
            {
                return this.LoadDataTable("SELECT id, name FROM room");
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message = {1}", ex.Message);
            }
            return null;
        }

        public DataTable getListRoomAvaiable(String status)
        {
            try
            {
                String sql = "SELECT id, name FROM room WHERE statusID=" + "'" + status + "'";
                return this.LoadDataTable(sql);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message = {1}", ex.Message);
            }
            return null;
        }


        public DataTable getListCustomer()
        {
            try
            {
                return this.LoadDataTable("SELECT id, name FROM customer");
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message = {1}", ex.Message);
            }
            return null;
        }

        public DataTable getListRoomBookStatus()
        {
            try
            {
                return this.LoadDataTable("SELECT id, name FROM roombookstatus");
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message = {1}", ex.Message);
            }
            return null;
        }

        public String getRoomBookStatusId(String id)
        {
            String name = "";
            DataTable result;

            try
            {
                string sql = "SELECT roombookstatusid FROM roombook where id='" + id + "'";

                result = this.LoadDataTable(sql);

                name = (result.Rows[0][0]).ToString();

                return name;

            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message = {1}", ex.Message);
            }
            return null;
        }

        public String getRoomId(String id)
        {
            String name = "";
            DataTable result;

            try
            {
                string sql = "SELECT roomid FROM roombook where id='" + id + "'";

                result = this.LoadDataTable(sql);

                name = (result.Rows[0][0]).ToString();

                return name;

            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message = {1}", ex.Message);
            }
            return null;
        }

        public String getCustomerId(String id)
        {
            String name = "";
            DataTable result;

            try
            {
                string sql = "SELECT customerid FROM roombook where id='" + id + "'";

                result = this.LoadDataTable(sql);

                name = (result.Rows[0][0]).ToString();

                return name;

            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message = {1}", ex.Message);
            }
            return null;
        }
        //=============

        public bool updateRoomBookDelay(String statusId, String now )
        {
            try
            {
                SqlParameter[] para = new SqlParameter[2];
                para[0] = new SqlParameter("@status", statusId);
                para[1] = new SqlParameter("@now", now);

                String sql = "UPDATE roombook SET roombookstatusid= @status WHERE enddate < " + "'" + @now + "'";
                int result = this.ExecuteNonQuery(sql, para);
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

        public bool updateRoomStatus(String roomId, String status)
        {
            try
            {
                SqlParameter[] para = new SqlParameter[2];
                para[0] = new SqlParameter("@status", status);
                para[1] = new SqlParameter("@id", roomId);




                int result = this.ExecuteNonQuery("UPDATE room SET statusID=@status WHERE id = @id", para);
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

    }
}
