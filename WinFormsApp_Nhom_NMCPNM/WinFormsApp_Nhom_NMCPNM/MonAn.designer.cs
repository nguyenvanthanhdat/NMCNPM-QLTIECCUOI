namespace WinFormsApp_Nhom_NMCPNM
{
    partial class form_monan
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
            this.gb_thaydoimonan = new System.Windows.Forms.GroupBox();
            this.bt_sua = new System.Windows.Forms.Button();
            this.bt_them = new System.Windows.Forms.Button();
            this.tb_dongia = new System.Windows.Forms.TextBox();
            this.tb_tenmonan = new System.Windows.Forms.TextBox();
            this.lb_dongia = new System.Windows.Forms.Label();
            this.lb_tenmonan = new System.Windows.Forms.Label();
            this.gb_danhsachmonan = new System.Windows.Forms.GroupBox();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.bt_luu = new System.Windows.Forms.Button();
            this.dgv_monan = new System.Windows.Forms.DataGridView();
            this.lb_monan = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_manhinhchinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_quaylai)).BeginInit();
            this.gb_thaydoimonan.SuspendLayout();
            this.gb_danhsachmonan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_monan)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_manhinhchinh
            // 
            this.pb_manhinhchinh.Location = new System.Drawing.Point(63, 17);
            this.pb_manhinhchinh.Name = "pb_manhinhchinh";
            this.pb_manhinhchinh.Size = new System.Drawing.Size(27, 27);
            this.pb_manhinhchinh.TabIndex = 19;
            this.pb_manhinhchinh.TabStop = false;
            this.pb_manhinhchinh.Click += new System.EventHandler(this.pb_manhinhchinh_Click);
            // 
            // pb_quaylai
            // 
            this.pb_quaylai.Location = new System.Drawing.Point(31, 17);
            this.pb_quaylai.Name = "pb_quaylai";
            this.pb_quaylai.Size = new System.Drawing.Size(27, 27);
            this.pb_quaylai.TabIndex = 18;
            this.pb_quaylai.TabStop = false;
            this.pb_quaylai.Click += new System.EventHandler(this.pb_quaylai_Click);
            // 
            // gb_thaydoimonan
            // 
            this.gb_thaydoimonan.BackColor = System.Drawing.Color.Transparent;
            this.gb_thaydoimonan.Controls.Add(this.bt_sua);
            this.gb_thaydoimonan.Controls.Add(this.bt_them);
            this.gb_thaydoimonan.Controls.Add(this.tb_dongia);
            this.gb_thaydoimonan.Controls.Add(this.tb_tenmonan);
            this.gb_thaydoimonan.Controls.Add(this.lb_dongia);
            this.gb_thaydoimonan.Controls.Add(this.lb_tenmonan);
            this.gb_thaydoimonan.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gb_thaydoimonan.Location = new System.Drawing.Point(31, 384);
            this.gb_thaydoimonan.Name = "gb_thaydoimonan";
            this.gb_thaydoimonan.Size = new System.Drawing.Size(765, 114);
            this.gb_thaydoimonan.TabIndex = 17;
            this.gb_thaydoimonan.TabStop = false;
            this.gb_thaydoimonan.Text = "Thay đổi món ăn";
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
            // tb_tenmonan
            // 
            this.tb_tenmonan.Location = new System.Drawing.Point(123, 30);
            this.tb_tenmonan.Name = "tb_tenmonan";
            this.tb_tenmonan.Size = new System.Drawing.Size(259, 29);
            this.tb_tenmonan.TabIndex = 5;
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
            // lb_tenmonan
            // 
            this.lb_tenmonan.AutoSize = true;
            this.lb_tenmonan.Location = new System.Drawing.Point(23, 33);
            this.lb_tenmonan.Name = "lb_tenmonan";
            this.lb_tenmonan.Size = new System.Drawing.Size(90, 21);
            this.lb_tenmonan.TabIndex = 0;
            this.lb_tenmonan.Text = "Tên món ăn";
            // 
            // gb_danhsachmonan
            // 
            this.gb_danhsachmonan.BackColor = System.Drawing.Color.Transparent;
            this.gb_danhsachmonan.Controls.Add(this.bt_xoa);
            this.gb_danhsachmonan.Controls.Add(this.bt_luu);
            this.gb_danhsachmonan.Controls.Add(this.dgv_monan);
            this.gb_danhsachmonan.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gb_danhsachmonan.Location = new System.Drawing.Point(31, 73);
            this.gb_danhsachmonan.Name = "gb_danhsachmonan";
            this.gb_danhsachmonan.Size = new System.Drawing.Size(765, 306);
            this.gb_danhsachmonan.TabIndex = 16;
            this.gb_danhsachmonan.TabStop = false;
            this.gb_danhsachmonan.Text = "Danh sách món ăn";
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
            // dgv_monan
            // 
            this.dgv_monan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_monan.Location = new System.Drawing.Point(20, 36);
            this.dgv_monan.Name = "dgv_monan";
            this.dgv_monan.RowTemplate.Height = 25;
            this.dgv_monan.Size = new System.Drawing.Size(732, 211);
            this.dgv_monan.TabIndex = 1;
            // 
            // lb_monan
            // 
            this.lb_monan.AutoSize = true;
            this.lb_monan.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.lb_monan.Location = new System.Drawing.Point(357, 42);
            this.lb_monan.Name = "lb_monan";
            this.lb_monan.Size = new System.Drawing.Size(125, 37);
            this.lb_monan.TabIndex = 15;
            this.lb_monan.Text = "MÓN ĂN";
            // 
            // form_monan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 514);
            this.Controls.Add(this.pb_manhinhchinh);
            this.Controls.Add(this.pb_quaylai);
            this.Controls.Add(this.gb_thaydoimonan);
            this.Controls.Add(this.gb_danhsachmonan);
            this.Controls.Add(this.lb_monan);
            this.Name = "form_monan";
            this.Text = "Món ăn";
            this.Load += new System.EventHandler(this.form_monan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_manhinhchinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_quaylai)).EndInit();
            this.gb_thaydoimonan.ResumeLayout(false);
            this.gb_thaydoimonan.PerformLayout();
            this.gb_danhsachmonan.ResumeLayout(false);
            this.gb_danhsachmonan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_monan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_manhinhchinh;
        private System.Windows.Forms.PictureBox pb_quaylai;
        private System.Windows.Forms.GroupBox gb_thaydoimonan;
        private System.Windows.Forms.Button bt_sua;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.TextBox tb_dongia;
        private System.Windows.Forms.TextBox tb_tenmonan;
        private System.Windows.Forms.Label lb_dongia;
        private System.Windows.Forms.Label lb_tenmonan;
        private System.Windows.Forms.GroupBox gb_danhsachmonan;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.Button bt_luu;
        private System.Windows.Forms.DataGridView dgv_monan;
        private System.Windows.Forms.Label lb_monan;
    }
}