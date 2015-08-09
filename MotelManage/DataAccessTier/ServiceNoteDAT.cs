using MotelManage.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MotelManage.DataAccessTier
{
    public class ServiceNoteDAT : DataBases
    {
        public ServiceNoteDAT()
        {
            //this.ServiceNote = new ServiceNoteDAT();
        }

        public DataTable getListServiceNote()
        {
            try
            {
                string sql = "select SN.ID, SN.CONTRACTID, SN.DATE, SN.TOTAL, CTR.ROOMID, RM.NAME AS ROOMNAME " +
                             "from ServiceNote SN " +
                             "LEFT JOIN CONTRACT CTR "+
                             "ON SN.CONTRACTID = CTR.ID " + 
                             "LEFT JOIN ROOM RM "+
                             "ON CTR.ROOMID=RM.ID ";
                return this.LoadDataTable(sql);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message = {1}", ex.Message);
            }
            return null;
        }

        public DataTable getListServiceNoteById(string id)
        {
            try
            {
                string sql = "Select * from ServiceNote where id = " + id;
                return this.LoadDataTable(sql);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message = {1}", ex.Message);
            }
            return null;

        }
        /// <summary>
        /// Lấy ghi chú dịch (của tháng) trước đó của một contractId.
        /// </summary>
        /// <param name="currentServiceNoteId"></param>
        /// <returns></returns>
        public DataTable getServiceNotePrev(string currentServiceNoteId)
        {
            try
            {
                string sql = "select top 1 * "
                           + "from servicenote "
                           + "where contractid = (select top 1 contractid from servicenote where id = '" + currentServiceNoteId + "') and date < (select top 1 date from servicenote where id = '" + currentServiceNoteId  + "') " 
                           + "order by date desc";
                return this.LoadDataTable(sql);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message = {1}", ex.Message);
            }
            return null;

        }

        public DataTable getListServiceNoteDetailById(string id)
        {
            try
            {
                string sql = "Select * from ServiceNoteDetail where servicenoteid = " + id;
                return this.LoadDataTable(sql);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message = {1}", ex.Message);
            }
            return null;

        }

        public DataTable addServiceNote(ServiceNote svcn, XElement xml)
        {
            try
            {
                string[] names = new string[5];
                object[] values = new object[5];

                names[0] = "@p_ID"; values[0] = svcn.Id;
                names[1] = "@p_CONTRACTID"; values[1] = svcn.Conntractid;
                names[2] = "@p_DATE"; values[2] = svcn.Date;
                names[3] = "@p_TOTAL"; values[3] = svcn.Total;
                names[4] = "@p_XML_DATA"; values[4] = xml.ToString();

                return this.ExcuteStoreProcedure("SERVICENOTE_Ins", names, values);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message = {1}", ex.Message);
            }

            return null;
        }

        public DataTable deleteServiceNote(String id)
        {
            try
            {
                string[] names = new string[1];
                object[] values = new object[1];

                names[0] = "@p_ID"; values[0] = id;

                return this.ExcuteStoreProcedure("SERVICENOTE_Del", names, values);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message = {1}", ex.Message);
            }

            return null;
        }

        public DataTable updateServiceNote(ServiceNote svcn, XElement xml)
        {
            try
            {
                string[] names = new string[5];
                object[] values = new object[5];

                names[0] = "@p_ID"; values[0] = svcn.Id;
                names[1] = "@p_CONTRACTID"; values[1] = svcn.Conntractid;
                names[2] = "@p_DATE"; values[2] = svcn.Date;
                names[3] = "@p_TOTAL"; values[3] = svcn.Total;
                names[4] = "@p_XML_DATA"; values[4] = xml.ToString();

                return this.ExcuteStoreProcedure("SERVICENOTE_Upd", names, values);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message = {1}", ex.Message);
            }

            return null;
        }

        public DataTable searchServiceNote(ServiceNote svcn, string roomName)
        {
            try
            {
                string[] names = new string[6];
                object[] values = new object[6];

                names[0] = "@p_ID"; values[0] = svcn.Id;
                names[1] = "@p_CONTRACTID"; values[1] = svcn.Conntractid;
                names[2] = "@p_DATE"; values[2] = svcn.Date;
                names[3] = "@p_TOTAL"; values[3] = svcn.Total;
                names[4] = "@p_ROOMNAME"; values[4] = roomName;
                names[5] = "@p_TOP"; values[5] = 0;

                return this.ExcuteStoreProcedure("SERVICENOTE_Search", names, values);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message = {1}", ex.Message);
            }

            return null;
        }

        public DataTable searchServiceNoteDetail(ServiceNoteDetail svcnd)
        {
            try
            {
                string[] names = new string[8];
                object[] values = new object[8];

                names[0] = "@p_ID"; values[0] = svcnd.Id;
                names[1] = "@p_SERVICENOTEID"; values[1] = svcnd.Servicenoteid;
                names[2] = "@p_SERVICEID"; values[2] = svcnd.Serviceid;
                names[3] = "@p_NUMBEROLD"; values[3] = svcnd.Numberold;
                names[4] = "@p_NUMBERNEW"; values[4] = svcnd.Numbernew;
                names[5] = "@p_NUMBERUSED"; values[5] = svcnd.NumberUsed;
                names[6] = "@p_TOTAL"; values[6] = svcnd.Total;
                names[7] = "@p_TOP"; values[7] = 0;

                return this.ExcuteStoreProcedure("SERVICENOTEDETAIL_Search", names, values);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message = {1}", ex.Message);
            }

            return null;
        }

        public DataTable getNumberOldLastMonth(string serviceid, string contractid)
        {
            try
            {
                string sql = "SELECT TOP 1 SVCND.NUMBEROLD " +
                             "FROM SERVICENOTEDETAIL SVCND " +
                             "LEFT JOIN SERVICENOTE SVCN " +
                             "ON SVCND.SERVICENOTEID = SVCN.ID " +
                             "WHERE SVCN.CONTRACTID = '" + contractid + "' AND SVCND.SERVICEID = '" + serviceid + "' " +
                             "ORDER BY SVCN.DATE DESC";
                return this.LoadDataTable(sql);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message = {1}", ex.Message);
            }
            return null;
        }
    }
}
