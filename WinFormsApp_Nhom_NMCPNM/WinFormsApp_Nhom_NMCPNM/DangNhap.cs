using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WinFormsApp_Nhom_NMCPNM
{
    public partial class form_dangnhap : Form
    {
        public string loaiTK;
        public form_dangnhap()
        {
            loaiTK = "khach";
            InitializeComponent();
        }

        private void lb_title_dangnhap_Click(object sender, EventArgs e)
        {

        }

        private void lb_matkhau_Click(object sender, EventArgs e)
        {

        }

        private void bt_dangnhap_Click(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection(@"Data Source=HYDRANOUS;Initial Catalog=QUANLYTIECCUOI;Integrated Security=True");
            //SqlDataAdapter da = new SqlDataAdapter("select * from TAIKHOAN where TenTK = N'" + tb_ten_dang_nhap.Text + "' and MatKhau = N'" + tb_matkhau.Text + "'", con);
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            //if (dt.Rows.Count > 0)
            //{
            //MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //loaiTK = dt.Rows[0][3].ToString();
            //this.Hide();
            //form_manhinhchinh f = new form_manhinhchinh(loaiTK);
            //f.Closed += (s, args) => this.Close();
            //f.ShowDialog();
            //}
            //else
            //{
            //MessageBox.Show("Đăng nhập không thành công!");
            //}    
            loaiTK = "quanly";
            this.Hide();
            form_manhinhchinh f = new form_manhinhchinh(loaiTK);
            f.Closed += (s, args) => this.Close();
            f.ShowDialog();
        }

        private void tb_ten_dang_nhap_TextChanged(object sender, EventArgs e)
        {

        }

        private void lb_quenmatkhau_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vui lòng liên hệ người quản lý!");
        }

        private void pb_quaylai_Click(object sender, EventArgs e)
        {
            this.Hide();
            form_manhinhchinh f = new form_manhinhchinh();
            f.Closed += (s, args) => this.Close();
            f.ShowDialog();
        }

        private void pb_manhinhchinh_Click(object sender, EventArgs e)
        {
            this.Hide();
            form_manhinhchinh f = new form_manhinhchinh();
            f.Closed += (s, args) => this.Close();
            f.ShowDialog();
        }
    }
}
