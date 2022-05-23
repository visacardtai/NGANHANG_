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
                return;
            }
            else
            {
                lbThongbao.Visible = false;
            }
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
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
