using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace NGANHANG_
{

    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        public static String server_publisher = "TIEN-TAI\\TRUSO";
        public static String servername = "";
        public static SqlConnection conn = new SqlConnection();
        public static String connstr;
        public static String connstr_publisher = "Data Source=" + Program.servername +
            ";Initial Catalog=NGANHANG;" +
            "Integrated Security=true";
        public static SqlDataAdapter da;
        public static SqlDataReader myReader;
        public static String username = "";
        public static String password = "";
        public static String mloginDN = "";
        public static String passwordDN = "";
        public static String database = "NGANHANG";
        public static String remotelogin = "HTKN";
        public static String remotepassword = "123";
        public static String mlogin = "";
        public static String mGroup = "";
        public static String mHoten = "";
        public static int mChinhanh = 0;

        public static BindingSource bds_dspm = new BindingSource();
        public static frmMain frMain;

        public static int KetNoi(bool security, bool reuse)
        {
            if (conn != null && conn.State == ConnectionState.Open)
                conn.Close();
            try
            {
                if (mlogin.Equals("sa") && !security)
                {
                    return -1;
                }
                connstr = "Data Source=" + Program.servername + ";Initial Catalog=" + database
                     + ";User ID =" + mlogin
                     + ";password=" + password;
                conn.ConnectionString = connstr;
                conn.Open();
                return 1;
            }
            catch (Exception e)
            {

                if (reuse) return 0;
                MessageBox.Show("Lỗi kết nối về CSDL gốc.\nKiểm tra lại username và password." + e.Message, "", MessageBoxButtons.OK);
                conn.Close();
                return 0;
            }
        }

        public static int KetNoiGoc()
        {

            connstr_publisher = "Data Source=" + Program.servername +
            ";Initial Catalog=NGANHANG;" +
            "Integrated Security=true";

            if (conn != null && conn.State == ConnectionState.Open)
                conn.Close();
            try
            {
                conn.ConnectionString = connstr_publisher;
                conn.Open();
                return 1;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối về CSDL gốc.\nKiểm tra lại tên Server và tên CSDL" + e.Message, "", MessageBoxButtons.OK);
                return 0;
            }

        }

        public static SqlDataReader ExecSqlDataReader(String strLenh)
        {
            //SqlDataReader myReader;
            SqlCommand cmd = new SqlCommand(strLenh, conn);
            cmd.CommandType = CommandType.Text;
            if (conn.State == ConnectionState.Open) conn.Close(); 
            if (conn.State == ConnectionState.Closed) conn.Open();

            try
            {
                myReader = cmd.ExecuteReader();
                return myReader;
            }
            catch (SqlException ex)
            {
                myReader.Close();
                conn.Close();
                MessageBox.Show(ex.Message);
                return null;
            }

        }

        public static int ExecSqlStoredProceduceValue(String strLenh, List<SqlParameter> parameters, CommandType type)
        {
            if (conn.State == ConnectionState.Open) conn.Close();
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlCommand cmd = new SqlCommand(strLenh, conn);
            if (parameters != null) cmd.Parameters.AddRange(parameters.ToArray());
            cmd.CommandType = type;
            cmd.CommandTimeout = 600;//secound

            try
            {
                return (int)cmd.ExecuteScalar();
            }
            catch (SqlException e)
            {
                MessageBox.Show("Error:" + e.Message);
                conn.Close();
                return e.State;//trạng thái lỗi gửi từ raiserror trong sql server qua
            }
        }

        public static SqlDataReader ExecSqlDataReader(String strLenh, List<SqlParameter> parameters, CommandType type)
        {

            SqlCommand cmd = new SqlCommand(strLenh, conn);
            if (parameters != null) cmd.Parameters.AddRange(parameters.ToArray());
            cmd.CommandType = type;
            if (conn.State == ConnectionState.Open) conn.Close();
            if (conn.State == ConnectionState.Closed) conn.Open();

            try
            {
                myReader = cmd.ExecuteReader();
                return myReader;
            }
            catch (SqlException e)
            {
                myReader.Close();
                conn.Close();
                MessageBox.Show(e.Message);
                return null;
            }

        }

        public static DataTable ExecSqlDataTable(String cmd)
        {
            DataTable dt = new DataTable();
            if (conn.State == ConnectionState.Closed) conn.Open();

            try
            {
                da = new SqlDataAdapter(cmd, conn);
                da.Fill(dt);
                return dt;
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }

        }

        public static int ExecSqlNonQuery(String strLenh)
        {
            SqlCommand cmd = new SqlCommand(strLenh, conn);
            cmd.CommandType = CommandType.Text;
            cmd.CommandTimeout = 600; //second
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                cmd.ExecuteNonQuery();
                conn.Close();
                return 0;
            }
            catch (SqlException e)
            {
                conn.Close();
                return e.State; //trạng thái lỗi gửi từ raiserror trong sql server qua
            }
        }

        public static int ExecSqlStoredProcedureValue(String strLenh, List<SqlParameter> parameters, CommandType type)
        {

            if (conn.State == ConnectionState.Closed) conn.Open();

            SqlCommand cmd = new SqlCommand(strLenh, conn);
            if (parameters != null) cmd.Parameters.AddRange(parameters.ToArray());
            cmd.CommandType = type;
            cmd.CommandTimeout = 600; //second

            using (conn)
            {
                try
                {
                    return (int)cmd.ExecuteScalar();
                }
                catch (SqlException e)
                {
                    MessageBox.Show("Error: " + e.Message);
                    return e.State; //trạng thái lỗi gửi từ raiserror trong sql server qua
                }
            }

        }

        public static Form CheckExists(Type ftype)
        {
            foreach (Form f in Application.OpenForms)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frMain = new frmMain();
            Application.Run(frMain);
        }

        public static int ExecSqlNonQuery(String strLenh, List<SqlParameter> parameters, CommandType type)
        {

            //Chỗ này lưu ý nhé: vì khi một connection đang mở thì mình phải tắt connection đó đi,
            ////rồi mở lại cái mới chứ không được sài cái connection đang mở đó
            ///vì cơ chế của C# là khi có cái mở sẵn, nó sẽ cho kết nối rồi một tí nó sẽ tự động tắt đi, nên mình phải chủ đọng trước
            ///câu này thầy thư có hỏi
            KetNoi(true, true); 
            if (conn.State == ConnectionState.Open) conn.Close();
                conn.Open();
            
            SqlCommand cmd = new SqlCommand(strLenh, conn);
            if (parameters != null) cmd.Parameters.AddRange(parameters.ToArray());
            cmd.CommandType = type;
            cmd.CommandTimeout = 600; //second

            using (conn)
            {
                try
                {
                    int value = cmd.ExecuteNonQuery();
                    conn.Close();
                    return value; 
                }
                catch (SqlException e)
                {
                    MessageBox.Show("Error: " + e.Message);
                    return e.State; //trạng thái lỗi gửi từ raiserror trong sql server qua
                }
            }
            /*if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                conn.Close();
                return cmd.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                conn.Close();
                MessageBox.Show("Error: " + e.Message);
                return e.State; //trạng thái lỗi gửi từ raiserror trong sql server qua
            }*/
        }
    }
}
