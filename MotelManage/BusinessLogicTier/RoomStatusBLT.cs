using MotelManage.DataAccessTier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MotelManage.DataTransferObject;

namespace MotelManage.BusinessLogicTier
{
    class RoomStatusBLT
    {
         private RoomStatusDAT roomStatusDAT;

         public RoomStatusBLT()
        {
            this.roomStatusDAT = new RoomStatusDAT();
        }

        public DataTable getListData()
        {
            return roomStatusDAT.getListData();
        }

       /* public DataTable getListRoomStatusByName(string name)
        {
            return roomStatusDAT.getListRoomStatusByName(name);
        }*/
        

        public bool deleteRoomStatus(String id)
        {
            return roomStatusDAT.deleteRoomStatus(id);
        }

        public bool addRoomStatus(RoomStatus roomStatus)
        {
            return roomStatusDAT.addRoomStatus(roomStatus);
        }

       
        
        public bool updateRoomStatus(RoomStatus roomStatus)
        {
            return roomStatusDAT.updateRoomStatus(roomStatus);
        }

        public DataTable searchRoomStatus(RoomStatus roomStatus)
        {
           
            try
            {
                return roomStatusDAT.SearchRoomStatus(roomStatus);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return null;
        }

        public int checkIsUsed(String status)
        {
          return roomStatusDAT.checkIsUsed(status);
        }

        public int checkDuplidateName(String name)
        {
            return roomStatusDAT.checkDuplidateName(name);
        }


    }
}
