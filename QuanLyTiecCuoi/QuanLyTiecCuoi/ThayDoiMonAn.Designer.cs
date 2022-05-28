namespace QuanLyTiecCuoi
{
    partial class form_thaydoimonan
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
            this.lb_monan = new System.Windows.Forms.Label();
            this.gb_danhsachmonan = new System.Windows.Forms.GroupBox();
            this.dgv_danhsachmonan = new System.Windows.Forms.DataGridView();
            this.gb_thongtinmonan = new System.Windows.Forms.GroupBox();
            this.tb_mamonan = new System.Windows.Forms.TextBox();
            this.lb_mamonan = new System.Windows.Forms.Label();
            this.tb_dongia = new System.Windows.Forms.TextBox();
            this.tb_tenmonan = new System.Windows.Forms.TextBox();
            this.lb_dongia = new System.Windows.Forms.Label();
            this.lb_tenmonan = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bt_them = new System.Windows.Forms.Button();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.bt_capnhat = new System.Windows.Forms.Button();
            this.bt_thaydoi = new System.Windows.Forms.Button();
            this.lb_timkiem = new System.Windows.Forms.Label();
            this.tb_timkiem = new System.Windows.Forms.TextBox();
            this.bt_quaylai = new System.Windows.Forms.Button();
            this.gb_danhsachmonan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_danhsachmonan)).BeginInit();
            this.gb_thongtinmonan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_monan
            // 
            this.lb_monan.AutoSize = true;
            this.lb_monan.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_monan.Location = new System.Drawing.Point(360, 25);
            this.lb_monan.Name = "lb_monan";
            this.lb_monan.Size = new System.Drawing.Size(109, 29);
            this.lb_monan.TabIndex = 0;
            this.lb_monan.Text = "MÓN ĂN";
            // 
            // gb_danhsachmonan
            // 
            this.gb_danhsachmonan.Controls.Add(this.dgv_danhsachmonan);
            this.gb_danhsachmonan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_danhsachmonan.Location = new System.Drawing.Point(36, 119);
            this.gb_danhsachmonan.Name = "gb_danhsachmonan";
            this.gb_danhsachmonan.Size = new System.Drawing.Size(345, 270);
            this.gb_danhsachmonan.TabIndex = 1;
            this.gb_danhsachmonan.TabStop = false;
            this.gb_danhsachmonan.Text = "Danh sách món ăn";
            // 
            // dgv_danhsachmonan
            // 
            this.dgv_danhsachmonan.AllowUserToAddRows = false;
            this.dgv_danhsachmonan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_danhsachmonan.Location = new System.Drawing.Point(24, 40);
            this.dgv_danhsachmonan.Name = "dgv_danhsachmonan";
            this.dgv_danhsachmonan.RowHeadersVisible = false;
            this.dgv_danhsachmonan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_danhsachmonan.Size = new System.Drawing.Size(307, 211);
            this.dgv_danhsachmonan.TabIndex = 0;
            this.dgv_danhsachmonan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_danhsachmonan_CellClick);
            // 
            // gb_thongtinmonan
            // 
            this.gb_thongtinmonan.Controls.Add(this.tb_mamonan);
            this.gb_thongtinmonan.Controls.Add(this.lb_mamonan);
            this.gb_thongtinmonan.Controls.Add(this.tb_dongia);
            this.gb_thongtinmonan.Controls.Add(this.tb_tenmonan);
            this.gb_thongtinmonan.Controls.Add(this.lb_dongia);
            this.gb_thongtinmonan.Controls.Add(this.lb_tenmonan);
            this.gb_thongtinmonan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_thongtinmonan.Location = new System.Drawing.Point(401, 120);
            this.gb_thongtinmonan.Name = "gb_thongtinmonan";
            this.gb_thongtinmonan.Size = new System.Drawing.Size(329, 269);
            this.gb_thongtinmonan.TabIndex = 2;
            this.gb_thongtinmonan.TabStop = false;
            this.gb_thongtinmonan.Text = "Thông tin chi tiết";
            // 
            // tb_mamonan
            // 
            this.tb_mamonan.Location = new System.Drawing.Point(119, 46);
            this.tb_mamonan.Multiline = true;
            this.tb_mamonan.Name = "tb_mamonan";
            this.tb_mamonan.Size = new System.Drawing.Size(121, 26);
            this.tb_mamonan.TabIndex = 7;
            // 
            // lb_mamonan
            // 
            this.lb_mamonan.AutoSize = true;
            this.lb_mamonan.Location = new System.Drawing.Point(21, 49);
            this.lb_mamonan.Name = "lb_mamonan";
            this.lb_mamonan.Size = new System.Drawing.Size(92, 20);
            this.lb_mamonan.TabIndex = 6;
            this.lb_mamonan.Text = "Mã món ăn:";
            // 
            // tb_dongia
            // 
            this.tb_dongia.Location = new System.Drawing.Point(119, 159);
            this.tb_dongia.Name = "tb_dongia";
            this.tb_dongia.Size = new System.Drawing.Size(121, 26);
            this.tb_dongia.TabIndex = 5;
            // 
            // tb_tenmonan
            // 
            this.tb_tenmonan.Location = new System.Drawing.Point(119, 104);
            this.tb_tenmonan.Multiline = true;
            this.tb_tenmonan.Name = "tb_tenmonan";
            this.tb_tenmonan.Size = new System.Drawing.Size(193, 26);
            this.tb_tenmonan.TabIndex = 4;
            // 
            // lb_dongia
            // 
            this.lb_dongia.AutoSize = true;
            this.lb_dongia.Location = new System.Drawing.Point(21, 162);
            this.lb_dongia.Name = "lb_dongia";
            this.lb_dongia.Size = new System.Drawing.Size(38, 20);
            this.lb_dongia.TabIndex = 2;
            this.lb_dongia.Text = "Giá:";
            // 
            // lb_tenmonan
            // 
            this.lb_tenmonan.AutoSize = true;
            this.lb_tenmonan.Location = new System.Drawing.Point(21, 107);
            this.lb_tenmonan.Name = "lb_tenmonan";
            this.lb_tenmonan.Size = new System.Drawing.Size(97, 20);
            this.lb_tenmonan.TabIndex = 1;
            this.lb_tenmonan.Text = "Tên món ăn:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Red;
            this.pictureBox1.Location = new System.Drawing.Point(17, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 26);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // bt_them
            // 
            this.bt_them.AutoSize = true;
            this.bt_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_them.Location = new System.Drawing.Point(455, 427);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(62, 33);
            this.bt_them.TabIndex = 4;
            this.bt_them.Text = "Thêm";
            this.bt_them.UseVisualStyleBackColor = true;
            this.bt_them.Visible = false;
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // bt_xoa
            // 
            this.bt_xoa.AutoSize = true;
            this.bt_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_xoa.Location = new System.Drawing.Point(658, 427);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(62, 33);
            this.bt_xoa.TabIndex = 5;
            this.bt_xoa.Text = "Xóa";
            this.bt_xoa.UseVisualStyleBackColor = true;
            this.bt_xoa.Visible = false;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // bt_capnhat
            // 
            this.bt_capnhat.AutoSize = true;
            this.bt_capnhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_capnhat.Location = new System.Drawing.Point(544, 427);
            this.bt_capnhat.Name = "bt_capnhat";
            this.bt_capnhat.Size = new System.Drawing.Size(84, 33);
            this.bt_capnhat.TabIndex = 6;
            this.bt_capnhat.Text = "Cập nhật";
            this.bt_capnhat.UseVisualStyleBackColor = true;
            this.bt_capnhat.Visible = false;
            this.bt_capnhat.Click += new System.EventHandler(this.bt_capnhat_Click);
            // 
            // bt_thaydoi
            // 
            this.bt_thaydoi.AutoSize = true;
            this.bt_thaydoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_thaydoi.Location = new System.Drawing.Point(605, 71);
            this.bt_thaydoi.Name = "bt_thaydoi";
            this.bt_thaydoi.Size = new System.Drawing.Size(78, 33);
            this.bt_thaydoi.TabIndex = 7;
            this.bt_thaydoi.Text = "Thay đổi";
            this.bt_thaydoi.UseVisualStyleBackColor = true;
            this.bt_thaydoi.Click += new System.EventHandler(this.bt_thaydoi_Click);
            // 
            // lb_timkiem
            // 
            this.lb_timkiem.AutoSize = true;
            this.lb_timkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_timkiem.Location = new System.Drawing.Point(43, 73);
            this.lb_timkiem.Name = "lb_timkiem";
            this.lb_timkiem.Size = new System.Drawing.Size(71, 20);
            this.lb_timkiem.TabIndex = 8;
            this.lb_timkiem.Text = "Tìm kiếm";
            // 
            // tb_timkiem
            // 
            this.tb_timkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_timkiem.Location = new System.Drawing.Point(133, 67);
            this.tb_timkiem.Multiline = true;
            this.tb_timkiem.Name = "tb_timkiem";
            this.tb_timkiem.Size = new System.Drawing.Size(121, 26);
            this.tb_timkiem.TabIndex = 6;
            this.tb_timkiem.TextChanged += new System.EventHandler(this.tb_timkiem_TextChanged);
            // 
            // bt_quaylai
            // 
            this.bt_quaylai.AutoSize = true;
            this.bt_quaylai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_quaylai.Location = new System.Drawing.Point(492, 71);
            this.bt_quaylai.Name = "bt_quaylai";
            this.bt_quaylai.Size = new System.Drawing.Size(78, 33);
            this.bt_quaylai.TabIndex = 9;
            this.bt_quaylai.Text = "Quay lại";
            this.bt_quaylai.UseVisualStyleBackColor = true;
            this.bt_quaylai.Click += new System.EventHandler(this.bt_quaylai_Click);
            // 
            // form_thaydoimonan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(771, 472);
            this.Controls.Add(this.bt_quaylai);
            this.Controls.Add(this.tb_timkiem);
            this.Controls.Add(this.lb_timkiem);
            this.Controls.Add(this.bt_thaydoi);
            this.Controls.Add(this.bt_capnhat);
            this.Controls.Add(this.bt_xoa);
            this.Controls.Add(this.bt_them);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gb_thongtinmonan);
            this.Controls.Add(this.gb_danhsachmonan);
            this.Controls.Add(this.lb_monan);
            this.Name = "form_thaydoimonan";
            this.Text = "DANH SÁCH MÓN ĂN";
            this.Load += new System.EventHandler(this.form_thaydoimonan_Load);
            this.gb_danhsachmonan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_danhsachmonan)).EndInit();
            this.gb_thongtinmonan.ResumeLayout(false);
            this.gb_thongtinmonan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_monan;
        private System.Windows.Forms.GroupBox gb_danhsachmonan;
        private System.Windows.Forms.DataGridView dgv_danhsachmonan;
        private System.Windows.Forms.GroupBox gb_thongtinmonan;
        private System.Windows.Forms.Label lb_dongia;
        private System.Windows.Forms.Label lb_tenmonan;
        private System.Windows.Forms.TextBox tb_dongia;
        private System.Windows.Forms.TextBox tb_tenmonan;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.Button bt_capnhat;
        private System.Windows.Forms.Button bt_thaydoi;
        private System.Windows.Forms.Label lb_timkiem;
        private System.Windows.Forms.TextBox tb_timkiem;
        private System.Windows.Forms.TextBox tb_mamonan;
        private System.Windows.Forms.Label lb_mamonan;
        private System.Windows.Forms.Button bt_quaylai;
    }
}