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
    public partial class frmGDGuiRut : Form
    {
        int sotk_pos;
        long soTienLonNhatCoTheRut = 0; 
        
        public frmGDGuiRut()
        {
            InitializeComponent();
        }

        private void taiKhoanBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.taiKhoanBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.KHACHHANGDS);
            
        }

        private void frmGDGuiRut_Load(object sender, EventArgs e)
        {
            loadTK();
            loadGD();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            /*try
            {
                this.giaoDichTableAdapter.Fill(this.KHACHHANGDS.GiaoDich, sOTKToolStripTextBox.Text, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(fROMDATEToolStripTextBox.Text, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(tODATEToolStripTextBox.Text, typeof(System.DateTime))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
*/
        }
        public void loadTK()
        {
            KHACHHANGDS.EnforceConstraints = false;
            this.taiKhoanTableAdapter.Connection.ConnectionString = Program.connstr;
            this.taiKhoanTableAdapter.Fill(this.KHACHHANGDS.TaiKhoan);


            panelControl1.Visible = false;
        }
        public void loadGD()
        {
            this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.nhanVienTableAdapter.Fill(this.KHACHHANGDS.NhanVien);
            this.giaoDichTableAdapter.Connection.ConnectionString = Program.connstr;
            if (taiKhoanBindingSource.Count > 0)
            {
                this.giaoDichTableAdapter.Fill(this.KHACHHANGDS.GiaoDich, ((DataRowView)taiKhoanBindingSource[taiKhoanBindingSource.Position])["SOTK"].ToString().Trim(),
                                                DateTime.Parse(((DataRowView)taiKhoanBindingSource[taiKhoanBindingSource.Position])["NGAYMOTK"].ToString().Trim()), DateTime.Now);
                btnLapGiaoDich.Enabled = true;
            }
            else
            {
                this.giaoDichTableAdapter.Fill(this.KHACHHANGDS.GiaoDich, null, null, null);
                btnLapGiaoDich.Enabled = false;
            }
            cmbLoaiGD.SelectedItem  = "Gởi tiền";
            giaoDichBindingSource.Filter = "LOAIGD='GT' OR LOAIGD='RT'";
            setupButton();
        }
        private void setupButton()
        {
            if (Program.mGroup == "NGANHANG")
            {
                btnLapGiaoDich.Enabled = false;
            }
            else
            {
                if (taiKhoanBindingSource.Count > 0)
                    btnLapGiaoDich.Enabled = true;
                else btnLapGiaoDich.Enabled = false;
            }
        }

        private void taiKhoanGridControl_Click(object sender, EventArgs e)
        {
            loadGD();
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnReLoad_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                loadTK();
                loadGD();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi reload: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnLapGiaoDich_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnLapGiaoDich.Enabled = btnReLoad.Enabled = false;
            panelControl1.Visible = true;
            sotk_pos = taiKhoanBindingSource.Position;                 //sotknhan luon trùng sotkchuyen lúc đầu để dễ kiểm lỗi trùng sotk
            txtSoTK.Text = ((DataRowView)taiKhoanBindingSource[taiKhoanBindingSource.Position])["SOTK"].ToString().Trim();
            String soduHienTai = ((DataRowView)taiKhoanBindingSource[taiKhoanBindingSource.Position])["SODU"].ToString().Trim().Replace(",", ""); 
            soTienLonNhatCoTheRut =long.Parse(soduHienTai.Substring(0, soduHienTai.Length - 5));
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            try
            {
                string sotk = "";
                DateTime ngaygd = DateTime.Now;
                string manv = Program.username;
                
                sotk = txtSoTK.Text.ToString();
                string loaigd ="GT";
                float sotien = float.Parse(txtSoTien.Text.Trim());                  //số tiền gởi/rút phải ít nhất 100,000
                if (cmbLoaiGD.SelectedIndex==-1)
                {
                    MessageBox.Show("Vui lòng chọn loại giao dịch.", "", MessageBoxButtons.OK);
                    return;
                }
                if (sotien < 100000)
                {
                    MessageBox.Show("Số tiền phải >= "+ string.Format("{0:#,00}", Convert.ToDecimal(100000)) + " VND", "", MessageBoxButtons.OK);
                    return;
                }
                if (cmbLoaiGD.SelectedIndex==1 && sotien>soTienLonNhatCoTheRut)//kiểm tra số tiền tôi đa được rút
                {
                    MessageBox.Show("Số tiền tối đa có thể rút là: "+ string.Format("{0:#,00}", Convert.ToDecimal(soTienLonNhatCoTheRut)) + " VND", "", MessageBoxButtons.OK);
                    return;
                }

                switch (cmbLoaiGD.SelectedIndex)
                {
                    case 0:
                        loaigd = "GT";
                        break;
                    case 1:
                        loaigd = "RT";
                        break;
                }

                if (Program.ExecSqlNonQuery("SP_GIAO_DICH_GOI_RUT",
                                        new List<SqlParameter> { new SqlParameter("@SOTK", sotk),
                                                                new SqlParameter("@LOAIGD", loaigd),
                                                                new SqlParameter("@SOTIEN", sotien),
                                                                new SqlParameter("@MANV", manv),
                                                                new SqlParameter("@NGAYGD", ngaygd)},
                                        CommandType.StoredProcedure) == 2)
                {
                    MessageBox.Show("Giao dịch thành công.");
                    loadTK();
                    taiKhoanBindingSource.Position = sotk_pos;
                    loadGD();
                    btnLapGiaoDich.Enabled = btnReLoad.Enabled = true;
                    panelControl1.Visible = false;
                    txtSoTK.Text = txtSoTien.Text = "";
                }
                else
                {

                    MessageBox.Show("Giao dịch thất bại.");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra\nError: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            btnLapGiaoDich.Enabled = btnReLoad.Enabled = true;
            panelControl1.Visible = false;
            txtSoTK.Text = txtSoTien.Text = "";
        }

        private void cmbLoaiGD_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
