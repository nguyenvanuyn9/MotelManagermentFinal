using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MotelManage.DataAccessTier
{
    public class DataBases
    {
        private ConnectionDB _cnn = new ConnectionDB();
        private SqlCommand Cmd;
        public DataBases() { }

        #region ham thuc hien bang ExecuteNonQuery
        public int ExecuteNonQuery(string ProcedureName)
        {
            int _Result;
            SqlConnection Cnn = _cnn.CreateConnect();

            Cmd = new SqlCommand(ProcedureName, Cnn);

            Cnn.Open();

            //phan nay dung de kiem tra neu xay ra loi trong khi thao tac voi csdl thi no se khoi phuc lai du lieu ban dau truoc khi chung ta chua thao tac len csdl 
            using (SqlTransaction _Transaction = Cnn.BeginTransaction())
            {
                try
                {
                    Cmd.Transaction = _Transaction; // gan lenh vao cmd de thuc hien lenh phuc hoi du lieu khi co loi xay ra
                    _Result = Cmd.ExecuteNonQuery();
                    _Transaction.Commit(); // du lieu se duoc gan tam vao 1 table ,neu khong co loi thi no se dc gan vao csdl ,neu loi thi table nay se huy ->khong anh huong dendu lieu trong csdl 
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _Transaction.Rollback(); // xay ra loi se khoi phuc lai du lieu ban dau
                    throw;
                }
                finally
                {
                    if (Cnn.State == ConnectionState.Open)
                        Cnn.Close();
                    Cnn.Dispose();
                    Cmd.Dispose();
                }
            }
            return _Result;
        }
        #endregion

        #region ham thuc hien bang ExecuteNonQuery co parameters

        public int ExecuteNonQuery(string ProcedureName, SqlParameter[] _Paramater)
        {
            int _Result;
            SqlConnection Cnn = _cnn.CreateConnect();

            Cmd = new SqlCommand(ProcedureName, Cnn);

            if (_Paramater != null)
                Cmd.Parameters.AddRange(_Paramater);
            Cnn.Open();
            //phan nay dung de kiem tra neu xay ra loi trong khi thao tac voi csdl thi no se khoi phuc lai du lieu ban dau truoc khi chung ta chua thao tac len csdl 
            using (SqlTransaction _Transaction = Cnn.BeginTransaction())
            {
                try
                {
                    Cmd.Transaction = _Transaction;
                    _Result = Cmd.ExecuteNonQuery();
                    _Transaction.Commit();
                }
                catch
                {
                    //MessageBox.Show(ex.Message, "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _Transaction.Rollback();
                    return 0;
                    //throw;
                }
                finally
                {
                    if (Cnn.State == ConnectionState.Open)
                        Cnn.Close();
                    Cnn.Dispose();
                    Cmd.Dispose();
                }
            }
            return _Result;
        }
        #endregion

        #region  Ham Thuc hien bang ExecuteScalar
        public object ExecuteScalar(String procedureName)
        {
            SqlConnection Cnn = _cnn.CreateConnect();
            Cmd = new SqlCommand(procedureName, Cnn);

            object _ReturnValue;

            Cnn.Open();
            //phan nay dung de kiem tra neu xay ra loi trong khi thao tac voi csdl thi no se khoi phuc lai du lieu ban dau truoc khi chung ta chua thao tac len csdl 
            using (SqlTransaction _Transaction = Cnn.BeginTransaction())
            {
                try
                {
                    Cmd.Transaction = _Transaction;
                    _ReturnValue = Cmd.ExecuteScalar();
                    _Transaction.Commit();
                }
                catch
                {
                    _Transaction.Rollback();
                    throw;
                }
                finally
                {
                    if (Cnn.State == ConnectionState.Open)
                        Cnn.Close();
                    Cnn.Dispose();
                    Cmd.Dispose();
                }
            }
            return _ReturnValue;
        }
        #endregion

        #region ham thuc hien bang ExecuteScalar co Parameters
        public object ExecuteScalar(String procedureName, SqlParameter[] parameters)
        {
            SqlConnection Cnn = _cnn.CreateConnect();
            Cmd = new SqlCommand(procedureName, Cnn);

            object _ReturnValue;

            Cnn.Open();

            //phan nay dung de kiem tra neu xay ra loi trong khi thao tac voi csdl thi no se khoi phuc lai du lieu ban dau truoc khi chung ta chua thao tac len csdl 
            using (SqlTransaction _Transaction = Cnn.BeginTransaction())
            {
                try
                {
                    if (parameters != null)
                        Cmd.Parameters.AddRange(parameters);

                    Cmd.Transaction = _Transaction;

                    _ReturnValue = Cmd.ExecuteScalar();

                    _Transaction.Commit();

                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _Transaction.Rollback();
                    throw;
                }
                finally
                {
                    if (Cnn.State == ConnectionState.Open)
                        Cnn.Close();
                    Cnn.Dispose();
                    Cmd.Dispose();
                }
            }
            return _ReturnValue;
        }


        #endregion

        #region ham thuc hien truy van bang ExeuteScalar tra ve 1 mang cac doi tuong Object

        public object[] ExecuteScalar(String[] procedureName, SqlParameter[] parameters)
        {
            SqlConnection Cnn = _cnn.CreateConnect();
            Cmd = new SqlCommand(procedureName[0], Cnn);
            Cnn.Open();
            object[] info = null;
            try
            {
                if (parameters != null)
                    Cmd.Parameters.AddRange(parameters);
                SqlDataReader sqlDataReader;
                sqlDataReader = Cmd.ExecuteReader();
                if (sqlDataReader.Read())
                {
                    info = new object[sqlDataReader.FieldCount];
                    sqlDataReader.GetValues(info);
                }
                sqlDataReader.Close();
                sqlDataReader.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                if (Cnn.State == ConnectionState.Open)
                    Cnn.Close();
                Cnn.Dispose();
                Cmd.Dispose();
            }

            return info;
        }
        #endregion

        #region hien thi du lieu len textbox co Parameters
        public void LoadDataTextbox(string procedureName, TextBox[] ArrayTextbox, string name, string _Parameters)
        {
            SqlConnection Cnn = _cnn.CreateConnect();
            Cmd = new SqlCommand(procedureName, Cnn);

            Cnn.Open();
            Cmd.Parameters.Add(new SqlParameter(name, _Parameters));
            SqlDataReader Dr = Cmd.ExecuteReader();

            try
            {
                if (Dr.Read())
                {
                    int _index = 0;
                    foreach (TextBox txt in ArrayTextbox)
                    {
                        txt.Text = Dr[_index].ToString();
                        _index++;
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (Cnn.State == ConnectionState.Open)
                    Cnn.Close();
                Cnn.Dispose();
                Cmd.Dispose();
            }
        }
        #endregion

        #region ham lay du lieu len textbox truyen vao mang parameters

        internal void LoadDataTextbox(string procedureName, TextBox[] ArrayTextbox, SqlParameter[] _Parameters)
        {
            SqlConnection Cnn = _cnn.CreateConnect();
            Cmd = new SqlCommand(procedureName, Cnn);
            Cnn.Open();

            // Cmd.Parameters.Add(new SqlParameter("@_TenDangNhap", _Parameters));
            if (_Parameters != null)
                Cmd.Parameters.AddRange(_Parameters);

            SqlDataReader Dr = Cmd.ExecuteReader();

            try
            {
                if (Dr.Read())
                {
                    int _index = 0;
                    foreach (TextBox txt in ArrayTextbox)
                    {
                        txt.Text = Dr[_index].ToString();
                        _index++;
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (Cnn.State == ConnectionState.Open)
                    Cnn.Close();
                Cnn.Dispose();
                Cmd.Dispose();
            }
        }
        #endregion

        #region ham do du lieu vao table
        public DataTable LoadDataTable(string ProcedureName)
        {
            SqlConnection Cnn = _cnn.CreateConnect();
            Cmd = new SqlCommand(ProcedureName, Cnn);

            SqlDataAdapter Da = new SqlDataAdapter();
            Da.SelectCommand = Cmd;
            DataTable tb = new DataTable();
            Cnn.Open();
            //phan nay dung de kiem tra neu xay ra loi trong khi thao tac voi csdl thi no se khoi phuc lai du lieu ban dau truoc khi chung ta chua thao tac len csdl 
            using (SqlTransaction _Transaction = Cnn.BeginTransaction())
            {
                try
                {
                    Da.SelectCommand.Transaction = _Transaction;
                    Da.Fill(tb);
                    _Transaction.Commit();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _Transaction.Rollback();
                    throw;
                }
                finally
                {
                    if (Cnn.State == ConnectionState.Open)
                        Cnn.Close();
                    Cnn.Dispose();
                    Cmd.Dispose();
                }
            }
            return tb;
        }
        #endregion

        #region ham do du lieu vao table co parameters
        public DataTable LoadDataTable(string ProcedureName, SqlParameter[] _Parameters)
        {
            SqlConnection Cnn = _cnn.CreateConnect();
            Cmd = new SqlCommand(ProcedureName, Cnn);

            DataTable dt = new DataTable();

            if (_Parameters != null)
                Cmd.Parameters.AddRange(_Parameters);

            SqlDataAdapter Da = new SqlDataAdapter();
            Da.SelectCommand = Cmd;
            Cnn.Open();
            //phan nay dung de kiem tra neu xay ra loi trong khi thao tac voi csdl thi no se khoi phuc lai du lieu ban dau truoc khi chung ta chua thao tac len csdl 
            using (SqlTransaction _Transaction = Cnn.BeginTransaction())
            {
                try
                {
                    Da.SelectCommand.Transaction = _Transaction;
                    Da.Fill(dt);
                    _Transaction.Commit();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _Transaction.Rollback();
                }
                finally
                {
                    if (Cnn.State == ConnectionState.Open)
                        Cnn.Close();
                    Cnn.Dispose();
                    Cmd.Dispose();
                }
            }
            return dt;
        }
        #endregion

        #region Load du lieu vao combobox
        public DataSet LoadComBox(string procedureName)
        {
            SqlConnection Cnn = _cnn.CreateConnect();

            SqlCommand cm = new SqlCommand(procedureName, Cnn);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataSet ds = new DataSet();

            try
            {
                da.Fill(ds);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (Cnn.State == ConnectionState.Open)
                    Cnn.Close();
                Cnn.Dispose();
                cm.Dispose();
            }
            return ds;
        }
        #endregion

        #region Load du lieu vao combobox co parameters
        public DataSet LoadComBox(string procedureName, SqlParameter[] _Parameters)
        {
            SqlConnection Cnn = _cnn.CreateConnect();

            SqlCommand cm = new SqlCommand(procedureName, Cnn);

            if (_Parameters != null)
                cm.Parameters.AddRange(_Parameters);

            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataSet ds = new DataSet();

            try
            {
                da.Fill(ds);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (Cnn.State == ConnectionState.Open)
                    Cnn.Close();
                Cnn.Dispose();
                cm.Dispose();
            }
            return ds;
        }
        #endregion

        #region Insert Customer Procedure
        public int Update(string ProcedureName,
             string[] name,
             object[] value,
             int parameters)
        {
            int _Result;
            SqlConnection Cnn = _cnn.CreateConnect();

            Cmd = new SqlCommand(ProcedureName, Cnn)
            {
                CommandType = CommandType.StoredProcedure
            };

            Cnn.Open();

            //phan nay dung de kiem tra neu xay ra loi trong khi thao tac voi csdl thi no se khoi phuc lai du lieu ban dau truoc khi chung ta chua thao tac len csdl 
            using (SqlTransaction _Transaction = Cnn.BeginTransaction())
            {
                try
                {
                    Cmd.Transaction = _Transaction; // gan lenh vao cmd de thuc hien lenh phuc hoi du lieu khi co loi xay ra
                    for (int i = 0; i < parameters; i++)
                    {
                        Cmd.Parameters.AddWithValue(name[i], value[i]);
                    }
                    _Result = Cmd.ExecuteNonQuery();
                    _Transaction.Commit(); // du lieu se duoc gan tam vao 1 table ,neu khong co loi thi no se dc gan vao csdl ,neu loi thi table nay se huy ->khong anh huong dendu lieu trong csdl 
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _Transaction.Rollback(); // xay ra loi se khoi phuc lai du lieu ban dau
                    throw;
                }
                finally
                {
                    if (Cnn.State == ConnectionState.Open)
                        Cnn.Close();
                    Cnn.Dispose();
                    Cmd.Dispose();
                }
            }
            return _Result;
        }
        #endregion

        #region ham do du lieu vao table bang procedure
        public DataTable LoadDataTableWithProcedure(string ProcedureName)
        {
            SqlConnection Cnn = _cnn.CreateConnect();
            Cmd = new SqlCommand(ProcedureName, Cnn) { CommandType = CommandType.StoredProcedure };

            SqlDataAdapter Da = new SqlDataAdapter();
            Da.SelectCommand = Cmd;
            DataTable tb = new DataTable();
            Cnn.Open();
            //phan nay dung de kiem tra neu xay ra loi trong khi thao tac voi csdl thi no se khoi phuc lai du lieu ban dau truoc khi chung ta chua thao tac len csdl 
            using (SqlTransaction _Transaction = Cnn.BeginTransaction())
            {
                try
                {
                    Da.SelectCommand.Transaction = _Transaction;
                    Da.Fill(tb);
                    _Transaction.Commit();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _Transaction.Rollback();
                    throw;
                }
                finally
                {
                    if (Cnn.State == ConnectionState.Open)
                        Cnn.Close();
                    Cnn.Dispose();
                    Cmd.Dispose();
                }
            }
            return tb;
        }
        #endregion

        #region ham do du lieu vao table  bang procedure co parameters
        public DataTable LoadDataTableWithProAndPara(string ProcedureName, SqlParameter[] _Parameters)
        {
            SqlConnection Cnn = _cnn.CreateConnect();
            Cmd = new SqlCommand(ProcedureName, Cnn) { CommandType = CommandType.StoredProcedure };

            DataTable dt = new DataTable();

            if (_Parameters != null)
                Cmd.Parameters.AddRange(_Parameters);

            SqlDataAdapter Da = new SqlDataAdapter();
            Da.SelectCommand = Cmd;
            Cnn.Open();
            //phan nay dung de kiem tra neu xay ra loi trong khi thao tac voi csdl thi no se khoi phuc lai du lieu ban dau truoc khi chung ta chua thao tac len csdl 
            using (SqlTransaction _Transaction = Cnn.BeginTransaction())
            {
                try
                {
                    Da.SelectCommand.Transaction = _Transaction;
                    Da.Fill(dt);
                    _Transaction.Commit();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _Transaction.Rollback();
                }
                finally
                {
                    if (Cnn.State == ConnectionState.Open)
                        Cnn.Close();
                    Cnn.Dispose();
                    Cmd.Dispose();
                }
            }
            return dt;
        }
        #endregion

        #region Vùng thiết lập gọi Store Procedure của Uy
        public DataTable SelectStoreProcedure(string ProcedureName,
             string[] name,
             object[] value)
        {
            SqlConnection con = _cnn.CreateConnect();
            DataTable dt = new DataTable();
            Cmd = new SqlCommand();
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.CommandText = ProcedureName;

            for (int i = 0; i < name.Length; i++)
            {
                Cmd.Parameters.AddWithValue(name[i], value[i]);
            }
            Cmd.Connection = con;

            try
            {
                con.Open();
                dt.Load(Cmd.ExecuteReader());
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
            return dt;
        }

        public DataTable ExcuteStoreProcedure(string ProcedureName,
            string[] name,
            object[] value)
        {
            SqlConnection con = _cnn.CreateConnect();
            DataTable dt = new DataTable();
            Cmd = new SqlCommand();
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.CommandText = ProcedureName;

            for (int i = 0; i < name.Length; i++)
            {
                Cmd.Parameters.AddWithValue(name[i], value[i]);
            }
            Cmd.Connection = con;

            try
            {
                using (SqlDataAdapter sda = new SqlDataAdapter(Cmd))
                {
                    sda.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
            return dt;
        }
        #endregion

        public DataTable LoadDataTableStoreProcedure(string ProcedureName, SqlParameter[] _Parameters)
        {
            SqlConnection Cnn = _cnn.CreateConnect();
            Cmd = new SqlCommand(ProcedureName, Cnn);
            Cmd.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();

            if (_Parameters != null)
                Cmd.Parameters.AddRange(_Parameters);

            SqlDataAdapter Da = new SqlDataAdapter();
            Da.SelectCommand = Cmd;
            Cnn.Open();
            //phan nay dung de kiem tra neu xay ra loi trong khi thao tac voi csdl thi no se khoi phuc lai du lieu ban dau truoc khi chung ta chua thao tac len csdl 
            using (SqlTransaction _Transaction = Cnn.BeginTransaction())
            {
                try
                {
                    Da.SelectCommand.Transaction = _Transaction;
                    Da.Fill(dt);
                    _Transaction.Commit();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _Transaction.Rollback();
                }
                finally
                {
                    if (Cnn.State == ConnectionState.Open)
                        Cnn.Close();
                    Cnn.Dispose();
                    Cmd.Dispose();
                }
            }
            return dt;
        }
    }
}
