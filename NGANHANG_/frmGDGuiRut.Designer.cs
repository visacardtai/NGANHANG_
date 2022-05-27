
namespace NGANHANG_
{
    partial class frmGDGuiRut
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label sOTKLabel;
            System.Windows.Forms.Label mANVLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGDGuiRut));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnLapGiaoDich = new DevExpress.XtraBars.BarButtonItem();
            this.btnReLoad = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.KHACHHANGDS = new NGANHANG_.KHACHHANGDS();
            this.taiKhoanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taiKhoanTableAdapter = new NGANHANG_.KHACHHANGDSTableAdapters.TaiKhoanTableAdapter();
            this.tableAdapterManager = new NGANHANG_.KHACHHANGDSTableAdapters.TableAdapterManager();
            this.taiKhoanGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSOTK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCMND = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSODU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYMOTK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.txtSoTien = new System.Windows.Forms.NumericUpDown();
            this.txtSoTK = new DevExpress.XtraEditors.TextEdit();
            this.mANVTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.nhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbLoaiGD = new System.Windows.Forms.ComboBox();
            this.giaoDichBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.giaoDichTableAdapter = new NGANHANG_.KHACHHANGDSTableAdapters.GiaoDichTableAdapter();
            this.giaoDichGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSODUTRUOC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLOAIGD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAGD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOTIEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYGD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSODUSAU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOTKNHAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nhanVienTableAdapter = new NGANHANG_.KHACHHANGDSTableAdapters.NhanVienTableAdapter();
            sOTKLabel = new System.Windows.Forms.Label();
            mANVLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KHACHHANGDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoTien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoTK.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mANVTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giaoDichBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giaoDichGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // sOTKLabel
            // 
            sOTKLabel.AutoSize = true;
            sOTKLabel.Location = new System.Drawing.Point(104, 69);
            sOTKLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            sOTKLabel.Name = "sOTKLabel";
            sOTKLabel.Size = new System.Drawing.Size(98, 17);
            sOTKLabel.TabIndex = 0;
            sOTKLabel.Text = "SỐ TÀI KHOẢN";
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Location = new System.Drawing.Point(654, 74);
            mANVLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(48, 17);
            mANVLabel.TabIndex = 8;
            mANVLabel.Text = "MANV:";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnLapGiaoDich,
            this.btnReLoad,
            this.btnThoat});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 3;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLapGiaoDich, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnReLoad, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // btnLapGiaoDich
            // 
            this.btnLapGiaoDich.Caption = "LẬP GIAO DỊCH";
            this.btnLapGiaoDich.Id = 0;
            this.btnLapGiaoDich.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLapGiaoDich.ImageOptions.SvgImage")));
            this.btnLapGiaoDich.Name = "btnLapGiaoDich";
            this.btnLapGiaoDich.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLapGiaoDich_ItemClick);
            // 
            // btnReLoad
            // 
            this.btnReLoad.Caption = "RELOAD";
            this.btnReLoad.Id = 1;
            this.btnReLoad.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnReLoad.ImageOptions.SvgImage")));
            this.btnReLoad.Name = "btnReLoad";
            this.btnReLoad.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReLoad_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "THOÁT";
            this.btnThoat.Id = 2;
            this.btnThoat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThoat.ImageOptions.SvgImage")));
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1447, 51);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 817);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1447, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 51);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 766);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1447, 51);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 766);
            // 
            // KHACHHANGDS
            // 
            this.KHACHHANGDS.DataSetName = "KHACHHANGDS";
            this.KHACHHANGDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // taiKhoanBindingSource
            // 
            this.taiKhoanBindingSource.DataMember = "TaiKhoan";
            this.taiKhoanBindingSource.DataSource = this.KHACHHANGDS;
            // 
            // taiKhoanTableAdapter
            // 
            this.taiKhoanTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TaiKhoanTableAdapter = this.taiKhoanTableAdapter;
            this.tableAdapterManager.UpdateOrder = NGANHANG_.KHACHHANGDSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // taiKhoanGridControl
            // 
            this.taiKhoanGridControl.DataSource = this.taiKhoanBindingSource;
            this.taiKhoanGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.taiKhoanGridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.taiKhoanGridControl.Location = new System.Drawing.Point(0, 51);
            this.taiKhoanGridControl.MainView = this.gridView1;
            this.taiKhoanGridControl.Margin = new System.Windows.Forms.Padding(4);
            this.taiKhoanGridControl.MenuManager = this.barManager1;
            this.taiKhoanGridControl.Name = "taiKhoanGridControl";
            this.taiKhoanGridControl.Size = new System.Drawing.Size(1447, 365);
            this.taiKhoanGridControl.TabIndex = 5;
            this.taiKhoanGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.taiKhoanGridControl.Click += new System.EventHandler(this.taiKhoanGridControl_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSOTK,
            this.colCMND,
            this.colSODU,
            this.colMACN,
            this.colNGAYMOTK});
            this.gridView1.DetailHeight = 437;
            this.gridView1.GridControl = this.taiKhoanGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            // 
            // colSOTK
            // 
            this.colSOTK.AppearanceHeader.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.colSOTK.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.colSOTK.AppearanceHeader.ForeColor = System.Drawing.Color.White;
            this.colSOTK.AppearanceHeader.Options.UseBackColor = true;
            this.colSOTK.AppearanceHeader.Options.UseBorderColor = true;
            this.colSOTK.AppearanceHeader.Options.UseFont = true;
            this.colSOTK.AppearanceHeader.Options.UseForeColor = true;
            this.colSOTK.AppearanceHeader.Options.UseTextOptions = true;
            this.colSOTK.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSOTK.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSOTK.Caption = "Số tài khoản";
            this.colSOTK.FieldName = "SOTK";
            this.colSOTK.MinWidth = 31;
            this.colSOTK.Name = "colSOTK";
            this.colSOTK.Visible = true;
            this.colSOTK.VisibleIndex = 0;
            this.colSOTK.Width = 117;
            // 
            // colCMND
            // 
            this.colCMND.AppearanceHeader.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.colCMND.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.colCMND.AppearanceHeader.ForeColor = System.Drawing.Color.White;
            this.colCMND.AppearanceHeader.Options.UseBackColor = true;
            this.colCMND.AppearanceHeader.Options.UseBorderColor = true;
            this.colCMND.AppearanceHeader.Options.UseFont = true;
            this.colCMND.AppearanceHeader.Options.UseForeColor = true;
            this.colCMND.AppearanceHeader.Options.UseTextOptions = true;
            this.colCMND.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCMND.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colCMND.Caption = "CMND";
            this.colCMND.FieldName = "CMND";
            this.colCMND.MinWidth = 31;
            this.colCMND.Name = "colCMND";
            this.colCMND.Visible = true;
            this.colCMND.VisibleIndex = 1;
            this.colCMND.Width = 117;
            // 
            // colSODU
            // 
            this.colSODU.AppearanceHeader.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.colSODU.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.colSODU.AppearanceHeader.ForeColor = System.Drawing.Color.White;
            this.colSODU.AppearanceHeader.Options.UseBackColor = true;
            this.colSODU.AppearanceHeader.Options.UseBorderColor = true;
            this.colSODU.AppearanceHeader.Options.UseFont = true;
            this.colSODU.AppearanceHeader.Options.UseForeColor = true;
            this.colSODU.AppearanceHeader.Options.UseTextOptions = true;
            this.colSODU.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSODU.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSODU.Caption = "Số dư";
            this.colSODU.DisplayFormat.FormatString = "##,#";
            this.colSODU.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSODU.FieldName = "SODU";
            this.colSODU.MinWidth = 31;
            this.colSODU.Name = "colSODU";
            this.colSODU.Visible = true;
            this.colSODU.VisibleIndex = 2;
            this.colSODU.Width = 117;
            // 
            // colMACN
            // 
            this.colMACN.AppearanceHeader.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.colMACN.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.colMACN.AppearanceHeader.ForeColor = System.Drawing.Color.White;
            this.colMACN.AppearanceHeader.Options.UseBackColor = true;
            this.colMACN.AppearanceHeader.Options.UseBorderColor = true;
            this.colMACN.AppearanceHeader.Options.UseFont = true;
            this.colMACN.AppearanceHeader.Options.UseForeColor = true;
            this.colMACN.AppearanceHeader.Options.UseTextOptions = true;
            this.colMACN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMACN.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colMACN.Caption = "Mã Chi Nhánh";
            this.colMACN.FieldName = "MACN";
            this.colMACN.MinWidth = 31;
            this.colMACN.Name = "colMACN";
            this.colMACN.Visible = true;
            this.colMACN.VisibleIndex = 3;
            this.colMACN.Width = 117;
            // 
            // colNGAYMOTK
            // 
            this.colNGAYMOTK.AppearanceHeader.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.colNGAYMOTK.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.colNGAYMOTK.AppearanceHeader.ForeColor = System.Drawing.Color.White;
            this.colNGAYMOTK.AppearanceHeader.Options.UseBackColor = true;
            this.colNGAYMOTK.AppearanceHeader.Options.UseBorderColor = true;
            this.colNGAYMOTK.AppearanceHeader.Options.UseFont = true;
            this.colNGAYMOTK.AppearanceHeader.Options.UseForeColor = true;
            this.colNGAYMOTK.AppearanceHeader.Options.UseTextOptions = true;
            this.colNGAYMOTK.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNGAYMOTK.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colNGAYMOTK.Caption = "Ngày mở tài khoản";
            this.colNGAYMOTK.DisplayFormat.FormatString = "G";
            this.colNGAYMOTK.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colNGAYMOTK.FieldName = "NGAYMOTK";
            this.colNGAYMOTK.MinWidth = 31;
            this.colNGAYMOTK.Name = "colNGAYMOTK";
            this.colNGAYMOTK.Visible = true;
            this.colNGAYMOTK.VisibleIndex = 4;
            this.colNGAYMOTK.Width = 117;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.txtSoTien);
            this.panelControl1.Controls.Add(this.txtSoTK);
            this.panelControl1.Controls.Add(mANVLabel);
            this.panelControl1.Controls.Add(this.mANVTextEdit);
            this.panelControl1.Controls.Add(this.btnHuy);
            this.panelControl1.Controls.Add(this.btnXacNhan);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.cmbLoaiGD);
            this.panelControl1.Controls.Add(sOTKLabel);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(0, 416);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(951, 401);
            this.panelControl1.TabIndex = 6;
            // 
            // txtSoTien
            // 
            this.txtSoTien.Location = new System.Drawing.Point(230, 183);
            this.txtSoTien.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoTien.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.txtSoTien.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.txtSoTien.Name = "txtSoTien";
            this.txtSoTien.Size = new System.Drawing.Size(311, 23);
            this.txtSoTien.TabIndex = 11;
            this.txtSoTien.ThousandsSeparator = true;
            this.txtSoTien.Value = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            // 
            // txtSoTK
            // 
            this.txtSoTK.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.taiKhoanBindingSource, "SOTK", true));
            this.txtSoTK.Enabled = false;
            this.txtSoTK.Location = new System.Drawing.Point(229, 71);
            this.txtSoTK.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoTK.MenuManager = this.barManager1;
            this.txtSoTK.Name = "txtSoTK";
            this.txtSoTK.Size = new System.Drawing.Size(311, 22);
            this.txtSoTK.TabIndex = 10;
            // 
            // mANVTextEdit
            // 
            this.mANVTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nhanVienBindingSource, "MANV", true));
            this.mANVTextEdit.Enabled = false;
            this.mANVTextEdit.Location = new System.Drawing.Point(742, 70);
            this.mANVTextEdit.Margin = new System.Windows.Forms.Padding(4);
            this.mANVTextEdit.MenuManager = this.barManager1;
            this.mANVTextEdit.Name = "mANVTextEdit";
            this.mANVTextEdit.Size = new System.Drawing.Size(156, 22);
            this.mANVTextEdit.TabIndex = 9;
            // 
            // nhanVienBindingSource
            // 
            this.nhanVienBindingSource.DataMember = "NhanVien";
            this.nhanVienBindingSource.DataSource = this.KHACHHANGDS;
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnHuy.Location = new System.Drawing.Point(507, 247);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(181, 45);
            this.btnHuy.TabIndex = 7;
            this.btnHuy.Text = "HỦY GIAO DỊCH";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXacNhan.Location = new System.Drawing.Point(192, 247);
            this.btnXacNhan.Margin = new System.Windows.Forms.Padding(4);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(210, 45);
            this.btnXacNhan.TabIndex = 6;
            this.btnXacNhan.Text = "XÁC NHẬN";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 185);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "SỐ TIỀN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 128);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "LOẠI GIAO DỊCH";
            // 
            // cmbLoaiGD
            // 
            this.cmbLoaiGD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLoaiGD.FormattingEnabled = true;
            this.cmbLoaiGD.Items.AddRange(new object[] {
            "Gởi tiền",
            "Rút tiền"});
            this.cmbLoaiGD.Location = new System.Drawing.Point(230, 121);
            this.cmbLoaiGD.Margin = new System.Windows.Forms.Padding(4);
            this.cmbLoaiGD.Name = "cmbLoaiGD";
            this.cmbLoaiGD.Size = new System.Drawing.Size(310, 24);
            this.cmbLoaiGD.TabIndex = 3;
            this.cmbLoaiGD.SelectedIndexChanged += new System.EventHandler(this.cmbLoaiGD_SelectedIndexChanged);
            // 
            // giaoDichBindingSource
            // 
            this.giaoDichBindingSource.DataMember = "GiaoDich";
            this.giaoDichBindingSource.DataSource = this.KHACHHANGDS;
            // 
            // giaoDichTableAdapter
            // 
            this.giaoDichTableAdapter.ClearBeforeFill = true;
            // 
            // giaoDichGridControl
            // 
            this.giaoDichGridControl.DataSource = this.giaoDichBindingSource;
            this.giaoDichGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.giaoDichGridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.giaoDichGridControl.Location = new System.Drawing.Point(951, 416);
            this.giaoDichGridControl.MainView = this.gridView2;
            this.giaoDichGridControl.Margin = new System.Windows.Forms.Padding(4);
            this.giaoDichGridControl.MenuManager = this.barManager1;
            this.giaoDichGridControl.Name = "giaoDichGridControl";
            this.giaoDichGridControl.Size = new System.Drawing.Size(496, 401);
            this.giaoDichGridControl.TabIndex = 11;
            this.giaoDichGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSODUTRUOC,
            this.colLOAIGD,
            this.colMAGD,
            this.colSOTIEN,
            this.colNGAYGD,
            this.colSODUSAU,
            this.colMANV,
            this.colSOTKNHAN});
            this.gridView2.DetailHeight = 437;
            this.gridView2.GridControl = this.giaoDichGridControl;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            // 
            // colSODUTRUOC
            // 
            this.colSODUTRUOC.AppearanceHeader.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.colSODUTRUOC.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.colSODUTRUOC.AppearanceHeader.ForeColor = System.Drawing.Color.White;
            this.colSODUTRUOC.AppearanceHeader.Options.UseBackColor = true;
            this.colSODUTRUOC.AppearanceHeader.Options.UseFont = true;
            this.colSODUTRUOC.AppearanceHeader.Options.UseForeColor = true;
            this.colSODUTRUOC.Caption = "Số dư trước";
            this.colSODUTRUOC.FieldName = "SODUTRUOC";
            this.colSODUTRUOC.MinWidth = 31;
            this.colSODUTRUOC.Name = "colSODUTRUOC";
            this.colSODUTRUOC.Visible = true;
            this.colSODUTRUOC.VisibleIndex = 0;
            this.colSODUTRUOC.Width = 117;
            // 
            // colLOAIGD
            // 
            this.colLOAIGD.AppearanceHeader.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.colLOAIGD.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.colLOAIGD.AppearanceHeader.ForeColor = System.Drawing.Color.White;
            this.colLOAIGD.AppearanceHeader.Options.UseBackColor = true;
            this.colLOAIGD.AppearanceHeader.Options.UseFont = true;
            this.colLOAIGD.AppearanceHeader.Options.UseForeColor = true;
            this.colLOAIGD.Caption = "Loại GD";
            this.colLOAIGD.FieldName = "LOAIGD";
            this.colLOAIGD.MinWidth = 31;
            this.colLOAIGD.Name = "colLOAIGD";
            this.colLOAIGD.Visible = true;
            this.colLOAIGD.VisibleIndex = 1;
            this.colLOAIGD.Width = 117;
            // 
            // colMAGD
            // 
            this.colMAGD.AppearanceHeader.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.colMAGD.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.colMAGD.AppearanceHeader.ForeColor = System.Drawing.Color.White;
            this.colMAGD.AppearanceHeader.Options.UseBackColor = true;
            this.colMAGD.AppearanceHeader.Options.UseFont = true;
            this.colMAGD.AppearanceHeader.Options.UseForeColor = true;
            this.colMAGD.Caption = "Mã GD";
            this.colMAGD.FieldName = "MAGD";
            this.colMAGD.MinWidth = 31;
            this.colMAGD.Name = "colMAGD";
            this.colMAGD.Visible = true;
            this.colMAGD.VisibleIndex = 2;
            this.colMAGD.Width = 117;
            // 
            // colSOTIEN
            // 
            this.colSOTIEN.AppearanceHeader.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.colSOTIEN.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.colSOTIEN.AppearanceHeader.ForeColor = System.Drawing.Color.White;
            this.colSOTIEN.AppearanceHeader.Options.UseBackColor = true;
            this.colSOTIEN.AppearanceHeader.Options.UseFont = true;
            this.colSOTIEN.AppearanceHeader.Options.UseForeColor = true;
            this.colSOTIEN.Caption = "Số tiền";
            this.colSOTIEN.DisplayFormat.FormatString = "##,#";
            this.colSOTIEN.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSOTIEN.FieldName = "SOTIEN";
            this.colSOTIEN.MinWidth = 31;
            this.colSOTIEN.Name = "colSOTIEN";
            this.colSOTIEN.Visible = true;
            this.colSOTIEN.VisibleIndex = 3;
            this.colSOTIEN.Width = 117;
            // 
            // colNGAYGD
            // 
            this.colNGAYGD.AppearanceHeader.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.colNGAYGD.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.colNGAYGD.AppearanceHeader.ForeColor = System.Drawing.Color.White;
            this.colNGAYGD.AppearanceHeader.Options.UseBackColor = true;
            this.colNGAYGD.AppearanceHeader.Options.UseFont = true;
            this.colNGAYGD.AppearanceHeader.Options.UseForeColor = true;
            this.colNGAYGD.Caption = "Ngày GD";
            this.colNGAYGD.DisplayFormat.FormatString = "G";
            this.colNGAYGD.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colNGAYGD.FieldName = "NGAYGD";
            this.colNGAYGD.MinWidth = 31;
            this.colNGAYGD.Name = "colNGAYGD";
            this.colNGAYGD.Visible = true;
            this.colNGAYGD.VisibleIndex = 4;
            this.colNGAYGD.Width = 117;
            // 
            // colSODUSAU
            // 
            this.colSODUSAU.AppearanceHeader.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.colSODUSAU.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.colSODUSAU.AppearanceHeader.ForeColor = System.Drawing.Color.White;
            this.colSODUSAU.AppearanceHeader.Options.UseBackColor = true;
            this.colSODUSAU.AppearanceHeader.Options.UseFont = true;
            this.colSODUSAU.AppearanceHeader.Options.UseForeColor = true;
            this.colSODUSAU.Caption = "Số dư sau";
            this.colSODUSAU.DisplayFormat.FormatString = "##,#";
            this.colSODUSAU.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSODUSAU.FieldName = "SODUSAU";
            this.colSODUSAU.MinWidth = 31;
            this.colSODUSAU.Name = "colSODUSAU";
            this.colSODUSAU.Visible = true;
            this.colSODUSAU.VisibleIndex = 5;
            this.colSODUSAU.Width = 117;
            // 
            // colMANV
            // 
            this.colMANV.AppearanceHeader.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.colMANV.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.colMANV.AppearanceHeader.ForeColor = System.Drawing.Color.White;
            this.colMANV.AppearanceHeader.Options.UseBackColor = true;
            this.colMANV.AppearanceHeader.Options.UseFont = true;
            this.colMANV.AppearanceHeader.Options.UseForeColor = true;
            this.colMANV.Caption = "Mã NV";
            this.colMANV.FieldName = "MANV";
            this.colMANV.MinWidth = 31;
            this.colMANV.Name = "colMANV";
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 6;
            this.colMANV.Width = 117;
            // 
            // colSOTKNHAN
            // 
            this.colSOTKNHAN.AppearanceHeader.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.colSOTKNHAN.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.colSOTKNHAN.AppearanceHeader.ForeColor = System.Drawing.Color.White;
            this.colSOTKNHAN.AppearanceHeader.Options.UseBackColor = true;
            this.colSOTKNHAN.AppearanceHeader.Options.UseFont = true;
            this.colSOTKNHAN.AppearanceHeader.Options.UseForeColor = true;
            this.colSOTKNHAN.Caption = "Số TK nhận";
            this.colSOTKNHAN.FieldName = "SOTKNHAN";
            this.colSOTKNHAN.MinWidth = 31;
            this.colSOTKNHAN.Name = "colSOTKNHAN";
            this.colSOTKNHAN.Visible = true;
            this.colSOTKNHAN.VisibleIndex = 7;
            this.colSOTKNHAN.Width = 117;
            // 
            // nhanVienTableAdapter
            // 
            this.nhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // frmGDGuiRut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1447, 837);
            this.Controls.Add(this.giaoDichGridControl);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.taiKhoanGridControl);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmGDGuiRut";
            this.Text = "Giao dịch gửi rút";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmGDGuiRut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KHACHHANGDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoTien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoTK.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mANVTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giaoDichBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giaoDichGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnLapGiaoDich;
        private DevExpress.XtraBars.BarButtonItem btnReLoad;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private System.Windows.Forms.BindingSource taiKhoanBindingSource;
        private KHACHHANGDS KHACHHANGDS;
        private KHACHHANGDSTableAdapters.TaiKhoanTableAdapter taiKhoanTableAdapter;
        private KHACHHANGDSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl taiKhoanGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTK;
        private DevExpress.XtraGrid.Columns.GridColumn colCMND;
        private DevExpress.XtraGrid.Columns.GridColumn colSODU;
        private DevExpress.XtraGrid.Columns.GridColumn colMACN;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYMOTK;
        private KHACHHANGDSTableAdapters.GiaoDichTableAdapter giaoDichTableAdapter;
        private DevExpress.XtraGrid.GridControl giaoDichGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colSODUTRUOC;
        private DevExpress.XtraGrid.Columns.GridColumn colLOAIGD;
        private DevExpress.XtraGrid.Columns.GridColumn colMAGD;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTIEN;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYGD;
        private DevExpress.XtraGrid.Columns.GridColumn colSODUSAU;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTKNHAN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbLoaiGD;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.BindingSource giaoDichBindingSource;
        private System.Windows.Forms.BindingSource nhanVienBindingSource;
        private KHACHHANGDSTableAdapters.NhanVienTableAdapter nhanVienTableAdapter;
        private DevExpress.XtraEditors.TextEdit mANVTextEdit;
        private DevExpress.XtraEditors.TextEdit txtSoTK;
        private System.Windows.Forms.NumericUpDown txtSoTien;
    }
}