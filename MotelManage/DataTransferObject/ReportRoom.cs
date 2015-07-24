using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotelManage.DataTransferObject
{
    class ReportRoom
    {
        String id;

        public String Id
        {
            get { return id; }
            set { id = value; }
        }
        String date;

        public String Date
        {
            get { return date; }
            set { date = value; }
        }
        int numberEmpty;

        public int NumberEmpty
        {
            get { return numberEmpty; }
            set { numberEmpty = value; }
        }
        int numberberusing;

        public int Numberberusing
        {
            get { return numberberusing; }
            set { numberberusing = value; }
        }
    }
}
