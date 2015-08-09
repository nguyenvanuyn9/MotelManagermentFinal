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
   public class CustomerDAT : DataBases
    {
        public CustomerDAT customer;

        public CustomerDAT()
        {
            //this.customer = new CustomerDAT();
        }

        public DataTable getListData()
        {
            try
            {
                string sql = "Select id AS [ID] , name AS [Name] , cmnd AS [Identity Card], phonenumber AS [Phone] , adress  AS [Address] , submit AS [Register]  from customer";
                return this.LoadDataTable(sql);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message = {1}", ex.Message);
            }
            return null;
        }
        public DataTable getListCustomerByName(string name)
        {

            try
            {
                string sql = "Select id AS [ID] , name AS [Name] , cmnd AS [Identity Card], phonenumber AS [Phone] , adress  AS [Address] , submit AS [Submit] from customer where name like '%" + name + "%'";
                return this.LoadDataTable(sql);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message = {1}", ex.Message);
            }
            return null;
        
        }

        public DataTable getListCustomerByNameAndId(string name , string id)
        {

            try
            {
                string sql = "Select * from customer where name like '%" + name + "%'"+ " and id like '%" + id + "%'";
                return this.LoadDataTable(sql);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message = {1}", ex.Message);
            }
            return null;

        }


        public DataTable getListCustomerById(string str)
        {

            try
            {
                string sql = "Select * from customer where name like '%" + str + "%'" + " OR id like '%" + str + "%'" + " OR phonenumber like '%" + str + "%'" + " OR adress like '%" + str + "%'";
                return this.LoadDataTable(sql);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message = {1}", ex.Message);
            }
            return null;

        }

        //public bool addCustomer(Customer c)
        //{
        //    try
        //    {
        //        int param = 5;

        //        string[] name = new string[param];
        //        object[] value = new object[param];

        //        name[0] = "@name"; value[0] = c.Name;
        //        name[1] = "@cmnd"; value[1] = c.Cmnd;
        //        name[2] = "@phonenumber"; value[2] = c.Phonenumber;
        //        name[3] = "@adress"; value[3] = c.Adress;
        //        name[4] = "@submit"; value[4] = c.Commit;
        //        int result = this.Update("customer_Insert", name, value, param);
        //        if (result != 0)
        //        {
        //            return true;
        //        }
        //    }
        //    catch (System.Exception ex)
        //    {
        //        Console.WriteLine("Message = {1}", ex.Message); 
        //    }

        //    return false;
        //}


        public DataTable addCustomer(Customer cus)
        {
            try
            {
                int param = 5;

                string[] name = new string[param];
                object[] value = new object[param];

                name[0] = "@p_NAME"; value[0] = cus.Name;
                name[1] = "@p_CMND"; value[1] = cus.Cmnd;
                name[2] = "@p_PHONENUMBER"; value[2] = cus.Phonenumber;
                name[3] = "@p_ADRESS"; value[3] = cus.Address;
                name[4] = "@p_SUBMIT"; value[4] = cus.Commit;

                return this.ExcuteStoreProcedure("CUSTOMER_Ins", name, value);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message = {1}", ex.Message);
            }

            return null;
        }

        public bool deleteCustomer(String id)
        {
            try
            {
                SqlParameter[] para = new SqlParameter[1];
                para[0] = new SqlParameter("@id", id);

                int result = this.ExecuteNonQuery("Delete from Customer where id = @id", para);
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

        public bool updateCustomer(Customer c)
        {
            try
            {
                string sql = "Update customer set name = N'" + c.Name + "', cmnd = N'" + c.Cmnd + "',  phonenumber = N'" + c.Phonenumber + "',  adress = N'" + c.Address + "' ,  submit = " + (c.Commit==false?0:1) + " where id = '" + c.Id.Trim() + "'";
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
    }
}
