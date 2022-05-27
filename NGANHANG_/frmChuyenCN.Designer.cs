
namespace NGANHANG_
{
    partial class frmChuyenCN
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
            this.lbThongbao = new System.Windows.Forms.Label();
            this.btnVerify = new System.Windows.Forms.Button();
            this.cbChinhanh = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbThongbao
            // 
            this.lbThongbao.AutoSize = true;
            this.lbThongbao.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbThongbao.Location = new System.Drawing.Point(195, 223);
            this.lbThongbao.Name = "lbThongbao";
            this.lbThongbao.Size = new System.Drawing.Size(496, 17);
            this.lbThongbao.TabIndex = 11;
            this.lbThongbao.Text = "Nhân viên chưa từng làm việc ở chi nhánh này, vui lòng chọn mã nhân viên mới";
            this.lbThongbao.Visible = false;
            // 
            // btnVerify
            // 
            this.btnVerify.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnVerify.Location = new System.Drawing.Point(306, 318);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(140, 49);
            this.btnVerify.TabIndex = 10;
            this.btnVerify.Text = "Xác Nhận";
            this.btnVerify.UseVisualStyleBackColor = true;
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // cbChinhanh
            // 
            this.cbChinhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChinhanh.FormattingEnabled = true;
            this.cbChinhanh.Location = new System.Drawing.Point(306, 181);
            this.cbChinhanh.Name = "cbChinhanh";
            this.cbChinhanh.Size = new System.Drawing.Size(304, 24);
            this.cbChinhanh.TabIndex = 9;
            this.cbChinhanh.SelectedIndexChanged += new System.EventHandler(this.cbChinhanh_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(194, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Chi Nhánh";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(82, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(637, 55);
            this.label1.TabIndex = 7;
            this.label1.Text = "Chọn Chi Nhánh Cần Chuyển";
            // 
            // frmChuyenCN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 450);
            this.Controls.Add(this.lbThongbao);
            this.Controls.Add(this.btnVerify);
            this.Controls.Add(this.cbChinhanh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmChuyenCN";
            this.Text = "Chuyển chi nhánh";
            this.Load += new System.EventHandler(this.frmChuyenCN_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbThongbao;
        private System.Windows.Forms.Button btnVerify;
        private System.Windows.Forms.ComboBox cbChinhanh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}