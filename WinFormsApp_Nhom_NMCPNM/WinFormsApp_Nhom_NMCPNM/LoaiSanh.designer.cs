namespace WinFormsApp_Nhom_NMCPNM
{
    partial class form_loaisanh
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
            this.lb_loaisanh = new System.Windows.Forms.Label();
            this.gb_thaydoiloaisanh = new System.Windows.Forms.GroupBox();
            this.bt_sua = new System.Windows.Forms.Button();
            this.bt_them = new System.Windows.Forms.Button();
            this.tb_dongiabantoithieu = new System.Windows.Forms.TextBox();
            this.tb_tenloaisanh = new System.Windows.Forms.TextBox();
            this.lb_dongiabantoithieu = new System.Windows.Forms.Label();
            this.lb_tenloaisanh = new System.Windows.Forms.Label();
            this.gb_danhsachloaisanh = new System.Windows.Forms.GroupBox();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.bt_luu = new System.Windows.Forms.Button();
            this.dgv_loaisanh = new System.Windows.Forms.DataGridView();
            this.pb_manhinhchinh = new System.Windows.Forms.PictureBox();
            this.pb_quaylai = new System.Windows.Forms.PictureBox();
            this.gb_thaydoiloaisanh.SuspendLayout();
            this.gb_danhsachloaisanh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_loaisanh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_manhinhchinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_quaylai)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_loaisanh
            // 
            this.lb_loaisanh.AutoSize = true;
            this.lb_loaisanh.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.lb_loaisanh.Location = new System.Drawing.Point(341, 35);
            this.lb_loaisanh.Name = "lb_loaisanh";
            this.lb_loaisanh.Size = new System.Drawing.Size(129, 37);
            this.lb_loaisanh.TabIndex = 0;
            this.lb_loaisanh.Text = "Loại sảnh";
            // 
            // gb_thaydoiloaisanh
            // 
            this.gb_thaydoiloaisanh.BackColor = System.Drawing.Color.Transparent;
            this.gb_thaydoiloaisanh.Controls.Add(this.bt_sua);
            this.gb_thaydoiloaisanh.Controls.Add(this.bt_them);
            this.gb_thaydoiloaisanh.Controls.Add(this.tb_dongiabantoithieu);
            this.gb_thaydoiloaisanh.Controls.Add(this.tb_tenloaisanh);
            this.gb_thaydoiloaisanh.Controls.Add(this.lb_dongiabantoithieu);
            this.gb_thaydoiloaisanh.Controls.Add(this.lb_tenloaisanh);
            this.gb_thaydoiloaisanh.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gb_thaydoiloaisanh.Location = new System.Drawing.Point(15, 377);
            this.gb_thaydoiloaisanh.Name = "gb_thaydoiloaisanh";
            this.gb_thaydoiloaisanh.Size = new System.Drawing.Size(765, 114);
            this.gb_thaydoiloaisanh.TabIndex = 6;
            this.gb_thaydoiloaisanh.TabStop = false;
            this.gb_thaydoiloaisanh.Text = "Thay đổi loại sảnh";
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
            // tb_dongiabantoithieu
            // 
            this.tb_dongiabantoithieu.Location = new System.Drawing.Point(550, 30);
            this.tb_dongiabantoithieu.Name = "tb_dongiabantoithieu";
            this.tb_dongiabantoithieu.Size = new System.Drawing.Size(202, 29);
            this.tb_dongiabantoithieu.TabIndex = 6;
            // 
            // tb_tenloaisanh
            // 
            this.tb_tenloaisanh.Location = new System.Drawing.Point(123, 30);
            this.tb_tenloaisanh.Name = "tb_tenloaisanh";
            this.tb_tenloaisanh.Size = new System.Drawing.Size(202, 29);
            this.tb_tenloaisanh.TabIndex = 5;
            // 
            // lb_dongiabantoithieu
            // 
            this.lb_dongiabantoithieu.AutoSize = true;
            this.lb_dongiabantoithieu.Location = new System.Drawing.Point(388, 33);
            this.lb_dongiabantoithieu.Name = "lb_dongiabantoithieu";
            this.lb_dongiabantoithieu.Size = new System.Drawing.Size(156, 21);
            this.lb_dongiabantoithieu.TabIndex = 1;
            this.lb_dongiabantoithieu.Text = "Đơn giá bàn tối thiểu";
            // 
            // lb_tenloaisanh
            // 
            this.lb_tenloaisanh.AutoSize = true;
            this.lb_tenloaisanh.Location = new System.Drawing.Point(23, 33);
            this.lb_tenloaisanh.Name = "lb_tenloaisanh";
            this.lb_tenloaisanh.Size = new System.Drawing.Size(99, 21);
            this.lb_tenloaisanh.TabIndex = 0;
            this.lb_tenloaisanh.Text = "Tên loại sảnh";
            // 
            // gb_danhsachloaisanh
            // 
            this.gb_danhsachloaisanh.BackColor = System.Drawing.Color.Transparent;
            this.gb_danhsachloaisanh.Controls.Add(this.bt_xoa);
            this.gb_danhsachloaisanh.Controls.Add(this.bt_luu);
            this.gb_danhsachloaisanh.Controls.Add(this.dgv_loaisanh);
            this.gb_danhsachloaisanh.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gb_danhsachloaisanh.Location = new System.Drawing.Point(15, 66);
            this.gb_danhsachloaisanh.Name = "gb_danhsachloaisanh";
            this.gb_danhsachloaisanh.Size = new System.Drawing.Size(765, 306);
            this.gb_danhsachloaisanh.TabIndex = 5;
            this.gb_danhsachloaisanh.TabStop = false;
            this.gb_danhsachloaisanh.Text = "Danh sách loại sảnh";
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
            // dgv_loaisanh
            // 
            this.dgv_loaisanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_loaisanh.Location = new System.Drawing.Point(20, 36);
            this.dgv_loaisanh.Name = "dgv_loaisanh";
            this.dgv_loaisanh.RowTemplate.Height = 25;
            this.dgv_loaisanh.Size = new System.Drawing.Size(732, 211);
            this.dgv_loaisanh.TabIndex = 1;
            // 
            // pb_manhinhchinh
            // 
            this.pb_manhinhchinh.Location = new System.Drawing.Point(47, 10);
            this.pb_manhinhchinh.Name = "pb_manhinhchinh";
            this.pb_manhinhchinh.Size = new System.Drawing.Size(27, 27);
            this.pb_manhinhchinh.TabIndex = 14;
            this.pb_manhinhchinh.TabStop = false;
            this.pb_manhinhchinh.Click += new System.EventHandler(this.pb_manhinhchinh_Click);
            // 
            // pb_quaylai
            // 
            this.pb_quaylai.Location = new System.Drawing.Point(15, 10);
            this.pb_quaylai.Name = "pb_quaylai";
            this.pb_quaylai.Size = new System.Drawing.Size(27, 27);
            this.pb_quaylai.TabIndex = 13;
            this.pb_quaylai.TabStop = false;
            this.pb_quaylai.Click += new System.EventHandler(this.pb_quaylai_Click);
            // 
            // form_loaisanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 504);
            this.Controls.Add(this.pb_manhinhchinh);
            this.Controls.Add(this.pb_quaylai);
            this.Controls.Add(this.gb_thaydoiloaisanh);
            this.Controls.Add(this.gb_danhsachloaisanh);
            this.Controls.Add(this.lb_loaisanh);
            this.Name = "form_loaisanh";
            this.Text = "Loại sảnh";
            this.gb_thaydoiloaisanh.ResumeLayout(false);
            this.gb_thaydoiloaisanh.PerformLayout();
            this.gb_danhsachloaisanh.ResumeLayout(false);
            this.gb_danhsachloaisanh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_loaisanh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_manhinhchinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_quaylai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_loaisanh;
        private System.Windows.Forms.GroupBox gb_thaydoiloaisanh;
        private System.Windows.Forms.Button bt_sua;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.TextBox tb_dongiabantoithieu;
        private System.Windows.Forms.TextBox tb_tenloaisanh;
        private System.Windows.Forms.Label lb_dongiabantoithieu;
        private System.Windows.Forms.Label lb_tenloaisanh;
        private System.Windows.Forms.GroupBox gb_danhsachloaisanh;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.Button bt_luu;
        private System.Windows.Forms.DataGridView dgv_loaisanh;
        private System.Windows.Forms.PictureBox pb_manhinhchinh;
        private System.Windows.Forms.PictureBox pb_quaylai;
    }
}