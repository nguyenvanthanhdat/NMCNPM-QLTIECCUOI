
namespace WinFormsApp_Nhom_NMCPNM
{
    partial class form_thaydoiquydinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_thaydoiquydinh));
            this.lb_thaydoiquydinh = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_them = new System.Windows.Forms.ComboBox();
            this.tb_them = new System.Windows.Forms.TextBox();
            this.cb_xoa = new System.Windows.Forms.ComboBox();
            this.lb_xoa = new System.Windows.Forms.Label();
            this.tb_capnhat = new System.Windows.Forms.TextBox();
            this.cb_capnhat = new System.Windows.Forms.ComboBox();
            this.lb_capnhat = new System.Windows.Forms.Label();
            this.cb_phat = new System.Windows.Forms.CheckBox();
            this.bt_luu = new System.Windows.Forms.Button();
            this.bt_thoat = new System.Windows.Forms.Button();
            this.bt_quaylai = new System.Windows.Forms.Button();
            this.pb_manhinhchinh = new System.Windows.Forms.PictureBox();
            this.pb_quaylai = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_manhinhchinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_quaylai)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_thaydoiquydinh
            // 
            this.lb_thaydoiquydinh.AutoSize = true;
            this.lb_thaydoiquydinh.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.lb_thaydoiquydinh.Location = new System.Drawing.Point(207, 23);
            this.lb_thaydoiquydinh.Name = "lb_thaydoiquydinh";
            this.lb_thaydoiquydinh.Size = new System.Drawing.Size(237, 32);
            this.lb_thaydoiquydinh.TabIndex = 0;
            this.lb_thaydoiquydinh.Text = "THAY ĐỔI QUY ĐỊNH";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.Location = new System.Drawing.Point(65, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "THÊM";
            // 
            // cb_them
            // 
            this.cb_them.FormattingEnabled = true;
            this.cb_them.Location = new System.Drawing.Point(114, 87);
            this.cb_them.Name = "cb_them";
            this.cb_them.Size = new System.Drawing.Size(16, 21);
            this.cb_them.TabIndex = 2;
            // 
            // tb_them
            // 
            this.tb_them.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tb_them.Location = new System.Drawing.Point(179, 88);
            this.tb_them.Name = "tb_them";
            this.tb_them.Size = new System.Drawing.Size(170, 25);
            this.tb_them.TabIndex = 3;
            this.tb_them.TextChanged += new System.EventHandler(this.tb_them_TextChanged);
            // 
            // cb_xoa
            // 
            this.cb_xoa.FormattingEnabled = true;
            this.cb_xoa.Location = new System.Drawing.Point(114, 167);
            this.cb_xoa.Name = "cb_xoa";
            this.cb_xoa.Size = new System.Drawing.Size(16, 21);
            this.cb_xoa.TabIndex = 5;
            // 
            // lb_xoa
            // 
            this.lb_xoa.AutoSize = true;
            this.lb_xoa.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lb_xoa.Location = new System.Drawing.Point(65, 169);
            this.lb_xoa.Name = "lb_xoa";
            this.lb_xoa.Size = new System.Drawing.Size(41, 21);
            this.lb_xoa.TabIndex = 4;
            this.lb_xoa.Text = "XÓA";
            // 
            // tb_capnhat
            // 
            this.tb_capnhat.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tb_capnhat.Location = new System.Drawing.Point(179, 127);
            this.tb_capnhat.Name = "tb_capnhat";
            this.tb_capnhat.Size = new System.Drawing.Size(170, 25);
            this.tb_capnhat.TabIndex = 9;
            // 
            // cb_capnhat
            // 
            this.cb_capnhat.FormattingEnabled = true;
            this.cb_capnhat.Location = new System.Drawing.Point(142, 127);
            this.cb_capnhat.Name = "cb_capnhat";
            this.cb_capnhat.Size = new System.Drawing.Size(16, 21);
            this.cb_capnhat.TabIndex = 8;
            // 
            // lb_capnhat
            // 
            this.lb_capnhat.AutoSize = true;
            this.lb_capnhat.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lb_capnhat.Location = new System.Drawing.Point(65, 127);
            this.lb_capnhat.Name = "lb_capnhat";
            this.lb_capnhat.Size = new System.Drawing.Size(84, 21);
            this.lb_capnhat.TabIndex = 7;
            this.lb_capnhat.Text = "CẬP NHẬT";
            // 
            // cb_phat
            // 
            this.cb_phat.AutoSize = true;
            this.cb_phat.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cb_phat.Location = new System.Drawing.Point(65, 212);
            this.cb_phat.Name = "cb_phat";
            this.cb_phat.Size = new System.Drawing.Size(139, 25);
            this.cb_phat.TabIndex = 11;
            this.cb_phat.Text = "ÁP DỤNG PHẠT";
            this.cb_phat.UseVisualStyleBackColor = true;
            // 
            // bt_luu
            // 
            this.bt_luu.AutoSize = true;
            this.bt_luu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt_luu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.bt_luu.Location = new System.Drawing.Point(353, 283);
            this.bt_luu.Name = "bt_luu";
            this.bt_luu.Size = new System.Drawing.Size(64, 29);
            this.bt_luu.TabIndex = 12;
            this.bt_luu.Text = "Lưu";
            this.bt_luu.UseVisualStyleBackColor = false;
            // 
            // bt_thoat
            // 
            this.bt_thoat.AutoSize = true;
            this.bt_thoat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt_thoat.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.bt_thoat.Location = new System.Drawing.Point(517, 283);
            this.bt_thoat.Name = "bt_thoat";
            this.bt_thoat.Size = new System.Drawing.Size(64, 29);
            this.bt_thoat.TabIndex = 13;
            this.bt_thoat.Text = "Thoát";
            this.bt_thoat.UseVisualStyleBackColor = false;
            // 
            // bt_quaylai
            // 
            this.bt_quaylai.AutoSize = true;
            this.bt_quaylai.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt_quaylai.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.bt_quaylai.Location = new System.Drawing.Point(435, 283);
            this.bt_quaylai.Name = "bt_quaylai";
            this.bt_quaylai.Size = new System.Drawing.Size(69, 29);
            this.bt_quaylai.TabIndex = 14;
            this.bt_quaylai.Text = "Quay lại";
            this.bt_quaylai.UseVisualStyleBackColor = false;
            // 
            // pb_manhinhchinh
            // 
            this.pb_manhinhchinh.Location = new System.Drawing.Point(44, 12);
            this.pb_manhinhchinh.Name = "pb_manhinhchinh";
            this.pb_manhinhchinh.Size = new System.Drawing.Size(27, 27);
            this.pb_manhinhchinh.TabIndex = 21;
            this.pb_manhinhchinh.TabStop = false;
            this.pb_manhinhchinh.Click += new System.EventHandler(this.pb_manhinhchinh_Click);
            // 
            // pb_quaylai
            // 
            this.pb_quaylai.Location = new System.Drawing.Point(12, 12);
            this.pb_quaylai.Name = "pb_quaylai";
            this.pb_quaylai.Size = new System.Drawing.Size(27, 27);
            this.pb_quaylai.TabIndex = 20;
            this.pb_quaylai.TabStop = false;
            this.pb_quaylai.Click += new System.EventHandler(this.pb_quaylai_Click);
            // 
            // form_thaydoiquydinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 315);
            this.Controls.Add(this.pb_manhinhchinh);
            this.Controls.Add(this.pb_quaylai);
            this.Controls.Add(this.bt_quaylai);
            this.Controls.Add(this.bt_thoat);
            this.Controls.Add(this.bt_luu);
            this.Controls.Add(this.cb_phat);
            this.Controls.Add(this.tb_capnhat);
            this.Controls.Add(this.cb_capnhat);
            this.Controls.Add(this.lb_capnhat);
            this.Controls.Add(this.cb_xoa);
            this.Controls.Add(this.lb_xoa);
            this.Controls.Add(this.tb_them);
            this.Controls.Add(this.cb_them);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_thaydoiquydinh);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form_thaydoiquydinh";
            this.Text = "THAY ĐỔI QUY ĐỊNH";
            ((System.ComponentModel.ISupportInitialize)(this.pb_manhinhchinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_quaylai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_thaydoiquydinh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_them;
        private System.Windows.Forms.TextBox tb_them;
        private System.Windows.Forms.ComboBox cb_xoa;
        private System.Windows.Forms.Label lb_xoa;
        private System.Windows.Forms.TextBox tb_capnhat;
        private System.Windows.Forms.ComboBox cb_capnhat;
        private System.Windows.Forms.Label lb_capnhat;
        private System.Windows.Forms.CheckBox cb_phat;
        private System.Windows.Forms.Button bt_luu;
        private System.Windows.Forms.Button bt_thoat;
        private System.Windows.Forms.Button bt_quaylai;
        private System.Windows.Forms.PictureBox pb_manhinhchinh;
        private System.Windows.Forms.PictureBox pb_quaylai;
    }
}