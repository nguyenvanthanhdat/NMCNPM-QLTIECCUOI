namespace QuanLyTiecCuoi
{
    partial class form_thaydoiloaisanh
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
            this.gb_danhsachloaisanh = new System.Windows.Forms.GroupBox();
            this.dgv_danhsachloaisanh = new System.Windows.Forms.DataGridView();
            this.gb_thongtinsanh = new System.Windows.Forms.GroupBox();
            this.tb_dongia = new System.Windows.Forms.TextBox();
            this.lb_gia = new System.Windows.Forms.Label();
            this.tb_tenloaisanh = new System.Windows.Forms.TextBox();
            this.lb_tenloaisanh = new System.Windows.Forms.Label();
            this.tb_maloaisanh = new System.Windows.Forms.TextBox();
            this.lb_maloaisanh = new System.Windows.Forms.Label();
            this.bt_them = new System.Windows.Forms.Button();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.bt_capnhat = new System.Windows.Forms.Button();
            this.ptb_quaylai = new System.Windows.Forms.PictureBox();
            this.lb_timkiem = new System.Windows.Forms.Label();
            this.tb_timkiem = new System.Windows.Forms.TextBox();
            this.bt_thaydoi = new System.Windows.Forms.Button();
            this.bt_quaylai = new System.Windows.Forms.Button();
            this.gb_danhsachloaisanh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_danhsachloaisanh)).BeginInit();
            this.gb_thongtinsanh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_quaylai)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_loaisanh
            // 
            this.lb_loaisanh.AutoSize = true;
            this.lb_loaisanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_loaisanh.Location = new System.Drawing.Point(437, 42);
            this.lb_loaisanh.Name = "lb_loaisanh";
            this.lb_loaisanh.Size = new System.Drawing.Size(138, 29);
            this.lb_loaisanh.TabIndex = 0;
            this.lb_loaisanh.Text = "LOẠI SẢNH";
            // 
            // gb_danhsachloaisanh
            // 
            this.gb_danhsachloaisanh.Controls.Add(this.dgv_danhsachloaisanh);
            this.gb_danhsachloaisanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_danhsachloaisanh.Location = new System.Drawing.Point(28, 135);
            this.gb_danhsachloaisanh.Name = "gb_danhsachloaisanh";
            this.gb_danhsachloaisanh.Size = new System.Drawing.Size(376, 243);
            this.gb_danhsachloaisanh.TabIndex = 1;
            this.gb_danhsachloaisanh.TabStop = false;
            this.gb_danhsachloaisanh.Text = "Danh sách loại sảnh";
            // 
            // dgv_danhsachloaisanh
            // 
            this.dgv_danhsachloaisanh.AllowUserToAddRows = false;
            this.dgv_danhsachloaisanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_danhsachloaisanh.EnableHeadersVisualStyles = false;
            this.dgv_danhsachloaisanh.Location = new System.Drawing.Point(30, 25);
            this.dgv_danhsachloaisanh.Name = "dgv_danhsachloaisanh";
            this.dgv_danhsachloaisanh.RowHeadersVisible = false;
            this.dgv_danhsachloaisanh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_danhsachloaisanh.Size = new System.Drawing.Size(307, 189);
            this.dgv_danhsachloaisanh.TabIndex = 0;
            this.dgv_danhsachloaisanh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_danhsachsanh_CellClick);
            // 
            // gb_thongtinsanh
            // 
            this.gb_thongtinsanh.Controls.Add(this.tb_dongia);
            this.gb_thongtinsanh.Controls.Add(this.lb_gia);
            this.gb_thongtinsanh.Controls.Add(this.tb_tenloaisanh);
            this.gb_thongtinsanh.Controls.Add(this.lb_tenloaisanh);
            this.gb_thongtinsanh.Controls.Add(this.tb_maloaisanh);
            this.gb_thongtinsanh.Controls.Add(this.lb_maloaisanh);
            this.gb_thongtinsanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_thongtinsanh.Location = new System.Drawing.Point(475, 135);
            this.gb_thongtinsanh.Name = "gb_thongtinsanh";
            this.gb_thongtinsanh.Size = new System.Drawing.Size(320, 243);
            this.gb_thongtinsanh.TabIndex = 2;
            this.gb_thongtinsanh.TabStop = false;
            this.gb_thongtinsanh.Text = "Thông tin loại sảnh";
            // 
            // tb_dongia
            // 
            this.tb_dongia.Location = new System.Drawing.Point(189, 160);
            this.tb_dongia.Name = "tb_dongia";
            this.tb_dongia.Size = new System.Drawing.Size(111, 26);
            this.tb_dongia.TabIndex = 14;
            // 
            // lb_gia
            // 
            this.lb_gia.AutoSize = true;
            this.lb_gia.Location = new System.Drawing.Point(16, 163);
            this.lb_gia.Name = "lb_gia";
            this.lb_gia.Size = new System.Drawing.Size(155, 20);
            this.lb_gia.TabIndex = 13;
            this.lb_gia.Text = "Đơn giá bàn tối thiểu";
            // 
            // tb_tenloaisanh
            // 
            this.tb_tenloaisanh.Location = new System.Drawing.Point(189, 101);
            this.tb_tenloaisanh.Name = "tb_tenloaisanh";
            this.tb_tenloaisanh.Size = new System.Drawing.Size(111, 26);
            this.tb_tenloaisanh.TabIndex = 12;
            // 
            // lb_tenloaisanh
            // 
            this.lb_tenloaisanh.AutoSize = true;
            this.lb_tenloaisanh.Location = new System.Drawing.Point(16, 107);
            this.lb_tenloaisanh.Name = "lb_tenloaisanh";
            this.lb_tenloaisanh.Size = new System.Drawing.Size(103, 20);
            this.lb_tenloaisanh.TabIndex = 11;
            this.lb_tenloaisanh.Text = "Tên loại sảnh";
            // 
            // tb_maloaisanh
            // 
            this.tb_maloaisanh.Location = new System.Drawing.Point(189, 45);
            this.tb_maloaisanh.Name = "tb_maloaisanh";
            this.tb_maloaisanh.Size = new System.Drawing.Size(111, 26);
            this.tb_maloaisanh.TabIndex = 10;
            // 
            // lb_maloaisanh
            // 
            this.lb_maloaisanh.AutoSize = true;
            this.lb_maloaisanh.Location = new System.Drawing.Point(16, 48);
            this.lb_maloaisanh.Name = "lb_maloaisanh";
            this.lb_maloaisanh.Size = new System.Drawing.Size(98, 20);
            this.lb_maloaisanh.TabIndex = 9;
            this.lb_maloaisanh.Text = "Mã loại sảnh";
            // 
            // bt_them
            // 
            this.bt_them.AutoSize = true;
            this.bt_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_them.Location = new System.Drawing.Point(484, 403);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(75, 30);
            this.bt_them.TabIndex = 3;
            this.bt_them.Text = "Thêm";
            this.bt_them.UseVisualStyleBackColor = true;
            this.bt_them.Visible = false;
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // bt_xoa
            // 
            this.bt_xoa.AutoSize = true;
            this.bt_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_xoa.Location = new System.Drawing.Point(709, 403);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(75, 30);
            this.bt_xoa.TabIndex = 4;
            this.bt_xoa.Text = "Xóa";
            this.bt_xoa.UseVisualStyleBackColor = true;
            this.bt_xoa.Visible = false;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // bt_capnhat
            // 
            this.bt_capnhat.AutoSize = true;
            this.bt_capnhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_capnhat.Location = new System.Drawing.Point(598, 403);
            this.bt_capnhat.Name = "bt_capnhat";
            this.bt_capnhat.Size = new System.Drawing.Size(84, 30);
            this.bt_capnhat.TabIndex = 5;
            this.bt_capnhat.Text = "Cập nhật";
            this.bt_capnhat.UseVisualStyleBackColor = true;
            this.bt_capnhat.Visible = false;
            this.bt_capnhat.Click += new System.EventHandler(this.bt_capnhat_Click);
            // 
            // ptb_quaylai
            // 
            this.ptb_quaylai.BackColor = System.Drawing.Color.Red;
            this.ptb_quaylai.Location = new System.Drawing.Point(12, 12);
            this.ptb_quaylai.Name = "ptb_quaylai";
            this.ptb_quaylai.Size = new System.Drawing.Size(33, 28);
            this.ptb_quaylai.TabIndex = 6;
            this.ptb_quaylai.TabStop = false;
            this.ptb_quaylai.Click += new System.EventHandler(this.ptb_quaylai_Click);
            // 
            // lb_timkiem
            // 
            this.lb_timkiem.AutoSize = true;
            this.lb_timkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_timkiem.Location = new System.Drawing.Point(42, 98);
            this.lb_timkiem.Name = "lb_timkiem";
            this.lb_timkiem.Size = new System.Drawing.Size(71, 20);
            this.lb_timkiem.TabIndex = 15;
            this.lb_timkiem.Text = "Tìm kiếm";
            // 
            // tb_timkiem
            // 
            this.tb_timkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_timkiem.Location = new System.Drawing.Point(134, 95);
            this.tb_timkiem.Name = "tb_timkiem";
            this.tb_timkiem.Size = new System.Drawing.Size(111, 26);
            this.tb_timkiem.TabIndex = 15;
            this.tb_timkiem.TextChanged += new System.EventHandler(this.tb_timkiem_TextChanged);
            // 
            // bt_thaydoi
            // 
            this.bt_thaydoi.AutoSize = true;
            this.bt_thaydoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_thaydoi.Location = new System.Drawing.Point(675, 88);
            this.bt_thaydoi.Name = "bt_thaydoi";
            this.bt_thaydoi.Size = new System.Drawing.Size(78, 30);
            this.bt_thaydoi.TabIndex = 16;
            this.bt_thaydoi.Text = "Thay đổi";
            this.bt_thaydoi.UseVisualStyleBackColor = true;
            this.bt_thaydoi.Click += new System.EventHandler(this.bt_thaydoi_Click);
            // 
            // bt_quaylai
            // 
            this.bt_quaylai.AutoSize = true;
            this.bt_quaylai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_quaylai.Location = new System.Drawing.Point(535, 88);
            this.bt_quaylai.Name = "bt_quaylai";
            this.bt_quaylai.Size = new System.Drawing.Size(75, 30);
            this.bt_quaylai.TabIndex = 17;
            this.bt_quaylai.Text = "Quay lại";
            this.bt_quaylai.UseVisualStyleBackColor = true;
            this.bt_quaylai.Visible = false;
            this.bt_quaylai.Click += new System.EventHandler(this.bt_quaylai_Click);
            // 
            // form_thaydoiloaisanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(820, 454);
            this.Controls.Add(this.bt_quaylai);
            this.Controls.Add(this.bt_thaydoi);
            this.Controls.Add(this.tb_timkiem);
            this.Controls.Add(this.lb_timkiem);
            this.Controls.Add(this.ptb_quaylai);
            this.Controls.Add(this.bt_capnhat);
            this.Controls.Add(this.bt_xoa);
            this.Controls.Add(this.bt_them);
            this.Controls.Add(this.gb_thongtinsanh);
            this.Controls.Add(this.gb_danhsachloaisanh);
            this.Controls.Add(this.lb_loaisanh);
            this.Name = "form_thaydoiloaisanh";
            this.Text = "THÔNG TIN LOẠI SẢNH";
            this.Load += new System.EventHandler(this.form_thongtinsanh_Load);
            this.gb_danhsachloaisanh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_danhsachloaisanh)).EndInit();
            this.gb_thongtinsanh.ResumeLayout(false);
            this.gb_thongtinsanh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_quaylai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_loaisanh;
        private System.Windows.Forms.GroupBox gb_danhsachloaisanh;
        private System.Windows.Forms.DataGridView dgv_danhsachloaisanh;
        private System.Windows.Forms.GroupBox gb_thongtinsanh;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.Button bt_capnhat;
        private System.Windows.Forms.PictureBox ptb_quaylai;
        private System.Windows.Forms.TextBox tb_dongia;
        private System.Windows.Forms.Label lb_gia;
        private System.Windows.Forms.TextBox tb_tenloaisanh;
        private System.Windows.Forms.Label lb_tenloaisanh;
        private System.Windows.Forms.TextBox tb_maloaisanh;
        private System.Windows.Forms.Label lb_maloaisanh;
        private System.Windows.Forms.Label lb_timkiem;
        private System.Windows.Forms.TextBox tb_timkiem;
        private System.Windows.Forms.Button bt_thaydoi;
        private System.Windows.Forms.Button bt_quaylai;
    }
}