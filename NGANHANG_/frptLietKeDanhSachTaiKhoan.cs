using DevExpress.XtraReports.UI;
using System;
using System.Data.SqlTypes;
using System.Globalization;
using System.Windows.Forms;

namespace NGANHANG_
{
    public partial class frptLietKeDanhSachTaiKhoan : Form
    {
        public frptLietKeDanhSachTaiKhoan()
        {
            InitializeComponent();
        }

        private void frptLietKeDanhSachTaiKhoan_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            this.chinhanhTableAdapter.Connection.ConnectionString = Program.connstr;
            this.chinhanhTableAdapter.Fill(this.dS.Chinhanh);

            if (Program.mGroup.Equals("ChiNhanh"))
            {
                cmbChinhanh.Enabled = false;
                ckInchinhanh.Enabled = false; 
            }
            else if (Program.mGroup.Equals("NganHang"))
            {
                cmbChinhanh.Enabled = true;
                ckInchinhanh.Enabled = true;
            }
        }

        private void btnXuatBaoCao_Click(object sender, EventArgs e)
        {
            
            string macn = cmbChinhanh.SelectedValue.ToString().Trim();
            DateTime from, to;
            if (ckInchinhanh.Checked) macn = "ALL"; 
            

            if (datefrom.Text.Trim().Length == 0) from = (DateTime)SqlDateTime.MinValue;
            else
            {
                if (!DateTime.TryParse(datefrom.Text.Trim(), out from))
                {
                    MessageBox.Show("Ngày bắt đầu không hợp lệ.", "", MessageBoxButtons.OK);
                    return;
                }
            }
            if (dateto.Text.Trim().Length == 0) to = DateTime.Now;
            else
            {
                if (!DateTime.TryParse(dateto.Text.Trim(), out to))
                {
                    MessageBox.Show("Ngày kết thúc không hợp lệ.", "", MessageBoxButtons.OK);
                    return;
                }
            }

            if (to > DateTime.Now) to = DateTime.Now;
            if (from > to)
            {
                MessageBox.Show("Ngày bắt đầu phải trước ngày kết thúc.", "", MessageBoxButtons.OK);
                return;
            }

            if (from.Year < 1753 || to.Year > 9999)
            {
                MessageBox.Show("Ngày nhập phải từ 01/01/1753 đến 31/12/9999", "", MessageBoxButtons.OK);
                return;
            }
            to.AddDays(1);

            XrptLietKeDanhSachTaiKhoan rpt = new XrptLietKeDanhSachTaiKhoan(macn, from, to);


            rpt.lbHoTen.Text = Program.mHoten;
            rpt.lbTieuDe.Text = "DANH SÁCH TÀI KHOẢN TẠO TỪ  " + from.ToString("dd/M/yyyy", CultureInfo.InvariantCulture) + " ĐẾN " + to.ToString("dd/M/yyyy", CultureInfo.InvariantCulture); ; 

            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
        }

        private void ckInchinhanh_CheckedChanged(object sender, EventArgs e)
        {
            if (ckInchinhanh.Checked) cmbChinhanh.Enabled = false;
            else cmbChinhanh.Enabled = true; 
        }

        private void cmbChinhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
