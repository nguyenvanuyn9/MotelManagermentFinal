using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotelManage.DataTransferObject
{
    class DetailBillToll
    {
        String id;

        public String Id
        {
            get { return id; }
            set { id = value; }
        }
        String tollbillsid;

        public String Tollbillsid
        {
            get { return tollbillsid; }
            set { tollbillsid = value; }
        }
        String serviceid;

        public String Serviceid
        {
            get { return serviceid; }
            set { serviceid = value; }
        }
        int numberold;

        public int Numberold
        {
            get { return numberold; }
            set { numberold = value; }
        }
        int numbernew;

        public int Numbernew
        {
            get { return numbernew; }
            set { numbernew = value; }
        }
        int numberuse;

        public int Numberuse
        {
            get { return numberuse; }
            set { numberuse = value; }
        }
        decimal money;

        public decimal Money
        {
            get { return money; }
            set { money = value; }
        }
    }
}
