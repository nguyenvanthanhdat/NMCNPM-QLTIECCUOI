
namespace WinFormsApp_Nhom_NMCPNM
{
    partial class form_hoadon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_hoadon));
            this.lb_hoadon = new System.Windows.Forms.Label();
            this.gb_thongtinhoadon = new System.Windows.Forms.GroupBox();
            this.lb_tencodau = new System.Windows.Forms.Label();
            this.lb_ngaythanhtoan = new System.Windows.Forms.Label();
            this.lb_tenchure = new System.Windows.Forms.Label();
            this.lb_soluongban = new System.Windows.Forms.Label();
            this.lb_dongiaban = new System.Windows.Forms.Label();
            this.lb_tongtienban = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.gb_dichvu = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gb_tinhtien = new System.Windows.Forms.GroupBox();
            this.lb_tongtiendichvu = new System.Windows.Forms.Label();
            this.lb_tiendatcoc = new System.Windows.Forms.Label();
            this.lb_tongtienhoadon = new System.Windows.Forms.Label();
            this.lb_conlai = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.bt_in = new System.Windows.Forms.Button();
            this.bt_thoat = new System.Windows.Forms.Button();
            this.bt_quaylai = new System.Windows.Forms.Button();
            this.gb_thongtinhoadon.SuspendLayout();
            this.gb_dichvu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gb_tinhtien.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_hoadon
            // 
            this.lb_hoadon.AutoSize = true;
            this.lb_hoadon.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_hoadon.Location = new System.Drawing.Point(330, 40);
            this.lb_hoadon.Name = "lb_hoadon";
            this.lb_hoadon.Size = new System.Drawing.Size(123, 32);
            this.lb_hoadon.TabIndex = 0;
            this.lb_hoadon.Text = "HÓA ĐƠN";
            // 
            // gb_thongtinhoadon
            // 
            this.gb_thongtinhoadon.Controls.Add(this.dateTimePicker1);
            this.gb_thongtinhoadon.Controls.Add(this.textBox5);
            this.gb_thongtinhoadon.Controls.Add(this.textBox4);
            this.gb_thongtinhoadon.Controls.Add(this.textBox3);
            this.gb_thongtinhoadon.Controls.Add(this.textBox2);
            this.gb_thongtinhoadon.Controls.Add(this.textBox1);
            this.gb_thongtinhoadon.Controls.Add(this.lb_tongtienban);
            this.gb_thongtinhoadon.Controls.Add(this.lb_dongiaban);
            this.gb_thongtinhoadon.Controls.Add(this.lb_soluongban);
            this.gb_thongtinhoadon.Controls.Add(this.lb_tenchure);
            this.gb_thongtinhoadon.Controls.Add(this.lb_ngaythanhtoan);
            this.gb_thongtinhoadon.Controls.Add(this.lb_tencodau);
            this.gb_thongtinhoadon.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gb_thongtinhoadon.Location = new System.Drawing.Point(11, 111);
            this.gb_thongtinhoadon.Name = "gb_thongtinhoadon";
            this.gb_thongtinhoadon.Size = new System.Drawing.Size(709, 207);
            this.gb_thongtinhoadon.TabIndex = 1;
            this.gb_thongtinhoadon.TabStop = false;
            this.gb_thongtinhoadon.Text = "Thông tin hóa đơn";
            // 
            // lb_tencodau
            // 
            this.lb_tencodau.AutoSize = true;
            this.lb_tencodau.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_tencodau.Location = new System.Drawing.Point(46, 38);
            this.lb_tencodau.Name = "lb_tencodau";
            this.lb_tencodau.Size = new System.Drawing.Size(100, 21);
            this.lb_tencodau.TabIndex = 0;
            this.lb_tencodau.Text = "TÊN CÔ DÂU";
            // 
            // lb_ngaythanhtoan
            // 
            this.lb_ngaythanhtoan.AutoSize = true;
            this.lb_ngaythanhtoan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_ngaythanhtoan.Location = new System.Drawing.Point(46, 123);
            this.lb_ngaythanhtoan.Name = "lb_ngaythanhtoan";
            this.lb_ngaythanhtoan.Size = new System.Drawing.Size(152, 21);
            this.lb_ngaythanhtoan.TabIndex = 1;
            this.lb_ngaythanhtoan.Text = "NGÀY THANH TOÁN";
            // 
            // lb_tenchure
            // 
            this.lb_tenchure.AutoSize = true;
            this.lb_tenchure.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_tenchure.Location = new System.Drawing.Point(46, 81);
            this.lb_tenchure.Name = "lb_tenchure";
            this.lb_tenchure.Size = new System.Drawing.Size(96, 21);
            this.lb_tenchure.TabIndex = 2;
            this.lb_tenchure.Text = "TÊN CHÚ RỂ";
            this.lb_tenchure.Click += new System.EventHandler(this.lb_tenchure_Click);
            // 
            // lb_soluongban
            // 
            this.lb_soluongban.AutoSize = true;
            this.lb_soluongban.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_soluongban.Location = new System.Drawing.Point(383, 38);
            this.lb_soluongban.Name = "lb_soluongban";
            this.lb_soluongban.Size = new System.Drawing.Size(124, 21);
            this.lb_soluongban.TabIndex = 3;
            this.lb_soluongban.Text = "SỐ LƯỢNG BÀN";
            // 
            // lb_dongiaban
            // 
            this.lb_dongiaban.AutoSize = true;
            this.lb_dongiaban.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_dongiaban.Location = new System.Drawing.Point(383, 81);
            this.lb_dongiaban.Name = "lb_dongiaban";
            this.lb_dongiaban.Size = new System.Drawing.Size(109, 21);
            this.lb_dongiaban.TabIndex = 4;
            this.lb_dongiaban.Text = "ĐƠN GIÁ BÀN";
            // 
            // lb_tongtienban
            // 
            this.lb_tongtienban.AutoSize = true;
            this.lb_tongtienban.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_tongtienban.Location = new System.Drawing.Point(383, 123);
            this.lb_tongtienban.Name = "lb_tongtienban";
            this.lb_tongtienban.Size = new System.Drawing.Size(124, 21);
            this.lb_tongtienban.TabIndex = 5;
            this.lb_tongtienban.Text = "TỔNG TIỀN BÀN";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(228, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(107, 25);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(228, 81);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(107, 25);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(539, 123);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(107, 25);
            this.textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(539, 81);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(107, 25);
            this.textBox4.TabIndex = 9;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(539, 38);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(107, 25);
            this.textBox5.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(228, 128);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(107, 25);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // gb_dichvu
            // 
            this.gb_dichvu.Controls.Add(this.dataGridView1);
            this.gb_dichvu.Controls.Add(this.label1);
            this.gb_dichvu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gb_dichvu.Location = new System.Drawing.Point(12, 339);
            this.gb_dichvu.Name = "gb_dichvu";
            this.gb_dichvu.Size = new System.Drawing.Size(707, 184);
            this.gb_dichvu.TabIndex = 2;
            this.gb_dichvu.TabStop = false;
            this.gb_dichvu.Text = "Dịch vụ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(281, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "BẢNG DỊCH VỤ ĐÃ ĐẶT";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(81, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(546, 84);
            this.dataGridView1.TabIndex = 1;
            // 
            // gb_tinhtien
            // 
            this.gb_tinhtien.Controls.Add(this.textBox9);
            this.gb_tinhtien.Controls.Add(this.textBox8);
            this.gb_tinhtien.Controls.Add(this.textBox7);
            this.gb_tinhtien.Controls.Add(this.textBox6);
            this.gb_tinhtien.Controls.Add(this.lb_conlai);
            this.gb_tinhtien.Controls.Add(this.lb_tongtienhoadon);
            this.gb_tinhtien.Controls.Add(this.lb_tiendatcoc);
            this.gb_tinhtien.Controls.Add(this.lb_tongtiendichvu);
            this.gb_tinhtien.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gb_tinhtien.Location = new System.Drawing.Point(12, 529);
            this.gb_tinhtien.Name = "gb_tinhtien";
            this.gb_tinhtien.Size = new System.Drawing.Size(707, 170);
            this.gb_tinhtien.TabIndex = 3;
            this.gb_tinhtien.TabStop = false;
            this.gb_tinhtien.Text = "Tính tiền";
            // 
            // lb_tongtiendichvu
            // 
            this.lb_tongtiendichvu.AutoSize = true;
            this.lb_tongtiendichvu.Location = new System.Drawing.Point(45, 36);
            this.lb_tongtiendichvu.Name = "lb_tongtiendichvu";
            this.lb_tongtiendichvu.Size = new System.Drawing.Size(118, 19);
            this.lb_tongtiendichvu.TabIndex = 0;
            this.lb_tongtiendichvu.Text = "Tổng tiền dịch vụ:";
            // 
            // lb_tiendatcoc
            // 
            this.lb_tiendatcoc.AutoSize = true;
            this.lb_tiendatcoc.Location = new System.Drawing.Point(45, 97);
            this.lb_tiendatcoc.Name = "lb_tiendatcoc";
            this.lb_tiendatcoc.Size = new System.Drawing.Size(89, 19);
            this.lb_tiendatcoc.TabIndex = 1;
            this.lb_tiendatcoc.Text = "Tiền đặt cọc: ";
            // 
            // lb_tongtienhoadon
            // 
            this.lb_tongtienhoadon.AutoSize = true;
            this.lb_tongtienhoadon.Location = new System.Drawing.Point(45, 66);
            this.lb_tongtienhoadon.Name = "lb_tongtienhoadon";
            this.lb_tongtienhoadon.Size = new System.Drawing.Size(125, 19);
            this.lb_tongtienhoadon.TabIndex = 2;
            this.lb_tongtienhoadon.Text = "Tổng tiền hóa đơn:";
            // 
            // lb_conlai
            // 
            this.lb_conlai.AutoSize = true;
            this.lb_conlai.Location = new System.Drawing.Point(45, 125);
            this.lb_conlai.Name = "lb_conlai";
            this.lb_conlai.Size = new System.Drawing.Size(58, 19);
            this.lb_conlai.TabIndex = 3;
            this.lb_conlai.Text = "Còn lại: ";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(211, 33);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(155, 25);
            this.textBox6.TabIndex = 4;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(211, 64);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(155, 25);
            this.textBox7.TabIndex = 5;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(211, 97);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(155, 25);
            this.textBox8.TabIndex = 6;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(211, 128);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(155, 25);
            this.textBox9.TabIndex = 7;
            // 
            // bt_in
            // 
            this.bt_in.AutoSize = true;
            this.bt_in.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt_in.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_in.Location = new System.Drawing.Point(443, 714);
            this.bt_in.Name = "bt_in";
            this.bt_in.Size = new System.Drawing.Size(75, 29);
            this.bt_in.TabIndex = 8;
            this.bt_in.Text = "In";
            this.bt_in.UseVisualStyleBackColor = false;
            // 
            // bt_thoat
            // 
            this.bt_thoat.AutoSize = true;
            this.bt_thoat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt_thoat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_thoat.Location = new System.Drawing.Point(645, 714);
            this.bt_thoat.Name = "bt_thoat";
            this.bt_thoat.Size = new System.Drawing.Size(75, 29);
            this.bt_thoat.TabIndex = 9;
            this.bt_thoat.Text = "Thoát";
            this.bt_thoat.UseVisualStyleBackColor = false;
            // 
            // bt_quaylai
            // 
            this.bt_quaylai.AutoSize = true;
            this.bt_quaylai.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt_quaylai.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_quaylai.Location = new System.Drawing.Point(538, 714);
            this.bt_quaylai.Name = "bt_quaylai";
            this.bt_quaylai.Size = new System.Drawing.Size(75, 29);
            this.bt_quaylai.TabIndex = 10;
            this.bt_quaylai.Text = "Quay lại";
            this.bt_quaylai.UseVisualStyleBackColor = false;
            // 
            // form_hoadon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 749);
            this.Controls.Add(this.bt_quaylai);
            this.Controls.Add(this.bt_thoat);
            this.Controls.Add(this.bt_in);
            this.Controls.Add(this.gb_tinhtien);
            this.Controls.Add(this.gb_dichvu);
            this.Controls.Add(this.gb_thongtinhoadon);
            this.Controls.Add(this.lb_hoadon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form_hoadon";
            this.Text = "HoaDon";
            this.gb_thongtinhoadon.ResumeLayout(false);
            this.gb_thongtinhoadon.PerformLayout();
            this.gb_dichvu.ResumeLayout(false);
            this.gb_dichvu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gb_tinhtien.ResumeLayout(false);
            this.gb_tinhtien.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_hoadon;
        private System.Windows.Forms.GroupBox gb_thongtinhoadon;
        private System.Windows.Forms.Label lb_tongtienban;
        private System.Windows.Forms.Label lb_dongiaban;
        private System.Windows.Forms.Label lb_soluongban;
        private System.Windows.Forms.Label lb_tenchure;
        private System.Windows.Forms.Label lb_ngaythanhtoan;
        private System.Windows.Forms.Label lb_tencodau;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox gb_dichvu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox gb_tinhtien;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label lb_conlai;
        private System.Windows.Forms.Label lb_tongtienhoadon;
        private System.Windows.Forms.Label lb_tiendatcoc;
        private System.Windows.Forms.Label lb_tongtiendichvu;
        private System.Windows.Forms.Button bt_in;
        private System.Windows.Forms.Button bt_thoat;
        private System.Windows.Forms.Button bt_quaylai;
    }
}