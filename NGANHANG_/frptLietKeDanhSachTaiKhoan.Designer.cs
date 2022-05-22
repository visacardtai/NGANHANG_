
namespace NGANHANG_
{
    partial class frptLietKeDanhSachTaiKhoan
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnXuatBaoCao = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.dateto = new DevExpress.XtraEditors.DateEdit();
            this.datefrom = new DevExpress.XtraEditors.DateEdit();
            this.ckInchinhanh = new System.Windows.Forms.CheckBox();
            this.dS = new NGANHANG_.DS();
            this.chinhanhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chinhanhTableAdapter = new NGANHANG_.DSTableAdapters.ChinhanhTableAdapter();
            this.tableAdapterManager = new NGANHANG_.DSTableAdapters.TableAdapterManager();
            this.cmbChinhanh = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dateto.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datefrom.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datefrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chinhanhBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(91, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chi Nhánh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(108, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Từ ngày";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(421, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Đến ngày";
            // 
            // btnXuatBaoCao
            // 
            this.btnXuatBaoCao.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXuatBaoCao.Location = new System.Drawing.Point(160, 250);
            this.btnXuatBaoCao.Name = "btnXuatBaoCao";
            this.btnXuatBaoCao.Size = new System.Drawing.Size(170, 32);
            this.btnXuatBaoCao.TabIndex = 6;
            this.btnXuatBaoCao.Text = "XUẤT BÁO CÁO";
            this.btnXuatBaoCao.UseVisualStyleBackColor = true;
            this.btnXuatBaoCao.Click += new System.EventHandler(this.btnXuatBaoCao_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoat.Location = new System.Drawing.Point(453, 250);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(138, 32);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "THOÁT";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // dateto
            // 
            this.dateto.EditValue = new System.DateTime(2022, 5, 22, 22, 48, 20, 154);
            this.dateto.Location = new System.Drawing.Point(506, 123);
            this.dateto.Name = "dateto";
            this.dateto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateto.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateto.Size = new System.Drawing.Size(153, 22);
            this.dateto.TabIndex = 8;
            // 
            // datefrom
            // 
            this.datefrom.EditValue = new System.DateTime(2022, 1, 1, 22, 48, 11, 0);
            this.datefrom.Location = new System.Drawing.Point(192, 125);
            this.datefrom.Name = "datefrom";
            this.datefrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.datefrom.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.datefrom.Size = new System.Drawing.Size(138, 22);
            this.datefrom.TabIndex = 9;
            // 
            // ckInchinhanh
            // 
            this.ckInchinhanh.AutoSize = true;
            this.ckInchinhanh.Location = new System.Drawing.Point(495, 60);
            this.ckInchinhanh.Name = "ckInchinhanh";
            this.ckInchinhanh.Size = new System.Drawing.Size(146, 21);
            this.ckInchinhanh.TabIndex = 11;
            this.ckInchinhanh.Text = "In tất cả chi nhánh";
            this.ckInchinhanh.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ckInchinhanh.UseVisualStyleBackColor = true;
            this.ckInchinhanh.CheckedChanged += new System.EventHandler(this.ckInchinhanh_CheckedChanged);
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chinhanhBindingSource
            // 
            this.chinhanhBindingSource.DataMember = "Chinhanh";
            this.chinhanhBindingSource.DataSource = this.dS;
            // 
            // chinhanhTableAdapter
            // 
            this.chinhanhTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.GD_CHUYENTIENTableAdapter = null;
            this.tableAdapterManager.GD_GOIRUTTableAdapter = null;
            this.tableAdapterManager.KhachHangTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.TaiKhoanTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = NGANHANG_.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cmbChinhanh
            // 
            this.cmbChinhanh.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.chinhanhBindingSource, "TENCN", true));
            this.cmbChinhanh.DataSource = this.chinhanhBindingSource;
            this.cmbChinhanh.DisplayMember = "TENCN";
            this.cmbChinhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChinhanh.FormattingEnabled = true;
            this.cmbChinhanh.Location = new System.Drawing.Point(192, 54);
            this.cmbChinhanh.Name = "cmbChinhanh";
            this.cmbChinhanh.Size = new System.Drawing.Size(213, 24);
            this.cmbChinhanh.TabIndex = 13;
            this.cmbChinhanh.ValueMember = "MACN";
            this.cmbChinhanh.SelectedIndexChanged += new System.EventHandler(this.cmbChinhanh_SelectedIndexChanged);
            // 
            // frptLietKeDanhSachTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 395);
            this.Controls.Add(this.cmbChinhanh);
            this.Controls.Add(this.ckInchinhanh);
            this.Controls.Add(this.datefrom);
            this.Controls.Add(this.dateto);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXuatBaoCao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frptLietKeDanhSachTaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frptLietKeDanhSachTaiKhoan";
            this.Load += new System.EventHandler(this.frptLietKeDanhSachTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dateto.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datefrom.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datefrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chinhanhBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnXuatBaoCao;
        private System.Windows.Forms.Button btnThoat;
        private DevExpress.XtraEditors.DateEdit dateto;
        private DevExpress.XtraEditors.DateEdit datefrom;
        private System.Windows.Forms.CheckBox ckInchinhanh;
        private DS dS;
        private System.Windows.Forms.BindingSource chinhanhBindingSource;
        private DSTableAdapters.ChinhanhTableAdapter chinhanhTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cmbChinhanh;
    }
}