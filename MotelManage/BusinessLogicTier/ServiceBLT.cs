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
   public class ServiceBLT
    {
        public ServiceDAT serviceDAT;

        public ServiceBLT()
        {
            this.serviceDAT = new ServiceDAT();
        }

        public DataTable getListService()
        {
            return serviceDAT.getListService();
        }

        public DataTable getListServiceWithContractDetail(string contractId)
        {
            return serviceDAT.getListServiceWithContractDetail(contractId);
        }

        public DataTable getListServiceById(string id)
        {
            return serviceDAT.getListServiceById(id);
        }

        public bool addService(Service rt, out string ServiceId)
        {
            var result = serviceDAT.addService(rt);
            if (result.Rows[0].ItemArray[0].ToString() == "0")
            {
                ServiceId = result.Rows[0].ItemArray[1].ToString();
                return true;
            }
            ServiceId = "";
            return false;
        }

        public bool deleteService(String id)
        {
            return serviceDAT.deleteService(id);
        }

        public bool updateService(Service rt)
        {
            return serviceDAT.updateService(rt);
        }

        public DataTable searchService(Service rt)
        {
            return serviceDAT.searchService(rt);
        }
    }
}
