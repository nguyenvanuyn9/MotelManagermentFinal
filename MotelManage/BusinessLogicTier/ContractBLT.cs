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
   public class ContractBLT
    {
       protected ContractDAT contractDAT;
       public ContractBLT()
       {
           contractDAT = new ContractDAT();
        }

        public DataTable getListContract()
        {
            return contractDAT.getListContract();
        }

        public DataTable searchContract(Contract ctr)
        {
            return contractDAT.searchContract(ctr);
        }

        public DataTable getListContractDetail(string contractid)
        {
            DataTable table = contractDAT.getListContractDetail(contractid);
            var serviceNoteBLT = new ServiceNoteBLT();
            table.Columns.Add("NumberOld");
            table.Columns.Add("NumberUsed");
            table.Columns.Add("Total");
            table.Columns.Add("NumberNew");

            foreach (DataRow dr in table.Rows)
            {
                int tempLastValue= serviceNoteBLT.getNumberOldLastMonth(dr["ServiceID"].ToString(), contractid);
                dr["NumberOld"] = tempLastValue;
                dr["NumberUsed"] = 0;
                dr["Total"] = 0;
                
                if (tempLastValue == -1)
                {
                    dr["NumberNew"] = -1;
                }
                else
                {
                    dr["NumberNew"] = 0;
                }
            }


            return table;
        }
        
        public string getLastIdContract()
        {
            return contractDAT.getLastIdContract();
        }
        public DataSet getComboContractData()
        {
            return contractDAT.getComboContractData();
        }
        public bool isValid(string contractID)
        {
            return contractDAT.isValue(contractID);
        }
    }
}
