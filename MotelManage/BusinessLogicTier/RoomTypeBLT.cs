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
   public class RoomTypeBLT
    {
        public RoomTypeDAT roomTypeDAT;

        public RoomTypeBLT()
        {
            this.roomTypeDAT = new RoomTypeDAT();
        }

        public DataTable getListRoomType()
        {
            return roomTypeDAT.getListData();
        }

        public DataTable getListRoomTypeById(string id)
        {
            return roomTypeDAT.getListRoomTypeById(id);
        }

        public bool addRoomType(RoomType rt, out string roomTypeId)
        {
            var result = roomTypeDAT.addRoomType(rt);
            if (result.Rows[0].ItemArray[0].ToString() == "0")
            {
                roomTypeId = result.Rows[0].ItemArray[1].ToString();
                return true;
            }
            roomTypeId = "";
            return false;
        }

        public bool deleteRoomType(String id)
        {
            return roomTypeDAT.deleteRoomType(id);
        }

        public bool updateRoomType(RoomType rt)
        {
            return roomTypeDAT.updateRoomType(rt);
        }

        public DataTable searchRoomType(RoomType rt)
        {
            return roomTypeDAT.searchRoomType(rt);
        }
    }
}
