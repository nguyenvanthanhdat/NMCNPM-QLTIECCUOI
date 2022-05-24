using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp_Nhom_NMCPNM
{
    public partial class form_thaydoiquydinh : Form
    {
        public string loaiTK;

        public form_thaydoiquydinh()
        {
            loaiTK = "khach";
            InitializeComponent();
        }

        public form_thaydoiquydinh(string loaitaikhoan)
        {
            loaiTK = loaitaikhoan;
            InitializeComponent();
        }

        private void tb_them_TextChanged(object sender, EventArgs e)
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
