
namespace WinFormsApp_Nhom_NMCPNM
{
    partial class form_thongtintaikhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_thongtintaikhoan));
            this.lb_tennguoidung = new System.Windows.Forms.Label();
            this.lb_quyenhan = new System.Windows.Forms.Label();
            this.tb_tennguoidung = new System.Windows.Forms.TextBox();
            this.tb_quyenhan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pb_manhinhchinh = new System.Windows.Forms.PictureBox();
            this.pb_quaylai = new System.Windows.Forms.PictureBox();
            this.lb_matkhau = new System.Windows.Forms.Label();
            this.lb_taikhoan = new System.Windows.Forms.Label();
            this.tb_taikhoan = new System.Windows.Forms.TextBox();
            this.tb_matkhau = new System.Windows.Forms.TextBox();
            this.bt_luu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_manhinhchinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_quaylai)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_tennguoidung
            // 
            this.lb_tennguoidung.AutoSize = true;
            this.lb_tennguoidung.Location = new System.Drawing.Point(17, 120);
            this.lb_tennguoidung.Name = "lb_tennguoidung";
            this.lb_tennguoidung.Size = new System.Drawing.Size(105, 19);
            this.lb_tennguoidung.TabIndex = 0;
            this.lb_tennguoidung.Text = "Tên người dùng";
            this.lb_tennguoidung.Click += new System.EventHandler(this.lb_tennguoidung_Click);
            // 
            // lb_quyenhan
            // 
            this.lb_quyenhan.AutoSize = true;
            this.lb_quyenhan.Location = new System.Drawing.Point(17, 164);
            this.lb_quyenhan.Name = "lb_quyenhan";
            this.lb_quyenhan.Size = new System.Drawing.Size(77, 19);
            this.lb_quyenhan.TabIndex = 1;
            this.lb_quyenhan.Text = "Quyền hạn";
            this.lb_quyenhan.Click += new System.EventHandler(this.lb_quyenhan_Click);
            // 
            // tb_tennguoidung
            // 
            this.tb_tennguoidung.Location = new System.Drawing.Point(128, 116);
            this.tb_tennguoidung.Name = "tb_tennguoidung";
            this.tb_tennguoidung.Size = new System.Drawing.Size(359, 25);
            this.tb_tennguoidung.TabIndex = 2;
            this.tb_tennguoidung.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tb_quyenhan
            // 
            this.tb_quyenhan.Location = new System.Drawing.Point(128, 160);
            this.tb_quyenhan.Name = "tb_quyenhan";
            this.tb_quyenhan.Size = new System.Drawing.Size(359, 25);
            this.tb_quyenhan.TabIndex = 3;
            this.tb_quyenhan.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.label1.Location = new System.Drawing.Point(186, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "THÔNG TIN TÀI KHOẢN";
            // 
            // pb_manhinhchinh
            // 
            this.pb_manhinhchinh.Location = new System.Drawing.Point(43, 9);
            this.pb_manhinhchinh.Name = "pb_manhinhchinh";
            this.pb_manhinhchinh.Size = new System.Drawing.Size(27, 27);
            this.pb_manhinhchinh.TabIndex = 26;
            this.pb_manhinhchinh.TabStop = false;
            this.pb_manhinhchinh.Click += new System.EventHandler(this.pb_manhinhchinh_Click);
            // 
            // pb_quaylai
            // 
            this.pb_quaylai.Location = new System.Drawing.Point(12, 9);
            this.pb_quaylai.Name = "pb_quaylai";
            this.pb_quaylai.Size = new System.Drawing.Size(27, 27);
            this.pb_quaylai.TabIndex = 25;
            this.pb_quaylai.TabStop = false;
            this.pb_quaylai.Click += new System.EventHandler(this.pb_quaylai_Click);
            // 
            // lb_matkhau
            // 
            this.lb_matkhau.AutoSize = true;
            this.lb_matkhau.Location = new System.Drawing.Point(15, 208);
            this.lb_matkhau.Name = "lb_matkhau";
            this.lb_matkhau.Size = new System.Drawing.Size(68, 19);
            this.lb_matkhau.TabIndex = 27;
            this.lb_matkhau.Text = "Mật khẩu";
            // 
            // lb_taikhoan
            // 
            this.lb_taikhoan.AutoSize = true;
            this.lb_taikhoan.Location = new System.Drawing.Point(17, 78);
            this.lb_taikhoan.Name = "lb_taikhoan";
            this.lb_taikhoan.Size = new System.Drawing.Size(66, 19);
            this.lb_taikhoan.TabIndex = 28;
            this.lb_taikhoan.Text = "Tài khoản";
            // 
            // tb_taikhoan
            // 
            this.tb_taikhoan.Location = new System.Drawing.Point(128, 72);
            this.tb_taikhoan.Name = "tb_taikhoan";
            this.tb_taikhoan.Size = new System.Drawing.Size(359, 25);
            this.tb_taikhoan.TabIndex = 29;
            // 
            // tb_matkhau
            // 
            this.tb_matkhau.Location = new System.Drawing.Point(128, 205);
            this.tb_matkhau.Name = "tb_matkhau";
            this.tb_matkhau.Size = new System.Drawing.Size(359, 25);
            this.tb_matkhau.TabIndex = 30;
            // 
            // bt_luu
            // 
            this.bt_luu.AutoSize = true;
            this.bt_luu.Location = new System.Drawing.Point(488, 255);
            this.bt_luu.Name = "bt_luu";
            this.bt_luu.Size = new System.Drawing.Size(75, 29);
            this.bt_luu.TabIndex = 31;
            this.bt_luu.Text = "Lưu";
            this.bt_luu.UseVisualStyleBackColor = true;
            // 
            // form_thongtintaikhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(594, 296);
            this.Controls.Add(this.bt_luu);
            this.Controls.Add(this.tb_matkhau);
            this.Controls.Add(this.tb_taikhoan);
            this.Controls.Add(this.lb_taikhoan);
            this.Controls.Add(this.lb_matkhau);
            this.Controls.Add(this.pb_manhinhchinh);
            this.Controls.Add(this.pb_quaylai);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_quyenhan);
            this.Controls.Add(this.tb_tennguoidung);
            this.Controls.Add(this.lb_quyenhan);
            this.Controls.Add(this.lb_tennguoidung);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(610, 316);
            this.Name = "form_thongtintaikhoan";
            this.Text = "Thông tin tài khoản";
            ((System.ComponentModel.ISupportInitialize)(this.pb_manhinhchinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_quaylai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_tennguoidung;
        private System.Windows.Forms.Label lb_quyenhan;
        private System.Windows.Forms.TextBox tb_tennguoidung;
        private System.Windows.Forms.TextBox tb_quyenhan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pb_manhinhchinh;
        private System.Windows.Forms.PictureBox pb_quaylai;
        private System.Windows.Forms.Label lb_matkhau;
        private System.Windows.Forms.Label lb_taikhoan;
        private System.Windows.Forms.TextBox tb_taikhoan;
        private System.Windows.Forms.TextBox tb_matkhau;
        private System.Windows.Forms.Button bt_luu;
    }
}