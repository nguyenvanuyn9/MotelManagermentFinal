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
    public class DebtBLT
    {

        protected DebtDAT debtDAT;
        public DebtBLT()
        {
            debtDAT = new DebtDAT();
        }

        public DataTable getListDebt()
        {
            return debtDAT.getListDebt();
        }
        public DataTable searchListDebt(String str)
        {
            return debtDAT.searchListDebt(str);
        }
        public bool addDebt(Debt c)
        {
            return debtDAT.addDebt(c);
        }
        public bool deleteDebt(String id)
        {
            return debtDAT.deleteDebt(id);
        }
        public bool updateDebt(Debt c)
        {
            return debtDAT.updateDebt(c);
        }
        public DataTable searchDebt(Debt debt)
        {
            return debtDAT.searchDebt(debt);
        }
    }
}
