namespace QuanLyTiecCuoi
{
    partial class form_thaydoiphat
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
            this.lb_phat = new System.Windows.Forms.Label();
            this.gb_thongtinphat = new System.Windows.Forms.GroupBox();
            this.dgv_thongtinphat = new System.Windows.Forms.DataGridView();
            this.bt_thaydoi = new System.Windows.Forms.Button();
            this.bt_luu = new System.Windows.Forms.Button();
            this.lb_timkiem = new System.Windows.Forms.Label();
            this.tb_timkiem = new System.Windows.Forms.TextBox();
            this.ptb_quaylai = new System.Windows.Forms.PictureBox();
            this.gb_thongtinphat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_thongtinphat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_quaylai)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_phat
            // 
            this.lb_phat.AutoSize = true;
            this.lb_phat.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_phat.Location = new System.Drawing.Point(252, 19);
            this.lb_phat.Name = "lb_phat";
            this.lb_phat.Size = new System.Drawing.Size(77, 29);
            this.lb_phat.TabIndex = 0;
            this.lb_phat.Text = "PHẠT";
            // 
            // gb_thongtinphat
            // 
            this.gb_thongtinphat.Controls.Add(this.dgv_thongtinphat);
            this.gb_thongtinphat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_thongtinphat.Location = new System.Drawing.Point(58, 139);
            this.gb_thongtinphat.Name = "gb_thongtinphat";
            this.gb_thongtinphat.Size = new System.Drawing.Size(419, 173);
            this.gb_thongtinphat.TabIndex = 1;
            this.gb_thongtinphat.TabStop = false;
            this.gb_thongtinphat.Text = "Thông tin phạt";
            // 
            // dgv_thongtinphat
            // 
            this.dgv_thongtinphat.AllowUserToAddRows = false;
            this.dgv_thongtinphat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_thongtinphat.Location = new System.Drawing.Point(19, 30);
            this.dgv_thongtinphat.Name = "dgv_thongtinphat";
            this.dgv_thongtinphat.ReadOnly = true;
            this.dgv_thongtinphat.Size = new System.Drawing.Size(375, 124);
            this.dgv_thongtinphat.TabIndex = 0;
            // 
            // bt_thaydoi
            // 
            this.bt_thaydoi.AutoSize = true;
            this.bt_thaydoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_thaydoi.Location = new System.Drawing.Point(388, 90);
            this.bt_thaydoi.Name = "bt_thaydoi";
            this.bt_thaydoi.Size = new System.Drawing.Size(89, 30);
            this.bt_thaydoi.TabIndex = 2;
            this.bt_thaydoi.Text = "Thay đổi";
            this.bt_thaydoi.UseVisualStyleBackColor = true;
            this.bt_thaydoi.Click += new System.EventHandler(this.bt_thaydoi_Click);
            // 
            // bt_luu
            // 
            this.bt_luu.AutoSize = true;
            this.bt_luu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_luu.Location = new System.Drawing.Point(448, 338);
            this.bt_luu.Name = "bt_luu";
            this.bt_luu.Size = new System.Drawing.Size(63, 30);
            this.bt_luu.TabIndex = 3;
            this.bt_luu.Text = "Lưu";
            this.bt_luu.UseVisualStyleBackColor = true;
            this.bt_luu.Visible = false;
            this.bt_luu.Click += new System.EventHandler(this.bt_luu_Click);
            // 
            // lb_timkiem
            // 
            this.lb_timkiem.AutoSize = true;
            this.lb_timkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_timkiem.Location = new System.Drawing.Point(45, 95);
            this.lb_timkiem.Name = "lb_timkiem";
            this.lb_timkiem.Size = new System.Drawing.Size(71, 20);
            this.lb_timkiem.TabIndex = 4;
            this.lb_timkiem.Text = "Tìm kiếm";
            // 
            // tb_timkiem
            // 
            this.tb_timkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_timkiem.Location = new System.Drawing.Point(132, 92);
            this.tb_timkiem.Name = "tb_timkiem";
            this.tb_timkiem.Size = new System.Drawing.Size(108, 26);
            this.tb_timkiem.TabIndex = 5;
            // 
            // ptb_quaylai
            // 
            this.ptb_quaylai.BackColor = System.Drawing.Color.Red;
            this.ptb_quaylai.Location = new System.Drawing.Point(16, 19);
            this.ptb_quaylai.Name = "ptb_quaylai";
            this.ptb_quaylai.Size = new System.Drawing.Size(33, 28);
            this.ptb_quaylai.TabIndex = 6;
            this.ptb_quaylai.TabStop = false;
            // 
            // form_thaydoiphat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(586, 380);
            this.Controls.Add(this.ptb_quaylai);
            this.Controls.Add(this.tb_timkiem);
            this.Controls.Add(this.lb_timkiem);
            this.Controls.Add(this.bt_luu);
            this.Controls.Add(this.bt_thaydoi);
            this.Controls.Add(this.gb_thongtinphat);
            this.Controls.Add(this.lb_phat);
            this.Name = "form_thaydoiphat";
            this.Text = "THÔNG TIN PHẠT";
            this.gb_thongtinphat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_thongtinphat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_quaylai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_phat;
        private System.Windows.Forms.GroupBox gb_thongtinphat;
        private System.Windows.Forms.DataGridView dgv_thongtinphat;
        private System.Windows.Forms.Button bt_thaydoi;
        private System.Windows.Forms.Button bt_luu;
        private System.Windows.Forms.Label lb_timkiem;
        private System.Windows.Forms.TextBox tb_timkiem;
        private System.Windows.Forms.PictureBox ptb_quaylai;
    }
}