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
        string dateSet;

        public string DateSet
        {
            get { return dateSet; }
            set { dateSet = value; }
        }
        decimal debtUntildate;
        public decimal DebtUntildate
        {
            get { return debtUntildate; }
            set { debtUntildate = value; }
        }

        String note;

        public String Note
        {
            get { return note; }
            set { note = value; }
        }

    }
}