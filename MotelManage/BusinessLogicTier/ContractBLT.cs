using MotelManage.DataAccessTier;
using MotelManage.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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


        public bool addContract(Contract ctr, XElement xml, out string ContractId)
        {
            var result = contractDAT.addContract(ctr, xml);
            if (result.Rows[0].ItemArray[0].ToString() == "0")
            {
                ContractId = result.Rows[0].ItemArray[1].ToString();
                return true;
            }
            ContractId = "";
            return false;
        }

        public bool deleteContract(String id)
        {
            var result = contractDAT.deleteContract(id);
            if (result.Rows[0].ItemArray[0].ToString() == "0")
            {
                return true;
            }
            return false;
        }

        public bool updateContract(Contract ctr, XElement xml)
        {
            var result = contractDAT.updateContract(ctr, xml);
            if (result.Rows[0].ItemArray[0].ToString() == "0")
            {
                return true;
            }
            return false;
        }

        public DataTable searchContract(Contract ctr, string roomName = "", string customerName = "")
        {
            return contractDAT.searchContract(ctr, roomName, customerName);
        }

        public DataTable searchContractDetail(ContractDetail ctrd)
        {
            return contractDAT.searchContractDetail(ctrd);
        }
    }
}
