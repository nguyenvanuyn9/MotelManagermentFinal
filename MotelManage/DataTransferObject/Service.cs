using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotelManage.DataTransferObject
{
    public class Service
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
        String unit;

        public String Unit
        {
            get { return unit; }
            set { unit = value; }
        }
        decimal price;

        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }
    }
}
