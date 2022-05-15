
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
            this.bt_thoat_1 = new System.Windows.Forms.Button();
            this.lb_title_dangnhap = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_tendangnhap
            // 
            this.lb_tendangnhap.AutoSize = true;
            this.lb_tendangnhap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_tendangnhap.Location = new System.Drawing.Point(194, 116);
            this.lb_tendangnhap.Name = "lb_tendangnhap";
            this.lb_tendangnhap.Size = new System.Drawing.Size(111, 21);
            this.lb_tendangnhap.TabIndex = 2;
            this.lb_tendangnhap.Text = "Tên đăng nhập";
            // 
            // lb_matkhau
            // 
            this.lb_matkhau.AutoSize = true;
            this.lb_matkhau.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_matkhau.Location = new System.Drawing.Point(194, 174);
            this.lb_matkhau.Name = "lb_matkhau";
            this.lb_matkhau.Size = new System.Drawing.Size(75, 21);
            this.lb_matkhau.TabIndex = 3;
            this.lb_matkhau.Text = "Mật khẩu";
            this.lb_matkhau.Click += new System.EventHandler(this.lb_matkhau_Click);
            // 
            // tb_ten_dang_nhap
            // 
            this.tb_ten_dang_nhap.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_ten_dang_nhap.Location = new System.Drawing.Point(311, 118);
            this.tb_ten_dang_nhap.Name = "tb_ten_dang_nhap";
            this.tb_ten_dang_nhap.Size = new System.Drawing.Size(159, 25);
            this.tb_ten_dang_nhap.TabIndex = 4;
            // 
            // tb_matkhau
            // 
            this.tb_matkhau.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_matkhau.Location = new System.Drawing.Point(311, 174);
            this.tb_matkhau.Name = "tb_matkhau";
            this.tb_matkhau.Size = new System.Drawing.Size(159, 25);
            this.tb_matkhau.TabIndex = 5;
            // 
            // bt_dangnhap
            // 
            this.bt_dangnhap.AutoSize = true;
            this.bt_dangnhap.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt_dangnhap.Location = new System.Drawing.Point(451, 263);
            this.bt_dangnhap.Name = "bt_dangnhap";
            this.bt_dangnhap.Size = new System.Drawing.Size(89, 29);
            this.bt_dangnhap.TabIndex = 6;
            this.bt_dangnhap.Text = "Đăng nhập";
            this.bt_dangnhap.UseVisualStyleBackColor = false;
            this.bt_dangnhap.Click += new System.EventHandler(this.bt_dangnhap_Click);
            // 
            // bt_thoat_1
            // 
            this.bt_thoat_1.AutoSize = true;
            this.bt_thoat_1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt_thoat_1.Location = new System.Drawing.Point(571, 263);
            this.bt_thoat_1.Name = "bt_thoat_1";
            this.bt_thoat_1.Size = new System.Drawing.Size(75, 29);
            this.bt_thoat_1.TabIndex = 7;
            this.bt_thoat_1.Text = "Thoát";
            this.bt_thoat_1.UseVisualStyleBackColor = false;
            // 
            // lb_title_dangnhap
            // 
            this.lb_title_dangnhap.AutoSize = true;
            this.lb_title_dangnhap.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_title_dangnhap.Location = new System.Drawing.Point(260, 33);
            this.lb_title_dangnhap.Name = "lb_title_dangnhap";
            this.lb_title_dangnhap.Size = new System.Drawing.Size(148, 37);
            this.lb_title_dangnhap.TabIndex = 9;
            this.lb_title_dangnhap.Text = "Đăng nhập";
            this.lb_title_dangnhap.Click += new System.EventHandler(this.lb_title_dangnhap_Click);
            // 
            // form_dangnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 298);
            this.Controls.Add(this.lb_title_dangnhap);
            this.Controls.Add(this.bt_thoat_1);
            this.Controls.Add(this.bt_dangnhap);
            this.Controls.Add(this.tb_matkhau);
            this.Controls.Add(this.tb_ten_dang_nhap);
            this.Controls.Add(this.lb_matkhau);
            this.Controls.Add(this.lb_tendangnhap);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "form_dangnhap";
            this.Text = "Đăng nhập";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb_tendangnhap;
        private System.Windows.Forms.Label lb_matkhau;
        private System.Windows.Forms.TextBox tb_ten_dang_nhap;
        private System.Windows.Forms.TextBox tb_matkhau;
        private System.Windows.Forms.Button bt_dangnhap;
        private System.Windows.Forms.Button bt_thoat_1;
        private System.Windows.Forms.Label lb_title_dangnhap;
    }
}

