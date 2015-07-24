using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotelManage.DataTransferObject
{
    
    public class BillSpend
    {
        String id;

        public String Id
        {
            get { return id; }
            set { id = value; }
        }

        DateTime dateestablish;

        public DateTime Dateestablish
        {
            get { return dateestablish; }
            set { dateestablish = value; }
        }
        String expenses;

        public String Expenses
        {
            get { return expenses; }
            set { expenses = value; }
        }
        decimal total;

        public decimal Total
        {
            get { return total; }
            set { total = value; }
        }
        String note;

        public String Note
        {
            get { return note; }
            set { note = value; }
        }
        String receiver;

        public String Receiver
        {
            get { return receiver; }
            set { receiver = value; }
        }
    }
}
