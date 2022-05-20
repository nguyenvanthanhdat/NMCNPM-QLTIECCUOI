
namespace WinFormsApp_Nhom_NMCPNM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_tracuutieccuoi));
            this.tb_timkiem = new System.Windows.Forms.TextBox();
            this.lb_ketquatimkiem = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bt_in = new System.Windows.Forms.Button();
            this.bt_thoat = new System.Windows.Forms.Button();
            this.bt_quaylai = new System.Windows.Forms.Button();
            this.lb_tracuutiec = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_timkiem
            // 
            this.tb_timkiem.Location = new System.Drawing.Point(151, 82);
            this.tb_timkiem.Name = "tb_timkiem";
            this.tb_timkiem.Size = new System.Drawing.Size(409, 23);
            this.tb_timkiem.TabIndex = 0;
            this.tb_timkiem.Text = "Nhập ngày tra cứu";
            // 
            // lb_ketquatimkiem
            // 
            this.lb_ketquatimkiem.AutoSize = true;
            this.lb_ketquatimkiem.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_ketquatimkiem.Location = new System.Drawing.Point(274, 126);
            this.lb_ketquatimkiem.Name = "lb_ketquatimkiem";
            this.lb_ketquatimkiem.Size = new System.Drawing.Size(172, 25);
            this.lb_ketquatimkiem.TabIndex = 1;
            this.lb_ketquatimkiem.Text = "KẾT QUẢ TÌM KIẾM";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WinFormsApp_Nhom_NMCPNM.Properties.Resources.loupe;
            this.pictureBox1.Location = new System.Drawing.Point(532, 82);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(142, 173);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(439, 131);
            this.dataGridView1.TabIndex = 3;
            // 
            // bt_in
            // 
            this.bt_in.AutoSize = true;
            this.bt_in.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt_in.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_in.Location = new System.Drawing.Point(382, 318);
            this.bt_in.Name = "bt_in";
            this.bt_in.Size = new System.Drawing.Size(75, 29);
            this.bt_in.TabIndex = 4;
            this.bt_in.Text = "In";
            this.bt_in.UseVisualStyleBackColor = false;
            // 
            // bt_thoat
            // 
            this.bt_thoat.AutoSize = true;
            this.bt_thoat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt_thoat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_thoat.Location = new System.Drawing.Point(589, 318);
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
            this.bt_quaylai.Location = new System.Drawing.Point(485, 318);
            this.bt_quaylai.Name = "bt_quaylai";
            this.bt_quaylai.Size = new System.Drawing.Size(75, 29);
            this.bt_quaylai.TabIndex = 6;
            this.bt_quaylai.Text = "Quay lại";
            this.bt_quaylai.UseVisualStyleBackColor = false;
            // 
            // lb_tracuutiec
            // 
            this.lb_tracuutiec.AutoSize = true;
            this.lb_tracuutiec.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_tracuutiec.Location = new System.Drawing.Point(282, 20);
            this.lb_tracuutiec.Name = "lb_tracuutiec";
            this.lb_tracuutiec.Size = new System.Drawing.Size(164, 32);
            this.lb_tracuutiec.TabIndex = 7;
            this.lb_tracuutiec.Text = "TRA CỨU TIỆC";
            // 
            // form_tracuutieccuoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WinFormsApp_Nhom_NMCPNM.Properties.Resources.backgroun_dattiec;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(677, 368);
            this.Controls.Add(this.lb_tracuutiec);
            this.Controls.Add(this.bt_quaylai);
            this.Controls.Add(this.bt_thoat);
            this.Controls.Add(this.bt_in);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lb_ketquatimkiem);
            this.Controls.Add(this.tb_timkiem);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form_tracuutieccuoi";
            this.Text = "TRA CỨU TIỆC CƯỚI";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_timkiem;
        private System.Windows.Forms.Label lb_ketquatimkiem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bt_in;
        private System.Windows.Forms.Button bt_thoat;
        private System.Windows.Forms.Button bt_quaylai;
        private System.Windows.Forms.Label lb_tracuutiec;
    }
}