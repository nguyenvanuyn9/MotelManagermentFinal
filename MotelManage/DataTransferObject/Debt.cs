using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotelManage.DataTransferObject
{
    public class Debt
    {
        String id;

        public String Id
        {
            get { return id; }
            set { id = value; }
        }
        String contractid;

        public String Contractid
        {
            get { return contractid; }
            set { contractid = value; }
        }
        DateTime dateSet;

        public DateTime DateSet
        {
            get { return dateSet; }
            set { dateSet = value; }
        }
        decimal debtUnitldate;
        public decimal DebtUnitldate
        {
            get { return debtUnitldate; }
            set { debtUnitldate = value; }
        }

        String note;

        public String Node
        {
            get { return note; }
            set { note = value; }
        }

    }
}