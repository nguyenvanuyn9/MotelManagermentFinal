using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotelManage.DataTransferObject
{
    class ReportRoomDetail
    {
        String reportroomid;

        public String Reportroomid
        {
            get { return reportroomid; }
            set { reportroomid = value; }
        }
        String roomid;

        public String Roomid
        {
            get { return roomid; }
            set { roomid = value; }
        }
        String statusid;

        public String Statusid
        {
            get { return statusid; }
            set { statusid = value; }
        }
    }
}
