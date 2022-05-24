using System;
using System.Windows.Forms;

namespace WinFormsApp_Nhom_NMCPNM
{
    public partial class form_thongtintaikhoan : Form
    {

        public string loaiTK;
        public form_thongtintaikhoan()
        {
            loaiTK = "khach";
            InitializeComponent();
        }

        public form_thongtintaikhoan(string loaitaikhoan)
        {
            loaiTK = loaitaikhoan;
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lb_quyenhan_Click(object sender, EventArgs e)
        {

        }

        private void lb_tennguoidung_Click(object sender, EventArgs e)
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
