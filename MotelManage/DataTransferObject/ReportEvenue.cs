using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotelManage.DataTransferObject
{
    class ReportEvenue
    {
        String id;

        public String Id
        {
            get { return id; }
            set { id = value; }
        }
        String date;

        public String Date
        {
            get { return date; }
            set { date = value; }
        }
        decimal total;

        public decimal Total
        {
            get { return total; }
            set { total = value; }
        }
    }
}
