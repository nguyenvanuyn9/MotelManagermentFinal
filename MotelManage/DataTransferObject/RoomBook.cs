using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotelManage.DataTransferObject
{
    public class RoomBook
    {
        String id;

        public String Id
        {
            get { return id; }
            set { id = value; }
        }

        String begindate;

        public String Begindate
        {
            get { return begindate; }
            set { begindate = value; }
        }
        String enddate;

        public String Enddate
        {
            get { return enddate; }
            set { enddate = value; }
        }
        String roomid;

        public String Roomid
        {
            get { return roomid; }
            set { roomid = value; }
        }
        String customerid;

        public String Customerid
        {
            get { return customerid; }
            set { customerid = value; }
        }

        String roomBookStatusid;

        public String RoomBookStatusid
        {
            get { return roomBookStatusid; }
            set { roomBookStatusid = value; }
        }


        String note;

        public String Note
        {
            get { return note; }
            set { note = value; }
        }

        decimal deposit;

        public decimal Deposit
        {
            get { return deposit; }
            set { deposit = value; }
        }
    }
}
