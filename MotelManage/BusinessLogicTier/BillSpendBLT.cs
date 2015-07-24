using MotelManage.DataAccessTier;
using MotelManage.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotelManage.BusinessLogicTier
{
    public class BillSpendBLT
    {

        protected BillSpendDAT billSpendDAT;
        public BillSpendBLT()
        {
            billSpendDAT = new BillSpendDAT();
        }

        public DataTable getListBillSpend()
        {
            return billSpendDAT.getListBillSpend();
        }
        public DataTable searchListBillSpend(String str)
        {
            return billSpendDAT.searchListBillSpend(str);
        }
        public bool addBillSpend(BillSpend c)
        {
            return billSpendDAT.addBillSpend(c);
        }
        public bool deleteBillSpend(String id)
        {
            return billSpendDAT.deleteBillSpend(id);
        }
        public bool updateBillSpend(BillSpend c)
        {
            return billSpendDAT.updateBillSpend(c);
        }
    }
}
