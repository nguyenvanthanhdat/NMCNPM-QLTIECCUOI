using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp_Nhom_NMCPNM
{
    public partial class form_manhinhchinh : Form
    {
        public string loaiTK;

        public form_manhinhchinh()
        {
            loaiTK = "khach";
            InitializeComponent();
            PhanQuyen();
        }

        public form_manhinhchinh(string loaitaikhoan)
        {
            loaiTK = loaitaikhoan;
            InitializeComponent();
            PhanQuyen();
        }
        void PhanQuyen()
        {
            if (loaiTK == "khach")
            {
                mnsi_dangxuat.Visible = false;
                mnsi_dattieccuoi.Visible = false; 
                mnsi_baocaodoanhso.Visible = false;
                mnsi_quanlyquydinh.Visible = false;
            }   
            else if (loaiTK == "khach_dadangnhap")
            {
                mnsi_dangnhap.Visible = false;
                mnsi_baocaodoanhso.Visible = false;
                mnsi_quanlyquydinh.Visible = false;
            }    
            else if (loaiTK == "nhanvien")
            {
                mnsi_dangnhap.Visible = false;
                mnsi_quanlyquydinh.Visible = false;
            }    
            else if (loaiTK == "quanly")
            {
                mnsi_dangnhap.Visible = false;
            }    
        }
        private void form_manhinhchinh_Load(object sender, EventArgs e)
        {
        }

        private void mnsi_dangxuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn đăng xuất không?", "Đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                this.Hide();
                form_manhinhchinh f = new form_manhinhchinh();
                f.Closed += (s, args) => this.Close();
                f.ShowDialog();
            }
        }

        private void tmnsi_tracuutieccuoi_Click(object sender, EventArgs e)
        {
            this.Hide();
            form_tracuutieccuoi f = new form_tracuutieccuoi(loaiTK);
            f.Closed += (s, args) => this.Close();
            f.ShowDialog();
        }

        private void mnsi_dattieccuoi_Click(object sender, EventArgs e)
        {
            this.Hide();
            form_dattieccuoi f = new form_dattieccuoi(loaiTK);
            f.Closed += (s, args) => this.Close();
            f.ShowDialog();
        }

        private void mnsi_baocaodoanhso_Click(object sender, EventArgs e)
        {
            this.Hide();
            form_baocaodoanhso f = new form_baocaodoanhso(loaiTK);
            f.Closed += (s, args) => this.Close();
            f.ShowDialog();
        }

        private void mnsi_dangnhap_Click(object sender, EventArgs e)
        {
            this.Hide();
            form_dangnhap f = new form_dangnhap();
            f.Closed += (s, args) => this.Close();
            f.ShowDialog();
        }

        private void mnsi_thongtintaikhoan_Click(object sender, EventArgs e)
        {
            this.Hide();
            form_thongtintaikhoan f = new form_thongtintaikhoan(loaiTK);
            f.Closed += (s, args) => this.Close();
            f.ShowDialog();
        }

        private void mnsi_quanlyquydinh_Click(object sender, EventArgs e)
        {
            this.Hide();
            form_thaydoiquydinh f = new form_thaydoiquydinh(loaiTK);
            f.Closed += (s, args) => this.Close();
            f.ShowDialog();
        }

        private void mnsi_sanh_Click(object sender, EventArgs e)
        {
            this.Hide();
            form_sanh f = new form_sanh(loaiTK);
            f.Closed += (s, args) => this.Close();
            f.ShowDialog();
        }

        private void mnsi_loaisanh_Click(object sender, EventArgs e)
        {
            this.Hide();
            form_loaisanh f = new form_loaisanh(loaiTK);
            f.Closed += (s, args) => this.Close();
            f.ShowDialog();
        }

        private void mnsi_monan_Click(object sender, EventArgs e)
        {
            this.Hide();
            form_monan f = new form_monan(loaiTK);
            f.Closed += (s, args) => this.Close();
            f.ShowDialog();
        }

        private void mnsi_dichvu_Click(object sender, EventArgs e)
        {
            this.Hide();
            form_dichvu f = new form_dichvu(loaiTK);
            f.Closed += (s, args) => this.Close();
            f.ShowDialog();
        }
    }
    
}
