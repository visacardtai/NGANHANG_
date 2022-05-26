using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NGANHANG_
{
    public partial class FrptDanhSachKhachHang : Form
    {
        public FrptDanhSachKhachHang()
        {
            InitializeComponent();
        }

        private void FrptDanhSachKhachHang_Load(object sender, EventArgs e)
        {
            cmbChinhanh.DataSource = Program.bds_dspm;
            cmbChinhanh.DisplayMember = "TENCN";
            cmbChinhanh.ValueMember = "TENSERVER";
            cmbChinhanh.SelectedIndex = Program.mChinhanh;

            if (Program.mGroup.Equals("ChiNhanh"))
            {
                cmbChinhanh.Enabled = false;
            }
            else if (Program.mGroup.Equals("NganHang"))
            {
                cmbChinhanh.Enabled = true;
            }
        }

        private void cmbChinhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbChinhanh.SelectedValue.ToString() != "System.Data.DataRowView")
                {
                    Program.servername = cmbChinhanh.SelectedValue.ToString();
                }
               /* if (cmbChinhanh.SelectedIndex != Program.mChinhanh)
                {
                    Program.mlogin = Program.remotelogin;
                    Program.password = Program.remotepassword;
                }
                else
                {
                    Program.mlogin = Program.mloginDN;
                    Program.password = Program.passwordDN;
                }*/

            }
            catch
            {
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XrptDanhSachKhachHang rpt = new XrptDanhSachKhachHang();
            rpt.lbTieuDe.Text = "DANH SÁCH KHÁCH HÀNG";
            rpt.xlbTenNV.Text = Program.mHoten;
            rpt.xlbNhom.Text = Program.mGroup;

            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();

        }
    }
}
