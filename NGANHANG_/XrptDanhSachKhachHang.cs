using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace NGANHANG_
{
    public partial class XrptDanhSachKhachHang : DevExpress.XtraReports.UI.XtraReport
    {
        public XrptDanhSachKhachHang()
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
        }

    }
}
