using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NGANHANG_
{
    public partial class frmChuyenCN : Form
    {
        private string manv, diachi, sodt, macn;
        public string manv_new { get; set; }
        public int selectedIndex { get; set; }
        private SqlConnection conn_publisher = new SqlConnection();

        public frmChuyenCN()
        {
            InitializeComponent();
        }
        public frmChuyenCN(string manv, string diachi, string sodt) : this()
        {
            this.manv = manv;
            this.diachi = diachi;
            this.sodt = sodt;
        }
       
        private void cbChinhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbChinhanh.SelectedIndex == Program.mChinhanh)
            {
                lbThongbao.Text = "Nhân viên hiện đang thuộc chi nhánh này.";
                lbThongbao.Visible = true;
                //txtManv.Visible = false;
                return;
            }
            switch (cbChinhanh.SelectedIndex)
            {
                case 0:
                    macn = "BENTHANH";
                    break;
                case 1:
                    macn = "TANDINH";
                    break;
            }
            DataTable dt = new DataTable();
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            SqlDataReader sqlDataReader;
            sqlDataReader = Program.ExecSqlDataReader("SP_TIM_NV_TRONG_CN_KHAC",
                            new List<SqlParameter> { new SqlParameter("@DIACHI", diachi),
                                                    new SqlParameter("@SODT", sodt),
                                                    new SqlParameter("@MACN", macn)},
                            CommandType.StoredProcedure);
            if (!sqlDataReader.Read())
            {
                lbThongbao.Text = "Nhân viên chưa từng làm việc ở chi nhánh này!";
                lbThongbao.Visible = true;
                //txtManv.Visible = true;
                manv_new = "";
            }
            else
            {
                //sqlDataReader.Read();
                manv_new = sqlDataReader.GetString(0);
                lbThongbao.Text = "Nhân viên đã từng làm việc ở chi nhánh này với Mã NV là: " + manv_new;
            }
            sqlDataReader.Close();
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            //if (manv_new == "" && (manv_new = txtManv.Text.Trim()) == "")
            //{
            //    if (txtManv.Visible == true) MessageBox.Show("Vui lòng điền mã nhân viên mới");
            //    return;
            //}
            //if (txtManv.Visible == true)
            //{
            //    SqlDataReader sqlDataReader = Program.ExecSqlDataReader("sp_tim_nv",
            //                                        new List<SqlParameter> { new SqlParameter("@MANV", manv_new) },
            //                                        CommandType.StoredProcedure);
            //    if (sqlDataReader.Read())
            //    {
            //        MessageBox.Show("Mã nhân viên đã tồn tại");
            //        manv_new = "";
            //        sqlDataReader.Close();
            //        return;
            //    }
            //    sqlDataReader.Close();
            //}
            this.DialogResult = DialogResult.OK;
            selectedIndex = cbChinhanh.SelectedIndex;
        }

        private void frmChuyenCN_Load(object sender, EventArgs e)
        {
            if (KetNoi_CSDLGOC() == 0) return;
            LayDSPM("select * from Get_Subscribes");
            cbChinhanh.SelectedIndex = 1;
            cbChinhanh.SelectedIndex = 0;
        }


        private int KetNoi_CSDLGOC()
        {
            if (conn_publisher != null && conn_publisher.State == ConnectionState.Open)
                conn_publisher.Close();
            try
            {
                conn_publisher.ConnectionString = Program.connstr_publisher;
                conn_publisher.Open();
                return 1;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối về CSDL gốc.\nKiểm tra lại tên server và tên CSDL" + e.Message, "", MessageBoxButtons.OK);
                return 0;
            }

        }

        private void LayDSPM(String cmd)
        {
            DataTable dt = new DataTable();
            if (conn_publisher.State == ConnectionState.Closed) conn_publisher.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn_publisher);
            da.Fill(dt);
            conn_publisher.Close();
            cbChinhanh.DataSource = dt;
            cbChinhanh.DisplayMember = "TENCN";
            cbChinhanh.ValueMember = "TENSERVER";
        }
    }
}
