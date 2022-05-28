
namespace QuanLyTiecCuoi
{
    partial class form_tracuutieccuoi
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
            this.lb_tracuutiec = new System.Windows.Forms.Label();
            this.tb_thongtintimkiem = new System.Windows.Forms.TextBox();
            this.gb_loaitimkiem = new System.Windows.Forms.GroupBox();
            this.rbt_sanh = new System.Windows.Forms.RadioButton();
            this.rbt_ngaydaitiec = new System.Windows.Forms.RadioButton();
            this.rbt_tencodau = new System.Windows.Forms.RadioButton();
            this.rbt_tenchure = new System.Windows.Forms.RadioButton();
            this.ptb_timkiem = new System.Windows.Forms.PictureBox();
            this.dgv_thongtintracuu = new System.Windows.Forms.DataGridView();
            this.ptb_home = new System.Windows.Forms.PictureBox();
            this.ptb_back = new System.Windows.Forms.PictureBox();
            this.ptb_exit = new System.Windows.Forms.PictureBox();
            this.dtp_ngaytimkiem = new System.Windows.Forms.DateTimePicker();
            this.lb_ngaytimkiem = new System.Windows.Forms.Label();
            this.lb_thongtintimkiem = new System.Windows.Forms.Label();
            this.gb_loaitimkiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_timkiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_thongtintracuu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_home)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_exit)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_tracuutiec
            // 
            this.lb_tracuutiec.AutoSize = true;
            this.lb_tracuutiec.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tracuutiec.Location = new System.Drawing.Point(238, 31);
            this.lb_tracuutiec.Name = "lb_tracuutiec";
            this.lb_tracuutiec.Size = new System.Drawing.Size(244, 29);
            this.lb_tracuutiec.TabIndex = 0;
            this.lb_tracuutiec.Text = "TRA CỨU TIỆC CƯỚI";
            // 
            // tb_thongtintimkiem
            // 
            this.tb_thongtintimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_thongtintimkiem.Location = new System.Drawing.Point(243, 86);
            this.tb_thongtintimkiem.Name = "tb_thongtintimkiem";
            this.tb_thongtintimkiem.Size = new System.Drawing.Size(280, 20);
            this.tb_thongtintimkiem.TabIndex = 1;
            this.tb_thongtintimkiem.TextChanged += new System.EventHandler(this.tb_thongtintimkiem_TextChanged);
            // 
            // gb_loaitimkiem
            // 
            this.gb_loaitimkiem.Controls.Add(this.rbt_sanh);
            this.gb_loaitimkiem.Controls.Add(this.rbt_ngaydaitiec);
            this.gb_loaitimkiem.Controls.Add(this.rbt_tencodau);
            this.gb_loaitimkiem.Controls.Add(this.rbt_tenchure);
            this.gb_loaitimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_loaitimkiem.Location = new System.Drawing.Point(134, 131);
            this.gb_loaitimkiem.Name = "gb_loaitimkiem";
            this.gb_loaitimkiem.Size = new System.Drawing.Size(467, 62);
            this.gb_loaitimkiem.TabIndex = 2;
            this.gb_loaitimkiem.TabStop = false;
            this.gb_loaitimkiem.Text = "Tìm kiếm theo: ";
            // 
            // rbt_sanh
            // 
            this.rbt_sanh.AutoSize = true;
            this.rbt_sanh.Location = new System.Drawing.Point(240, 35);
            this.rbt_sanh.Name = "rbt_sanh";
            this.rbt_sanh.Size = new System.Drawing.Size(59, 21);
            this.rbt_sanh.TabIndex = 3;
            this.rbt_sanh.TabStop = true;
            this.rbt_sanh.Text = "Sảnh";
            this.rbt_sanh.UseVisualStyleBackColor = true;
            this.rbt_sanh.CheckedChanged += new System.EventHandler(this.rbt_sanh_CheckedChanged);
            // 
            // rbt_ngaydaitiec
            // 
            this.rbt_ngaydaitiec.AutoSize = true;
            this.rbt_ngaydaitiec.Location = new System.Drawing.Point(321, 35);
            this.rbt_ngaydaitiec.Name = "rbt_ngaydaitiec";
            this.rbt_ngaydaitiec.Size = new System.Drawing.Size(108, 21);
            this.rbt_ngaydaitiec.TabIndex = 2;
            this.rbt_ngaydaitiec.TabStop = true;
            this.rbt_ngaydaitiec.Text = "Ngày đãi tiệc";
            this.rbt_ngaydaitiec.UseVisualStyleBackColor = true;
            this.rbt_ngaydaitiec.CheckedChanged += new System.EventHandler(this.rbt_ngaydaitiec_CheckedChanged);
            // 
            // rbt_tencodau
            // 
            this.rbt_tencodau.AutoSize = true;
            this.rbt_tencodau.Location = new System.Drawing.Point(124, 35);
            this.rbt_tencodau.Name = "rbt_tencodau";
            this.rbt_tencodau.Size = new System.Drawing.Size(98, 21);
            this.rbt_tencodau.TabIndex = 1;
            this.rbt_tencodau.TabStop = true;
            this.rbt_tencodau.Text = "Tên cô dâu";
            this.rbt_tencodau.UseVisualStyleBackColor = true;
            this.rbt_tencodau.CheckedChanged += new System.EventHandler(this.rbt_tencodau_CheckedChanged);
            // 
            // rbt_tenchure
            // 
            this.rbt_tenchure.AutoSize = true;
            this.rbt_tenchure.Location = new System.Drawing.Point(6, 35);
            this.rbt_tenchure.Name = "rbt_tenchure";
            this.rbt_tenchure.Size = new System.Drawing.Size(95, 21);
            this.rbt_tenchure.TabIndex = 0;
            this.rbt_tenchure.TabStop = true;
            this.rbt_tenchure.Text = "Tên chú rể";
            this.rbt_tenchure.UseVisualStyleBackColor = true;
            this.rbt_tenchure.CheckedChanged += new System.EventHandler(this.rbt_tenchure_CheckedChanged);
            // 
            // ptb_timkiem
            // 
            this.ptb_timkiem.BackColor = System.Drawing.Color.LightCoral;
            this.ptb_timkiem.Location = new System.Drawing.Point(535, 87);
            this.ptb_timkiem.Name = "ptb_timkiem";
            this.ptb_timkiem.Size = new System.Drawing.Size(30, 19);
            this.ptb_timkiem.TabIndex = 3;
            this.ptb_timkiem.TabStop = false;
            this.ptb_timkiem.Click += new System.EventHandler(this.ptb_timkiem_Click);
            // 
            // dgv_thongtintracuu
            // 
            this.dgv_thongtintracuu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_thongtintracuu.GridColor = System.Drawing.Color.White;
            this.dgv_thongtintracuu.Location = new System.Drawing.Point(72, 245);
            this.dgv_thongtintracuu.Name = "dgv_thongtintracuu";
            this.dgv_thongtintracuu.RowHeadersVisible = false;
            this.dgv_thongtintracuu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_thongtintracuu.Size = new System.Drawing.Size(601, 142);
            this.dgv_thongtintracuu.TabIndex = 4;
            // 
            // ptb_home
            // 
            this.ptb_home.BackColor = System.Drawing.Color.LightCoral;
            this.ptb_home.Location = new System.Drawing.Point(57, 12);
            this.ptb_home.Name = "ptb_home";
            this.ptb_home.Size = new System.Drawing.Size(30, 19);
            this.ptb_home.TabIndex = 5;
            this.ptb_home.TabStop = false;
            // 
            // ptb_back
            // 
            this.ptb_back.BackColor = System.Drawing.Color.LightCoral;
            this.ptb_back.Location = new System.Drawing.Point(12, 12);
            this.ptb_back.Name = "ptb_back";
            this.ptb_back.Size = new System.Drawing.Size(30, 19);
            this.ptb_back.TabIndex = 6;
            this.ptb_back.TabStop = false;
            // 
            // ptb_exit
            // 
            this.ptb_exit.BackColor = System.Drawing.Color.LightCoral;
            this.ptb_exit.Location = new System.Drawing.Point(106, 12);
            this.ptb_exit.Name = "ptb_exit";
            this.ptb_exit.Size = new System.Drawing.Size(30, 19);
            this.ptb_exit.TabIndex = 7;
            this.ptb_exit.TabStop = false;
            this.ptb_exit.Click += new System.EventHandler(this.ptb_exit_Click);
            // 
            // dtp_ngaytimkiem
            // 
            this.dtp_ngaytimkiem.CustomFormat = "";
            this.dtp_ngaytimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_ngaytimkiem.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_ngaytimkiem.Location = new System.Drawing.Point(351, 83);
            this.dtp_ngaytimkiem.Name = "dtp_ngaytimkiem";
            this.dtp_ngaytimkiem.Size = new System.Drawing.Size(131, 23);
            this.dtp_ngaytimkiem.TabIndex = 8;
            this.dtp_ngaytimkiem.Visible = false;
            this.dtp_ngaytimkiem.ValueChanged += new System.EventHandler(this.dtp_ngaytimkiem_ValueChanged);
            // 
            // lb_ngaytimkiem
            // 
            this.lb_ngaytimkiem.AutoSize = true;
            this.lb_ngaytimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ngaytimkiem.Location = new System.Drawing.Point(240, 86);
            this.lb_ngaytimkiem.Name = "lb_ngaytimkiem";
            this.lb_ngaytimkiem.Size = new System.Drawing.Size(80, 17);
            this.lb_ngaytimkiem.TabIndex = 9;
            this.lb_ngaytimkiem.Text = "Chọn ngày:";
            this.lb_ngaytimkiem.Visible = false;
            // 
            // lb_thongtintimkiem
            // 
            this.lb_thongtintimkiem.AutoSize = true;
            this.lb_thongtintimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_thongtintimkiem.Location = new System.Drawing.Point(137, 87);
            this.lb_thongtintimkiem.Name = "lb_thongtintimkiem";
            this.lb_thongtintimkiem.Size = new System.Drawing.Size(105, 17);
            this.lb_thongtintimkiem.TabIndex = 10;
            this.lb_thongtintimkiem.Text = "Nhập thông tin:";
            // 
            // form_tracuutieccuoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(754, 463);
            this.Controls.Add(this.lb_thongtintimkiem);
            this.Controls.Add(this.lb_ngaytimkiem);
            this.Controls.Add(this.dtp_ngaytimkiem);
            this.Controls.Add(this.ptb_exit);
            this.Controls.Add(this.ptb_back);
            this.Controls.Add(this.ptb_home);
            this.Controls.Add(this.dgv_thongtintracuu);
            this.Controls.Add(this.ptb_timkiem);
            this.Controls.Add(this.gb_loaitimkiem);
            this.Controls.Add(this.tb_thongtintimkiem);
            this.Controls.Add(this.lb_tracuutiec);
            this.Name = "form_tracuutieccuoi";
            this.Text = "TRA CỨU TIỆC CƯỚI";
            this.Load += new System.EventHandler(this.form_tracuutieccuoi_Load);
            this.gb_loaitimkiem.ResumeLayout(false);
            this.gb_loaitimkiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_timkiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_thongtintracuu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_home)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_exit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_tracuutiec;
        private System.Windows.Forms.TextBox tb_thongtintimkiem;
        private System.Windows.Forms.GroupBox gb_loaitimkiem;
        private System.Windows.Forms.RadioButton rbt_tenchure;
        private System.Windows.Forms.RadioButton rbt_sanh;
        private System.Windows.Forms.RadioButton rbt_ngaydaitiec;
        private System.Windows.Forms.RadioButton rbt_tencodau;
        private System.Windows.Forms.PictureBox ptb_timkiem;
        private System.Windows.Forms.DataGridView dgv_thongtintracuu;
        private System.Windows.Forms.PictureBox ptb_home;
        private System.Windows.Forms.PictureBox ptb_back;
        private System.Windows.Forms.PictureBox ptb_exit;
        private System.Windows.Forms.DateTimePicker dtp_ngaytimkiem;
        private System.Windows.Forms.Label lb_ngaytimkiem;
        private System.Windows.Forms.Label lb_thongtintimkiem;
    }
}

