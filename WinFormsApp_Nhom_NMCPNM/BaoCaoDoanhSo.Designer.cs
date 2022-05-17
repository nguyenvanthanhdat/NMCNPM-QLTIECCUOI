
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_baocaodoanhso
            // 
            this.lb_baocaodoanhso.AutoSize = true;
            this.lb_baocaodoanhso.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_baocaodoanhso.Location = new System.Drawing.Point(298, 28);
            this.lb_baocaodoanhso.Name = "lb_baocaodoanhso";
            this.lb_baocaodoanhso.Size = new System.Drawing.Size(245, 32);
            this.lb_baocaodoanhso.TabIndex = 0;
            this.lb_baocaodoanhso.Text = "BÁO CÁO DOANH SỐ";
            // 
            // lb_nhapthang
            // 
            this.lb_nhapthang.AutoSize = true;
            this.lb_nhapthang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_nhapthang.Location = new System.Drawing.Point(259, 92);
            this.lb_nhapthang.Name = "lb_nhapthang";
            this.lb_nhapthang.Size = new System.Drawing.Size(108, 21);
            this.lb_nhapthang.TabIndex = 1;
            this.lb_nhapthang.Text = "NHẬP THÁNG";
            // 
            // lb_nhapnam
            // 
            this.lb_nhapnam.AutoSize = true;
            this.lb_nhapnam.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_nhapnam.Location = new System.Drawing.Point(259, 132);
            this.lb_nhapnam.Name = "lb_nhapnam";
            this.lb_nhapnam.Size = new System.Drawing.Size(92, 21);
            this.lb_nhapnam.TabIndex = 2;
            this.lb_nhapnam.Text = "NHẬP NĂM";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(415, 86);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(171, 25);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(415, 132);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(171, 25);
            this.textBox2.TabIndex = 4;
            // 
            // lb_doanhsothang
            // 
            this.lb_doanhsothang.AutoSize = true;
            this.lb_doanhsothang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_doanhsothang.Location = new System.Drawing.Point(259, 176);
            this.lb_doanhsothang.Name = "lb_doanhsothang";
            this.lb_doanhsothang.Size = new System.Drawing.Size(150, 21);
            this.lb_doanhsothang.TabIndex = 5;
            this.lb_doanhsothang.Text = "DOANH SỐ THÁNG:";
            // 
            // lb_tongdoanhthu
            // 
            this.lb_tongdoanhthu.AutoSize = true;
            this.lb_tongdoanhthu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_tongdoanhthu.Location = new System.Drawing.Point(259, 212);
            this.lb_tongdoanhthu.Name = "lb_tongdoanhthu";
            this.lb_tongdoanhthu.Size = new System.Drawing.Size(150, 21);
            this.lb_tongdoanhthu.TabIndex = 6;
            this.lb_tongdoanhthu.Text = "TỔNG DOANH THU:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(514, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "VND";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(59, 277);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(638, 150);
            this.dataGridView1.TabIndex = 8;
            // 
            // bt_in
            // 
            this.bt_in.AutoSize = true;
            this.bt_in.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt_in.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_in.Location = new System.Drawing.Point(447, 456);
            this.bt_in.Name = "bt_in";
            this.bt_in.Size = new System.Drawing.Size(75, 29);
            this.bt_in.TabIndex = 9;
            this.bt_in.Text = "In";
            this.bt_in.UseVisualStyleBackColor = false;
            // 
            // bt_quaylai
            // 
            this.bt_quaylai.AutoSize = true;
            this.bt_quaylai.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt_quaylai.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_quaylai.Location = new System.Drawing.Point(542, 456);
            this.bt_quaylai.Name = "bt_quaylai";
            this.bt_quaylai.Size = new System.Drawing.Size(75, 29);
            this.bt_quaylai.TabIndex = 10;
            this.bt_quaylai.Text = "Quay lại";
            this.bt_quaylai.UseVisualStyleBackColor = false;
            // 
            // bt_thoat
            // 
            this.bt_thoat.AutoSize = true;
            this.bt_thoat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt_thoat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_thoat.Location = new System.Drawing.Point(636, 456);
            this.bt_thoat.Name = "bt_thoat";
            this.bt_thoat.Size = new System.Drawing.Size(75, 29);
            this.bt_thoat.TabIndex = 11;
            this.bt_thoat.Text = "Thoát";
            this.bt_thoat.UseVisualStyleBackColor = false;
            // 
            // form_baocaodoanhso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 500);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form_baocaodoanhso";
            this.Text = "BÁO CÁO DOANH SỐ";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
    }
}