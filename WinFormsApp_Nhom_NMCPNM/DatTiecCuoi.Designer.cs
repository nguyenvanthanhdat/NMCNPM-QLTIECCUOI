
namespace WinFormsApp_Nhom_NMCPNM
{
    partial class DatTiecCuoi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatTiecCuoi));
            this.label1 = new System.Windows.Forms.Label();
            this.gb_thongtintieccuoi = new System.Windows.Forms.GroupBox();
            this.dt_ngaydattiec = new System.Windows.Forms.DateTimePicker();
            this.tb_ca = new System.Windows.Forms.MaskedTextBox();
            this.tb_tenchure = new System.Windows.Forms.MaskedTextBox();
            this.tb_tiendatcoc = new System.Windows.Forms.MaskedTextBox();
            this.tb_sanh = new System.Windows.Forms.MaskedTextBox();
            this.tb_soluongban = new System.Windows.Forms.MaskedTextBox();
            this.tb_soluongbandutru = new System.Windows.Forms.MaskedTextBox();
            this.tb_khachhang = new System.Windows.Forms.MaskedTextBox();
            this.tb_dienthoai = new System.Windows.Forms.MaskedTextBox();
            this.tb_tencodau = new System.Windows.Forms.MaskedTextBox();
            this.lb_sanh = new System.Windows.Forms.Label();
            this.lb_tiendatcoc = new System.Windows.Forms.Label();
            this.lb_soluongbandutru = new System.Windows.Forms.Label();
            this.lb_dienthoai = new System.Windows.Forms.Label();
            this.lb_ngaydattiec = new System.Windows.Forms.Label();
            this.lb_tenchure = new System.Windows.Forms.Label();
            this.lb_ca = new System.Windows.Forms.Label();
            this.lb_soluongban = new System.Windows.Forms.Label();
            this.lb_khachhang = new System.Windows.Forms.Label();
            this.lb_tencodau = new System.Windows.Forms.Label();
            this.gb_datban = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lb_monan = new System.Windows.Forms.Label();
            this.gb_dichvukhac = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.lb_dichvu = new System.Windows.Forms.Label();
            this.bt_luu = new System.Windows.Forms.Button();
            this.bt_thoat = new System.Windows.Forms.Button();
            this.bt_quaylai = new System.Windows.Forms.Button();
            this.lb_dattieccuoi = new System.Windows.Forms.Label();
            this.gb_thongtintieccuoi.SuspendLayout();
            this.gb_datban.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gb_dichvukhac.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 0;
            // 
            // gb_thongtintieccuoi
            // 
            this.gb_thongtintieccuoi.Controls.Add(this.dt_ngaydattiec);
            this.gb_thongtintieccuoi.Controls.Add(this.tb_ca);
            this.gb_thongtintieccuoi.Controls.Add(this.tb_tenchure);
            this.gb_thongtintieccuoi.Controls.Add(this.tb_tiendatcoc);
            this.gb_thongtintieccuoi.Controls.Add(this.tb_sanh);
            this.gb_thongtintieccuoi.Controls.Add(this.tb_soluongban);
            this.gb_thongtintieccuoi.Controls.Add(this.tb_soluongbandutru);
            this.gb_thongtintieccuoi.Controls.Add(this.tb_khachhang);
            this.gb_thongtintieccuoi.Controls.Add(this.tb_dienthoai);
            this.gb_thongtintieccuoi.Controls.Add(this.tb_tencodau);
            this.gb_thongtintieccuoi.Controls.Add(this.lb_sanh);
            this.gb_thongtintieccuoi.Controls.Add(this.lb_tiendatcoc);
            this.gb_thongtintieccuoi.Controls.Add(this.lb_soluongbandutru);
            this.gb_thongtintieccuoi.Controls.Add(this.lb_dienthoai);
            this.gb_thongtintieccuoi.Controls.Add(this.lb_ngaydattiec);
            this.gb_thongtintieccuoi.Controls.Add(this.lb_tenchure);
            this.gb_thongtintieccuoi.Controls.Add(this.lb_ca);
            this.gb_thongtintieccuoi.Controls.Add(this.lb_soluongban);
            this.gb_thongtintieccuoi.Controls.Add(this.lb_khachhang);
            this.gb_thongtintieccuoi.Controls.Add(this.lb_tencodau);
            this.gb_thongtintieccuoi.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gb_thongtintieccuoi.Location = new System.Drawing.Point(18, 80);
            this.gb_thongtintieccuoi.Name = "gb_thongtintieccuoi";
            this.gb_thongtintieccuoi.Size = new System.Drawing.Size(662, 224);
            this.gb_thongtintieccuoi.TabIndex = 1;
            this.gb_thongtintieccuoi.TabStop = false;
            this.gb_thongtintieccuoi.Text = "Thông tin tiệc cưới";
            // 
            // dt_ngaydattiec
            // 
            this.dt_ngaydattiec.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_ngaydattiec.Location = new System.Drawing.Point(183, 126);
            this.dt_ngaydattiec.Name = "dt_ngaydattiec";
            this.dt_ngaydattiec.Size = new System.Drawing.Size(101, 25);
            this.dt_ngaydattiec.TabIndex = 19;
            // 
            // tb_ca
            // 
            this.tb_ca.Location = new System.Drawing.Point(184, 168);
            this.tb_ca.Name = "tb_ca";
            this.tb_ca.Size = new System.Drawing.Size(100, 25);
            this.tb_ca.TabIndex = 18;
            // 
            // tb_tenchure
            // 
            this.tb_tenchure.Location = new System.Drawing.Point(184, 64);
            this.tb_tenchure.Name = "tb_tenchure";
            this.tb_tenchure.Size = new System.Drawing.Size(100, 25);
            this.tb_tenchure.TabIndex = 17;
            this.tb_tenchure.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox8_MaskInputRejected);
            // 
            // tb_tiendatcoc
            // 
            this.tb_tiendatcoc.Location = new System.Drawing.Point(525, 64);
            this.tb_tiendatcoc.Name = "tb_tiendatcoc";
            this.tb_tiendatcoc.Size = new System.Drawing.Size(100, 25);
            this.tb_tiendatcoc.TabIndex = 16;
            // 
            // tb_sanh
            // 
            this.tb_sanh.Location = new System.Drawing.Point(525, 35);
            this.tb_sanh.Name = "tb_sanh";
            this.tb_sanh.Size = new System.Drawing.Size(100, 25);
            this.tb_sanh.TabIndex = 15;
            // 
            // tb_soluongban
            // 
            this.tb_soluongban.Location = new System.Drawing.Point(525, 95);
            this.tb_soluongban.Name = "tb_soluongban";
            this.tb_soluongban.Size = new System.Drawing.Size(100, 25);
            this.tb_soluongban.TabIndex = 14;
            // 
            // tb_soluongbandutru
            // 
            this.tb_soluongbandutru.Location = new System.Drawing.Point(526, 133);
            this.tb_soluongbandutru.Name = "tb_soluongbandutru";
            this.tb_soluongbandutru.Size = new System.Drawing.Size(100, 25);
            this.tb_soluongbandutru.TabIndex = 13;
            // 
            // tb_khachhang
            // 
            this.tb_khachhang.Location = new System.Drawing.Point(526, 171);
            this.tb_khachhang.Name = "tb_khachhang";
            this.tb_khachhang.Size = new System.Drawing.Size(100, 25);
            this.tb_khachhang.TabIndex = 12;
            // 
            // tb_dienthoai
            // 
            this.tb_dienthoai.Location = new System.Drawing.Point(184, 95);
            this.tb_dienthoai.Name = "tb_dienthoai";
            this.tb_dienthoai.Size = new System.Drawing.Size(100, 25);
            this.tb_dienthoai.TabIndex = 11;
            // 
            // tb_tencodau
            // 
            this.tb_tencodau.Location = new System.Drawing.Point(184, 35);
            this.tb_tencodau.Name = "tb_tencodau";
            this.tb_tencodau.Size = new System.Drawing.Size(100, 25);
            this.tb_tencodau.TabIndex = 10;
            // 
            // lb_sanh
            // 
            this.lb_sanh.AutoSize = true;
            this.lb_sanh.Location = new System.Drawing.Point(368, 38);
            this.lb_sanh.Name = "lb_sanh";
            this.lb_sanh.Size = new System.Drawing.Size(42, 17);
            this.lb_sanh.TabIndex = 9;
            this.lb_sanh.Text = "SẢNH";
            // 
            // lb_tiendatcoc
            // 
            this.lb_tiendatcoc.AutoSize = true;
            this.lb_tiendatcoc.Location = new System.Drawing.Point(368, 67);
            this.lb_tiendatcoc.Name = "lb_tiendatcoc";
            this.lb_tiendatcoc.Size = new System.Drawing.Size(93, 17);
            this.lb_tiendatcoc.TabIndex = 8;
            this.lb_tiendatcoc.Text = "TIỀN ĐẶT CỌC";
            // 
            // lb_soluongbandutru
            // 
            this.lb_soluongbandutru.AutoSize = true;
            this.lb_soluongbandutru.Location = new System.Drawing.Point(368, 136);
            this.lb_soluongbandutru.Name = "lb_soluongbandutru";
            this.lb_soluongbandutru.Size = new System.Drawing.Size(152, 17);
            this.lb_soluongbandutru.TabIndex = 7;
            this.lb_soluongbandutru.Text = "SỐ LƯỢNG BÀN DỰ TRỮ";
            // 
            // lb_dienthoai
            // 
            this.lb_dienthoai.AutoSize = true;
            this.lb_dienthoai.Location = new System.Drawing.Point(30, 98);
            this.lb_dienthoai.Name = "lb_dienthoai";
            this.lb_dienthoai.Size = new System.Drawing.Size(78, 17);
            this.lb_dienthoai.TabIndex = 6;
            this.lb_dienthoai.Text = "ĐIỆN THOẠI";
            // 
            // lb_ngaydattiec
            // 
            this.lb_ngaydattiec.AutoSize = true;
            this.lb_ngaydattiec.Location = new System.Drawing.Point(30, 136);
            this.lb_ngaydattiec.Name = "lb_ngaydattiec";
            this.lb_ngaydattiec.Size = new System.Drawing.Size(98, 17);
            this.lb_ngaydattiec.TabIndex = 5;
            this.lb_ngaydattiec.Text = "NGÀY ĐẶT TIỆC";
            // 
            // lb_tenchure
            // 
            this.lb_tenchure.AutoSize = true;
            this.lb_tenchure.Location = new System.Drawing.Point(30, 67);
            this.lb_tenchure.Name = "lb_tenchure";
            this.lb_tenchure.Size = new System.Drawing.Size(81, 17);
            this.lb_tenchure.TabIndex = 4;
            this.lb_tenchure.Text = "TÊN CHÚ RỂ";
            this.lb_tenchure.Click += new System.EventHandler(this.lb_tenchure_Click);
            // 
            // lb_ca
            // 
            this.lb_ca.AutoSize = true;
            this.lb_ca.Location = new System.Drawing.Point(30, 171);
            this.lb_ca.Name = "lb_ca";
            this.lb_ca.Size = new System.Drawing.Size(24, 17);
            this.lb_ca.TabIndex = 3;
            this.lb_ca.Text = "CA";
            // 
            // lb_soluongban
            // 
            this.lb_soluongban.AutoSize = true;
            this.lb_soluongban.Location = new System.Drawing.Point(368, 98);
            this.lb_soluongban.Name = "lb_soluongban";
            this.lb_soluongban.Size = new System.Drawing.Size(102, 17);
            this.lb_soluongban.TabIndex = 2;
            this.lb_soluongban.Text = "SỐ LƯỢNG BÀN";
            // 
            // lb_khachhang
            // 
            this.lb_khachhang.AutoSize = true;
            this.lb_khachhang.Location = new System.Drawing.Point(368, 171);
            this.lb_khachhang.Name = "lb_khachhang";
            this.lb_khachhang.Size = new System.Drawing.Size(118, 17);
            this.lb_khachhang.TabIndex = 1;
            this.lb_khachhang.Text = "TÊN KHÁCH HÀNG";
            // 
            // lb_tencodau
            // 
            this.lb_tencodau.AutoSize = true;
            this.lb_tencodau.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_tencodau.Location = new System.Drawing.Point(30, 38);
            this.lb_tencodau.Name = "lb_tencodau";
            this.lb_tencodau.Size = new System.Drawing.Size(84, 17);
            this.lb_tencodau.TabIndex = 0;
            this.lb_tencodau.Text = "TÊN CÔ DÂU";
            // 
            // gb_datban
            // 
            this.gb_datban.Controls.Add(this.dataGridView1);
            this.gb_datban.Controls.Add(this.lb_monan);
            this.gb_datban.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gb_datban.Location = new System.Drawing.Point(18, 310);
            this.gb_datban.Name = "gb_datban";
            this.gb_datban.Size = new System.Drawing.Size(662, 228);
            this.gb_datban.TabIndex = 2;
            this.gb_datban.TabStop = false;
            this.gb_datban.Text = "Đặt bàn";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(77, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(566, 78);
            this.dataGridView1.TabIndex = 1;
            // 
            // lb_monan
            // 
            this.lb_monan.AutoSize = true;
            this.lb_monan.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_monan.Location = new System.Drawing.Point(297, 30);
            this.lb_monan.Name = "lb_monan";
            this.lb_monan.Size = new System.Drawing.Size(143, 25);
            this.lb_monan.TabIndex = 0;
            this.lb_monan.Text = "BẢNG MÓN ĂN";
            this.lb_monan.Click += new System.EventHandler(this.lb_monan_Click);
            // 
            // gb_dichvukhac
            // 
            this.gb_dichvukhac.Controls.Add(this.dataGridView2);
            this.gb_dichvukhac.Controls.Add(this.lb_dichvu);
            this.gb_dichvukhac.Location = new System.Drawing.Point(18, 544);
            this.gb_dichvukhac.Name = "gb_dichvukhac";
            this.gb_dichvukhac.Size = new System.Drawing.Size(662, 153);
            this.gb_dichvukhac.TabIndex = 3;
            this.gb_dichvukhac.TabStop = false;
            this.gb_dichvukhac.Text = "Các dịch vụ khác";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(89, 71);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(554, 69);
            this.dataGridView2.TabIndex = 1;
            // 
            // lb_dichvu
            // 
            this.lb_dichvu.AutoSize = true;
            this.lb_dichvu.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_dichvu.Location = new System.Drawing.Point(300, 35);
            this.lb_dichvu.Name = "lb_dichvu";
            this.lb_dichvu.Size = new System.Drawing.Size(140, 25);
            this.lb_dichvu.TabIndex = 0;
            this.lb_dichvu.Text = "BẢNG DỊCH VỤ";
            // 
            // bt_luu
            // 
            this.bt_luu.AutoSize = true;
            this.bt_luu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt_luu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_luu.Location = new System.Drawing.Point(404, 714);
            this.bt_luu.Name = "bt_luu";
            this.bt_luu.Size = new System.Drawing.Size(75, 29);
            this.bt_luu.TabIndex = 4;
            this.bt_luu.Text = "Lưu";
            this.bt_luu.UseVisualStyleBackColor = false;
            // 
            // bt_thoat
            // 
            this.bt_thoat.AutoSize = true;
            this.bt_thoat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt_thoat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_thoat.Location = new System.Drawing.Point(605, 714);
            this.bt_thoat.Name = "bt_thoat";
            this.bt_thoat.Size = new System.Drawing.Size(75, 29);
            this.bt_thoat.TabIndex = 5;
            this.bt_thoat.Text = "Thoát";
            this.bt_thoat.UseVisualStyleBackColor = false;
            // 
            // bt_quaylai
            // 
            this.bt_quaylai.AutoSize = true;
            this.bt_quaylai.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt_quaylai.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_quaylai.Location = new System.Drawing.Point(506, 714);
            this.bt_quaylai.Name = "bt_quaylai";
            this.bt_quaylai.Size = new System.Drawing.Size(75, 29);
            this.bt_quaylai.TabIndex = 6;
            this.bt_quaylai.Text = "Quay lại";
            this.bt_quaylai.UseVisualStyleBackColor = false;
            // 
            // lb_dattieccuoi
            // 
            this.lb_dattieccuoi.AutoSize = true;
            this.lb_dattieccuoi.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_dattieccuoi.Location = new System.Drawing.Point(283, 9);
            this.lb_dattieccuoi.Name = "lb_dattieccuoi";
            this.lb_dattieccuoi.Size = new System.Drawing.Size(175, 32);
            this.lb_dattieccuoi.TabIndex = 7;
            this.lb_dattieccuoi.Text = "ĐẶT TIỆC CƯỚI";
            this.lb_dattieccuoi.Click += new System.EventHandler(this.lb_dattieccuoi_Click);
            // 
            // DatTiecCuoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 749);
            this.Controls.Add(this.lb_dattieccuoi);
            this.Controls.Add(this.bt_quaylai);
            this.Controls.Add(this.bt_thoat);
            this.Controls.Add(this.bt_luu);
            this.Controls.Add(this.gb_dichvukhac);
            this.Controls.Add(this.gb_datban);
            this.Controls.Add(this.gb_thongtintieccuoi);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DatTiecCuoi";
            this.Text = "ĐẶT TIỆC CƯỚI";
            this.gb_thongtintieccuoi.ResumeLayout(false);
            this.gb_thongtintieccuoi.PerformLayout();
            this.gb_datban.ResumeLayout(false);
            this.gb_datban.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gb_dichvukhac.ResumeLayout(false);
            this.gb_dichvukhac.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gb_thongtintieccuoi;
        private System.Windows.Forms.Label lb_sanh;
        private System.Windows.Forms.Label lb_tiendatcoc;
        private System.Windows.Forms.Label lb_soluongbandutru;
        private System.Windows.Forms.Label lb_dienthoai;
        private System.Windows.Forms.Label lb_ngaydattiec;
        private System.Windows.Forms.Label lb_tenchure;
        private System.Windows.Forms.Label lb_ca;
        private System.Windows.Forms.Label lb_soluongban;
        private System.Windows.Forms.Label lb_khachhang;
        private System.Windows.Forms.Label lb_tencodau;
        private System.Windows.Forms.MaskedTextBox tb_tenchure;
        private System.Windows.Forms.MaskedTextBox tb_tiendatcoc;
        private System.Windows.Forms.MaskedTextBox tb_sanh;
        private System.Windows.Forms.MaskedTextBox tb_soluongban;
        private System.Windows.Forms.MaskedTextBox tb_soluongbandutru;
        private System.Windows.Forms.MaskedTextBox tb_khachhang;
        private System.Windows.Forms.MaskedTextBox tb_dienthoai;
        private System.Windows.Forms.MaskedTextBox tb_tencodau;
        private System.Windows.Forms.DateTimePicker dt_ngaydattiec;
        private System.Windows.Forms.MaskedTextBox tb_ca;
        private System.Windows.Forms.GroupBox gb_datban;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lb_monan;
        private System.Windows.Forms.GroupBox gb_dichvukhac;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label lb_dichvu;
        private System.Windows.Forms.Button bt_luu;
        private System.Windows.Forms.Button bt_thoat;
        private System.Windows.Forms.Button bt_quaylai;
        private System.Windows.Forms.Label lb_dattieccuoi;
    }
}