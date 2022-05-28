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
    public partial class form_thaydoidichvu : Form
    {
        public form_thaydoidichvu()
        {
            InitializeComponent();
        }
        Modify modify = new Modify();
        string query1 = "select MaDichVu as N'Mã dịch vụ', TenDichVu as N'Tên dịch vụ', DonGia as N'Giá' from DICHVU";
        string query;
        // Dữ liệu ban đầu của màn hình
        private void form_danhsachdichvu_Load(object sender, EventArgs e)
        {
            try
            {
                dgv_danhsachdichvu.DataSource = modify.DataTable(query1);
                tb_madichvu.Text = dgv_danhsachdichvu.SelectedRows[0].Cells[0].Value.ToString();
                tb_tendichvu.Text = dgv_danhsachdichvu.SelectedRows[0].Cells[1].Value.ToString();
                tb_dongia.Text = dgv_danhsachdichvu.SelectedRows[0].Cells[2].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: "+ex.Message);
            }
        }
        // Hiển thị thông tin dịch vụ được chọn
        private void dgv_danhsachdichvu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_madichvu.Text = dgv_danhsachdichvu.SelectedRows[0].Cells[0].Value.ToString();
            tb_tendichvu.Text = dgv_danhsachdichvu.SelectedRows[0].Cells[1].Value.ToString();
            tb_dongia.Text = dgv_danhsachdichvu.SelectedRows[0].Cells[2].Value.ToString();
        }
        // Tìm kiếm tiệc
        string thongTinTimKiem;
        private void tb_timkiem_TextChanged(object sender, EventArgs e)
        {
            thongTinTimKiem = tb_timkiem.Text.Trim();
            query = "select MaDichVu as N'Mã dịch vụ', TenDichVu as N'Tên dịch vụ', DonGia as N'Giá' from DICHVU where TenDichVu like N'%"+thongTinTimKiem+"%'";
            dgv_danhsachdichvu.DataSource = modify.DataTable(query);

        }
        // Lưu
        // Truy vấn lưu
        string tendichvu, madichvu, dongia;

        void LayDuLieu()
        {
            madichvu = tb_madichvu.Text.ToString();
            tendichvu = tb_tendichvu.Text.ToString();
            dongia = tb_dongia.Text.ToString();
        }
        // Xóa dữ liệu trước khi thêm
        private void XoaDuLieu()
        {
            tb_madichvu.Text = "";
            tb_tendichvu.Text = "";
            tb_dongia.Text = "";
        }
        //string value;
        private bool KiemTraNhap()
        {
            if (tendichvu == "" || madichvu == "" || dongia == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void bt_thaydoi_Click(object sender, EventArgs e)
        {
            bt_them.Visible = true;
            bt_capnhat.Visible = true;
            bt_xoa.Visible = true;
            XoaDuLieu();
        }
        // Thêm
        private void bt_them_Click(object sender, EventArgs e)
        {
            if (dgv_danhsachdichvu.RowCount > 21)
            {
                MessageBox.Show("Danh sách dịch vụ đầy! Xóa bớt để thêm mới");
            }
            else
            {
                LayDuLieu();
                if (KiemTraNhap() == true)
                {
                    query = "insert into dichvu values (\'" + madichvu + "\', N'" + tendichvu + "', '" + dongia + "')";
                    try
                    {
                        if (MessageBox.Show("Bạn có muốn thêm vào không?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            modify.Command(query);
                            MessageBox.Show("Thêm thành công!");
                            form_danhsachdichvu_Load(sender, e);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi thêm: " + ex);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập thông tin!");
                }
            }
        }
        // Cập nhật lại dữ liệu
        private void bt_capnhat_Click(object sender, EventArgs e)
        {
            tb_madichvu.ReadOnly = true;
            if (dgv_danhsachdichvu.RowCount < 1)
            {
                MessageBox.Show("Danh sách trống!");
            }
            else
            {
                LayDuLieu();
                if (KiemTraNhap() == true)
                {
                    query = "update dichvu set tendichvu = N'" + tendichvu + "', dongia = '" + dongia + "'";
                    query += " where madichvu = '" + madichvu + "'";
                    try
                    {
                        if (MessageBox.Show("Bạn có muốn cập nhật không?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            modify.Command(query);
                            MessageBox.Show("Cập nhật thành công!");
                            form_danhsachdichvu_Load(sender, e);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi sửa: " + ex);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập thông tin!");
                }
            }
        }
        // Xóa
        private void bt_xoa_Click(object sender, EventArgs e)
        {
            if (dgv_danhsachdichvu.RowCount < 1)
            {
                MessageBox.Show("Danh sách trống!");
            }
            else
            {
                string choose = dgv_danhsachdichvu.SelectedRows[0].Cells[0].Value.ToString();
                if (KiemTraNhap() == true)
                {
                    query = "delete dichvu";
                    query += " where madichvu = '" + choose + "'";
                    try
                    {
                        if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            modify.Command(query);
                            MessageBox.Show("Xóa thành công!");
                            form_danhsachdichvu_Load(sender, e);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi xóa: " + ex);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập thông tin!");
                }
            }
        }

    }
}
