using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NGANHANG_
{
    public partial class frmNV : Form
    {
        
        int vitri = 0;
        public frmNV()
        {
            InitializeComponent();
        }

        private void nhanVienBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nhanVienBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void frmNV_Load(object sender, EventArgs e)
        {


            //LOAD DANH SÁCH CHI NHÁNH VÀO CMOBOBOX
            cmbChinhanh.DataSource = Program.bds_dspm;
            cmbChinhanh.DisplayMember = "TENCN";
            cmbChinhanh.ValueMember = "TENSERVER";
            cmbChinhanh.SelectedIndex = Program.mChinhanh;

            if (Program.mGroup.Equals("ChiNhanh"))
            {
                cmbChinhanh.Enabled = false; 
            }else if (Program.mGroup.Equals("NganHang"))
            {
                gridView1.OptionsBehavior.Editable = false; 
            }
            LoadNhanvien();

        }


        private void btnExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (nhanVienBindingSource.Count > 0)
            {


                string manhanvien = gridView1.GetRowCellValue(gridView1.DataRowCount - 1, "MANV").ToString();
                if (manhanvien.Equals(""))
                {
                    MessageBox.Show("Bạn phải hoàn tất thao tác trước đó!", "Cảnh báo!", MessageBoxButtons.OK);
                    return;
                }
            }

            nhanVienBindingSource.AddNew();






            if (cmbChinhanh.SelectedIndex == 0)
            {
                gridView1.SetFocusedRowCellValue("MACN", "BENTHANH");
            }
            else if (cmbChinhanh.SelectedIndex == 1)
            {
                gridView1.SetFocusedRowCellValue("MACN", "TANDINH");
            }

            //quan trọng: để chương trình không tự báo lỗi.
            gridView1.SetFocusedRowCellValue("MANV", "MNV0");
            
            if(layRaMaNhanvienLonNhat() + 1 < 100)
            {
                gridView1.SetFocusedRowCellValue("MANV", "MNV0" + (layRaMaNhanvienLonNhat() + 1));
            }
            else
            {
                gridView1.SetFocusedRowCellValue("MANV", "MNV" + layRaMaNhanvienLonNhat() + 1);
            }
            gridView1.SetFocusedRowCellValue("HO", "");
            gridView1.SetFocusedRowCellValue("TEN", "");
            gridView1.SetFocusedRowCellValue("TrangThaiXoa",0);
            gridView1.SetFocusedRowCellValue("PHAI", "Nữ");



            //quan trọng, nhấm đánh dấu là đã được tồn tại
            gridView1.FocusedRowHandle = gridView1.DataRowCount;


        }


        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
            string manhanvien = gridView1.GetRowCellValue(gridView1.RowCount - 1, "MANV").ToString();
            string ho = gridView1.GetRowCellValue(gridView1.RowCount - 1, "HO").ToString();
            string ten = gridView1.GetRowCellValue(gridView1.RowCount - 1, "TEN").ToString();
            string phai = gridView1.GetRowCellValue(gridView1.RowCount - 1, "PHAI").ToString();
            string diachi = gridView1.GetRowCellValue(gridView1.RowCount - 1, "DIACHI").ToString();

            if (kiemTraThongTinNVKhongBiTrong(manhanvien, ho, ten, phai, diachi) == true) return;
            if (phai.Trim().ToLower().Equals("nam")) gridView1.SetRowCellValue(gridView1.RowCount - 1, "PHAI", "Nam");
            else if (phai.Trim().ToLower().Equals("nữ")) gridView1.SetRowCellValue(gridView1.RowCount - 1, "PHAI", "Nữ");
            try
            {
                this.Validate();
                this.nhanVienBindingSource.EndEdit();
                this.nhanVienTableAdapter.Update(this.dS.NhanVien);
                gridView1.ClearColumnErrors();


                MessageBox.Show("Lưu dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm nhân viên thất bại!", "Thông báo!", MessageBoxButtons.OK);
            }

        }
        private bool kiemTraThongTinNVKhongBiTrong(string manv, string ho, string ten, string phai, string diachi)
        {
            if (manv.Trim().Equals(""))
            {
                MessageBox.Show("Mã nhân viên không được rỗng", "Cảnh báo!", MessageBoxButtons.OK);
                return true;
            }
            else if (ho.Trim().Equals(""))
            {
                MessageBox.Show("Họ nhân viên không được rỗng!", "Cảnh báo!", MessageBoxButtons.OK);
                return true;
            }
            else if (ten.Trim().Equals(""))
            {
                MessageBox.Show("Tên nhân viên không được rỗng!", "Cảnh báo!", MessageBoxButtons.OK);
                return true;
            }
            else if (phai.Trim().Equals(""))
            {
                MessageBox.Show("Phái nhân viên không được rỗng!", "Cảnh báo!", MessageBoxButtons.OK);
                return true;
            }
            else if (diachi.Trim().Equals(""))
            {
                MessageBox.Show("Địa chỉ nhân viên không được rỗng!", "Cảnh báo!", MessageBoxButtons.OK);
                return true;
            }
            return false;

        }


        private void cmbChinhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbChinhanh.SelectedValue.ToString() != "System.Data.DataRowView")
                {
                    Program.servername = cmbChinhanh.SelectedValue.ToString();
                }
                if (cmbChinhanh.SelectedIndex != Program.mChinhanh)
                {
                    Program.mlogin = Program.remotelogin;
                    Program.password = Program.remotepassword;
                }
                else
                {
                    Program.mlogin = Program.mloginDN;
                    Program.password = Program.passwordDN;
                }

                if (Program.KetNoi(true, true) == 0)
                {
                    MessageBox.Show("Lỗi chuyển chi nhánh", "Thông báo !", MessageBoxButtons.OK);
                    return;
                }
                else
                {
                    try
                    {
                        LoadNhanvien();
                     

                    }
                    catch (Exception) { }
                }


            }
            catch
            {
                return;
            }
        }
        private void LoadNhanvien()
        {
           // this.dS.EnforceConstraints = false;
            this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.nhanVienTableAdapter.Fill(this.dS.NhanVien);
            //this.nhanVienBindingSource.Filter = "TrangThaiXoa= 0 ";
            
            this.gD_GOIRUTTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gD_GOIRUTTableAdapter.Fill(this.dS.GD_GOIRUT);

            this.gD_CHUYENTIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gD_CHUYENTIENTableAdapter.Fill(this.dS.GD_CHUYENTIEN);

            if (Program.mGroup == "NganHang")
            {
                cmbChinhanh.Enabled = true;
                btnThem.Enabled = btnXoa.Enabled = btnReload.Enabled = btnPhuchoi.Enabled = btnLuu.Enabled = btnChuyenCN.Enabled = false;
            }
            

        }

        private void btnPhuchoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            nhanVienBindingSource.CancelEdit();
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            //điều kiện để xóa nhân viên là: nhân viên chưa từng thực hiện giao dịch
            if (gD_CHUYENTIENBindingSource.Count > 0 || gD_GOIRUTBindingSource.Count > 0)
            {
                MessageBox.Show("Không thể xoá nhân viên này vì đã thực hiện giao dịch ", "", MessageBoxButtons.OK);
                return;
            }

            if (MessageBox.Show("Bạn thực sự muốn xoá nhân viên này?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {

                    nhanVienBindingSource.RemoveCurrent();
                    this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.nhanVienTableAdapter.Update(this.dS.NhanVien);
                    MessageBox.Show("Xoá nhân viên thành công.", "", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xoá nhân viên.\n" + ex.Message, "", MessageBoxButtons.OK);
                    this.nhanVienTableAdapter.Fill(this.dS.NhanVien);
                    return;
                }
            }
        }

        private void nhanVienGridControl_Click(object sender, EventArgs e)
        {
            string trangthaixoa = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TrangThaiXoa").ToString();
            if (trangthaixoa.Trim().Equals("0"))
            {
                btnChuyenCN.Enabled = true;
                lbthongbaonv.Visible = false; 

            }else
            {
                btnChuyenCN.Enabled = false;
                lbthongbaonv.Visible = true;
            }
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadNhanvien();
            MessageBox.Show("Load danh sách nhân viên thành công!");
        }

   



        private void btnChuyenCN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string manv = ((DataRowView)nhanVienBindingSource[nhanVienBindingSource.Position])["MANV"].ToString().Trim();
            string diachi = ((DataRowView)nhanVienBindingSource[nhanVienBindingSource.Position])["DIACHI"].ToString().Trim();
            string sodt = ((DataRowView)nhanVienBindingSource[nhanVienBindingSource.Position])["SODT"].ToString().Trim();
            string macn_new = "";
            using (frmChuyenCN frm = new frmChuyenCN(manv, diachi, sodt))
            {
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {

                    switch (frm.selectedIndex)
                    {
                        case 0:
                            macn_new = "BENTHANH";
                            break;
                        case 1:
                            macn_new = "TANDINH";
                            break;
                    }
                    //lấy ra mã nhân viên lớn nhất ở site chủ: 
                    
                    string manv_moi = "";
                    if (frm.manv_new.Equals("") == false)
                    {
                        manv_moi = frm.manv_new; 
                    }else
                    {
                        int maNVLonNhat = layRaMaNhanvienLonNhatTaiSiteChu();
                        manv_moi = (maNVLonNhat + 1) < 100 ? ("MNV0" + (maNVLonNhat + 1)) : ("MNV" + (maNVLonNhat + 1)); 
                    }
                    var status = Program.ExecSqlNonQuery("SP_CHUYEN_CN",
                                        new List<SqlParameter> { new SqlParameter("@MANV", manv.Trim()),
                                                                new SqlParameter("@MANV2", manv_moi),
                                                                new SqlParameter("@MACN", macn_new.Trim())},
                                        CommandType.StoredProcedure);
                    if (status == 2)
                    {

                        MessageBox.Show("Chuyển chi nhánh thành công.");
                        vitri = nhanVienBindingSource.Position;
                        btnReload.PerformClick();
                        nhanVienBindingSource.Position = vitri;
                    }
                    else
                    {
                        MessageBox.Show("Lỗi thực thi quá trình chuyển chi nhánh. " + status + "-" + manv + "-" + frm.manv_new + "-" + macn_new);
                    }
                }
            }
            LoadNhanvien();
        }

        //kiểm tra mỗi khi chuyển sang ô khác

        private void gridView1_ValidatingEditor_1(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            if (gridView1.FocusedColumn.FieldName == "MANV")
            {
                string manv = e.Value as string;
                if (manv.Equals(""))
                {
                    e.Valid = false;
                    e.ErrorText = "Mã nhân viên bị rỗng";
                    MessageBox.Show(this, "Mã nhân viên bị rỗng!", "Cảnh báo!", MessageBoxButtons.OK);
                    return;
                }
                if (kiemTraMaNhanvienTrung(manv) == 1)
                {
                    e.Valid = false;
                    e.ErrorText = "Mã nhân viên bị trùng ở chi nhánh khác";
                    MessageBox.Show(this, "Mã nhân viên bị trùng ở chi nhánh khác!", "Cảnh báo!", MessageBoxButtons.OK);
                    return;
                }


            }
            else if (gridView1.FocusedColumn.FieldName == "PHAI")
            {
                string phai = e.Value as string;
                if (!phai.Trim().ToLower().Equals("nam") && !phai.Trim().ToLower().Equals("nữ"))
                {
                    e.Valid = false;
                    e.ErrorText = "Phái phải là Nam/Nữ ";
                    MessageBox.Show(this, "Phái phải là Nam/Nữ!", "Cảnh báo!", MessageBoxButtons.OK);
                    return;
                }
            }
            else if (gridView1.FocusedColumn.FieldName == "DIACHI")
            {
                string diachi = e.Value as string;
                if (diachi.Trim().Equals(""))
                {
                    e.Valid = false;
                    e.ErrorText = "Địa chỉ nhập vào không được rỗng";
                    MessageBox.Show(this, "Địa chỉ nhập vào không được rỗng", "Cảnh báo!", MessageBoxButtons.OK);
                    return;
                }
            }
            else if (gridView1.FocusedColumn.FieldName == "SODT")
            {
                string sodt = e.Value as string;
                if (!Regex.IsMatch(sodt.Trim(), "^0[0-9]{9}$"))
                {
                    e.Valid = false;
                    e.ErrorText = "Số điện thoại nhập vào phải đúng định dạng";
                    MessageBox.Show(this, "Số điện thoại nhập vào phải đúng định dạng", "Cảnh báo!", MessageBoxButtons.OK);
                    return;
                }
            }
        }

        private int kiemTraMaNhanvienTrung(string value)
        {


            string queryName = "DECLARE @return_value int "
               + "EXEC @return_value = [dbo].[KIEM_TRA_MA_NV_TRUNG] @Ma = N'" + value + "' SELECT  'Return Value' = @return_value";
            SqlDataReader ketqua = Program.ExecSqlDataReader(queryName);

            if (ketqua == null)
            {
                MessageBox.Show("Server bị lỗi");
                ketqua.Close();
                return -1;
            }
            ketqua.Read();
            int giatri = ketqua.GetInt32(0);
            ketqua.Close();
            return giatri; //0: không trùng; 1: trùng
        }
        private int layRaMaNhanvienLonNhat()
        {
            int max = 0;
            for (int i = 0; i < nhanVienBindingSource.Count; i++)
            {
                string manv = ((DataRowView)nhanVienBindingSource[i])["MANV"].ToString().Trim();
                int manvTamthoi = int.Parse(manv.Substring(3).Trim()); 
                if (manvTamthoi > max)
                {
                    max = manvTamthoi; 
                }
            }

            string queryName = "DECLARE @return_value int "
                   + "EXEC    @return_value = [dbo].[SP_TIM_MANV_LON_NHAT_CN_KHAC]" + "SELECT  'Return Value' = @return_value";
            SqlDataReader ketqua = Program.ExecSqlDataReader(queryName);

            if (ketqua == null)
            {
                MessageBox.Show("Server bị lỗi");
                ketqua.Close();
                return -1;
            }
            ketqua.Read();
            String manvSiteConLai = ketqua.GetString(0);
            
            return int.Parse(manvSiteConLai) > max? int.Parse(manvSiteConLai) : max; 
        }
        private int layRaMaNhanvienLonNhatTaiSiteChu()
        {
            string queryName = "DECLARE @return_value int "
                       + "EXEC   @return_value = [dbo].[SP_TIM_MANV_LON_NHAT]" + "SELECT  'Return Value' = @return_value";
            SqlDataReader ketqua = Program.ExecSqlDataReader(queryName);

            if (ketqua == null)
            {
                MessageBox.Show("Server bị lỗi");
                ketqua.Close();
                return -1;
            }
            ketqua.Read();
            String manvSiteConLai = ketqua.GetString(0);
            return int.Parse(manvSiteConLai.Trim());
        }
        private void KhongChoSuaNhanVien()
        {
            for (int i = 0; i < nhanVienBindingSource.Count; i++)
            {
                int trangthaixoa = int.Parse(((DataRowView)nhanVienBindingSource[i])["TrangThaiXoa"].ToString().Trim());
              
                if (trangthaixoa==1 )
                {

                    //gridView1.In.Enable = false;
                }
            }
        }

        private void gridView1_ShownEditor(object sender, EventArgs e)
        {
            
        }

        private void gridView1_ShowingEditor(object sender, CancelEventArgs e)
        {
            string trangthaixoa = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TrangThaiXoa").ToString();
            e.Cancel = trangthaixoa.Trim().Equals("1"); 

        }
    }
    
}
