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
   public class TollBillsBLT
    {
        public TollBillsDAT tollBillsDAT;

        public TollBillsBLT()
        {
            this.tollBillsDAT = new TollBillsDAT();
        }

        public DataSet getComboTollBillData(string str)
        {
            return tollBillsDAT.getComboTollBillData(str);
        }

        public decimal getTotalByTollBillId(string str)
        {
            return tollBillsDAT.getTotalByTollBillId(str);
        }

        public DataTable getListTollBill()
        {
            return tollBillsDAT.getListTollBill();
        }

        public DataTable getListTollBillById(string id)
        {
            return tollBillsDAT.getListTollBillById(id);
        }

        public bool addTollBill(TollBills rt, out string TollBillId)
        {
            var result = tollBillsDAT.addTollBill(rt);
            if (result.Rows[0].ItemArray[0].ToString() == "0")
            {
                TollBillId = result.Rows[0].ItemArray[1].ToString();
                return true;
            }
            TollBillId = "";
            return false;
        }

        public bool deleteTollBill(String id)
        {
            return tollBillsDAT.deleteTollBill(id);
        }

        public bool updateTollBill(TollBills rt)
        {
            return tollBillsDAT.updateTollBill(rt);
        }

        public DataTable searchTollBill(TollBills rt, string contractId, string roomName, string dateNoteService, decimal roomPrice, decimal serviceTotalMoney, decimal debt, decimal total)
        {
            return tollBillsDAT.searchTollBill(rt, contractId, roomName, dateNoteService, roomPrice, serviceTotalMoney, debt, total);
        }
    }
}
