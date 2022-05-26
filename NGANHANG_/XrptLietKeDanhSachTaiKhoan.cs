using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace NGANHANG_
{
    public partial class XrptLietKeDanhSachTaiKhoan : DevExpress.XtraReports.UI.XtraReport
    {

        public XrptLietKeDanhSachTaiKhoan()
        {
            InitializeComponent();
        }
        public XrptLietKeDanhSachTaiKhoan(string macn, DateTime from, DateTime to)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = macn;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = from;
            this.sqlDataSource1.Queries[0].Parameters[2].Value = to;
            this.sqlDataSource1.Fill();
        }

    }
}
