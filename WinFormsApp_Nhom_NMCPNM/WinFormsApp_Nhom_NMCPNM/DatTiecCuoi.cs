using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp_Nhom_NMCPNM
{
    public partial class form_dattieccuoi : Form
    {

        public string loaiTK;

        public form_dattieccuoi()
        {
            loaiTK = "khach";
            InitializeComponent();
        }

        public form_dattieccuoi(string loaitaikhoan)
        {
            loaiTK = loaitaikhoan;
            InitializeComponent();
        }

        private void lb_tenchure_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox8_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void lb_monan_Click(object sender, EventArgs e)
        {

        }

        private void lb_dattieccuoi_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void gb_thongtintieccuoi_Enter(object sender, EventArgs e)
        {
            
        }

        private void pb_quaylai_Click(object sender, EventArgs e)
        {
            this.Hide();
            form_manhinhchinh f = new form_manhinhchinh(loaiTK);
            f.Closed += (s, args) => this.Close();
            f.ShowDialog();
        }

        private void pb_manhinhchinh_Click(object sender, EventArgs e)
        {
            this.Hide();
            form_manhinhchinh f = new form_manhinhchinh(loaiTK);
            f.Closed += (s, args) => this.Close();
            f.ShowDialog();
        }
    }
}
