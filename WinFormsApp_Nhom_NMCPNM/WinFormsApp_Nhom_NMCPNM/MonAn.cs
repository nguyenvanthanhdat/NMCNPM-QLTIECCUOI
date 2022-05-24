using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp_Nhom_NMCPNM
{
    public partial class form_monan : Form
    {
        public string loaiTK;
        public form_monan()
        {
            loaiTK = "khach";
            InitializeComponent();
            PhanQuyen();
        }

        public form_monan(string loaitaikhoan)
        {
            loaiTK = loaitaikhoan;
            InitializeComponent();
            PhanQuyen();
        }
        void PhanQuyen()
        {
            if (loaiTK == "khach")
            {
                bt_xoa.Visible = false;
                bt_luu.Visible = false;
                gb_thaydoimonan.Visible = false;
            }
            else if (loaiTK == "khach_dadangnhap")
            {
                bt_xoa.Visible = false;
                bt_luu.Visible = false;
                gb_thaydoimonan.Visible = false;
            }
            else if (loaiTK == "nhanvien")
            {
                bt_xoa.Visible = false;
                bt_luu.Visible = false;
                gb_thaydoimonan.Visible = false;
            }
            else if (loaiTK == "quanly")
            {

            }
        }


        private void pb_quaylai_Click(object sender, EventArgs e)
        {
            this.Hide();
            form_manhinhchinh f = new form_manhinhchinh(loaiTK);
            f.Closed += (s, args) => this.Close();
            f.ShowDialog();
        }

        private void gb_tiepnhansanh_Enter(object sender, EventArgs e)
        {

        }

        private void pb_manhinhchinh_Click(object sender, EventArgs e)
        {
            this.Hide();
            form_manhinhchinh f = new form_manhinhchinh(loaiTK);
            f.Closed += (s, args) => this.Close();
            f.ShowDialog();
        }

        private void gb_danhsachsanh_Enter(object sender, EventArgs e)
        {

        }

        private void form_monan_Load(object sender, EventArgs e)
        {

        }
    }
}
