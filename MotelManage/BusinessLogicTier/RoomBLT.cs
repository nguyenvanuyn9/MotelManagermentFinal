using MotelManage.DataAccessTier;
using MotelManage.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotelManage.BusinessLogicTier
{
    class RoomBLT
    {
         private RoomDAT roomDAT;

         public RoomBLT()
        {
            this.roomDAT = new RoomDAT();
        }

        public DataTable getListData()
        {
            DataTable table = roomDAT.getListData();

            return table;
        }

        public DataTable getListRoom()
        {
            return roomDAT.getListRoom();
        }

        public bool deleteRoom(String id)
        {
            return roomDAT.deleteRoom(id);
        }

        public bool addRoom(Room room)
        {
            return roomDAT.addRoom(room);
        }



        public bool updateRoom(Room room)
        {
            return roomDAT.updateRoom(room);
        }


        //==================================
        public DataTable getListRoomType()
        {
            return roomDAT.getListRoomType();
        }

        public DataTable getListRoomStatus()
        {
            return roomDAT.getListRoomStatus();
        }

        public String getNameRoomTypeById(String id)
        {
            return roomDAT.getNameRoomTypeById(id);
        }

        public String getNameRoomStatusById(String id)
        {
            return roomDAT.getNameRoomStatusById(id);
        }

        public DataTable searchRoom(Room room)
        {

            try
            {
                return roomDAT.SearchRoom(room);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return null;
        }
    }
}
