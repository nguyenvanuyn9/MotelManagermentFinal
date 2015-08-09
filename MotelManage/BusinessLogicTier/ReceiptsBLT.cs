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
    public class ReceiptsBLT
    {
        protected ReceiptDAT receiptDAT;
        public ReceiptsBLT()
        {
            receiptDAT = new ReceiptDAT();
        }

        public DataTable getListReceipts()
        {
            return receiptDAT.getListReceipts();
        }
        public DataTable searchListReceipts(String str)
        {
            return receiptDAT.searchListReceipts(str);
        }
        public bool addReceipts(Receipts c)
        {
            return receiptDAT.addReceipt(c);
        }
        public bool deleteReceipts(String id)
        {
            return receiptDAT.deleteReceipts(id);
        }
        public bool updateReceipts(Receipts c)
        {
            return receiptDAT.updateReceipts(c);
        }

        public DataTable searchReceipts(Receipts rpt)
        {
            return receiptDAT.searchReceipts(rpt);
        }
    }
}
