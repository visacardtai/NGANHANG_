using System;

namespace NGANHANG_
{
    public partial class Xrpt_SaoKeGiaoDichKhachHang : DevExpress.XtraReports.UI.XtraReport
    {
        public Xrpt_SaoKeGiaoDichKhachHang()
        {

        }

        public Xrpt_SaoKeGiaoDichKhachHang(String SOTK, DateTime fromDay, DateTime toDay)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = SOTK;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = fromDay;
            this.sqlDataSource1.Queries[0].Parameters[2].Value = toDay;
            this.sqlDataSource1.Fill();
        }

    }
}
