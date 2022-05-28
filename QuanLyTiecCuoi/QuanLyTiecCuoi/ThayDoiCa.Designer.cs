namespace QuanLyTiecCuoi
{
    partial class form_thaydoica
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
            this.bt_quaylai = new System.Windows.Forms.Button();
            this.bt_thaydoi = new System.Windows.Forms.Button();
            this.tb_timkiem = new System.Windows.Forms.TextBox();
            this.lb_timkiem = new System.Windows.Forms.Label();
            this.ptb_quaylai = new System.Windows.Forms.PictureBox();
            this.bt_capnhat = new System.Windows.Forms.Button();
            this.gb_thongtinca = new System.Windows.Forms.GroupBox();
            this.tb_tenca = new System.Windows.Forms.TextBox();
            this.lb_tenca = new System.Windows.Forms.Label();
            this.tb_maca = new System.Windows.Forms.TextBox();
            this.lb_maca = new System.Windows.Forms.Label();
            this.gb_danhsachca = new System.Windows.Forms.GroupBox();
            this.dgv_danhsachca = new System.Windows.Forms.DataGridView();
            this.lb_ca = new System.Windows.Forms.Label();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.bt_them = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_quaylai)).BeginInit();
            this.gb_thongtinca.SuspendLayout();
            this.gb_danhsachca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_danhsachca)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_quaylai
            // 
            this.bt_quaylai.AutoSize = true;
            this.bt_quaylai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_quaylai.Location = new System.Drawing.Point(424, 81);
            this.bt_quaylai.Name = "bt_quaylai";
            this.bt_quaylai.Size = new System.Drawing.Size(75, 30);
            this.bt_quaylai.TabIndex = 28;
            this.bt_quaylai.Text = "Quay lại";
            this.bt_quaylai.UseVisualStyleBackColor = true;
            this.bt_quaylai.Visible = false;
            this.bt_quaylai.Click += new System.EventHandler(this.bt_quaylai_Click);
            // 
            // bt_thaydoi
            // 
            this.bt_thaydoi.AutoSize = true;
            this.bt_thaydoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_thaydoi.Location = new System.Drawing.Point(564, 81);
            this.bt_thaydoi.Name = "bt_thaydoi";
            this.bt_thaydoi.Size = new System.Drawing.Size(78, 30);
            this.bt_thaydoi.TabIndex = 27;
            this.bt_thaydoi.Text = "Thay đổi";
            this.bt_thaydoi.UseVisualStyleBackColor = true;
            this.bt_thaydoi.Click += new System.EventHandler(this.bt_thaydoi_Click);
            // 
            // tb_timkiem
            // 
            this.tb_timkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_timkiem.Location = new System.Drawing.Point(131, 83);
            this.tb_timkiem.Name = "tb_timkiem";
            this.tb_timkiem.Size = new System.Drawing.Size(111, 26);
            this.tb_timkiem.TabIndex = 25;
            this.tb_timkiem.TextChanged += new System.EventHandler(this.tb_timkiem_TextChanged);
            // 
            // lb_timkiem
            // 
            this.lb_timkiem.AutoSize = true;
            this.lb_timkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_timkiem.Location = new System.Drawing.Point(31, 86);
            this.lb_timkiem.Name = "lb_timkiem";
            this.lb_timkiem.Size = new System.Drawing.Size(71, 20);
            this.lb_timkiem.TabIndex = 26;
            this.lb_timkiem.Text = "Tìm kiếm";
            // 
            // ptb_quaylai
            // 
            this.ptb_quaylai.BackColor = System.Drawing.Color.Red;
            this.ptb_quaylai.Location = new System.Drawing.Point(9, 15);
            this.ptb_quaylai.Name = "ptb_quaylai";
            this.ptb_quaylai.Size = new System.Drawing.Size(33, 28);
            this.ptb_quaylai.TabIndex = 24;
            this.ptb_quaylai.TabStop = false;
            // 
            // bt_capnhat
            // 
            this.bt_capnhat.AutoSize = true;
            this.bt_capnhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_capnhat.Location = new System.Drawing.Point(482, 313);
            this.bt_capnhat.Name = "bt_capnhat";
            this.bt_capnhat.Size = new System.Drawing.Size(84, 30);
            this.bt_capnhat.TabIndex = 23;
            this.bt_capnhat.Text = "Cập nhật";
            this.bt_capnhat.UseVisualStyleBackColor = true;
            this.bt_capnhat.Visible = false;
            this.bt_capnhat.Click += new System.EventHandler(this.bt_capnhat_Click);
            // 
            // gb_thongtinca
            // 
            this.gb_thongtinca.Controls.Add(this.tb_tenca);
            this.gb_thongtinca.Controls.Add(this.lb_tenca);
            this.gb_thongtinca.Controls.Add(this.tb_maca);
            this.gb_thongtinca.Controls.Add(this.lb_maca);
            this.gb_thongtinca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_thongtinca.Location = new System.Drawing.Point(353, 138);
            this.gb_thongtinca.Name = "gb_thongtinca";
            this.gb_thongtinca.Size = new System.Drawing.Size(320, 144);
            this.gb_thongtinca.TabIndex = 20;
            this.gb_thongtinca.TabStop = false;
            this.gb_thongtinca.Text = "Thông tin ca";
            // 
            // tb_tenca
            // 
            this.tb_tenca.Location = new System.Drawing.Point(194, 81);
            this.tb_tenca.Name = "tb_tenca";
            this.tb_tenca.Size = new System.Drawing.Size(111, 26);
            this.tb_tenca.TabIndex = 12;
            // 
            // lb_tenca
            // 
            this.lb_tenca.AutoSize = true;
            this.lb_tenca.Location = new System.Drawing.Point(21, 87);
            this.lb_tenca.Name = "lb_tenca";
            this.lb_tenca.Size = new System.Drawing.Size(57, 20);
            this.lb_tenca.TabIndex = 11;
            this.lb_tenca.Text = "Tên ca";
            // 
            // tb_maca
            // 
            this.tb_maca.Location = new System.Drawing.Point(194, 33);
            this.tb_maca.Name = "tb_maca";
            this.tb_maca.Size = new System.Drawing.Size(111, 26);
            this.tb_maca.TabIndex = 10;
            // 
            // lb_maca
            // 
            this.lb_maca.AutoSize = true;
            this.lb_maca.Location = new System.Drawing.Point(21, 36);
            this.lb_maca.Name = "lb_maca";
            this.lb_maca.Size = new System.Drawing.Size(52, 20);
            this.lb_maca.TabIndex = 9;
            this.lb_maca.Text = "Mã ca";
            // 
            // gb_danhsachca
            // 
            this.gb_danhsachca.Controls.Add(this.dgv_danhsachca);
            this.gb_danhsachca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_danhsachca.Location = new System.Drawing.Point(25, 138);
            this.gb_danhsachca.Name = "gb_danhsachca";
            this.gb_danhsachca.Size = new System.Drawing.Size(285, 144);
            this.gb_danhsachca.TabIndex = 19;
            this.gb_danhsachca.TabStop = false;
            this.gb_danhsachca.Text = "Danh sách loại sảnh";
            // 
            // dgv_danhsachca
            // 
            this.dgv_danhsachca.AllowUserToAddRows = false;
            this.dgv_danhsachca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_danhsachca.EnableHeadersVisualStyles = false;
            this.dgv_danhsachca.Location = new System.Drawing.Point(30, 25);
            this.dgv_danhsachca.Name = "dgv_danhsachca";
            this.dgv_danhsachca.RowHeadersVisible = false;
            this.dgv_danhsachca.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_danhsachca.Size = new System.Drawing.Size(221, 82);
            this.dgv_danhsachca.TabIndex = 0;
            this.dgv_danhsachca.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_danhsachca_CellClick);
            // 
            // lb_ca
            // 
            this.lb_ca.AutoSize = true;
            this.lb_ca.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ca.Location = new System.Drawing.Point(321, 15);
            this.lb_ca.Name = "lb_ca";
            this.lb_ca.Size = new System.Drawing.Size(45, 29);
            this.lb_ca.TabIndex = 18;
            this.lb_ca.Text = "CA";
            // 
            // bt_xoa
            // 
            this.bt_xoa.AutoSize = true;
            this.bt_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_xoa.Location = new System.Drawing.Point(593, 313);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(75, 30);
            this.bt_xoa.TabIndex = 22;
            this.bt_xoa.Text = "Xóa";
            this.bt_xoa.UseVisualStyleBackColor = true;
            this.bt_xoa.Visible = false;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // bt_them
            // 
            this.bt_them.AutoSize = true;
            this.bt_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_them.Location = new System.Drawing.Point(368, 313);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(75, 30);
            this.bt_them.TabIndex = 21;
            this.bt_them.Text = "Thêm";
            this.bt_them.UseVisualStyleBackColor = true;
            this.bt_them.Visible = false;
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // form_thaydoica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(705, 366);
            this.Controls.Add(this.bt_quaylai);
            this.Controls.Add(this.bt_thaydoi);
            this.Controls.Add(this.tb_timkiem);
            this.Controls.Add(this.lb_timkiem);
            this.Controls.Add(this.ptb_quaylai);
            this.Controls.Add(this.bt_capnhat);
            this.Controls.Add(this.bt_xoa);
            this.Controls.Add(this.bt_them);
            this.Controls.Add(this.gb_thongtinca);
            this.Controls.Add(this.gb_danhsachca);
            this.Controls.Add(this.lb_ca);
            this.Name = "form_thaydoica";
            this.Text = "THÔNG TIN CA";
            this.Load += new System.EventHandler(this.form_thaydoica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_quaylai)).EndInit();
            this.gb_thongtinca.ResumeLayout(false);
            this.gb_thongtinca.PerformLayout();
            this.gb_danhsachca.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_danhsachca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_quaylai;
        private System.Windows.Forms.Button bt_thaydoi;
        private System.Windows.Forms.TextBox tb_timkiem;
        private System.Windows.Forms.Label lb_timkiem;
        private System.Windows.Forms.PictureBox ptb_quaylai;
        private System.Windows.Forms.Button bt_capnhat;
        private System.Windows.Forms.GroupBox gb_thongtinca;
        private System.Windows.Forms.TextBox tb_tenca;
        private System.Windows.Forms.Label lb_tenca;
        private System.Windows.Forms.TextBox tb_maca;
        private System.Windows.Forms.Label lb_maca;
        private System.Windows.Forms.GroupBox gb_danhsachca;
        private System.Windows.Forms.DataGridView dgv_danhsachca;
        private System.Windows.Forms.Label lb_ca;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.Button bt_them;
    }
}