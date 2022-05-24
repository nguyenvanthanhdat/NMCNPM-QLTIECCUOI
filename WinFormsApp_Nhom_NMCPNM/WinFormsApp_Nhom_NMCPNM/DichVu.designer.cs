namespace WinFormsApp_Nhom_NMCPNM
{
    partial class form_dichvu
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
            this.pb_manhinhchinh = new System.Windows.Forms.PictureBox();
            this.pb_quaylai = new System.Windows.Forms.PictureBox();
            this.gb_thaydoidichvu = new System.Windows.Forms.GroupBox();
            this.bt_sua = new System.Windows.Forms.Button();
            this.bt_them = new System.Windows.Forms.Button();
            this.tb_dongia = new System.Windows.Forms.TextBox();
            this.tb_tendichvu = new System.Windows.Forms.TextBox();
            this.lb_dongia = new System.Windows.Forms.Label();
            this.lb_tendichvu = new System.Windows.Forms.Label();
            this.gb_danhsachmonan = new System.Windows.Forms.GroupBox();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.bt_luu = new System.Windows.Forms.Button();
            this.dgv_dịchvu = new System.Windows.Forms.DataGridView();
            this.lb_monan = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_manhinhchinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_quaylai)).BeginInit();
            this.gb_thaydoidichvu.SuspendLayout();
            this.gb_danhsachmonan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dịchvu)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_manhinhchinh
            // 
            this.pb_manhinhchinh.Location = new System.Drawing.Point(63, 16);
            this.pb_manhinhchinh.Name = "pb_manhinhchinh";
            this.pb_manhinhchinh.Size = new System.Drawing.Size(27, 27);
            this.pb_manhinhchinh.TabIndex = 24;
            this.pb_manhinhchinh.TabStop = false;
            this.pb_manhinhchinh.Click += new System.EventHandler(this.pb_manhinhchinh_Click);
            // 
            // pb_quaylai
            // 
            this.pb_quaylai.Location = new System.Drawing.Point(32, 16);
            this.pb_quaylai.Name = "pb_quaylai";
            this.pb_quaylai.Size = new System.Drawing.Size(27, 27);
            this.pb_quaylai.TabIndex = 23;
            this.pb_quaylai.TabStop = false;
            this.pb_quaylai.Click += new System.EventHandler(this.pb_quaylai_Click);
            // 
            // gb_thaydoidichvu
            // 
            this.gb_thaydoidichvu.BackColor = System.Drawing.Color.Transparent;
            this.gb_thaydoidichvu.Controls.Add(this.bt_sua);
            this.gb_thaydoidichvu.Controls.Add(this.bt_them);
            this.gb_thaydoidichvu.Controls.Add(this.tb_dongia);
            this.gb_thaydoidichvu.Controls.Add(this.tb_tendichvu);
            this.gb_thaydoidichvu.Controls.Add(this.lb_dongia);
            this.gb_thaydoidichvu.Controls.Add(this.lb_tendichvu);
            this.gb_thaydoidichvu.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gb_thaydoidichvu.Location = new System.Drawing.Point(32, 383);
            this.gb_thaydoidichvu.Name = "gb_thaydoidichvu";
            this.gb_thaydoidichvu.Size = new System.Drawing.Size(765, 114);
            this.gb_thaydoidichvu.TabIndex = 22;
            this.gb_thaydoidichvu.TabStop = false;
            this.gb_thaydoidichvu.Text = "Thay đổi dịch vụ";
            // 
            // bt_sua
            // 
            this.bt_sua.AutoSize = true;
            this.bt_sua.Location = new System.Drawing.Point(687, 69);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(64, 31);
            this.bt_sua.TabIndex = 10;
            this.bt_sua.Text = "Sửa";
            this.bt_sua.UseVisualStyleBackColor = true;
            // 
            // bt_them
            // 
            this.bt_them.AutoSize = true;
            this.bt_them.Location = new System.Drawing.Point(618, 69);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(64, 31);
            this.bt_them.TabIndex = 3;
            this.bt_them.Text = "Thêm";
            this.bt_them.UseVisualStyleBackColor = true;
            // 
            // tb_dongia
            // 
            this.tb_dongia.Location = new System.Drawing.Point(493, 30);
            this.tb_dongia.Name = "tb_dongia";
            this.tb_dongia.Size = new System.Drawing.Size(259, 29);
            this.tb_dongia.TabIndex = 6;
            // 
            // tb_tendichvu
            // 
            this.tb_tendichvu.Location = new System.Drawing.Point(123, 30);
            this.tb_tendichvu.Name = "tb_tendichvu";
            this.tb_tendichvu.Size = new System.Drawing.Size(259, 29);
            this.tb_tendichvu.TabIndex = 5;
            // 
            // lb_dongia
            // 
            this.lb_dongia.AutoSize = true;
            this.lb_dongia.Location = new System.Drawing.Point(417, 33);
            this.lb_dongia.Name = "lb_dongia";
            this.lb_dongia.Size = new System.Drawing.Size(65, 21);
            this.lb_dongia.TabIndex = 1;
            this.lb_dongia.Text = "Đơn giá";
            // 
            // lb_tendichvu
            // 
            this.lb_tendichvu.AutoSize = true;
            this.lb_tendichvu.Location = new System.Drawing.Point(23, 33);
            this.lb_tendichvu.Name = "lb_tendichvu";
            this.lb_tendichvu.Size = new System.Drawing.Size(87, 21);
            this.lb_tendichvu.TabIndex = 0;
            this.lb_tendichvu.Text = "Tên dịch vụ";
            // 
            // gb_danhsachmonan
            // 
            this.gb_danhsachmonan.BackColor = System.Drawing.Color.Transparent;
            this.gb_danhsachmonan.Controls.Add(this.bt_xoa);
            this.gb_danhsachmonan.Controls.Add(this.bt_luu);
            this.gb_danhsachmonan.Controls.Add(this.dgv_dịchvu);
            this.gb_danhsachmonan.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gb_danhsachmonan.Location = new System.Drawing.Point(32, 72);
            this.gb_danhsachmonan.Name = "gb_danhsachmonan";
            this.gb_danhsachmonan.Size = new System.Drawing.Size(765, 306);
            this.gb_danhsachmonan.TabIndex = 21;
            this.gb_danhsachmonan.TabStop = false;
            this.gb_danhsachmonan.Text = "Danh sách dịch vụ";
            // 
            // bt_xoa
            // 
            this.bt_xoa.AutoSize = true;
            this.bt_xoa.Location = new System.Drawing.Point(618, 261);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(64, 31);
            this.bt_xoa.TabIndex = 10;
            this.bt_xoa.Text = "Xóa";
            this.bt_xoa.UseVisualStyleBackColor = true;
            // 
            // bt_luu
            // 
            this.bt_luu.AutoSize = true;
            this.bt_luu.Location = new System.Drawing.Point(687, 261);
            this.bt_luu.Name = "bt_luu";
            this.bt_luu.Size = new System.Drawing.Size(64, 31);
            this.bt_luu.TabIndex = 2;
            this.bt_luu.Text = "Lưu";
            this.bt_luu.UseVisualStyleBackColor = true;
            // 
            // dgv_dịchvu
            // 
            this.dgv_dịchvu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dịchvu.Location = new System.Drawing.Point(20, 36);
            this.dgv_dịchvu.Name = "dgv_dịchvu";
            this.dgv_dịchvu.RowTemplate.Height = 25;
            this.dgv_dịchvu.Size = new System.Drawing.Size(732, 211);
            this.dgv_dịchvu.TabIndex = 1;
            // 
            // lb_monan
            // 
            this.lb_monan.AutoSize = true;
            this.lb_monan.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.lb_monan.Location = new System.Drawing.Point(358, 16);
            this.lb_monan.Name = "lb_monan";
            this.lb_monan.Size = new System.Drawing.Size(122, 37);
            this.lb_monan.TabIndex = 20;
            this.lb_monan.Text = "DỊCH VỤ";
            // 
            // form_dichvu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 514);
            this.Controls.Add(this.pb_manhinhchinh);
            this.Controls.Add(this.pb_quaylai);
            this.Controls.Add(this.gb_thaydoidichvu);
            this.Controls.Add(this.gb_danhsachmonan);
            this.Controls.Add(this.lb_monan);
            this.Name = "form_dichvu";
            this.Text = "Dịch vụ";
            ((System.ComponentModel.ISupportInitialize)(this.pb_manhinhchinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_quaylai)).EndInit();
            this.gb_thaydoidichvu.ResumeLayout(false);
            this.gb_thaydoidichvu.PerformLayout();
            this.gb_danhsachmonan.ResumeLayout(false);
            this.gb_danhsachmonan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dịchvu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_manhinhchinh;
        private System.Windows.Forms.PictureBox pb_quaylai;
        private System.Windows.Forms.GroupBox gb_thaydoidichvu;
        private System.Windows.Forms.Button bt_sua;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.TextBox tb_dongia;
        private System.Windows.Forms.TextBox tb_tendichvu;
        private System.Windows.Forms.Label lb_dongia;
        private System.Windows.Forms.Label lb_tendichvu;
        private System.Windows.Forms.GroupBox gb_danhsachmonan;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.Button bt_luu;
        private System.Windows.Forms.DataGridView dgv_dịchvu;
        private System.Windows.Forms.Label lb_monan;
    }
}