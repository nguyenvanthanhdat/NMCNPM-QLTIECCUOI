
namespace WinFormsApp_Nhom_NMCPNM
{
    partial class form_dangnhap
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_tendangnhap = new System.Windows.Forms.Label();
            this.lb_matkhau = new System.Windows.Forms.Label();
            this.tb_ten_dang_nhap = new System.Windows.Forms.TextBox();
            this.tb_matkhau = new System.Windows.Forms.TextBox();
            this.bt_dangnhap = new System.Windows.Forms.Button();
            this.lb_title_dangnhap = new System.Windows.Forms.Label();
            this.lb_quenmatkhau = new System.Windows.Forms.Label();
            this.pb_manhinhchinh = new System.Windows.Forms.PictureBox();
            this.pb_quaylai = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_manhinhchinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_quaylai)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_tendangnhap
            // 
            this.lb_tendangnhap.AutoSize = true;
            this.lb_tendangnhap.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lb_tendangnhap.Location = new System.Drawing.Point(165, 115);
            this.lb_tendangnhap.Name = "lb_tendangnhap";
            this.lb_tendangnhap.Size = new System.Drawing.Size(111, 21);
            this.lb_tendangnhap.TabIndex = 2;
            this.lb_tendangnhap.Text = "Tên đăng nhập";
            // 
            // lb_matkhau
            // 
            this.lb_matkhau.AutoSize = true;
            this.lb_matkhau.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lb_matkhau.Location = new System.Drawing.Point(165, 173);
            this.lb_matkhau.Name = "lb_matkhau";
            this.lb_matkhau.Size = new System.Drawing.Size(75, 21);
            this.lb_matkhau.TabIndex = 3;
            this.lb_matkhau.Text = "Mật khẩu";
            this.lb_matkhau.Click += new System.EventHandler(this.lb_matkhau_Click);
            // 
            // tb_ten_dang_nhap
            // 
            this.tb_ten_dang_nhap.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tb_ten_dang_nhap.Location = new System.Drawing.Point(282, 115);
            this.tb_ten_dang_nhap.Name = "tb_ten_dang_nhap";
            this.tb_ten_dang_nhap.Size = new System.Drawing.Size(159, 25);
            this.tb_ten_dang_nhap.TabIndex = 4;
            this.tb_ten_dang_nhap.TextChanged += new System.EventHandler(this.tb_ten_dang_nhap_TextChanged);
            // 
            // tb_matkhau
            // 
            this.tb_matkhau.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tb_matkhau.Location = new System.Drawing.Point(282, 173);
            this.tb_matkhau.Name = "tb_matkhau";
            this.tb_matkhau.Size = new System.Drawing.Size(159, 25);
            this.tb_matkhau.TabIndex = 5;
            this.tb_matkhau.UseSystemPasswordChar = true;
            // 
            // bt_dangnhap
            // 
            this.bt_dangnhap.AutoSize = true;
            this.bt_dangnhap.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt_dangnhap.Location = new System.Drawing.Point(483, 226);
            this.bt_dangnhap.Name = "bt_dangnhap";
            this.bt_dangnhap.Size = new System.Drawing.Size(89, 29);
            this.bt_dangnhap.TabIndex = 6;
            this.bt_dangnhap.Text = "Đăng nhập";
            this.bt_dangnhap.UseVisualStyleBackColor = false;
            this.bt_dangnhap.Click += new System.EventHandler(this.bt_dangnhap_Click);
            // 
            // lb_title_dangnhap
            // 
            this.lb_title_dangnhap.AutoSize = true;
            this.lb_title_dangnhap.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.lb_title_dangnhap.Location = new System.Drawing.Point(231, 32);
            this.lb_title_dangnhap.Name = "lb_title_dangnhap";
            this.lb_title_dangnhap.Size = new System.Drawing.Size(148, 37);
            this.lb_title_dangnhap.TabIndex = 9;
            this.lb_title_dangnhap.Text = "Đăng nhập";
            this.lb_title_dangnhap.Click += new System.EventHandler(this.lb_title_dangnhap_Click);
            // 
            // lb_quenmatkhau
            // 
            this.lb_quenmatkhau.AutoSize = true;
            this.lb_quenmatkhau.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lb_quenmatkhau.Location = new System.Drawing.Point(69, 229);
            this.lb_quenmatkhau.Name = "lb_quenmatkhau";
            this.lb_quenmatkhau.Size = new System.Drawing.Size(124, 21);
            this.lb_quenmatkhau.TabIndex = 10;
            this.lb_quenmatkhau.Text = "Quên mật khẩu?";
            this.lb_quenmatkhau.Click += new System.EventHandler(this.lb_quenmatkhau_Click);
            // 
            // pb_manhinhchinh
            // 
            this.pb_manhinhchinh.Location = new System.Drawing.Point(43, 12);
            this.pb_manhinhchinh.Name = "pb_manhinhchinh";
            this.pb_manhinhchinh.Size = new System.Drawing.Size(27, 27);
            this.pb_manhinhchinh.TabIndex = 29;
            this.pb_manhinhchinh.TabStop = false;
            this.pb_manhinhchinh.Click += new System.EventHandler(this.pb_manhinhchinh_Click);
            // 
            // pb_quaylai
            // 
            this.pb_quaylai.Location = new System.Drawing.Point(12, 12);
            this.pb_quaylai.Name = "pb_quaylai";
            this.pb_quaylai.Size = new System.Drawing.Size(27, 27);
            this.pb_quaylai.TabIndex = 28;
            this.pb_quaylai.TabStop = false;
            this.pb_quaylai.Click += new System.EventHandler(this.pb_quaylai_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 19);
            this.label1.TabIndex = 27;
            // 
            // form_dangnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(610, 272);
            this.Controls.Add(this.pb_manhinhchinh);
            this.Controls.Add(this.pb_quaylai);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_quenmatkhau);
            this.Controls.Add(this.lb_title_dangnhap);
            this.Controls.Add(this.bt_dangnhap);
            this.Controls.Add(this.tb_matkhau);
            this.Controls.Add(this.tb_ten_dang_nhap);
            this.Controls.Add(this.lb_matkhau);
            this.Controls.Add(this.lb_tendangnhap);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Name = "form_dangnhap";
            this.Text = "Đăng nhập";
            ((System.ComponentModel.ISupportInitialize)(this.pb_manhinhchinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_quaylai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb_tendangnhap;
        private System.Windows.Forms.Label lb_matkhau;
        private System.Windows.Forms.TextBox tb_ten_dang_nhap;
        private System.Windows.Forms.TextBox tb_matkhau;
        private System.Windows.Forms.Button bt_dangnhap;
        private System.Windows.Forms.Label lb_title_dangnhap;
        private System.Windows.Forms.Label lb_quenmatkhau;
        private System.Windows.Forms.PictureBox pb_manhinhchinh;
        private System.Windows.Forms.PictureBox pb_quaylai;
        private System.Windows.Forms.Label label1;
    }
}

