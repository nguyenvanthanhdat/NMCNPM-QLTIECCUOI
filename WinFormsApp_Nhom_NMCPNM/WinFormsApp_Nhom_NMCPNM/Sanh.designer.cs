namespace WinFormsApp_Nhom_NMCPNM
{
    partial class form_sanh
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
            this.lb_sanh = new System.Windows.Forms.Label();
            this.dgv_sanh = new System.Windows.Forms.DataGridView();
            this.gb_danhsachsanh = new System.Windows.Forms.GroupBox();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.bt_luu = new System.Windows.Forms.Button();
            this.gb_tiepnhansanh = new System.Windows.Forms.GroupBox();
            this.bt_sua = new System.Windows.Forms.Button();
            this.bt_them = new System.Windows.Forms.Button();
            this.cb_tensanh = new System.Windows.Forms.ComboBox();
            this.cb_tenloaisanh = new System.Windows.Forms.ComboBox();
            this.tb_ghichu = new System.Windows.Forms.TextBox();
            this.tb_dongiabantoithieu = new System.Windows.Forms.TextBox();
            this.tb_soluongbantoida = new System.Windows.Forms.TextBox();
            this.lb_tensanh = new System.Windows.Forms.Label();
            this.lb_soluongbantoida = new System.Windows.Forms.Label();
            this.lb_ghichu = new System.Windows.Forms.Label();
            this.lb_dongiabantoithieu = new System.Windows.Forms.Label();
            this.lb_tenloaisanh = new System.Windows.Forms.Label();
            this.pb_quaylai = new System.Windows.Forms.PictureBox();
            this.pb_manhinhchinh = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sanh)).BeginInit();
            this.gb_danhsachsanh.SuspendLayout();
            this.gb_tiepnhansanh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_quaylai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_manhinhchinh)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_sanh
            // 
            this.lb_sanh.AutoSize = true;
            this.lb_sanh.BackColor = System.Drawing.Color.Transparent;
            this.lb_sanh.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_sanh.Location = new System.Drawing.Point(431, 20);
            this.lb_sanh.Name = "lb_sanh";
            this.lb_sanh.Size = new System.Drawing.Size(75, 37);
            this.lb_sanh.TabIndex = 0;
            this.lb_sanh.Text = "Sảnh";
            // 
            // dgv_sanh
            // 
            this.dgv_sanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_sanh.Location = new System.Drawing.Point(23, 42);
            this.dgv_sanh.Name = "dgv_sanh";
            this.dgv_sanh.RowTemplate.Height = 25;
            this.dgv_sanh.Size = new System.Drawing.Size(854, 243);
            this.dgv_sanh.TabIndex = 1;
            // 
            // gb_danhsachsanh
            // 
            this.gb_danhsachsanh.BackColor = System.Drawing.Color.Transparent;
            this.gb_danhsachsanh.Controls.Add(this.bt_xoa);
            this.gb_danhsachsanh.Controls.Add(this.bt_luu);
            this.gb_danhsachsanh.Controls.Add(this.dgv_sanh);
            this.gb_danhsachsanh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gb_danhsachsanh.Location = new System.Drawing.Point(32, 72);
            this.gb_danhsachsanh.Name = "gb_danhsachsanh";
            this.gb_danhsachsanh.Size = new System.Drawing.Size(893, 353);
            this.gb_danhsachsanh.TabIndex = 2;
            this.gb_danhsachsanh.TabStop = false;
            this.gb_danhsachsanh.Text = "Danh sách sảnh";
            // 
            // bt_xoa
            // 
            this.bt_xoa.AutoSize = true;
            this.bt_xoa.Location = new System.Drawing.Point(721, 301);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(75, 31);
            this.bt_xoa.TabIndex = 10;
            this.bt_xoa.Text = "Xóa";
            this.bt_xoa.UseVisualStyleBackColor = true;
            // 
            // bt_luu
            // 
            this.bt_luu.AutoSize = true;
            this.bt_luu.Location = new System.Drawing.Point(802, 301);
            this.bt_luu.Name = "bt_luu";
            this.bt_luu.Size = new System.Drawing.Size(75, 31);
            this.bt_luu.TabIndex = 2;
            this.bt_luu.Text = "Lưu";
            this.bt_luu.UseVisualStyleBackColor = true;
            // 
            // gb_tiepnhansanh
            // 
            this.gb_tiepnhansanh.BackColor = System.Drawing.Color.Transparent;
            this.gb_tiepnhansanh.Controls.Add(this.bt_sua);
            this.gb_tiepnhansanh.Controls.Add(this.bt_them);
            this.gb_tiepnhansanh.Controls.Add(this.cb_tensanh);
            this.gb_tiepnhansanh.Controls.Add(this.cb_tenloaisanh);
            this.gb_tiepnhansanh.Controls.Add(this.tb_ghichu);
            this.gb_tiepnhansanh.Controls.Add(this.tb_dongiabantoithieu);
            this.gb_tiepnhansanh.Controls.Add(this.tb_soluongbantoida);
            this.gb_tiepnhansanh.Controls.Add(this.lb_tensanh);
            this.gb_tiepnhansanh.Controls.Add(this.lb_soluongbantoida);
            this.gb_tiepnhansanh.Controls.Add(this.lb_ghichu);
            this.gb_tiepnhansanh.Controls.Add(this.lb_dongiabantoithieu);
            this.gb_tiepnhansanh.Controls.Add(this.lb_tenloaisanh);
            this.gb_tiepnhansanh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gb_tiepnhansanh.Location = new System.Drawing.Point(32, 431);
            this.gb_tiepnhansanh.Name = "gb_tiepnhansanh";
            this.gb_tiepnhansanh.Size = new System.Drawing.Size(893, 223);
            this.gb_tiepnhansanh.TabIndex = 3;
            this.gb_tiepnhansanh.TabStop = false;
            this.gb_tiepnhansanh.Text = "Tiếp nhận sảnh";
            // 
            // bt_sua
            // 
            this.bt_sua.AutoSize = true;
            this.bt_sua.Location = new System.Drawing.Point(802, 172);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(75, 31);
            this.bt_sua.TabIndex = 10;
            this.bt_sua.Text = "Sửa";
            this.bt_sua.UseVisualStyleBackColor = true;
            // 
            // bt_them
            // 
            this.bt_them.AutoSize = true;
            this.bt_them.Location = new System.Drawing.Point(721, 172);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(75, 31);
            this.bt_them.TabIndex = 3;
            this.bt_them.Text = "Thêm";
            this.bt_them.UseVisualStyleBackColor = true;
            // 
            // cb_tensanh
            // 
            this.cb_tensanh.FormattingEnabled = true;
            this.cb_tensanh.Location = new System.Drawing.Point(642, 32);
            this.cb_tensanh.Name = "cb_tensanh";
            this.cb_tensanh.Size = new System.Drawing.Size(235, 29);
            this.cb_tensanh.TabIndex = 9;
            // 
            // cb_tenloaisanh
            // 
            this.cb_tenloaisanh.FormattingEnabled = true;
            this.cb_tenloaisanh.Location = new System.Drawing.Point(179, 35);
            this.cb_tenloaisanh.Name = "cb_tenloaisanh";
            this.cb_tenloaisanh.Size = new System.Drawing.Size(235, 29);
            this.cb_tenloaisanh.TabIndex = 8;
            // 
            // tb_ghichu
            // 
            this.tb_ghichu.Location = new System.Drawing.Point(23, 137);
            this.tb_ghichu.Name = "tb_ghichu";
            this.tb_ghichu.Size = new System.Drawing.Size(854, 29);
            this.tb_ghichu.TabIndex = 7;
            // 
            // tb_dongiabantoithieu
            // 
            this.tb_dongiabantoithieu.Enabled = false;
            this.tb_dongiabantoithieu.Location = new System.Drawing.Point(642, 67);
            this.tb_dongiabantoithieu.Name = "tb_dongiabantoithieu";
            this.tb_dongiabantoithieu.Size = new System.Drawing.Size(235, 29);
            this.tb_dongiabantoithieu.TabIndex = 6;
            // 
            // tb_soluongbantoida
            // 
            this.tb_soluongbantoida.Location = new System.Drawing.Point(179, 70);
            this.tb_soluongbantoida.Name = "tb_soluongbantoida";
            this.tb_soluongbantoida.Size = new System.Drawing.Size(235, 29);
            this.tb_soluongbantoida.TabIndex = 5;
            // 
            // lb_tensanh
            // 
            this.lb_tensanh.AutoSize = true;
            this.lb_tensanh.Location = new System.Drawing.Point(471, 35);
            this.lb_tensanh.Name = "lb_tensanh";
            this.lb_tensanh.Size = new System.Drawing.Size(70, 21);
            this.lb_tensanh.TabIndex = 4;
            this.lb_tensanh.Text = "Tên sảnh";
            // 
            // lb_soluongbantoida
            // 
            this.lb_soluongbantoida.AutoSize = true;
            this.lb_soluongbantoida.Location = new System.Drawing.Point(27, 73);
            this.lb_soluongbantoida.Name = "lb_soluongbantoida";
            this.lb_soluongbantoida.Size = new System.Drawing.Size(146, 21);
            this.lb_soluongbantoida.TabIndex = 3;
            this.lb_soluongbantoida.Text = "Số lượng bàn tối đa";
            // 
            // lb_ghichu
            // 
            this.lb_ghichu.AutoSize = true;
            this.lb_ghichu.Location = new System.Drawing.Point(27, 113);
            this.lb_ghichu.Name = "lb_ghichu";
            this.lb_ghichu.Size = new System.Drawing.Size(63, 21);
            this.lb_ghichu.TabIndex = 2;
            this.lb_ghichu.Text = "Ghi chú";
            // 
            // lb_dongiabantoithieu
            // 
            this.lb_dongiabantoithieu.AutoSize = true;
            this.lb_dongiabantoithieu.Location = new System.Drawing.Point(471, 70);
            this.lb_dongiabantoithieu.Name = "lb_dongiabantoithieu";
            this.lb_dongiabantoithieu.Size = new System.Drawing.Size(156, 21);
            this.lb_dongiabantoithieu.TabIndex = 1;
            this.lb_dongiabantoithieu.Text = "Đơn giá bàn tối thiểu";
            // 
            // lb_tenloaisanh
            // 
            this.lb_tenloaisanh.AutoSize = true;
            this.lb_tenloaisanh.Location = new System.Drawing.Point(27, 38);
            this.lb_tenloaisanh.Name = "lb_tenloaisanh";
            this.lb_tenloaisanh.Size = new System.Drawing.Size(99, 21);
            this.lb_tenloaisanh.TabIndex = 0;
            this.lb_tenloaisanh.Text = "Tên loại sảnh";
            // 
            // pb_quaylai
            // 
            this.pb_quaylai.Location = new System.Drawing.Point(32, 7);
            this.pb_quaylai.Name = "pb_quaylai";
            this.pb_quaylai.Size = new System.Drawing.Size(31, 31);
            this.pb_quaylai.TabIndex = 11;
            this.pb_quaylai.TabStop = false;
            this.pb_quaylai.Click += new System.EventHandler(this.pb_quaylai_Click);
            // 
            // pb_manhinhchinh
            // 
            this.pb_manhinhchinh.Location = new System.Drawing.Point(69, 7);
            this.pb_manhinhchinh.Name = "pb_manhinhchinh";
            this.pb_manhinhchinh.Size = new System.Drawing.Size(31, 31);
            this.pb_manhinhchinh.TabIndex = 12;
            this.pb_manhinhchinh.TabStop = false;
            this.pb_manhinhchinh.Click += new System.EventHandler(this.pb_manhinhchinh_Click);
            // 
            // form_sanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 671);
            this.Controls.Add(this.pb_manhinhchinh);
            this.Controls.Add(this.pb_quaylai);
            this.Controls.Add(this.gb_tiepnhansanh);
            this.Controls.Add(this.lb_sanh);
            this.Controls.Add(this.gb_danhsachsanh);
            this.Name = "form_sanh";
            this.Text = "Sảnh";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sanh)).EndInit();
            this.gb_danhsachsanh.ResumeLayout(false);
            this.gb_danhsachsanh.PerformLayout();
            this.gb_tiepnhansanh.ResumeLayout(false);
            this.gb_tiepnhansanh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_quaylai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_manhinhchinh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_sanh;
        private System.Windows.Forms.DataGridView dgv_sanh;
        private System.Windows.Forms.GroupBox gb_danhsachsanh;
        private System.Windows.Forms.GroupBox gb_tiepnhansanh;
        private System.Windows.Forms.Label lb_tenloaisanh;
        private System.Windows.Forms.Label lb_tensanh;
        private System.Windows.Forms.Label lb_soluongbantoida;
        private System.Windows.Forms.Label lb_ghichu;
        private System.Windows.Forms.Label lb_dongiabantoithieu;
        private System.Windows.Forms.Button bt_luu;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.ComboBox cb_tensanh;
        private System.Windows.Forms.ComboBox cb_tenloaisanh;
        private System.Windows.Forms.TextBox tb_ghichu;
        private System.Windows.Forms.TextBox tb_dongiabantoithieu;
        private System.Windows.Forms.TextBox tb_soluongbantoida;
        private System.Windows.Forms.Button bt_sua;
        private System.Windows.Forms.PictureBox pb_quaylai;
        private System.Windows.Forms.PictureBox pb_manhinhchinh;
    }
}