using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotelManage.DataTransferObject
{
    public class TollBills
    {
        String id;

        public String Id
        {
            get { return id; }
            set { id = value; }
        }
        //String contractid;

        //public String Contractid
        //{
        //    get { return contractid; }
        //    set { contractid = value; }
        //}
        String servicenoteid;

        public String Servicenoteid
        {
            get { return servicenoteid; }
            set { servicenoteid = value; }
        }
        String datetoll;

        public String Datetoll
        {
            get { return datetoll; }
            set { datetoll = value; }
        }
        decimal total;

        public decimal Total
        {
            get { return total; }
            set { total = value; }
        }
        decimal discountMoney;

        public decimal DiscountMoney
        {
            get { return discountMoney; }
            set { discountMoney = value; }
        }
        decimal debtUntilDate;

        public decimal DebtUntilDate
        {
            get { return debtUntilDate; }
            set { debtUntilDate = value; }
        }
        String note;

        public String Note
        {
            get { return note; }
            set { note = value; }
        }
    }
}
