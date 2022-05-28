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
    public partial class form_thaydoiloaisanh : Form
    {
        public form_thaydoiloaisanh()
        {
            InitializeComponent();
        }
        string query ;
        string query1 = "select maloaisanh as N'Mã loại sảnh', tenloaisanh as N'Tên loại sảnh', dongiabantoithieu as N'Đơn giá bàn tối thiểu' from loaisanh";
        Modify modify = new Modify();
        string timKiem, maloaisanh, tenloaisanh, dongia;

        // Load dữ liệu từ cơ sở dữ liệu
        private void form_thongtinsanh_Load(object sender, EventArgs e)
        {
            dgv_danhsachloaisanh.DataSource = modify.DataTable(query1);
            tb_maloaisanh.Text = dgv_danhsachloaisanh.SelectedRows[0].Cells[0].Value.ToString();
            tb_tenloaisanh.Text = dgv_danhsachloaisanh.SelectedRows[0].Cells[1].Value.ToString();
            tb_dongia.Text = dgv_danhsachloaisanh.SelectedRows[0].Cells[2].Value.ToString();
        }
        // Hiển thị thông tin chi tiết của loại sảnh
        private void dgv_danhsachsanh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_maloaisanh.Text = dgv_danhsachloaisanh.SelectedRows[0].Cells[0].Value.ToString();
            tb_tenloaisanh.Text = dgv_danhsachloaisanh.SelectedRows[0].Cells[1].Value.ToString();
            tb_dongia.Text = dgv_danhsachloaisanh.SelectedRows[0].Cells[2].Value.ToString();
        }
        // Tìm kiếmstring timKiem;
        private void tb_timkiem_TextChanged(object sender, EventArgs e)
        {
            timKiem = tb_timkiem.Text.Trim();
            query = "select maloaisanh as N'Mã loại sảnh', tenloaisanh as N'Tên loại sảnh', dongiabantoithieu as N'Đơn giá bàn tối thiểu' from loaisanh where tenloaisanh like '%"+timKiem+"%'";
            dgv_danhsachloaisanh.DataSource = modify.DataTable(query);
        }
        
        // Quay lại màn hình trước đó
        private void ptb_quaylai_Click(object sender, EventArgs e)
        {
            
        }
        // Lấy dữ liệu
        public void LayDuLieu()
        {
            maloaisanh = tb_maloaisanh.Text.ToString();
            tenloaisanh = tb_tenloaisanh.Text.ToString();
            dongia = tb_dongia.Text.ToString();
        }
        // Xóa dữ liệu
        public void XoaDuLieu()
        {
            tb_maloaisanh.Text = "";
            tb_tenloaisanh.Text = "";
            tb_dongia.Text = "";
        }
        // Kiểm tra dữ liệu
        public bool KiemTra()
        {
            if (maloaisanh ==""|| tenloaisanh==""||dongia=="")
            {
                return false;
            }    
            else
            {
                return true;
            }
        }
        // Thực hiện thay đổi loại sảnh
        private void bt_thaydoi_Click(object sender, EventArgs e)
        {
            bt_them.Visible = true;
            bt_capnhat.Visible = true;
            bt_xoa.Visible = true;
            bt_quaylai.Visible = true;
            bt_thaydoi.Visible = false;
            XoaDuLieu();
        }
        // Quay lại trước khi thay đổi
        private void bt_quaylai_Click(object sender, EventArgs e)
        {
            bt_thaydoi.Visible = true;
            bt_them.Visible = false;
            bt_capnhat.Visible = false;
            bt_xoa.Visible = false;
            bt_quaylai.Visible = false;
        }
        // Thêm loại sảnh
        private void bt_them_Click(object sender, EventArgs e)
        {
            LayDuLieu();
            if (KiemTra()== true)
            {
                if (MessageBox.Show("Bạn có muốn thêm không?", "Thông báo",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Information)==DialogResult.Yes)
                {
                    query = "insert into loaisanh values (N'"+maloaisanh+"',N'"+tenloaisanh+"', '"+dongia+"')";
                    try
                    {
                        modify.Command(query);
                        MessageBox.Show("Thêm thành công!");
                        dgv_danhsachloaisanh.DataSource = modify.DataTable(query1);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi thêm: " + ex);
                    }
                }    
            }
            else
            {
                MessageBox.Show("Vui lòng nhập thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        // Cập nhật dữ liệu
        private void bt_capnhat_Click(object sender, EventArgs e)
        {
            if (dgv_danhsachloaisanh.RowCount>0)
            {
                tb_maloaisanh.ReadOnly = true;
                LayDuLieu();
                if (KiemTra() == true)
                {
                    if (MessageBox.Show("Bạn có muốn cập nhật không?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        query = "update loaisanh set tenloaisanh = N'"+tenloaisanh+"', dongiabantoithieu = '"+dongia+"'";
                        query += " where maloaisanh = '" + maloaisanh + "'";
                        try
                        {
                            modify.Command(query);
                            MessageBox.Show("Cập nhật thành công!");
                            dgv_danhsachloaisanh.DataSource = modify.DataTable(query1);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi cập nhật: " + ex);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Danh sách rỗng!");
            }
        }
        // Xóa loại sảnh
        private void bt_xoa_Click(object sender, EventArgs e)
        {
            if (dgv_danhsachloaisanh.RowCount > 0)
            {
                string choose = dgv_danhsachloaisanh.SelectedRows[0].Cells[0].Value.ToString();
                query = "delete loaisanh";
                query += " where maloaisanh = '" + choose + "'";
                if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    try
                    {
                        modify.Command(query);
                        MessageBox.Show("Xóa thành công!");
                        dgv_danhsachloaisanh.DataSource = modify.DataTable(query1);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi xóa: " + ex);
                    }
                }    
            }   
            else
            {
                MessageBox.Show("Danh sách rỗng!");
            }    
        }

    }
}
