using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotelManage.DataTransferObject
{
    public class Customer
    {
        string id;
        bool flagCommit;
        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public bool Commit
        {
            get { return flagCommit; }
            set { flagCommit = value; }
        }

        string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        string cmnd;

        public string Cmnd
        {
            get { return cmnd; }
            set { cmnd = value; }
        }
        string phonenumber;

        public string Phonenumber
        {
            get { return phonenumber; }
            set { phonenumber = value; }
        }
        string address;

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public void reset()
        {
            address = "";
            name = "";
            id = "";
            phonenumber = "";
            cmnd = "";

        }
    }
}
