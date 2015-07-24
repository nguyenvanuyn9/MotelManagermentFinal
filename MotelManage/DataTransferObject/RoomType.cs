using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotelManage.DataTransferObject
{
    public class RoomType
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
        decimal price;

        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }
        decimal deposit;

        public decimal Deposit
        {
            get { return deposit; }
            set { deposit = value; }
        }
        String note;

        public String Note
        {
            get { return note; }
            set { note = value; }
        }
    }
}
