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
   public class ServiceNoteBLT
    {
        public ServiceNoteDAT serviceNoteDAT;

        public ServiceNoteBLT()
        {
            this.serviceNoteDAT = new ServiceNoteDAT();
        }

        public DataTable getListServiceNote()
        {
            return serviceNoteDAT.getListServiceNote();
        }

        public DataTable getListServiceNoteDetail(string serviceNoteId)
        {
            return serviceNoteDAT.getListServiceNote();
        }

        public DataTable getListServiceNoteById(string id)
        {
            return serviceNoteDAT.getListServiceNoteById(id);
        }

        public bool addServiceNote(ServiceNote rt, XElement xml, out string ServiceNoteId)
        {
            var result = serviceNoteDAT.addServiceNote(rt, xml);
            if (result.Rows[0].ItemArray[0].ToString() == "0")
            {
                ServiceNoteId = result.Rows[0].ItemArray[1].ToString();
                return true;
            }
            ServiceNoteId = "";
            return false;
        }

        public bool deleteServiceNote(String id)
        {
            var result = serviceNoteDAT.deleteServiceNote(id);
            if (result.Rows[0].ItemArray[0].ToString() == "0")
            {
                return true;
            }
            return false;
        }

        public bool updateServiceNote(ServiceNote rt, XElement xml)
        {
            var result = serviceNoteDAT.updateServiceNote(rt, xml);
            if (result.Rows[0].ItemArray[0].ToString() == "0")
            {
                return true;
            }
            return false;
        }

        public DataTable searchServiceNote(ServiceNote rt, string roomName)
        {
            return serviceNoteDAT.searchServiceNote(rt, roomName);
        }

        public DataTable searchServiceNoteDetail(ServiceNoteDetail rt)
        {
            return serviceNoteDAT.searchServiceNoteDetail(rt);
        }

        public int getNumberOldLastMonth(string serviceid, string contractid)
        {
            var result = serviceNoteDAT.getNumberOldLastMonth(serviceid, contractid);
            return int.Parse(result.Rows[0].ItemArray[0].ToString());
        }
    }
}
