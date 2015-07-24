using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotelManage.DataTransferObject
{
    class ContractDetail
    {
        String id;

        public String Id
        {
            get { return id; }
            set { id = value; }
        }
        String contractid;

        public String Contractid
        {
            get { return contractid; }
            set { contractid = value; }
        }
        String serviceid;

        public String Serviceid
        {
            get { return serviceid; }
            set { serviceid = value; }
        }
    }
}
