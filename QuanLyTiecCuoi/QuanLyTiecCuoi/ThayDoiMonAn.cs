using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTiecCuoi
{
    public partial class form_thaydoimonan : Form
    {
        public form_thaydoimonan()
        {
            InitializeComponent();
        }
        Modify modify = new Modify();
        string query;
        string query1 = "select MaMonAn as N'Mã món ăn', TenMonAn as N'Tên món ăn', DonGia as N'Đơn giá' from MONAN";
        // Load dữ liệu lên bảng danh sách dịch vụ

        private void form_thaydoimonan_Load(object sender, EventArgs e)
        {
            try
            {
                dgv_danhsachmonan.DataSource = modify.DataTable(query1);
                tb_mamonan.Text = dgv_danhsachmonan.SelectedRows[0].Cells[0].Value.ToString();
                tb_tenmonan.Text = dgv_danhsachmonan.SelectedRows[0].Cells[1].Value.ToString();
                tb_dongia.Text = dgv_danhsachmonan.SelectedRows[0].Cells[2].Value.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi: "+ex.Message);
            }
        }
        // Load dữ liệu trên thông tin chi tiết
        private void dgv_danhsachmonan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_mamonan.Text = dgv_danhsachmonan.SelectedRows[0].Cells[0].Value.ToString();
            tb_tenmonan.Text = dgv_danhsachmonan.SelectedRows[0].Cells[1].Value.ToString();
            tb_dongia.Text = dgv_danhsachmonan.SelectedRows[0].Cells[2].Value.ToString();
        }

        // Tìm kiếm
        string timKiem;
        private void tb_timkiem_TextChanged(object sender, EventArgs e)
        {
            timKiem = tb_timkiem.Text.Trim();
            query = "select MaMonAn as N'Mã món ăn', TenMonAn as N'Tên món ăn', DonGia as N'Đơn giá' from MONAN where tenmonan like N'%"+timKiem+"%'";
            dgv_danhsachmonan.DataSource = modify.DataTable(query);
            tb_mamonan.Text = dgv_danhsachmonan.SelectedRows[0].Cells[0].Value.ToString();
            tb_tenmonan.Text = dgv_danhsachmonan.SelectedRows[0].Cells[1].Value.ToString();
            tb_dongia.Text = dgv_danhsachmonan.SelectedRows[0].Cells[2].Value.ToString();
        }

        // Lấy dữ liệu
        string mamonan, tenmonan, dongia;

        // Xóa dữ liệu trước khi thay đổi
        private void XoaDuLieu()
        {
            tb_tenmonan.Text = "";
            tb_mamonan.Text = "";
            tb_dongia.Text = "";
        }
        private void LayDuLieu()
        {
            mamonan = tb_mamonan.Text.ToString();
            tenmonan = tb_tenmonan.Text.ToString();
            dongia = tb_dongia.Text.ToString();
        }
        // Thay đổi món ăn
        private void bt_thaydoi_Click(object sender, EventArgs e)
        {
            bt_them.Visible = true;
            bt_capnhat.Visible = true;
            bt_xoa.Visible = true;
            XoaDuLieu();
        }
        // Kết thúc thay đổi
        private void bt_quaylai_Click(object sender, EventArgs e)
        {
            bt_them.Visible = false;
            bt_capnhat.Visible = false;
            bt_xoa.Visible = false;
        }

        // Kiểm tra dữ liệu nhập
        private bool KiemTra()
        {
            if (mamonan == "" || tenmonan == "" || dongia == "")
            {
                return false;
            }
            else
            {
                return true;
            } 
                
        }
        // Thêm món ăn
        private void bt_them_Click(object sender, EventArgs e)
        {
            LayDuLieu();
            if (dgv_danhsachmonan.RowCount <= 100)
            {
                if (KiemTra()==true)
                {
                    if (MessageBox.Show("Bạn có muốn thêm không?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        try
                        {
                            query = "insert into monan values (\'" + mamonan + "\', N'" + tenmonan + "', '" + dongia + "')";
                            modify.Command(query);
                            MessageBox.Show("Thêm thành công!");
                            form_thaydoimonan_Load(sender, e);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi thêm: " + ex);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng thông tin!");
                }    
            }
            else
            {
                MessageBox.Show("Danh sách dầy!", "Error!!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }    
        }

        // Cập nhật lại các món ăn
        private void bt_capnhat_Click(object sender, EventArgs e)
        {
            tb_mamonan.ReadOnly = true;
            if (dgv_danhsachmonan.RowCount > 0)
            {
                LayDuLieu();
                if (KiemTra() == true)
                {
                    if (MessageBox.Show("Bạn có muốn cập nhật không?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        try
                        {
                            query = "update monan set tenmonan = N'" + tenmonan + "', dongia = '" + dongia + "'";
                            query += " where mamonan = '" + mamonan + "'";
                            modify.Command(query);
                            MessageBox.Show("Cập nhật thành công!");
                            form_thaydoimonan_Load(sender, e);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi cập nhật: " + ex);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng thông tin!");
                }
            }
            else
            {
                MessageBox.Show("Danh sách rỗng!", "Error!!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
        // Xóa dữ liệu
        private void bt_xoa_Click(object sender, EventArgs e)
        {
            if (dgv_danhsachmonan.RowCount > 0)
            {
                string choose = dgv_danhsachmonan.SelectedRows[0].Cells[0].Value.ToString();
                if (MessageBox.Show("Bạn có món xóa không?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    query = "delete monan";
                    query += " where mamonan = '" + choose + "'";
                    try
                    {
                        modify.Command(query);
                        MessageBox.Show("Xóa thành công!");
                        form_thaydoimonan_Load(sender, e);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi xóa: " + ex);
                    }
                }
            }
            else
            {
                MessageBox.Show("Danh sách rỗng!", "Error!!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
    }
}
