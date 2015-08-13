﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using MotelManage.DataTransferObject;

namespace MotelManage.DataAccessTier
{
    class RoomDAT: DataBases
    {

        public RoomDAT()
        {

        }

        public DataTable getListRoom()
        {
            try
            {
                string sql = "select RM.ID, RM.NAME, RM.STATUSID, RMS.NAME AS STATUSNAME, RM.ROOMTYPEID, RMT.NAME AS ROOMTYPENAME " +
                             "from ROOM RM " +
                             "LEFT JOIN ROOMSTATUS RMS " +
                             "ON RM.STATUSID = RMS.ID " +
                             "LEFT JOIN ROOMTYPE RMT " +
                             "ON RM.ROOMTYPEID=RMT.ID ";
                return this.LoadDataTable(sql);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message = {1}", ex.Message);
            }
            return null;
        }

        public DataTable getListData()
        {
            try
            {
                string sql = "select RM.ID, RM.NAME, RMS.NAME AS STATUSNAME, RMT.NAME AS ROOMTYPENAME " +
                             "from ROOM RM " +
                             "LEFT JOIN ROOMSTATUS RMS " +
                             "ON RM.STATUSID = RMS.ID " +
                             "LEFT JOIN ROOMTYPE RMT " +
                             "ON RM.ROOMTYPEID=RMT.ID ";
                return this.LoadDataTable(sql);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message = {1}", ex.Message);
            }
            return null;
        }


        public bool addRoom(Room room)
        {
            try
            {
                int param = 3;

                string[] name = new string[param];
                object[] value = new object[param];

                name[0] = "@name"; value[0] = room.Name;
                name[1] = "@statusid"; value[1] = room.StatusID;
                name[2] = "@roomtypeid"; value[2] = room.RoomType;



                int result = this.Update("Room_Insert", name, value, param);
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


        public bool deleteRoom(String id)
        {
            try
            {
                SqlParameter[] para = new SqlParameter[1];
                para[0] = new SqlParameter("@id", id);

                int result = this.ExecuteNonQuery("DELETE FROM room WHERE id = @id", para);
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

        public bool updateRoom(Room room)
        {
            try
            {
                SqlParameter[] para = new SqlParameter[4];
                para[0] = new SqlParameter("@id", room.Id);
                para[1] = new SqlParameter("@name", room.Name);
                para[2] = new SqlParameter("@status", room.StatusID);
                para[3] = new SqlParameter("@type", room.RoomType);

                int result = this.ExecuteNonQuery("UPDATE room SET name=@name, statusID=@status, roomtypeid=@type WHERE id = @id", para);
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

        //=========================================================================

        public DataTable getListRoomStatus()
        {
            try
            {
                return this.LoadDataTable("SELECT id, name FROM roomstatus");
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message = {1}", ex.Message);
            }
            return null;
        }

        public DataTable getListRoomType()
        {
            try
            {
                return this.LoadDataTable("SELECT id, name FROM roomtype");
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message = {1}", ex.Message);
            }
            return null;
        }

        public String getNameRoomTypeById(String id)
        {
            String name = "";
            DataTable result;

            try
            {
                string sql = "SELECT name FROM roomtype where id='" + id + "'";

                result = this.LoadDataTable(sql);

                name = result.Rows[0][0].ToString();

                return name;
               
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message = {1}", ex.Message);
            }
            return null;
        }

        public String getRoomStatusById(String id)
        {
            String status = "";
            DataTable result;

            try
            {
                string sql = "SELECT statusID FROM room where id='" + id + "'";

                result = this.LoadDataTable(sql);

                status = result.Rows[0][0].ToString();

                return status;

            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message = {1}", ex.Message);
            }
            return null;
        }
         

        public int checkDuplidateName(String name)
        {
            int count = -1;
            DataTable result;

            try
            {
                string sql = "Select count(*) from room where name='" + name + "'";

                result = this.LoadDataTable(sql);

                count = Convert.ToInt32(result.Rows[0][0].ToString());

                return count;

            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message = {1}", ex.Message);
            }
            return -1 ;
        }

        public String getNameRoomStatusById(String id)
        {
            String name = "";
            DataTable result;

            try
            {
                string sql = "SELECT name FROM roomstatus where id='" + id + "'";

                result = this.LoadDataTable(sql);

                name = result.Rows[0]["name"].ToString();
               
                return name;

            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message = {1}", ex.Message);
            }
            return null;
        }

        public DataTable SearchRoom(Room room)
        {
            try
            {
                SqlParameter[] para = new SqlParameter[4];
                para[0] = new SqlParameter("@p_id", room.Id);
                para[1] = new SqlParameter("@p_name", room.Name);
                para[2] = new SqlParameter("@p_statusid", room.StatusID);
                para[3] = new SqlParameter("@p_roomtypeid", room.RoomType);

                DataTable lstRoom = LoadDataTableStoreProcedure("Room_Search", para);
                return lstRoom;
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return null;
        }

    }

   
}
