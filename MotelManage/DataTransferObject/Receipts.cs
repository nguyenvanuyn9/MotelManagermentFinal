using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotelManage.DataTransferObject
{
    public class Receipts
    {
        String id;

        public String Id
        {
            get { return id; }
            set { id = value; }
        }
        string dateestablish;

        public string Dateestablish
        {
            get { return dateestablish; }
            set { dateestablish = value; }
        }
        String reason;

        public String Reason
        {
            get { return reason; }
            set { reason = value; }
        }
        decimal total;

        public decimal Total
        {
            get { return total; }
            set { total = value; }
        }
        String contractid;

        public String Contractid
        {
            get { return contractid; }
            set { contractid = value; }
        }
        String billid;

        public String Billid
        {
            get { return billid; }
            set { billid = value; }
        }
        String customername;

        public String Customername
        {
            get { return customername; }
            set { customername = value; }
        }
        String contents;

        public String Contents
        {
            get { return contents; }
            set { contents = value; }
        }
    }
}