namespace QuanLyTiecCuoi
{
    partial class form_thaydoidichvu
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
            this.lb_dichvu = new System.Windows.Forms.Label();
            this.ptb_quaylai = new System.Windows.Forms.PictureBox();
            this.gb_danhsachdichvu = new System.Windows.Forms.GroupBox();
            this.dgv_danhsachdichvu = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_madichvu = new System.Windows.Forms.TextBox();
            this.lb_madichvu = new System.Windows.Forms.Label();
            this.tb_dongia = new System.Windows.Forms.TextBox();
            this.tb_tendichvu = new System.Windows.Forms.TextBox();
            this.lb_gia = new System.Windows.Forms.Label();
            this.lb_tendichvu = new System.Windows.Forms.Label();
            this.bt_them = new System.Windows.Forms.Button();
            this.bt_capnhat = new System.Windows.Forms.Button();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.lb_timkiem = new System.Windows.Forms.Label();
            this.tb_timkiem = new System.Windows.Forms.TextBox();
            this.ptb_quaylaithaydoidichvu = new System.Windows.Forms.PictureBox();
            this.bt_thaydoi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_quaylai)).BeginInit();
            this.gb_danhsachdichvu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_danhsachdichvu)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_quaylaithaydoidichvu)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_dichvu
            // 
            this.lb_dichvu.AutoSize = true;
            this.lb_dichvu.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_dichvu.Location = new System.Drawing.Point(347, 19);
            this.lb_dichvu.Name = "lb_dichvu";
            this.lb_dichvu.Size = new System.Drawing.Size(108, 29);
            this.lb_dichvu.TabIndex = 0;
            this.lb_dichvu.Text = "DỊCH VỤ";
            // 
            // ptb_quaylai
            // 
            this.ptb_quaylai.BackColor = System.Drawing.Color.Red;
            this.ptb_quaylai.Location = new System.Drawing.Point(16, 15);
            this.ptb_quaylai.Name = "ptb_quaylai";
            this.ptb_quaylai.Size = new System.Drawing.Size(35, 32);
            this.ptb_quaylai.TabIndex = 1;
            this.ptb_quaylai.TabStop = false;
            // 
            // gb_danhsachdichvu
            // 
            this.gb_danhsachdichvu.Controls.Add(this.dgv_danhsachdichvu);
            this.gb_danhsachdichvu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_danhsachdichvu.Location = new System.Drawing.Point(68, 138);
            this.gb_danhsachdichvu.Name = "gb_danhsachdichvu";
            this.gb_danhsachdichvu.Size = new System.Drawing.Size(363, 236);
            this.gb_danhsachdichvu.TabIndex = 2;
            this.gb_danhsachdichvu.TabStop = false;
            this.gb_danhsachdichvu.Text = "Danh sách dịch vụ";
            // 
            // dgv_danhsachdichvu
            // 
            this.dgv_danhsachdichvu.AllowUserToAddRows = false;
            this.dgv_danhsachdichvu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_danhsachdichvu.Location = new System.Drawing.Point(25, 33);
            this.dgv_danhsachdichvu.Name = "dgv_danhsachdichvu";
            this.dgv_danhsachdichvu.RowHeadersVisible = false;
            this.dgv_danhsachdichvu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_danhsachdichvu.Size = new System.Drawing.Size(303, 165);
            this.dgv_danhsachdichvu.TabIndex = 0;
            this.dgv_danhsachdichvu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_danhsachdichvu_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_madichvu);
            this.groupBox1.Controls.Add(this.lb_madichvu);
            this.groupBox1.Controls.Add(this.tb_dongia);
            this.groupBox1.Controls.Add(this.tb_tendichvu);
            this.groupBox1.Controls.Add(this.lb_gia);
            this.groupBox1.Controls.Add(this.lb_tendichvu);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(459, 138);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 235);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết";
            // 
            // tb_madichvu
            // 
            this.tb_madichvu.Location = new System.Drawing.Point(115, 51);
            this.tb_madichvu.Multiline = true;
            this.tb_madichvu.Name = "tb_madichvu";
            this.tb_madichvu.Size = new System.Drawing.Size(149, 25);
            this.tb_madichvu.TabIndex = 5;
            // 
            // lb_madichvu
            // 
            this.lb_madichvu.AutoSize = true;
            this.lb_madichvu.Location = new System.Drawing.Point(20, 54);
            this.lb_madichvu.Name = "lb_madichvu";
            this.lb_madichvu.Size = new System.Drawing.Size(84, 20);
            this.lb_madichvu.TabIndex = 4;
            this.lb_madichvu.Text = "Mã dịch vụ";
            // 
            // tb_dongia
            // 
            this.tb_dongia.Location = new System.Drawing.Point(115, 173);
            this.tb_dongia.Name = "tb_dongia";
            this.tb_dongia.Size = new System.Drawing.Size(149, 26);
            this.tb_dongia.TabIndex = 3;
            // 
            // tb_tendichvu
            // 
            this.tb_tendichvu.Location = new System.Drawing.Point(115, 113);
            this.tb_tendichvu.Multiline = true;
            this.tb_tendichvu.Name = "tb_tendichvu";
            this.tb_tendichvu.Size = new System.Drawing.Size(149, 25);
            this.tb_tendichvu.TabIndex = 2;
            // 
            // lb_gia
            // 
            this.lb_gia.AutoSize = true;
            this.lb_gia.Location = new System.Drawing.Point(20, 176);
            this.lb_gia.Name = "lb_gia";
            this.lb_gia.Size = new System.Drawing.Size(34, 20);
            this.lb_gia.TabIndex = 1;
            this.lb_gia.Text = "Giá";
            // 
            // lb_tendichvu
            // 
            this.lb_tendichvu.AutoSize = true;
            this.lb_tendichvu.Location = new System.Drawing.Point(20, 116);
            this.lb_tendichvu.Name = "lb_tendichvu";
            this.lb_tendichvu.Size = new System.Drawing.Size(89, 20);
            this.lb_tendichvu.TabIndex = 0;
            this.lb_tendichvu.Text = "Tên dịch vụ";
            // 
            // bt_them
            // 
            this.bt_them.AutoSize = true;
            this.bt_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_them.Location = new System.Drawing.Point(481, 434);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(76, 30);
            this.bt_them.TabIndex = 4;
            this.bt_them.Text = "Thêm";
            this.bt_them.UseVisualStyleBackColor = true;
            this.bt_them.Visible = false;
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // bt_capnhat
            // 
            this.bt_capnhat.AutoSize = true;
            this.bt_capnhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_capnhat.Location = new System.Drawing.Point(585, 434);
            this.bt_capnhat.Name = "bt_capnhat";
            this.bt_capnhat.Size = new System.Drawing.Size(84, 30);
            this.bt_capnhat.TabIndex = 5;
            this.bt_capnhat.Text = "Cập nhật";
            this.bt_capnhat.UseVisualStyleBackColor = true;
            this.bt_capnhat.Visible = false;
            this.bt_capnhat.Click += new System.EventHandler(this.bt_capnhat_Click);
            // 
            // bt_xoa
            // 
            this.bt_xoa.AutoSize = true;
            this.bt_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_xoa.Location = new System.Drawing.Point(686, 434);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(76, 30);
            this.bt_xoa.TabIndex = 6;
            this.bt_xoa.Text = "Xóa";
            this.bt_xoa.UseVisualStyleBackColor = true;
            this.bt_xoa.Visible = false;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // lb_timkiem
            // 
            this.lb_timkiem.AutoSize = true;
            this.lb_timkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_timkiem.Location = new System.Drawing.Point(65, 85);
            this.lb_timkiem.Name = "lb_timkiem";
            this.lb_timkiem.Size = new System.Drawing.Size(75, 20);
            this.lb_timkiem.TabIndex = 7;
            this.lb_timkiem.Text = "Tìm kiếm:";
            // 
            // tb_timkiem
            // 
            this.tb_timkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_timkiem.Location = new System.Drawing.Point(155, 82);
            this.tb_timkiem.Name = "tb_timkiem";
            this.tb_timkiem.Size = new System.Drawing.Size(125, 26);
            this.tb_timkiem.TabIndex = 8;
            this.tb_timkiem.TextChanged += new System.EventHandler(this.tb_timkiem_TextChanged);
            // 
            // ptb_quaylaithaydoidichvu
            // 
            this.ptb_quaylaithaydoidichvu.BackColor = System.Drawing.Color.Red;
            this.ptb_quaylaithaydoidichvu.Location = new System.Drawing.Point(16, 15);
            this.ptb_quaylaithaydoidichvu.Name = "ptb_quaylaithaydoidichvu";
            this.ptb_quaylaithaydoidichvu.Size = new System.Drawing.Size(35, 32);
            this.ptb_quaylaithaydoidichvu.TabIndex = 10;
            this.ptb_quaylaithaydoidichvu.TabStop = false;
            this.ptb_quaylaithaydoidichvu.Visible = false;
            // 
            // bt_thaydoi
            // 
            this.bt_thaydoi.AutoSize = true;
            this.bt_thaydoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_thaydoi.Location = new System.Drawing.Point(612, 75);
            this.bt_thaydoi.Name = "bt_thaydoi";
            this.bt_thaydoi.Size = new System.Drawing.Size(78, 30);
            this.bt_thaydoi.TabIndex = 11;
            this.bt_thaydoi.Text = "Thay đổi";
            this.bt_thaydoi.UseVisualStyleBackColor = true;
            this.bt_thaydoi.Click += new System.EventHandler(this.bt_thaydoi_Click);
            // 
            // form_thaydoidichvu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 476);
            this.Controls.Add(this.bt_thaydoi);
            this.Controls.Add(this.ptb_quaylaithaydoidichvu);
            this.Controls.Add(this.tb_timkiem);
            this.Controls.Add(this.lb_timkiem);
            this.Controls.Add(this.bt_xoa);
            this.Controls.Add(this.bt_capnhat);
            this.Controls.Add(this.bt_them);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gb_danhsachdichvu);
            this.Controls.Add(this.ptb_quaylai);
            this.Controls.Add(this.lb_dichvu);
            this.Name = "form_thaydoidichvu";
            this.Text = "DANH SÁCH DỊCH VỤ";
            this.Load += new System.EventHandler(this.form_danhsachdichvu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_quaylai)).EndInit();
            this.gb_danhsachdichvu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_danhsachdichvu)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_quaylaithaydoidichvu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_dichvu;
        private System.Windows.Forms.PictureBox ptb_quaylai;
        private System.Windows.Forms.GroupBox gb_danhsachdichvu;
        private System.Windows.Forms.DataGridView dgv_danhsachdichvu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_dongia;
        private System.Windows.Forms.TextBox tb_tendichvu;
        private System.Windows.Forms.Label lb_gia;
        private System.Windows.Forms.Label lb_tendichvu;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.Button bt_capnhat;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.Label lb_timkiem;
        private System.Windows.Forms.TextBox tb_timkiem;
        private System.Windows.Forms.TextBox tb_madichvu;
        private System.Windows.Forms.Label lb_madichvu;
        private System.Windows.Forms.PictureBox ptb_quaylaithaydoidichvu;
        private System.Windows.Forms.Button bt_thaydoi;
    }
}