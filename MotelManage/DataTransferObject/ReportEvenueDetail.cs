using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotelManage.DataTransferObject
{
    class ReportEvenueDetail
    {
        String reportrevenueid;

        public String Reportrevenueid
        {
            get { return reportrevenueid; }
            set { reportrevenueid = value; }
        }
        String contractid;

        public String Contractid
        {
            get { return contractid; }
            set { contractid = value; }
        }
        decimal price;

        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }
    }
}
