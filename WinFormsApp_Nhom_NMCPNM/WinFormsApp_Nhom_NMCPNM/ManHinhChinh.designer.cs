namespace WinFormsApp_Nhom_NMCPNM
{
    partial class form_manhinhchinh
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
            this.mns_luachon = new System.Windows.Forms.MenuStrip();
            this.mnsi_venhahang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsi_thongtin = new System.Windows.Forms.ToolStripMenuItem();
            this.tmnsi_tracuutieccuoi = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsi_sanh = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsi_loaisanh = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsi_monan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsi_dichvu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsi_dattieccuoi = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsi_baocaodoanhso = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsi_dangnhap = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsi_thongtintaikhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsi_quanlyquydinh = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsi_dangxuat = new System.Windows.Forms.ToolStripMenuItem();
            this.pb_manhinhchinh = new System.Windows.Forms.PictureBox();
            this.lb_nhahangtieccuoi = new System.Windows.Forms.Label();
            this.lb_tennhahang = new System.Windows.Forms.Label();
            this.mns_luachon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_manhinhchinh)).BeginInit();
            this.SuspendLayout();
            // 
            // mns_luachon
            // 
            this.mns_luachon.AutoSize = false;
            this.mns_luachon.BackColor = System.Drawing.SystemColors.Desktop;
            this.mns_luachon.Dock = System.Windows.Forms.DockStyle.Left;
            this.mns_luachon.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mns_luachon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsi_venhahang,
            this.mnsi_thongtin,
            this.mnsi_dattieccuoi,
            this.mnsi_baocaodoanhso,
            this.mnsi_dangnhap,
            this.mnsi_thongtintaikhoan,
            this.mnsi_quanlyquydinh,
            this.mnsi_dangxuat});
            this.mns_luachon.Location = new System.Drawing.Point(0, 0);
            this.mns_luachon.Name = "mns_luachon";
            this.mns_luachon.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.mns_luachon.Size = new System.Drawing.Size(146, 497);
            this.mns_luachon.TabIndex = 0;
            this.mns_luachon.Text = "Lựa chọn";
            // 
            // mnsi_venhahang
            // 
            this.mnsi_venhahang.AutoSize = false;
            this.mnsi_venhahang.BackColor = System.Drawing.SystemColors.Desktop;
            this.mnsi_venhahang.ForeColor = System.Drawing.SystemColors.Info;
            this.mnsi_venhahang.Name = "mnsi_venhahang";
            this.mnsi_venhahang.Size = new System.Drawing.Size(163, 60);
            this.mnsi_venhahang.Text = "Về nhà hàng";
            // 
            // mnsi_thongtin
            // 
            this.mnsi_thongtin.AutoSize = false;
            this.mnsi_thongtin.BackColor = System.Drawing.SystemColors.Desktop;
            this.mnsi_thongtin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmnsi_tracuutieccuoi,
            this.mnsi_sanh,
            this.mnsi_loaisanh,
            this.mnsi_monan,
            this.mnsi_dichvu});
            this.mnsi_thongtin.ForeColor = System.Drawing.SystemColors.Info;
            this.mnsi_thongtin.Name = "mnsi_thongtin";
            this.mnsi_thongtin.Size = new System.Drawing.Size(163, 60);
            this.mnsi_thongtin.Text = "Thông tin";
            // 
            // tmnsi_tracuutieccuoi
            // 
            this.tmnsi_tracuutieccuoi.BackColor = System.Drawing.SystemColors.Desktop;
            this.tmnsi_tracuutieccuoi.ForeColor = System.Drawing.SystemColors.Info;
            this.tmnsi_tracuutieccuoi.Name = "tmnsi_tracuutieccuoi";
            this.tmnsi_tracuutieccuoi.Size = new System.Drawing.Size(192, 26);
            this.tmnsi_tracuutieccuoi.Text = "Tra cứu tiệc cưới";
            this.tmnsi_tracuutieccuoi.Click += new System.EventHandler(this.tmnsi_tracuutieccuoi_Click);
            // 
            // mnsi_sanh
            // 
            this.mnsi_sanh.BackColor = System.Drawing.SystemColors.Desktop;
            this.mnsi_sanh.ForeColor = System.Drawing.SystemColors.Info;
            this.mnsi_sanh.Name = "mnsi_sanh";
            this.mnsi_sanh.Size = new System.Drawing.Size(192, 26);
            this.mnsi_sanh.Text = "Sảnh";
            this.mnsi_sanh.Click += new System.EventHandler(this.mnsi_sanh_Click);
            // 
            // mnsi_loaisanh
            // 
            this.mnsi_loaisanh.BackColor = System.Drawing.SystemColors.Desktop;
            this.mnsi_loaisanh.ForeColor = System.Drawing.SystemColors.Info;
            this.mnsi_loaisanh.Name = "mnsi_loaisanh";
            this.mnsi_loaisanh.Size = new System.Drawing.Size(192, 26);
            this.mnsi_loaisanh.Text = "Loại sảnh";
            this.mnsi_loaisanh.Click += new System.EventHandler(this.mnsi_loaisanh_Click);
            // 
            // mnsi_monan
            // 
            this.mnsi_monan.BackColor = System.Drawing.SystemColors.Desktop;
            this.mnsi_monan.ForeColor = System.Drawing.SystemColors.Info;
            this.mnsi_monan.Name = "mnsi_monan";
            this.mnsi_monan.Size = new System.Drawing.Size(192, 26);
            this.mnsi_monan.Text = "Món ăn";
            this.mnsi_monan.Click += new System.EventHandler(this.mnsi_monan_Click);
            // 
            // mnsi_dichvu
            // 
            this.mnsi_dichvu.BackColor = System.Drawing.SystemColors.Desktop;
            this.mnsi_dichvu.ForeColor = System.Drawing.SystemColors.Info;
            this.mnsi_dichvu.Name = "mnsi_dichvu";
            this.mnsi_dichvu.Size = new System.Drawing.Size(192, 26);
            this.mnsi_dichvu.Text = "Dịch vụ";
            this.mnsi_dichvu.Click += new System.EventHandler(this.mnsi_dichvu_Click);
            // 
            // mnsi_dattieccuoi
            // 
            this.mnsi_dattieccuoi.AutoSize = false;
            this.mnsi_dattieccuoi.ForeColor = System.Drawing.SystemColors.Info;
            this.mnsi_dattieccuoi.Name = "mnsi_dattieccuoi";
            this.mnsi_dattieccuoi.Size = new System.Drawing.Size(163, 60);
            this.mnsi_dattieccuoi.Text = "Đặt tiệc cưới";
            this.mnsi_dattieccuoi.Click += new System.EventHandler(this.mnsi_dattieccuoi_Click);
            // 
            // mnsi_baocaodoanhso
            // 
            this.mnsi_baocaodoanhso.AutoSize = false;
            this.mnsi_baocaodoanhso.ForeColor = System.Drawing.SystemColors.Info;
            this.mnsi_baocaodoanhso.Name = "mnsi_baocaodoanhso";
            this.mnsi_baocaodoanhso.Size = new System.Drawing.Size(163, 60);
            this.mnsi_baocaodoanhso.Text = "Báo cáo doanh số";
            this.mnsi_baocaodoanhso.Click += new System.EventHandler(this.mnsi_baocaodoanhso_Click);
            // 
            // mnsi_dangnhap
            // 
            this.mnsi_dangnhap.AutoSize = false;
            this.mnsi_dangnhap.ForeColor = System.Drawing.SystemColors.Info;
            this.mnsi_dangnhap.Name = "mnsi_dangnhap";
            this.mnsi_dangnhap.Size = new System.Drawing.Size(163, 60);
            this.mnsi_dangnhap.Text = "Đăng nhập";
            this.mnsi_dangnhap.Click += new System.EventHandler(this.mnsi_dangnhap_Click);
            // 
            // mnsi_thongtintaikhoan
            // 
            this.mnsi_thongtintaikhoan.AutoSize = false;
            this.mnsi_thongtintaikhoan.ForeColor = System.Drawing.SystemColors.Info;
            this.mnsi_thongtintaikhoan.Name = "mnsi_thongtintaikhoan";
            this.mnsi_thongtintaikhoan.Size = new System.Drawing.Size(163, 60);
            this.mnsi_thongtintaikhoan.Text = "Thông tin tài khoản";
            this.mnsi_thongtintaikhoan.Click += new System.EventHandler(this.mnsi_thongtintaikhoan_Click);
            // 
            // mnsi_quanlyquydinh
            // 
            this.mnsi_quanlyquydinh.AutoSize = false;
            this.mnsi_quanlyquydinh.ForeColor = System.Drawing.SystemColors.Info;
            this.mnsi_quanlyquydinh.Name = "mnsi_quanlyquydinh";
            this.mnsi_quanlyquydinh.Size = new System.Drawing.Size(163, 60);
            this.mnsi_quanlyquydinh.Text = "Quản lý quy định";
            this.mnsi_quanlyquydinh.Click += new System.EventHandler(this.mnsi_quanlyquydinh_Click);
            // 
            // mnsi_dangxuat
            // 
            this.mnsi_dangxuat.AutoSize = false;
            this.mnsi_dangxuat.ForeColor = System.Drawing.SystemColors.Info;
            this.mnsi_dangxuat.Name = "mnsi_dangxuat";
            this.mnsi_dangxuat.Size = new System.Drawing.Size(163, 60);
            this.mnsi_dangxuat.Text = "Đăng xuất";
            this.mnsi_dangxuat.Click += new System.EventHandler(this.mnsi_dangxuat_Click);
            // 
            // pb_manhinhchinh
            // 
            this.pb_manhinhchinh.Location = new System.Drawing.Point(141, 0);
            this.pb_manhinhchinh.Name = "pb_manhinhchinh";
            this.pb_manhinhchinh.Size = new System.Drawing.Size(753, 563);
            this.pb_manhinhchinh.TabIndex = 1;
            this.pb_manhinhchinh.TabStop = false;
            // 
            // lb_nhahangtieccuoi
            // 
            this.lb_nhahangtieccuoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_nhahangtieccuoi.AutoSize = true;
            this.lb_nhahangtieccuoi.BackColor = System.Drawing.Color.Transparent;
            this.lb_nhahangtieccuoi.Font = new System.Drawing.Font("Shalimar", 20F, System.Drawing.FontStyle.Bold);
            this.lb_nhahangtieccuoi.Location = new System.Drawing.Point(606, 138);
            this.lb_nhahangtieccuoi.Name = "lb_nhahangtieccuoi";
            this.lb_nhahangtieccuoi.Size = new System.Drawing.Size(275, 44);
            this.lb_nhahangtieccuoi.TabIndex = 2;
            this.lb_nhahangtieccuoi.Text = "NHÀ HÀNG TIỆC CƯỚI";
            // 
            // lb_tennhahang
            // 
            this.lb_tennhahang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_tennhahang.AutoSize = true;
            this.lb_tennhahang.BackColor = System.Drawing.Color.Transparent;
            this.lb_tennhahang.Font = new System.Drawing.Font("Shalimar", 50F, System.Drawing.FontStyle.Bold);
            this.lb_tennhahang.Location = new System.Drawing.Point(607, 182);
            this.lb_tennhahang.Name = "lb_tennhahang";
            this.lb_tennhahang.Size = new System.Drawing.Size(257, 110);
            this.lb_tennhahang.TabIndex = 3;
            this.lb_tennhahang.Text = "TMHĐN";
            // 
            // form_manhinhchinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 497);
            this.Controls.Add(this.lb_tennhahang);
            this.Controls.Add(this.lb_nhahangtieccuoi);
            this.Controls.Add(this.mns_luachon);
            this.Controls.Add(this.pb_manhinhchinh);
            this.MainMenuStrip = this.mns_luachon;
            this.Name = "form_manhinhchinh";
            this.Text = "Màn hình chính";
            this.mns_luachon.ResumeLayout(false);
            this.mns_luachon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_manhinhchinh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mns_luachon;
        private System.Windows.Forms.ToolStripMenuItem mnsi_venhahang;
        private System.Windows.Forms.ToolStripMenuItem mnsi_thongtin;
        private System.Windows.Forms.ToolStripMenuItem tmnsi_tracuutieccuoi;
        private System.Windows.Forms.ToolStripMenuItem mnsi_sanh;
        private System.Windows.Forms.ToolStripMenuItem mnsi_monan;
        private System.Windows.Forms.ToolStripMenuItem mnsi_dichvu;
        private System.Windows.Forms.ToolStripMenuItem mnsi_dattieccuoi;
        private System.Windows.Forms.ToolStripMenuItem mnsi_baocaodoanhso;
        private System.Windows.Forms.ToolStripMenuItem mnsi_dangnhap;
        private System.Windows.Forms.ToolStripMenuItem mnsi_dangxuat;
        private System.Windows.Forms.ToolStripMenuItem mnsi_thongtintaikhoan;
        private System.Windows.Forms.ToolStripMenuItem mnsi_quanlyquydinh;
        private System.Windows.Forms.PictureBox pb_manhinhchinh;
        private System.Windows.Forms.Label lb_nhahangtieccuoi;
        private System.Windows.Forms.Label lb_tennhahang;
        private System.Windows.Forms.ToolStripMenuItem mnsi_loaisanh;
    }
}