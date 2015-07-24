using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotelManage.DataTransferObject
{
    public class ServiceNoteDetail
    {
        string id;
        String servicenoteid;

        public String Servicenoteid
        {
            get { return servicenoteid; }
            set { servicenoteid = value; }
        }
        String serviceid;

        public String Serviceid
        {
            get { return serviceid; }
            set { serviceid = value; }
        }
        //String serviceName;

        //public String ServiceName
        //{
        //    get { return serviceName; }
        //    set { serviceName = value; }
        //}
        //String unit;

        //public String Unit
        //{
        //    get { return unit; }
        //    set { unit = value; }
        //}
        //decimal price;

        //public decimal Price
        //{
        //    get { return price; }
        //    set { price = value; }
        //}
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
        int numberUsed;

        public int NumberUsed
        {
            get { return numberUsed; }
            set { numberUsed = value; }
        }
        decimal total;

        public decimal Total
        {
            get { return total; }
            set { total = value; }
        }

        public string Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }
    }
}
