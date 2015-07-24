using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotelManage.DataTransferObject
{
    public class Contract
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
        String setdate;

        public String Setdate
        {
            get { return setdate; }
            set { setdate = value; }
        }
        String nameEstablish;

        public String NameEstablish
        {
            get { return nameEstablish; }
            set { nameEstablish = value; }
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
        String note;

        public String Note
        {
            get { return note; }
            set { note = value; }
        }

        public bool IsValid
        {
            get
            {
                return isValid;
            }

            set
            {
                isValid = value;
            }
        }

        public decimal PriceRoom
        {
            get
            {
                return priceRoom;
            }

            set
            {
                priceRoom = value;
            }
        }

        public decimal Deposit
        {
            get
            {
                return deposit;
            }

            set
            {
                deposit = value;
            }
        }

        bool isValid;

        decimal priceRoom;

        decimal deposit;

    }
}
