using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotelManage.DataTransferObject
{
    public class Room
    {
        String id;

        public String Id
        {
            get { return id; }
            set { id = value; }
        }
        String name;

        public String Name
        {
            get { return name; }
            set { name = value; }
        }
        String statusID;

        public String StatusID
        {
            get { return statusID; }
            set { statusID = value; }
        }

        String roomType;

        public String RoomType
        {
            get { return roomType; }
            set { roomType = value; }
        }


    }
}
