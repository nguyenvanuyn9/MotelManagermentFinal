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
   public class CustomerBLT
    {
        public CustomerDAT customerDAT;

        public CustomerBLT()
        {
            this.customerDAT = new CustomerDAT();
        }

        public DataTable getListCustomer()
        {
            return customerDAT.getListData();
        }

        public bool addCustomer(Customer c, out string customerId)
        {
            var result = customerDAT.addCustomer(c);
            if (result.Rows[0].ItemArray[0].ToString() == "0")
            {
                customerId = result.Rows[0].ItemArray[1].ToString();
                return true;
            }
            customerId = "";
            return false;
        }

        public bool deleteCustomer(String id)
        {
            return customerDAT.deleteCustomer(id);
        }

        public bool updateCustomer(Customer c)
        {
            return customerDAT.updateCustomer(c);
        }
        public DataTable getListCustomerByName(string name)
        {
            return customerDAT.getListCustomerByName(name);
        }
        public DataTable getListCustomerById(string id)
        {
            return customerDAT.getListCustomerById(id);
        }
        public DataTable getListCustomerByNameAndId(string id, string name)
        {
            return customerDAT.getListCustomerByNameAndId(name, id);
        }
    }
}
