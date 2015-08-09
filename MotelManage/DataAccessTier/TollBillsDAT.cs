using MotelManage.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotelManage.DataAccessTier
{
    public class TollBillsDAT : DataBases
    {
        public TollBillsDAT()
        {
            //this.TollBill = new TollBillsDAT();
        }
        
        public DataSet getComboTollBillData(string str)
        {
            try
            {
                string sql = "select id from tollbills where contractid = '" + str + "'";

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

        public decimal getTotalByTollBillId(string str)
        {
            decimal total = 0;
            try
            {
                string sql = "select total from tollbills where id = '" + str + "'";

                DataTable t = new DataTable();
                t = this.LoadDataTable(sql);
                string tempvalue = t.Rows[0]["total"].ToString();
                total = decimal.Parse(tempvalue);

            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message = {1}", ex.Message);
            }
            return total;
        }

        public DataTable getListTollBill()
        {
            try
            {
                string sql = "select TB.ID, TB.SERVICENOTEID, TB.DISCOUNTMONEY, TB.DEBTUNTILDATE, TB.DATETOLL, TB.TOTAL, TB.NOTE, SVCN.CONTRACTID, SVCN.TOTAL SERVICESUMMONEY, SVCN.DATE AS DATESERVICENOTE, CTR.PRICEROOM, RM.NAME AS ROOMNAME "
                            + "from TollBills TB "
                            + "LEFT JOIN SERVICENOTE SVCN "
                            + "ON SVCN.ID=TB.SERVICENOTEID "
                            + "LEFT JOIN CONTRACT CTR "
                            + "ON CTR.ID=SVCN.CONTRACTID "
                            + "LEFT JOIN ROOM RM "
                            + "ON RM.ID=CTR.ROOMID "
                            + "ORDER BY TB.DATETOLL DESC";
                return this.LoadDataTable(sql);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message = {1}", ex.Message);
            }
            return null;
        }

        public DataTable getListTollBillById(string id)
        {
            try
            {
                string sql = "select TB.ID, TB.SERVICENOTEID, TB.DISCOUNTMONEY, TB.DATETOLL, TB.TOTAL, TB.NOTE, SVCN.CONTRACTID, SVCN.TOTAL SERVICESUMMONEY, SVCN.DATE AS DATESERVICENOTE, DEB.DEBTUNTILDATE, CTR.PRICEROOM, RM.NAME AS ROOMNAME "
                            + "from TollBills TB "
                            + "LEFT JOIN SERVICENOTE SVCN "
                            + "ON SVCN.ID=TB.SERVICENOTEID "
                            + "LEFT JOIN CONTRACT CTR "
                            + "ON CTR.ID=SVCN.CONTRACTID "
                            + "LEFT JOIN DEBT DEB "
                            + "ON DEB.CONTRACTID=SVCN.CONTRACTID "
                            + "LEFT JOIN ROOM RM "
                            + "ON RM.ID=CTR.ROOMID "
                            + "where id = '" + id 
                            + "' order by datetoll DESC";
                return this.LoadDataTable(sql);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message = {1}", ex.Message);
            }
            return null;

        }

        public DataTable addTollBill(TollBills rt)
        {
            try
            {
                string[] names = new string[6];
                object[] values = new object[6];

                names[0] = "@p_SERVICENOTEID"; values[0] = rt.Servicenoteid;
                names[1] = "@p_DISCOUNTMONEY"; values[1] = rt.DiscountMoney;
                names[2] = "@p_DEBTUNTILDATE"; values[2] = rt.DebtUntilDate;
                names[3] = "@p_DATETOLL"; values[3] = rt.Datetoll;
                names[4] = "@p_TOTAL"; values[4] = rt.Total;
                names[5] = "@p_NOTE"; values[5] = rt.Note;

                return this.ExcuteStoreProcedure("TOLLBILLS_Ins", names, values);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message = {1}", ex.Message);
            }

            return null;
        }

        public bool deleteTollBill(String id)
        {
            try
            {
                SqlParameter[] para = new SqlParameter[1];
                para[0] = new SqlParameter("@id", id);

                int result = this.ExecuteNonQuery("Delete from tollbills where id = @id", para);
                if (result != 0)
                {
                    return true;
                }
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message = {1}", ex.Message);
            }
            return false;
        }

        public bool updateTollBill(TollBills rt)
        {
            try
            {
                string sql = "Update TollBills "
                    + "set servicenoteid = N'" + rt.Servicenoteid + "', "
                    + "discountmoney = " + rt.DiscountMoney.ToString().Replace(',', '.') + ", "
                    + "datetoll = CONVERT(DATETIME, '" + rt.Datetoll + "', 103), "
                    + "debtuntildate = " + rt.DebtUntilDate.ToString().Replace(',', '.') + ", "
                    + "total = " + rt.Total.ToString().Replace(',', '.') + ", "
                    + "note = N'" + rt.Note + "' "
                    + "where id = '" + rt.Id.Trim() + "'";
                int result = this.ExecuteNonQuery(sql);
                if (result != 0)
                {
                    return true;
                }
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message = {1}", ex.Message);
            }
            return false;
        }

        public DataTable searchTollBill(TollBills rt, string contractId, string roomName, string dateNoteService, decimal roomPrice, decimal serviceTotalMoney, decimal debt, decimal total)
        {
            try
            {
                string[] names = new string[13];
                object[] values = new object[13];

                names[0] = "@p_ID"; values[0] = rt.Id;
                names[1] = "@p_CONTRACTID"; values[1] = contractId;
                names[2] = "@p_SERVICENOTEID"; values[2] = rt.Servicenoteid;
                names[3] = "@p_DISCOUNTMONEY"; values[3] = rt.DiscountMoney;
                names[4] = "@p_DATETOLL"; values[4] = rt.Datetoll;
                names[5] = "@p_TOTAL"; values[5] = rt.Total;
                names[6] = "@p_NOTE"; values[6] = rt.Note;
                names[7] = "@p_ROOMNAME"; values[7] = roomName;
                names[8] = "@p_DATENOTESERVICE"; values[8] = dateNoteService;
                names[9] = "@p_PRICEROOM"; values[9] = roomPrice;
                names[10] = "@p_SERVICETOTALMONEY"; values[10] = serviceTotalMoney;
                names[11] = "@p_DEBT"; values[11] = debt;
                names[12] = "@p_TOP"; values[12] = 0;

                return this.ExcuteStoreProcedure("TOLLBILLS_Search", names, values);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message = {1}", ex.Message);
            }

            return null;
        }
    }
}
