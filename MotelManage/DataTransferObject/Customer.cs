using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotelManage.DataTransferObject
{
    public class Customer
    {
        String id;
        Boolean flagCommit;
        public String Id
        {
            get { return id; }
            set { id = value; }
        }

        public Boolean Commit
        {
            get { return flagCommit; }
            set { flagCommit = value; }
        }

        String name;

        public String Name
        {
            get { return name; }
            set { name = value; }
        }
        String cmnd;

        public String Cmnd
        {
            get { return cmnd; }
            set { cmnd = value; }
        }
        int phonenumber;

        public int Phonenumber
        {
            get { return phonenumber; }
            set { phonenumber = value; }
        }
        String adress;

        public String Adress
        {
            get { return adress; }
            set { adress = value; }
        }

        public void reset()
        {
            adress = "";
            name = "";
            id = "";
            phonenumber = 0;
            cmnd = "";

        }
    }
}
