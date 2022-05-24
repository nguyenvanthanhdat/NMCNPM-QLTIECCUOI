
namespace WinFormsApp_Nhom_NMCPNM
{
    partial class form_baocaodoanhso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_baocaodoanhso));
            this.lb_baocaodoanhso = new System.Windows.Forms.Label();
            this.lb_nhapthang = new System.Windows.Forms.Label();
            this.lb_nhapnam = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lb_doanhsothang = new System.Windows.Forms.Label();
            this.lb_tongdoanhthu = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bt_in = new System.Windows.Forms.Button();
            this.bt_quaylai = new System.Windows.Forms.Button();
            this.bt_thoat = new System.Windows.Forms.Button();
            this.tb_tongdoanhthu = new System.Windows.Forms.TextBox();
            this.tb_doanhsothang = new System.Windows.Forms.TextBox();
            this.pb_manhinhchinh = new System.Windows.Forms.PictureBox();
            this.pb_quaylai = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_manhinhchinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_quaylai)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_baocaodoanhso
            // 
            this.lb_baocaodoanhso.AutoSize = true;
            this.lb_baocaodoanhso.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.lb_baocaodoanhso.Location = new System.Drawing.Point(255, 24);
            this.lb_baocaodoanhso.Name = "lb_baocaodoanhso";
            this.lb_baocaodoanhso.Size = new System.Drawing.Size(245, 32);
            this.lb_baocaodoanhso.TabIndex = 0;
            this.lb_baocaodoanhso.Text = "BÁO CÁO DOANH SỐ";
            // 
            // lb_nhapthang
            // 
            this.lb_nhapthang.AutoSize = true;
            this.lb_nhapthang.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lb_nhapthang.Location = new System.Drawing.Point(212, 91);
            this.lb_nhapthang.Name = "lb_nhapthang";
            this.lb_nhapthang.Size = new System.Drawing.Size(108, 21);
            this.lb_nhapthang.TabIndex = 1;
            this.lb_nhapthang.Text = "NHẬP THÁNG";
            // 
            // lb_nhapnam
            // 
            this.lb_nhapnam.AutoSize = true;
            this.lb_nhapnam.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lb_nhapnam.Location = new System.Drawing.Point(212, 119);
            this.lb_nhapnam.Name = "lb_nhapnam";
            this.lb_nhapnam.Size = new System.Drawing.Size(92, 21);
            this.lb_nhapnam.TabIndex = 2;
            this.lb_nhapnam.Text = "NHẬP NĂM";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBox1.Location = new System.Drawing.Point(368, 86);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(147, 25);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBox2.Location = new System.Drawing.Point(368, 119);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(147, 25);
            this.textBox2.TabIndex = 4;
            // 
            // lb_doanhsothang
            // 
            this.lb_doanhsothang.AutoSize = true;
            this.lb_doanhsothang.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lb_doanhsothang.Location = new System.Drawing.Point(212, 152);
            this.lb_doanhsothang.Name = "lb_doanhsothang";
            this.lb_doanhsothang.Size = new System.Drawing.Size(150, 21);
            this.lb_doanhsothang.TabIndex = 5;
            this.lb_doanhsothang.Text = "DOANH SỐ THÁNG:";
            // 
            // lb_tongdoanhthu
            // 
            this.lb_tongdoanhthu.AutoSize = true;
            this.lb_tongdoanhthu.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lb_tongdoanhthu.Location = new System.Drawing.Point(212, 183);
            this.lb_tongdoanhthu.Name = "lb_tongdoanhthu";
            this.lb_tongdoanhthu.Size = new System.Drawing.Size(150, 21);
            this.lb_tongdoanhthu.TabIndex = 6;
            this.lb_tongdoanhthu.Text = "TỔNG DOANH THU:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.Location = new System.Drawing.Point(477, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 21);
            this.label3.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(87, 225);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(559, 167);
            this.dataGridView1.TabIndex = 8;
            // 
            // bt_in
            // 
            this.bt_in.AutoSize = true;
            this.bt_in.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt_in.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.bt_in.Location = new System.Drawing.Point(441, 398);
            this.bt_in.Name = "bt_in";
            this.bt_in.Size = new System.Drawing.Size(64, 29);
            this.bt_in.TabIndex = 9;
            this.bt_in.Text = "In";
            this.bt_in.UseVisualStyleBackColor = false;
            // 
            // bt_quaylai
            // 
            this.bt_quaylai.AutoSize = true;
            this.bt_quaylai.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt_quaylai.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.bt_quaylai.Location = new System.Drawing.Point(522, 398);
            this.bt_quaylai.Name = "bt_quaylai";
            this.bt_quaylai.Size = new System.Drawing.Size(69, 29);
            this.bt_quaylai.TabIndex = 10;
            this.bt_quaylai.Text = "Quay lại";
            this.bt_quaylai.UseVisualStyleBackColor = false;
            // 
            // bt_thoat
            // 
            this.bt_thoat.AutoSize = true;
            this.bt_thoat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt_thoat.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.bt_thoat.Location = new System.Drawing.Point(603, 398);
            this.bt_thoat.Name = "bt_thoat";
            this.bt_thoat.Size = new System.Drawing.Size(64, 29);
            this.bt_thoat.TabIndex = 11;
            this.bt_thoat.Text = "Thoát";
            this.bt_thoat.UseVisualStyleBackColor = false;
            // 
            // tb_tongdoanhthu
            // 
            this.tb_tongdoanhthu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tb_tongdoanhthu.Location = new System.Drawing.Point(368, 183);
            this.tb_tongdoanhthu.Name = "tb_tongdoanhthu";
            this.tb_tongdoanhthu.ReadOnly = true;
            this.tb_tongdoanhthu.Size = new System.Drawing.Size(147, 25);
            this.tb_tongdoanhthu.TabIndex = 12;
            this.tb_tongdoanhthu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_doanhsothang
            // 
            this.tb_doanhsothang.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tb_doanhsothang.Location = new System.Drawing.Point(368, 152);
            this.tb_doanhsothang.Name = "tb_doanhsothang";
            this.tb_doanhsothang.ReadOnly = true;
            this.tb_doanhsothang.Size = new System.Drawing.Size(147, 25);
            this.tb_doanhsothang.TabIndex = 13;
            this.tb_doanhsothang.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pb_manhinhchinh
            // 
            this.pb_manhinhchinh.Location = new System.Drawing.Point(43, 12);
            this.pb_manhinhchinh.Name = "pb_manhinhchinh";
            this.pb_manhinhchinh.Size = new System.Drawing.Size(27, 27);
            this.pb_manhinhchinh.TabIndex = 31;
            this.pb_manhinhchinh.TabStop = false;
            this.pb_manhinhchinh.Click += new System.EventHandler(this.pb_manhinhchinh_Click);
            // 
            // pb_quaylai
            // 
            this.pb_quaylai.Location = new System.Drawing.Point(12, 12);
            this.pb_quaylai.Name = "pb_quaylai";
            this.pb_quaylai.Size = new System.Drawing.Size(27, 27);
            this.pb_quaylai.TabIndex = 30;
            this.pb_quaylai.TabStop = false;
            this.pb_quaylai.Click += new System.EventHandler(this.pb_quaylai_Click);
            // 
            // form_baocaodoanhso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(727, 433);
            this.Controls.Add(this.pb_manhinhchinh);
            this.Controls.Add(this.pb_quaylai);
            this.Controls.Add(this.tb_doanhsothang);
            this.Controls.Add(this.tb_tongdoanhthu);
            this.Controls.Add(this.bt_thoat);
            this.Controls.Add(this.bt_quaylai);
            this.Controls.Add(this.bt_in);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lb_tongdoanhthu);
            this.Controls.Add(this.lb_doanhsothang);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lb_nhapnam);
            this.Controls.Add(this.lb_nhapthang);
            this.Controls.Add(this.lb_baocaodoanhso);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form_baocaodoanhso";
            this.Text = "BÁO CÁO DOANH SỐ";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_manhinhchinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_quaylai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_baocaodoanhso;
        private System.Windows.Forms.Label lb_nhapthang;
        private System.Windows.Forms.Label lb_nhapnam;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lb_doanhsothang;
        private System.Windows.Forms.Label lb_tongdoanhthu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bt_in;
        private System.Windows.Forms.Button bt_quaylai;
        private System.Windows.Forms.Button bt_thoat;
        private System.Windows.Forms.TextBox tb_tongdoanhthu;
        private System.Windows.Forms.TextBox tb_doanhsothang;
        private System.Windows.Forms.PictureBox pb_manhinhchinh;
        private System.Windows.Forms.PictureBox pb_quaylai;
    }
}