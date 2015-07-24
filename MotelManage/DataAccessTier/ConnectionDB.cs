using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotelManage.DataAccessTier
{

    public class ConnectionDB
    {
        SqlConnection connection;

        public ConnectionDB()
        {
            connection = new SqlConnection();
        }
        #region tao ket noi csdl, xac dinh chuoi ket noi

        public SqlConnection CreateConnect()
        {
            return new SqlConnection(@"Server=NGUYENVANUY\SQLEXPRESS;Initial Catalog=db_motel;Integrated Security=True;MultipleActiveResultSets=True;User Instance=False;Context Connection=False;Connect Timeout=300;");
        }
        #endregion
    }
}
