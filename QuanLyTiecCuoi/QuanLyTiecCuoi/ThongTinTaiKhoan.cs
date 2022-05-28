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
using System.Text.RegularExpressions;

namespace QuanLyTiecCuoi
{
    public partial class form_thongtintaikhoan : Form
    {
        public string TenTK="huynt";
        public form_thongtintaikhoan()
        {
            InitializeComponent();
        }
        // 
        string tentaikhoan, tennguoidung, matkhau, loainguoidung;
        string query;
        // Kiểm tra thông tin thay đổi và lưu vào cơ sở dữ liệu
        private void bt_luu_Click(object sender, EventArgs e)
        {
            //
            if (tb_matkhau.Text.ToString().Length >= 8)
            {
                if (MessageBox.Show("Bạn có muốn lưu những thay đổi không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {

                    bt_capnhat.Visible = true;
                    bt_luu.Visible = false;
                    tb_matkhau.ReadOnly = true;
                    tb_tennguoidung.ReadOnly = true;
                    MessageBox.Show("Đã cập nhật thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                tennguoidung = tb_tennguoidung.Text.ToString();
                matkhau = tb_matkhau.Text.ToString();
                query = "update TAIKHOAN set HoTen = N'" + tennguoidung + "', MatKhau = '" + matkhau + "'";
                query += "where TenTK = '" + TenTK + "'";
                SqlConnection conn = Connection._connection();
                conn.Open();
                SqlCommand conten = new SqlCommand(query, conn);
                conten.ExecuteNonQuery();
                lb_loimatkhau.Visible = false;
            }
            else
            {
                lb_loimatkhau.Visible = true;
            }
        }
        // Thoát ứng dụng
        private void ptb_thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)==DialogResult.OK)
            {
                Application.Exit();
            }    
        }
        // Thay đổi thông tin tài khoản
        private void bt_capnhat_Click(object sender, EventArgs e)
        {
            bt_capnhat.Visible = false;
            bt_luu.Visible = true;
            tb_matkhau.ReadOnly = false;
            tb_tennguoidung.ReadOnly = false;
            //
        }
        // Lấy thông tin tài khoản từ cơ sở dữ liệu
        void HienThi()
        {
            SqlConnection conn = Connection._connection();
            conn.Open();
            string query = "select * from TAIKHOAN where TenTK = \'"+TenTK+"\'";
            SqlCommand conten = new SqlCommand(query, conn);
            SqlDataReader sqlDataReader = conten.ExecuteReader();
            while (sqlDataReader.Read())
            {
                tentaikhoan = sqlDataReader[0].ToString();
                tennguoidung = sqlDataReader[2].ToString();
                matkhau = sqlDataReader[1].ToString();
                loainguoidung = sqlDataReader[3].ToString();
            }    
            sqlDataReader.Close();
        }
        // Hiền thị thông tin tài khoản
        private void form_thongtintaikhoan_Load(object sender, EventArgs e)
        {
            HienThi();
            tb_tentaikhoan.Text  = tentaikhoan;
            tb_tennguoidung.Text = tennguoidung;
            tb_quyenhan.Text = loainguoidung;
            tb_matkhau.Text = matkhau;
        }

    }
}
