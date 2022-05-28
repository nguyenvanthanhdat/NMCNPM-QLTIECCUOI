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


namespace QuanLyTiecCuoi
{
    public partial class form_tracuutieccuoi : Form
    {
        public form_tracuutieccuoi()
        {
            InitializeComponent();
        }
        // Đưa dữ liệu từ cơ sở dữ liệu vào bảng tra cứu tiệc
        Modify modify = new Modify();
        string query = "select * from DanhSachTiec";
        private void form_tracuutieccuoi_Load(object sender, EventArgs e)
        {
            try
            {
                dgv_thongtintracuu.DataSource = modify.DataTable(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            } 
        }
        int luaChonTimKiem = 0;
        // Loại 1: Tìm theo tên chú rể
        private void rbt_tenchure_CheckedChanged(object sender, EventArgs e)
        {
            luaChonTimKiem = 1;
            HienThi(luaChonTimKiem);
        }
        // Loại 2: Tìm kiếm theo tên cô dâu
        private void rbt_tencodau_CheckedChanged(object sender, EventArgs e)
        {
            luaChonTimKiem = 2;
            HienThi(luaChonTimKiem);
        }
        // Loại 3: Tìm kiếm theo sảnh
        private void rbt_sanh_CheckedChanged(object sender, EventArgs e)
        {
            luaChonTimKiem = 3;
            HienThi(luaChonTimKiem);
        }

        // Loại 4: Tìm kiếm theo ngày
        private void rbt_ngaydaitiec_CheckedChanged(object sender, EventArgs e)
        {
            luaChonTimKiem = 4;
            HienThi(luaChonTimKiem);

        }
        string thongTinTimKiem;
        
        int year, month, day;
        private void dtp_ngaytimkiem_ValueChanged(object sender, EventArgs e)
        {
            
            year = dtp_ngaytimkiem.Value.Year;
            month = dtp_ngaytimkiem.Value.Month;
            day = dtp_ngaytimkiem.Value.Day; 
        }
        // hiển thị tap tim kiêm
        public void HienThi(int luachon)
        {
            if (luachon == 4)
            {
                dtp_ngaytimkiem.Visible = true;
                lb_ngaytimkiem.Visible = true;
                tb_thongtintimkiem.Visible = false;
                lb_thongtintimkiem.Visible = false;
            }
            else
            {
                dtp_ngaytimkiem.Visible = false;
                lb_ngaytimkiem.Visible = false;
                tb_thongtintimkiem.Visible = true;
                lb_thongtintimkiem.Visible = true;
            }
        }
        private void tb_thongtintimkiem_TextChanged(object sender, EventArgs e)
        {
            thongTinTimKiem = tb_thongtintimkiem.Text.Trim();
            HienThi(luaChonTimKiem);
        }
        //
        private void ptb_timkiem_Click(object sender, EventArgs e)
        {
            if (thongTinTimKiem == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin");
            }
            if (luaChonTimKiem == 0)
            {
                form_tracuutieccuoi_Load(sender, e);
            }    
            else if (luaChonTimKiem == 1)
            {
                query = "select TenChuRe as 'Tên chú rể', TenCoDau as 'Tên cô dâu', TenSanh as 'Sảnh', NgayDaiTiec as 'Ngày', GioDaiTiec as 'Gio', SoLuongBan as 'Số lượng bàn' from TIEC, SANH where TIEC.MaSanh = SANH.MaSanh and TenChuRe like  N'%"+thongTinTimKiem+"%'";
                dgv_thongtintracuu.DataSource = modify.DataTable(query);
            }    
            else if (luaChonTimKiem == 2)
            {
                query = "select TenChuRe as 'Tên chú rể', TenCoDau as 'Tên cô dâu', TenSanh as 'Sảnh', NgayDaiTiec as 'Ngày', GioDaiTiec as 'Gio', SoLuongBan as 'Số lượng bàn' from TIEC, SANH where TIEC.MaSanh = SANH.MaSanh and TenCoDau like  N'%"+thongTinTimKiem+"%'";
                dgv_thongtintracuu.DataSource = modify.DataTable(query);
            }    
            else if (luaChonTimKiem == 4)
            {
                query = "select TenChuRe as 'Tên chú rể', TenCoDau as 'Tên cô dâu', TenSanh as 'Sảnh', NgayDaiTiec as 'Ngày', GioDaiTiec as 'Gio', SoLuongBan as 'Số lượng bàn' from TIEC, SANH where TIEC.MaSanh = SANH.MaSanh and Year(NgayDaiTiec) = '"+year+"' and Month(NgayDaiTiec) = '"+month+"' and Day(NgayDaiTiec) ='"+day+"'";
                dgv_thongtintracuu.DataSource = modify.DataTable(query);
            }    
            else if (luaChonTimKiem == 3)
            {
                query = "select TenChuRe as 'Tên chú rể', TenCoDau as 'Tên cô dâu', TenSanh as 'Sảnh', NgayDaiTiec as 'Ngày', GioDaiTiec as 'Gio', SoLuongBan as 'Số lượng bàn' from TIEC, SANH where TIEC.MaSanh = SANH.MaSanh and TenSanh like  N'%"+thongTinTimKiem+"%'";
                dgv_thongtintracuu.DataSource = modify.DataTable(query );
            }    
            if (dgv_thongtintracuu.Rows.Count == 1)
            {
                MessageBox.Show("Không có kết quả phù hợp! Vui lòng nhập đúng!", "Lỗi!!!");
            }
        }

        private void ptb_exit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                Application.Exit();
            }    
        }
    }
}
