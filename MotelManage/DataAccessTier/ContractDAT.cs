using MotelManage.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotelManage.DataAccessTier
{
    public class ContractDAT : DataBases
    {
        public DataTable getListContract()
        {
            try
            {
                string sql = "select CTR.ID, CTR.BEGINDATE, CTR.ENDDATE, CTR.SETDATE, CTR.ROOMID, RM.NAME AS ROOMNAME, CTR.CUSTOMERID, CUS.NAME AS CUSTOMERNAME, CTR.NOTE, CTR.PRICEROOM, CTR.DEPOSIT, CTR.ISVALID " +
                             "from CONTRACT CTR " +
                             "LEFT JOIN ROOM RM " +
                             "ON CTR.ROOMID = RM.ID " +
                             "LEFT JOIN CUSTOMER CUS " +
                             "ON CTR.CUSTOMERID = CUS.ID ";
                return this.LoadDataTable(sql);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message = {1}", ex.Message);
            }
            return null;
        }
        public DataTable searchContract(Contract ctr)
        {
            try
            {
                string[] names = new string[11];
                object[] values = new object[11];

                names[0] = "@p_ID"; values[0] = ctr.Id;
                names[1] = "@p_BEGINDATE"; values[1] = ctr.Begindate;
                names[2] = "@p_ENDDATE"; values[2] = ctr.Enddate;
                names[3] = "@p_SETDATE"; values[3] = ctr.Setdate;
                names[4] = "@p_ROOMID"; values[4] = ctr.Roomid;
                names[5] = "@p_CUSTOMERID"; values[5] = ctr.Customerid;
                names[6] = "@p_NOTE"; values[6] = ctr.Note;
                names[7] = "@p_PRICEROOM"; values[7] = ctr.PriceRoom;
                names[8] = "@p_DEPOSIT"; values[8] = ctr.Deposit;
                names[9] = "@p_ISVALID"; values[9] = (ctr.IsValid==true)?1:0;
                names[10] = "@p_TOP"; values[10] = 0;

                return this.ExcuteStoreProcedure("CONTRACT_Search", names, values);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message = {1}", ex.Message);
            }

            return null;
        }

        public DataTable getListContractDetail(string contractId)
        {
            try
            {
                string sql = "select CTRD.ID, CTRD.CONTRACTID, CTRD.SERVICEID, SER.NAME AS SERVICENAME, SER.UNIT, SER.PRICE " +
                             "from CONTRACTDETAIL CTRD " +
                             "LEFT JOIN SERVICE SER " +
                             "ON CTRD.SERVICEID = SER.ID " +
                             "WHERE CTRD.CONTRACTID='" + contractId + "'";
                return this.LoadDataTable(sql);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message = {1}", ex.Message);
            }
            return null;
        }
        public DataSet getComboContractData()
        {
            try
            {
                string sql = "select id from contract";

                DataSet dtContract = new DataSet();
                DataTable contractTable = this.LoadDataTable(sql);
                DataRow dr = contractTable.NewRow();
                dr["id"] = "No Choice";
                contractTable.Rows.Add(dr);
                dtContract.Tables.Add(contractTable);
                return dtContract;
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message = {1}", ex.Message);
            }
            return null;
        }

        public string getLastIdContract()
        {
            string id = " ";
            try
            {
                string sql = "SELECT TOP(1)id		FROM dbo.contract	ORDER BY id DESC";
                DataTable dt = this.LoadDataTable(sql);
                id = dt.Rows[0]["id"].ToString();
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message = {1}", ex.Message);
            }
            return id;
        }
        public bool isValue(string contractID)
        {
            bool flag = false;
            try
            {
                string sql = "SELECT isvalid		FROM dbo.contract	where id='" + contractID + "'";
                DataTable dt = this.LoadDataTable(sql);
                flag = bool.Parse(dt.Rows[0]["isvalid"].ToString());
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message = {1}", ex.Message);
            }
            return flag;
        }

    }
}
