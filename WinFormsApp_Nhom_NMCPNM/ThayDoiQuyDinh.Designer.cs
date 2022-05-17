
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
            this.SuspendLayout();
            // 
            // lb_thaydoiquydinh
            // 
            this.lb_thaydoiquydinh.AutoSize = true;
            this.lb_thaydoiquydinh.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_thaydoiquydinh.Location = new System.Drawing.Point(241, 26);
            this.lb_thaydoiquydinh.Name = "lb_thaydoiquydinh";
            this.lb_thaydoiquydinh.Size = new System.Drawing.Size(237, 32);
            this.lb_thaydoiquydinh.TabIndex = 0;
            this.lb_thaydoiquydinh.Text = "THAY ĐỔI QUY ĐỊNH";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(76, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "THÊM";
            // 
            // cb_them
            // 
            this.cb_them.FormattingEnabled = true;
            this.cb_them.Location = new System.Drawing.Point(133, 100);
            this.cb_them.Name = "cb_them";
            this.cb_them.Size = new System.Drawing.Size(18, 23);
            this.cb_them.TabIndex = 2;
            // 
            // tb_them
            // 
            this.tb_them.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_them.Location = new System.Drawing.Point(209, 102);
            this.tb_them.Name = "tb_them";
            this.tb_them.Size = new System.Drawing.Size(198, 25);
            this.tb_them.TabIndex = 3;
            this.tb_them.TextChanged += new System.EventHandler(this.tb_them_TextChanged);
            // 
            // cb_xoa
            // 
            this.cb_xoa.FormattingEnabled = true;
            this.cb_xoa.Location = new System.Drawing.Point(133, 193);
            this.cb_xoa.Name = "cb_xoa";
            this.cb_xoa.Size = new System.Drawing.Size(18, 23);
            this.cb_xoa.TabIndex = 5;
            // 
            // lb_xoa
            // 
            this.lb_xoa.AutoSize = true;
            this.lb_xoa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_xoa.Location = new System.Drawing.Point(76, 195);
            this.lb_xoa.Name = "lb_xoa";
            this.lb_xoa.Size = new System.Drawing.Size(41, 21);
            this.lb_xoa.TabIndex = 4;
            this.lb_xoa.Text = "XÓA";
            // 
            // tb_capnhat
            // 
            this.tb_capnhat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_capnhat.Location = new System.Drawing.Point(209, 147);
            this.tb_capnhat.Name = "tb_capnhat";
            this.tb_capnhat.Size = new System.Drawing.Size(198, 25);
            this.tb_capnhat.TabIndex = 9;
            // 
            // cb_capnhat
            // 
            this.cb_capnhat.FormattingEnabled = true;
            this.cb_capnhat.Location = new System.Drawing.Point(166, 147);
            this.cb_capnhat.Name = "cb_capnhat";
            this.cb_capnhat.Size = new System.Drawing.Size(18, 23);
            this.cb_capnhat.TabIndex = 8;
            // 
            // lb_capnhat
            // 
            this.lb_capnhat.AutoSize = true;
            this.lb_capnhat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_capnhat.Location = new System.Drawing.Point(76, 147);
            this.lb_capnhat.Name = "lb_capnhat";
            this.lb_capnhat.Size = new System.Drawing.Size(84, 21);
            this.lb_capnhat.TabIndex = 7;
            this.lb_capnhat.Text = "CẬP NHẬT";
            // 
            // cb_phat
            // 
            this.cb_phat.AutoSize = true;
            this.cb_phat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_phat.Location = new System.Drawing.Point(76, 245);
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
            this.bt_luu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_luu.Location = new System.Drawing.Point(412, 326);
            this.bt_luu.Name = "bt_luu";
            this.bt_luu.Size = new System.Drawing.Size(75, 29);
            this.bt_luu.TabIndex = 12;
            this.bt_luu.Text = "Lưu";
            this.bt_luu.UseVisualStyleBackColor = false;
            // 
            // bt_thoat
            // 
            this.bt_thoat.AutoSize = true;
            this.bt_thoat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt_thoat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_thoat.Location = new System.Drawing.Point(603, 326);
            this.bt_thoat.Name = "bt_thoat";
            this.bt_thoat.Size = new System.Drawing.Size(75, 29);
            this.bt_thoat.TabIndex = 13;
            this.bt_thoat.Text = "Thoát";
            this.bt_thoat.UseVisualStyleBackColor = false;
            // 
            // bt_quaylai
            // 
            this.bt_quaylai.AutoSize = true;
            this.bt_quaylai.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt_quaylai.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_quaylai.Location = new System.Drawing.Point(507, 326);
            this.bt_quaylai.Name = "bt_quaylai";
            this.bt_quaylai.Size = new System.Drawing.Size(75, 29);
            this.bt_quaylai.TabIndex = 14;
            this.bt_quaylai.Text = "Quay lại";
            this.bt_quaylai.UseVisualStyleBackColor = false;
            // 
            // form_thaydoiquydinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 364);
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
    }
}