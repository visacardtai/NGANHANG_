
namespace NGANHANG_
{
    partial class frmNV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNV));
            this.cmbChinhanh = new System.Windows.Forms.ComboBox();
            this.nhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new NGANHANG_.DS();
            this.nhanVienTableAdapter = new NGANHANG_.DSTableAdapters.NhanVienTableAdapter();
            this.tableAdapterManager = new NGANHANG_.DSTableAdapters.TableAdapterManager();
            this.nhanVienGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPHAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSODT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTrangThaiXoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnLuu = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhuchoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnReload = new DevExpress.XtraBars.BarButtonItem();
            this.btnChuyenCN = new DevExpress.XtraBars.BarButtonItem();
            this.btnExit = new DevExpress.XtraBars.BarButtonItem();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.panelThongtin = new DevExpress.XtraEditors.PanelControl();
            this.gD_GOIRUTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gD_CHUYENTIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gD_GOIRUTTableAdapter = new NGANHANG_.DSTableAdapters.GD_GOIRUTTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.hScrollBar1 = new DevExpress.XtraEditors.HScrollBar();
            this.gD_CHUYENTIENTableAdapter = new NGANHANG_.DSTableAdapters.GD_CHUYENTIENTableAdapter();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.lbthongbaonv = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelThongtin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD_GOIRUTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD_CHUYENTIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbChinhanh
            // 
            this.cmbChinhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChinhanh.FormattingEnabled = true;
            this.cmbChinhanh.Location = new System.Drawing.Point(334, 56);
            this.cmbChinhanh.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.cmbChinhanh.Name = "cmbChinhanh";
            this.cmbChinhanh.Size = new System.Drawing.Size(842, 24);
            this.cmbChinhanh.TabIndex = 1;
            this.cmbChinhanh.SelectedIndexChanged += new System.EventHandler(this.cmbChinhanh_SelectedIndexChanged);
            this.cmbChinhanh.Click += new System.EventHandler(this.cmbChinhanh_SelectedIndexChanged);
            // 
            // nhanVienBindingSource
            // 
            this.nhanVienBindingSource.DataMember = "NhanVien";
            this.nhanVienBindingSource.DataSource = this.dS;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nhanVienTableAdapter
            // 
            this.nhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.GD_CHUYENTIENTableAdapter = null;
            this.tableAdapterManager.GD_GOIRUTTableAdapter = null;
            this.tableAdapterManager.KhachHangTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = this.nhanVienTableAdapter;
            this.tableAdapterManager.TaiKhoanTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = NGANHANG_.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // nhanVienGridControl
            // 
            this.nhanVienGridControl.DataSource = this.nhanVienBindingSource;
            this.nhanVienGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nhanVienGridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.nhanVienGridControl.Location = new System.Drawing.Point(0, 203);
            this.nhanVienGridControl.MainView = this.gridView1;
            this.nhanVienGridControl.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.nhanVienGridControl.MenuManager = this.barManager1;
            this.nhanVienGridControl.Name = "nhanVienGridControl";
            this.nhanVienGridControl.Size = new System.Drawing.Size(1426, 421);
            this.nhanVienGridControl.TabIndex = 34;
            this.nhanVienGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.nhanVienGridControl.Click += new System.EventHandler(this.nhanVienGridControl_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMANV,
            this.colHO,
            this.colTEN,
            this.colDIACHI,
            this.colPHAI,
            this.colSODT,
            this.colMACN,
            this.colTrangThaiXoa});
            this.gridView1.DetailHeight = 852;
            this.gridView1.GridControl = this.nhanVienGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.ShowingEditor += new System.ComponentModel.CancelEventHandler(this.gridView1_ShowingEditor);
            this.gridView1.ShownEditor += new System.EventHandler(this.gridView1_ShownEditor);
            this.gridView1.ValidatingEditor += new DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventHandler(this.gridView1_ValidatingEditor_1);
            // 
            // colMANV
            // 
            this.colMANV.AppearanceHeader.BackColor = System.Drawing.Color.DodgerBlue;
            this.colMANV.AppearanceHeader.BackColor2 = System.Drawing.Color.White;
            this.colMANV.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.colMANV.AppearanceHeader.ForeColor = System.Drawing.Color.White;
            this.colMANV.AppearanceHeader.Options.UseBackColor = true;
            this.colMANV.AppearanceHeader.Options.UseFont = true;
            this.colMANV.AppearanceHeader.Options.UseForeColor = true;
            this.colMANV.Caption = "Mã Nhân Viên";
            this.colMANV.FieldName = "MANV";
            this.colMANV.MinWidth = 31;
            this.colMANV.Name = "colMANV";
            this.colMANV.OptionsColumn.AllowEdit = false;
            this.colMANV.OptionsColumn.ShowInExpressionEditor = false;
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 0;
            this.colMANV.Width = 117;
            // 
            // colHO
            // 
            this.colHO.AppearanceHeader.BackColor = System.Drawing.Color.DodgerBlue;
            this.colHO.AppearanceHeader.BackColor2 = System.Drawing.Color.White;
            this.colHO.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.colHO.AppearanceHeader.ForeColor = System.Drawing.Color.White;
            this.colHO.AppearanceHeader.Options.UseBackColor = true;
            this.colHO.AppearanceHeader.Options.UseFont = true;
            this.colHO.AppearanceHeader.Options.UseForeColor = true;
            this.colHO.Caption = "Họ";
            this.colHO.FieldName = "HO";
            this.colHO.MinWidth = 31;
            this.colHO.Name = "colHO";
            this.colHO.Visible = true;
            this.colHO.VisibleIndex = 1;
            this.colHO.Width = 117;
            // 
            // colTEN
            // 
            this.colTEN.AppearanceHeader.BackColor = System.Drawing.Color.DodgerBlue;
            this.colTEN.AppearanceHeader.BackColor2 = System.Drawing.Color.White;
            this.colTEN.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.colTEN.AppearanceHeader.ForeColor = System.Drawing.Color.White;
            this.colTEN.AppearanceHeader.Options.UseBackColor = true;
            this.colTEN.AppearanceHeader.Options.UseFont = true;
            this.colTEN.AppearanceHeader.Options.UseForeColor = true;
            this.colTEN.Caption = "Tên";
            this.colTEN.FieldName = "TEN";
            this.colTEN.MinWidth = 31;
            this.colTEN.Name = "colTEN";
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 2;
            this.colTEN.Width = 117;
            // 
            // colDIACHI
            // 
            this.colDIACHI.AppearanceHeader.BackColor = System.Drawing.Color.DodgerBlue;
            this.colDIACHI.AppearanceHeader.BackColor2 = System.Drawing.Color.White;
            this.colDIACHI.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.colDIACHI.AppearanceHeader.ForeColor = System.Drawing.Color.White;
            this.colDIACHI.AppearanceHeader.Options.UseBackColor = true;
            this.colDIACHI.AppearanceHeader.Options.UseFont = true;
            this.colDIACHI.AppearanceHeader.Options.UseForeColor = true;
            this.colDIACHI.Caption = "Địa Chỉ";
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.MinWidth = 31;
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 3;
            this.colDIACHI.Width = 117;
            // 
            // colPHAI
            // 
            this.colPHAI.AppearanceHeader.BackColor = System.Drawing.Color.DodgerBlue;
            this.colPHAI.AppearanceHeader.BackColor2 = System.Drawing.Color.White;
            this.colPHAI.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.colPHAI.AppearanceHeader.ForeColor = System.Drawing.Color.White;
            this.colPHAI.AppearanceHeader.Options.UseBackColor = true;
            this.colPHAI.AppearanceHeader.Options.UseFont = true;
            this.colPHAI.AppearanceHeader.Options.UseForeColor = true;
            this.colPHAI.Caption = "Phái";
            this.colPHAI.FieldName = "PHAI";
            this.colPHAI.MinWidth = 31;
            this.colPHAI.Name = "colPHAI";
            this.colPHAI.Visible = true;
            this.colPHAI.VisibleIndex = 4;
            this.colPHAI.Width = 117;
            // 
            // colSODT
            // 
            this.colSODT.AppearanceHeader.BackColor = System.Drawing.Color.DodgerBlue;
            this.colSODT.AppearanceHeader.BackColor2 = System.Drawing.Color.White;
            this.colSODT.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.colSODT.AppearanceHeader.ForeColor = System.Drawing.Color.White;
            this.colSODT.AppearanceHeader.Options.UseBackColor = true;
            this.colSODT.AppearanceHeader.Options.UseFont = true;
            this.colSODT.AppearanceHeader.Options.UseForeColor = true;
            this.colSODT.Caption = "Số DT";
            this.colSODT.FieldName = "SODT";
            this.colSODT.MinWidth = 31;
            this.colSODT.Name = "colSODT";
            this.colSODT.Visible = true;
            this.colSODT.VisibleIndex = 5;
            this.colSODT.Width = 117;
            // 
            // colMACN
            // 
            this.colMACN.AppearanceHeader.BackColor = System.Drawing.Color.DodgerBlue;
            this.colMACN.AppearanceHeader.BackColor2 = System.Drawing.Color.White;
            this.colMACN.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.colMACN.AppearanceHeader.ForeColor = System.Drawing.Color.White;
            this.colMACN.AppearanceHeader.Options.UseBackColor = true;
            this.colMACN.AppearanceHeader.Options.UseFont = true;
            this.colMACN.AppearanceHeader.Options.UseForeColor = true;
            this.colMACN.Caption = "Mã Chi Nhánh";
            this.colMACN.FieldName = "MACN";
            this.colMACN.MinWidth = 31;
            this.colMACN.Name = "colMACN";
            this.colMACN.OptionsColumn.AllowEdit = false;
            this.colMACN.Visible = true;
            this.colMACN.VisibleIndex = 6;
            this.colMACN.Width = 117;
            // 
            // colTrangThaiXoa
            // 
            this.colTrangThaiXoa.AppearanceHeader.BackColor = System.Drawing.Color.DodgerBlue;
            this.colTrangThaiXoa.AppearanceHeader.BackColor2 = System.Drawing.Color.White;
            this.colTrangThaiXoa.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.colTrangThaiXoa.AppearanceHeader.ForeColor = System.Drawing.Color.White;
            this.colTrangThaiXoa.AppearanceHeader.Options.UseBackColor = true;
            this.colTrangThaiXoa.AppearanceHeader.Options.UseFont = true;
            this.colTrangThaiXoa.AppearanceHeader.Options.UseForeColor = true;
            this.colTrangThaiXoa.FieldName = "TrangThaiXoa";
            this.colTrangThaiXoa.MinWidth = 31;
            this.colTrangThaiXoa.Name = "colTrangThaiXoa";
            this.colTrangThaiXoa.Width = 117;
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
            this.btnThem,
            this.btnLuu,
            this.btnXoa,
            this.btnPhuchoi,
            this.btnReload,
            this.btnChuyenCN,
            this.btnExit});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 8;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLuu, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnPhuchoi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnReload, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnChuyenCN, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnExit, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThem.ImageOptions.SvgImage")));
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnLuu
            // 
            this.btnLuu.Caption = "Ghi";
            this.btnLuu.Id = 2;
            this.btnLuu.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLuu.ImageOptions.SvgImage")));
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLuu_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 3;
            this.btnXoa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXoa.ImageOptions.SvgImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnPhuchoi
            // 
            this.btnPhuchoi.Caption = "Phục hồi";
            this.btnPhuchoi.Id = 4;
            this.btnPhuchoi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPhuchoi.ImageOptions.SvgImage")));
            this.btnPhuchoi.Name = "btnPhuchoi";
            this.btnPhuchoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhuchoi_ItemClick);
            // 
            // btnReload
            // 
            this.btnReload.Caption = "Reload";
            this.btnReload.Id = 5;
            this.btnReload.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnReload.ImageOptions.SvgImage")));
            this.btnReload.Name = "btnReload";
            this.btnReload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReload_ItemClick);
            // 
            // btnChuyenCN
            // 
            this.btnChuyenCN.Caption = "Chuyển chi nhánh";
            this.btnChuyenCN.Id = 6;
            this.btnChuyenCN.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnChuyenCN.ImageOptions.SvgImage")));
            this.btnChuyenCN.Name = "btnChuyenCN";
            this.btnChuyenCN.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnChuyenCN_ItemClick);
            // 
            // btnExit
            // 
            this.btnExit.Caption = "Thoát";
            this.btnExit.Id = 7;
            this.btnExit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnExit.ImageOptions.SvgImage")));
            this.btnExit.Name = "btnExit";
            this.btnExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExit_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(1426, 51);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 624);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1426, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 51);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 573);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1426, 51);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 573);
            // 
            // panelThongtin
            // 
            this.panelThongtin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelThongtin.Location = new System.Drawing.Point(0, 203);
            this.panelThongtin.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.panelThongtin.Name = "panelThongtin";
            this.panelThongtin.Size = new System.Drawing.Size(1426, 421);
            this.panelThongtin.TabIndex = 35;
            // 
            // gD_GOIRUTBindingSource
            // 
            this.gD_GOIRUTBindingSource.DataMember = "FK_GD_GOIRUT_NhanVien";
            this.gD_GOIRUTBindingSource.DataSource = this.nhanVienBindingSource;
            // 
            // gD_CHUYENTIENBindingSource
            // 
            this.gD_CHUYENTIENBindingSource.DataMember = "FK_GD_CHUYENTIEN_NhanVien";
            this.gD_CHUYENTIENBindingSource.DataSource = this.nhanVienBindingSource;
            // 
            // gD_GOIRUTTableAdapter
            // 
            this.gD_GOIRUTTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(181, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chi Nhánh";
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(572, -24);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(80, 21);
            this.hScrollBar1.TabIndex = 32;
            // 
            // gD_CHUYENTIENTableAdapter
            // 
            this.gD_CHUYENTIENTableAdapter.ClearBeforeFill = true;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.lbthongbaonv);
            this.panelControl1.Controls.Add(this.cmbChinhanh);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 51);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1426, 152);
            this.panelControl1.TabIndex = 33;
            // 
            // lbthongbaonv
            // 
            this.lbthongbaonv.AutoSize = true;
            this.lbthongbaonv.Font = new System.Drawing.Font("Tahoma", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbthongbaonv.ForeColor = System.Drawing.Color.Red;
            this.lbthongbaonv.Location = new System.Drawing.Point(1414, 119);
            this.lbthongbaonv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbthongbaonv.Name = "lbthongbaonv";
            this.lbthongbaonv.Size = new System.Drawing.Size(520, 21);
            this.lbthongbaonv.TabIndex = 2;
            this.lbthongbaonv.Text = "Thông báo: Nhân viên không còn làm việc tại chi nhánh này";
            this.lbthongbaonv.Visible = false;
            // 
            // frmNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1426, 644);
            this.Controls.Add(this.nhanVienGridControl);
            this.Controls.Add(this.panelThongtin);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmNV";
            this.Text = "Quản lý nhân viên";
            this.Load += new System.EventHandler(this.frmNV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelThongtin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD_GOIRUTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD_CHUYENTIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbChinhanh;
        private System.Windows.Forms.BindingSource nhanVienBindingSource;
        private DS dS;
        private DSTableAdapters.NhanVienTableAdapter nhanVienTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl nhanVienGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnLuu;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnPhuchoi;
        private DevExpress.XtraBars.BarButtonItem btnReload;
        private DevExpress.XtraBars.BarButtonItem btnChuyenCN;
        private DevExpress.XtraBars.BarButtonItem btnExit;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.PanelControl panelThongtin;
        private DevExpress.XtraEditors.HScrollBar hScrollBar1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource gD_GOIRUTBindingSource;
        private System.Windows.Forms.BindingSource gD_CHUYENTIENBindingSource;
        private DSTableAdapters.GD_GOIRUTTableAdapter gD_GOIRUTTableAdapter;
        private DSTableAdapters.GD_CHUYENTIENTableAdapter gD_CHUYENTIENTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colPHAI;
        private DevExpress.XtraGrid.Columns.GridColumn colSODT;
        private DevExpress.XtraGrid.Columns.GridColumn colMACN;
        private DevExpress.XtraGrid.Columns.GridColumn colTrangThaiXoa;
        private System.Windows.Forms.Label lbthongbaonv;
    }
}