
namespace NGANHANG_
{
    partial class Frpt_SaoKeGiaoDichKhachHang
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
            System.Windows.Forms.Label kHLabel;
            System.Windows.Forms.Label sOTKLabel;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            this.cmbChiNhanh = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dS = new NGANHANG_.DS();
            this.bdsTTKH = new System.Windows.Forms.BindingSource(this.components);
            this.tbaTTKH = new NGANHANG_.DSTableAdapters.TTKHTableAdapter();
            this.tbmTTKH = new NGANHANG_.DSTableAdapters.TableAdapterManager();
            this.cmbTTKH = new System.Windows.Forms.ComboBox();
            this.btnPreview = new System.Windows.Forms.Button();
            this.bdsKH = new System.Windows.Forms.BindingSource(this.components);
            this.tbaKH = new NGANHANG_.DSTableAdapters.KhachHangTableAdapter();
            this.bdsTK_KH = new System.Windows.Forms.BindingSource(this.components);
            this.tbaTK_KH = new NGANHANG_.DSTableAdapters.TaiKhoanTableAdapter();
            this.cmbSTK = new System.Windows.Forms.ComboBox();
            this.dtpFromDay = new System.Windows.Forms.DateTimePicker();
            this.dtpToDay = new System.Windows.Forms.DateTimePicker();
            kHLabel = new System.Windows.Forms.Label();
            sOTKLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTTKH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTK_KH)).BeginInit();
            this.SuspendLayout();
            // 
            // kHLabel
            // 
            kHLabel.AutoSize = true;
            kHLabel.Location = new System.Drawing.Point(129, 125);
            kHLabel.Name = "kHLabel";
            kHLabel.Size = new System.Drawing.Size(101, 20);
            kHLabel.TabIndex = 2;
            kHLabel.Text = "Khách Hàng:";
            // 
            // sOTKLabel
            // 
            sOTKLabel.AutoSize = true;
            sOTKLabel.Location = new System.Drawing.Point(687, 125);
            sOTKLabel.Name = "sOTKLabel";
            sOTKLabel.Size = new System.Drawing.Size(204, 20);
            sOTKLabel.TabIndex = 5;
            sOTKLabel.Text = "Số Tài Khoản Khách Hàng: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(687, 221);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(87, 20);
            label2.TabIndex = 9;
            label2.Text = "Đến Ngày: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(129, 223);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(75, 20);
            label3.TabIndex = 10;
            label3.Text = "Từ Ngày: ";
            // 
            // cmbChiNhanh
            // 
            this.cmbChiNhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChiNhanh.FormattingEnabled = true;
            this.cmbChiNhanh.Location = new System.Drawing.Point(515, 37);
            this.cmbChiNhanh.Name = "cmbChiNhanh";
            this.cmbChiNhanh.Size = new System.Drawing.Size(326, 28);
            this.cmbChiNhanh.TabIndex = 0;
            this.cmbChiNhanh.SelectedIndexChanged += new System.EventHandler(this.cmbChiNhanh_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(402, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chi Nhánh: ";
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsTTKH
            // 
            this.bdsTTKH.DataMember = "TTKH";
            this.bdsTTKH.DataSource = this.dS;
            // 
            // tbaTTKH
            // 
            this.tbaTTKH.ClearBeforeFill = true;
            // 
            // tbmTTKH
            // 
            this.tbmTTKH.BackupDataSetBeforeUpdate = false;
            this.tbmTTKH.Connection = null;
            this.tbmTTKH.GD_CHUYENTIENTableAdapter = null;
            this.tbmTTKH.GD_GOIRUTTableAdapter = null;
            this.tbmTTKH.KhachHangTableAdapter = null;
            this.tbmTTKH.NhanVienTableAdapter = null;
            this.tbmTTKH.TaiKhoanTableAdapter = null;
            this.tbmTTKH.UpdateOrder = NGANHANG_.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cmbTTKH
            // 
            this.cmbTTKH.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbTTKH.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbTTKH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsTTKH, "KH", true));
            this.cmbTTKH.DataSource = this.bdsTTKH;
            this.cmbTTKH.DisplayMember = "KH";
            this.cmbTTKH.FormattingEnabled = true;
            this.cmbTTKH.Location = new System.Drawing.Point(248, 122);
            this.cmbTTKH.Name = "cmbTTKH";
            this.cmbTTKH.Size = new System.Drawing.Size(326, 28);
            this.cmbTTKH.TabIndex = 3;
            this.cmbTTKH.ValueMember = "CMND";
            this.cmbTTKH.SelectedIndexChanged += new System.EventHandler(this.cmbTTKH_SelectedIndexChanged);
            // 
            // btnPreview
            // 
            this.btnPreview.BackColor = System.Drawing.Color.Aqua;
            this.btnPreview.Location = new System.Drawing.Point(502, 337);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(209, 63);
            this.btnPreview.TabIndex = 4;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = false;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // bdsKH
            // 
            this.bdsKH.DataMember = "KhachHang";
            this.bdsKH.DataSource = this.dS;
            // 
            // tbaKH
            // 
            this.tbaKH.ClearBeforeFill = true;
            // 
            // bdsTK_KH
            // 
            this.bdsTK_KH.DataMember = "FK_TaiKhoan_KhachHang";
            this.bdsTK_KH.DataSource = this.bdsKH;
            // 
            // tbaTK_KH
            // 
            this.tbaTK_KH.ClearBeforeFill = true;
            // 
            // cmbSTK
            // 
            this.cmbSTK.DataSource = this.bdsTK_KH;
            this.cmbSTK.DisplayMember = "SOTK";
            this.cmbSTK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSTK.FormattingEnabled = true;
            this.cmbSTK.Location = new System.Drawing.Point(897, 122);
            this.cmbSTK.Name = "cmbSTK";
            this.cmbSTK.Size = new System.Drawing.Size(180, 28);
            this.cmbSTK.TabIndex = 6;
            this.cmbSTK.ValueMember = "SOTK";
            this.cmbSTK.SelectedIndexChanged += new System.EventHandler(this.cmbSTK_SelectedIndexChanged);
            // 
            // dtpFromDay
            // 
            this.dtpFromDay.Location = new System.Drawing.Point(248, 220);
            this.dtpFromDay.Name = "dtpFromDay";
            this.dtpFromDay.Size = new System.Drawing.Size(245, 26);
            this.dtpFromDay.TabIndex = 7;
            // 
            // dtpToDay
            // 
            this.dtpToDay.Location = new System.Drawing.Point(897, 220);
            this.dtpToDay.Name = "dtpToDay";
            this.dtpToDay.Size = new System.Drawing.Size(245, 26);
            this.dtpToDay.TabIndex = 8;
            // 
            // Frpt_SaoKeGiaoDichKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 453);
            this.Controls.Add(label3);
            this.Controls.Add(label2);
            this.Controls.Add(this.dtpToDay);
            this.Controls.Add(this.dtpFromDay);
            this.Controls.Add(sOTKLabel);
            this.Controls.Add(this.cmbSTK);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(kHLabel);
            this.Controls.Add(this.cmbTTKH);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbChiNhanh);
            this.Name = "Frpt_SaoKeGiaoDichKhachHang";
            this.Text = "Frpt_SaoKeGiaoDichKhachHang";
            this.Load += new System.EventHandler(this.Frpt_SaoKeGiaoDichKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTTKH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTK_KH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbChiNhanh;
        private System.Windows.Forms.Label label1;
        private DS dS;
        private System.Windows.Forms.BindingSource bdsTTKH;
        private DSTableAdapters.TTKHTableAdapter tbaTTKH;
        private DSTableAdapters.TableAdapterManager tbmTTKH;
        private System.Windows.Forms.ComboBox cmbTTKH;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.BindingSource bdsKH;
        private DSTableAdapters.KhachHangTableAdapter tbaKH;
        private System.Windows.Forms.BindingSource bdsTK_KH;
        private DSTableAdapters.TaiKhoanTableAdapter tbaTK_KH;
        private System.Windows.Forms.ComboBox cmbSTK;
        private System.Windows.Forms.DateTimePicker dtpFromDay;
        private System.Windows.Forms.DateTimePicker dtpToDay;
    }
}