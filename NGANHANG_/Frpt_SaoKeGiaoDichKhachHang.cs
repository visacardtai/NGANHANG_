using DevExpress.XtraReports.UI;
using System;
using System.Data;
using System.Windows.Forms;

namespace NGANHANG_
{
    public partial class Frpt_SaoKeGiaoDichKhachHang : Form
    {

        String nameKH, stkKH;
        public Frpt_SaoKeGiaoDichKhachHang()
        {
            InitializeComponent();
        }

        private void Frpt_SaoKeGiaoDichKhachHang_Load(object sender, EventArgs e)
        {

            this.dS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS.KhachHang' table. You can move, or remove it, as needed.
            this.tbaKH.Connection.ConnectionString = Program.connstr;
            this.tbaKH.Fill(this.dS.KhachHang);
            // TODO: This line of code loads data into the 'dS.TTKH' table. You can move, or remove it, as needed.
            this.tbaTTKH.Connection.ConnectionString = Program.connstr;
            this.tbaTTKH.Fill(this.dS.TTKH);
            // TODO: This line of code loads data into the 'dS.TaiKhoan' table. You can move, or remove it, as needed.
            this.tbaTK_KH.Connection.ConnectionString = Program.connstr;
            this.tbaTK_KH.Fill(this.dS.TaiKhoan);

            int index, pos;
            string CMND;
            for (index = 0; index < bdsKH.Count; index++)
            {
                bdsKH.Position = index;
                if (bdsTK_KH.Count == 0)
                {
                    CMND = ((DataRowView)bdsKH.Current)["CMND"].ToString();
                    pos = bdsTTKH.Find("CMND", CMND);
                    DataRowView rowView = ((DataRowView)bdsTTKH[pos]);
                    rowView.Delete();
                }
            }

            bdsTTKH.EndEdit();
            bdsTTKH.Position = 0;
            CMND = ((DataRowView)bdsTTKH.Current)["CMND"].ToString();
            bdsKH.Position = bdsKH.Find("CMND", CMND);
            cmbSTK.SelectedItem = 0;

            cmbChiNhanh.DataSource = Program.bds_dspm.DataSource;
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
            cmbChiNhanh.SelectedIndex = Program.mChinhanh;

            if (Program.mGroup == "ChiNhanh")
            {
                cmbChiNhanh.Enabled = false;
            }
            else cmbChiNhanh.Enabled = true;

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
                // TODO: This line of code loads data into the 'dS.KhachHang' table. You can move, or remove it, as needed.
                this.tbaKH.Connection.ConnectionString = Program.connstr;
                this.tbaKH.Fill(this.dS.KhachHang);
                // TODO: This line of code loads data into the 'dS.TaiKhoan' table. You can move, or remove it, as needed.
                this.tbaTK_KH.Connection.ConnectionString = Program.connstr;
                this.tbaTK_KH.Fill(this.dS.TaiKhoan);
                // TODO: This line of code loads data into the 'dS.TTKH' table. You can move, or remove it, as needed.
                this.tbaTTKH.Connection.ConnectionString = Program.connstr;
                this.tbaTTKH.Fill(this.dS.TTKH);

                int index;
                for (index = 0; index < bdsKH.Count; index++)
                {
                    bdsKH.Position = index;
                    if (bdsTK_KH.Count == 0)
                    {
                        string CMND = ((DataRowView)bdsKH.Current)["CMND"].ToString();
                        int pos = bdsTTKH.Find("CMND", CMND);
                        DataRowView rowView = ((DataRowView)bdsTTKH[pos]);
                        rowView.Delete();
                    }
                }

                bdsTTKH.EndEdit();

            }

        }

        private void btnPreview_Click(object sender, EventArgs e)
        {

           /* Xrpt_SaoKeGiaoDichKhachHang rpt = new Xrpt_SaoKeGiaoDichKhachHang(cmbSTK.Text, dtpFromDay.Value, dtpToDay.Value);
            cmbSTK_SelectedIndexChanged(null, null);
            rpt.txtSTK.Text = stkKH;
            rpt.txtFromDay.Text = dtpFromDay.Value.Date.ToString("dd/MM/yyyy");
            if (dtpToDay.Value == null)
                dtpToDay.Value = DateTime.Now;
            rpt.txtToDay.Text = dtpToDay.Value.Date.ToString("dd/MM/yyyy");
            rpt.txtHoTen.Text = nameKH;
            rpt.txtHTNV.Text = Program.mHoten;

            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();*/

        }

        private void cmbSTK_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbSTK.SelectedValue != null)
                    stkKH = cmbSTK.SelectedValue.ToString();

            }
            catch { }
        }

        private void cmbTTKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbTTKH.SelectedValue != null)
                {
                    string CMND = cmbTTKH.SelectedValue.ToString();
                    string KH = ((DS.TTKHRow)((DataRowView)cmbTTKH.SelectedItem).Row).KH.Split('-')[1].Trim();
                    nameKH = KH;
                    bdsKH.Position = bdsKH.Find("CMND", CMND);

                }

            }
            catch { }
        }
    }
}
