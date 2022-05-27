using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace NGANHANG_
{
    public partial class frmChuyenTien : DevExpress.XtraEditors.XtraForm
    {
        public frmChuyenTien()
        {
            InitializeComponent();
        }

        private void frmChuyenTien_Load(object sender, EventArgs e)
        {

            this.DS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'DS.TTNV' table. You can move, or remove it, as needed.
            this.tbaTTNV.Connection.ConnectionString = Program.connstr;
            this.tbaTTNV.Fill(this.DS.TTNV);
            // TODO: This line of code loads data into the 'DS.GD_CHUYENTIEN' table. You can move, or remove it, as needed.
            this.tbaCT.Connection.ConnectionString = Program.connstr;
            this.tbaCT.Fill(this.DS.GD_CHUYENTIEN);

            this.tbaTK_KH.Connection.ConnectionString = Program.connstr;
            this.tbaTK_KH.Fill(this.DS.TaiKhoan);

            if (Program.mGroup == "ChiNhanh")
            {
                cmbChiNhanh.Enabled = false;
                Program.mlogin = Program.remotelogin;
                Program.password = Program.remotepassword;
                Program.servername = Program.server_tracuu;

            }
            else cmbChiNhanh.Enabled = true;

            if (Program.KetNoi(false, true) == 0)
                MessageBox.Show("Loi ket noi ve chi nhanh moi", "", MessageBoxButtons.OK);
            else
            {

                // TODO: This line of code loads data into the 'DS.KhachHang' table. You can move, or remove it, as needed.
                this.tbaKH.Connection.ConnectionString = Program.connstr;
                this.tbaKH.Fill(this.DS.KhachHang);
                // TODO: This line of code loads data into the 'DS.TTKH' table. You can move, or remove it, as needed.
                this.tbaTTKH.Connection.ConnectionString = Program.connstr;
                this.tbaTTKH.Fill(this.DS.TTKH);
            }

            // TODO: This line of code loads data into the 'DS.TK_KH' table. You can move, or remove it, as needed.

            cmbChiNhanh.DataSource = Program.bds_dspm.DataSource;

            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
            cmbChiNhanh.SelectedIndex = Program.mChinhanh;

            bdsCT.Position = 0;

        }

        private void cmbTTNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbTTNV.SelectedValue != null)
                    txtMANV.Text = cmbTTNV.SelectedValue.ToString();

            }
            catch { }
        }

        private void cmbTTTKC_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbTTTKC.SelectedValue != null)
                {
                    string CMND = cmbTTTKC.SelectedValue.ToString();
                    string KH = ((DS.TTKHRow)((DataRowView)cmbTTTKC.SelectedItem).Row).KH.Split('-')[1].Trim();
                    int index = bdsKHC.Find("CMND", CMND);
                    int selectedIndex = cmbTTTKC.SelectedIndex;

                    if (KH.Equals(txtKHN.Text))
                    {
                        if (index < bdsKHC.Count - 1)
                        {
                            index++;
                            selectedIndex++;
                        }
                        else
                        {
                            index = 0;
                            selectedIndex = 0;
                        }
                    }

                    bdsKHC.Position = index;
                    cmbTTTKC.SelectedIndex = selectedIndex;

                    cmbTKC.SelectedIndex = 0;
                    cmbTKC_SelectedIndexChanged(null, null);
                    KH = ((DS.TTKHRow)((DataRowView)cmbTTTKC.SelectedItem).Row).KH.Split('-')[1].Trim();
                    txtKHC.Text = KH;

                }

            }
            catch { }
        }

        private void cmbTTTKN_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbTTTKN.SelectedValue != null)
                {
                    string CMND = cmbTTTKN.SelectedValue.ToString();
                    string KH = ((DS.TTKHRow)((DataRowView)cmbTTTKN.SelectedItem).Row).KH.Split('-')[1].Trim();
                    int index = bdsTTKHN.Find("CMND", CMND);
                    int selectedIndex = cmbTTTKN.SelectedIndex;

                    if (KH.Equals(txtKHC.Text))
                    {
                        //thong bao trung
                        if (index < bdsKHN.Count - 1)
                        {
                            index++;
                            selectedIndex++;
                        }
                        else
                        {
                            index = 0;
                            selectedIndex = 0;
                        }
                    }

                    bdsKHN.Position = index;
                    cmbTTTKN.SelectedIndex = selectedIndex;

                    cmbTKN.SelectedIndex = 0;
                    cmbTKN_SelectedIndexChanged(null, null);
                    KH = ((DS.TTKHRow)((DataRowView)cmbTTTKN.SelectedItem).Row).KH.Split('-')[1].Trim();
                    txtKHN.Text = KH;
                }

            }
            catch { }
        }

        private void cmbTTTKC_Validated(object sender, EventArgs e)
        {
            if (cmbTTTKC.SelectedIndex == -1)
            {
                bdsTTKHC.Position = 0;
            }

        }

        private void cmbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbChiNhanh.SelectedValue.ToString() == "System.Data.DataRowView")
                return;
            Program.servername = cmbChiNhanh.SelectedValue.ToString();

            if (cmbChiNhanh.SelectedIndex != Program.mChinhanh)
            {
                Program.mlogin = Program.remotelogin;
                Program.password = Program.remotepassword;
            }
            else
            {
                Program.mlogin = Program.mloginDN;
                Program.password = Program.passwordDN;
            }

            if (Program.KetNoi(false, true) == 0)
                MessageBox.Show("Loi ket noi ve chi nhanh moi", "", MessageBoxButtons.OK);
            else
            {

                Program.mChinhanh = cmbChiNhanh.SelectedIndex;
                // TODO: This line of code loads data into the 'DS.NhanVien' table. You can move, or remove it, as needed.
                this.DS.EnforceConstraints = false;
                // TODO: This line of code loads data into the 'DS.KhachHang' table. You can move, or remove it, as needed.
                this.tbaKH.Connection.ConnectionString = Program.connstr;
                this.tbaKH.Fill(this.DS.KhachHang);
                // TODO: This line of code loads data into the 'DS.TTNV' table. You can move, or remove it, as needed.
                this.tbaTTNV.Connection.ConnectionString = Program.connstr;
                this.tbaTTNV.Fill(this.DS.TTNV);
                // TODO: This line of code loads data into the 'DS.GD_CHUYENTIEN' table. You can move, or remove it, as needed.
                this.tbaCT.Connection.ConnectionString = Program.connstr;
                this.tbaCT.Fill(this.DS.GD_CHUYENTIEN);

                /*if (Program.mGroup == "ChiNhanh")
                {
                    cmbChiNhanh.Enabled = false;
                }
                else cmbChiNhanh.Enabled = true;*/
                // TODO: This line of code loads data into the 'DS.TTKH' table. You can move, or remove it, as needed.
                this.tbaTTKH.Connection.ConnectionString = Program.connstr;
                this.tbaTTKH.Fill(this.DS.TTKH);
                // TODO: This line of code loads data into the 'DS.TK_KH' table. You can move, or remove it, as needed.
                this.tbaTK_KH.Connection.ConnectionString = Program.connstr;
                this.tbaTK_KH.Fill(this.DS.TaiKhoan);

                bdsCT.Position = 0;

            }
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsCT.AddNew();
            colMANV.OptionsColumn.AllowEdit = true;
            btnAdd.Enabled = btnExit.Enabled = false;
            btnCancel.Enabled = btnWri.Enabled = true;
            pcfrmCT.Enabled = true;

            cmbTTTKC.SelectedIndex = 0;
            cmbTTTKN.SelectedIndex = 1;

            cmbTKC_SelectedIndexChanged(null, null);
            cmbTKN_SelectedIndexChanged(null, null);

        }

        private void btnExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Loi ket noi ve chi nhanh moi", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Close();
            }
        }

        private void cmbTKC_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbTKC.SelectedValue != null)
                {
                    txtSTKC.Text = cmbTKC.SelectedValue.ToString();
                    btnWri.Enabled = true;
                }
                else
                {
                    txtSTKC.Text = "";
                    txtKHC.Text = "";
                    btnWri.Enabled = false;
                }
            }
            catch { }
        }

        private void cmbTKN_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbTKN.SelectedValue != null)
                    txtSTKN.Text = cmbTKN.SelectedValue.ToString();
                else
                {
                    txtSTKN.Text = "";
                    txtKHN.Text = "";
                    btnWri.Enabled = false;
                }
            }
            catch { }
        }

        private void btnWri_Click(object sender, EventArgs e)
        {
            colMANV.OptionsColumn.AllowEdit = false;
            btnAdd.Enabled = btnExit.Enabled = true;
            btnCancel.Enabled = btnWri.Enabled = false;

            cmbTTTKC.SelectedIndex = 0;
            cmbTTTKN.SelectedIndex = 1;

            if (txtSTKC.Text == "" || txtSTKN.Text == "")
            {
                //loi
            }
            else
            {
                if (Program.ExecSqlStoredProcedureValue("SP_GIAO_DICH_CHUYEN_TIEN", new List<SqlParameter> {
                                       new SqlParameter("@SOTKCHUYEN", txtSTKC.Text.Trim()),
                                       new SqlParameter("@SOTKNHAN", txtSTKN.Text.Trim()),
                                       new SqlParameter("@SOTIEN", tedSoTien.Text.Trim()),
                                       new SqlParameter("@MANV", txtMANV.Text.Trim()),
                                       new SqlParameter("@NGAYGD", dtpNgayGD.Text.Trim())
                                   }, CommandType.StoredProcedure) == 0)
                {
                    MessageBox.Show("Giao dich thanh cong !", "", MessageBoxButtons.OK);
                    return;
                }
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            bdsCT.CancelEdit();
            btnAdd.Enabled = btnExit.Enabled = true;
            btnCancel.Enabled = btnWri.Enabled = false;
            colMANV.OptionsColumn.AllowEdit = false;

            cmbTTTKC.SelectedIndex = 0;
            cmbTTTKN.SelectedIndex = 1;
        }
    }
}