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
    public partial class form_thaydoica : Form
    {
        public form_thaydoica()
        {
            InitializeComponent();
        }
        // Khởi tạo biến
        string query;
        string query1 = "select maca as N'Mã ca', tenca as N'Tên ca' from ca";
        Modify modify = new Modify();
        string timkiem, maca, tenca;
        // Load dữ liệu từ cơ sở dữ liệu
        private void form_thaydoica_Load(object sender, EventArgs e)
        {
            dgv_danhsachca.DataSource = modify.DataTable(query1);
            tb_maca.Text = dgv_danhsachca.SelectedRows[0].Cells[0].Value.ToString();
            tb_tenca.Text = dgv_danhsachca.SelectedRows[0].Cells[1].Value.ToString();
        }
        private void dgv_danhsachca_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_maca.Text = dgv_danhsachca.SelectedRows[0].Cells[0].Value.ToString();
            tb_tenca.Text = dgv_danhsachca.SelectedRows[0].Cells[1].Value.ToString();
        }
        // Lấy dữ liệu
        public void LayDuLieu()
        {
            maca = tb_maca.Text.ToString();
            tenca  = tb_tenca.Text.ToString();
        }

        // Xóa dữ liệu
        public void XoaDuLieu()
        {
            tb_maca.Text = "";
            tb_tenca.Text = "";
        }
        // Kiểm tra dữ liệu nhập
        public bool KiemTra()
        {
            if (maca == ""|| tenca=="")
            {
                return false;
            }    
            else
            {
                return true;
            }    
        }
        // Tìm kiếm ca
        private void tb_timkiem_TextChanged(object sender, EventArgs e)
        {
            timkiem = tb_timkiem.Text.Trim();
            string query2 = query1 + " where tenca like N'%" + timkiem + "%'";
            dgv_danhsachca.DataSource = modify.DataTable(query2);
        }
        // Thay đổi ca
        private void bt_thaydoi_Click(object sender, EventArgs e)
        {
            bt_them.Visible = true;
            bt_capnhat.Visible = true;
            bt_xoa.Visible = true;
            bt_quaylai.Visible = true;
            bt_thaydoi.Visible = false;
            XoaDuLieu();
        }
        // Kết thúc thay đổi
        private void bt_quaylai_Click(object sender, EventArgs e)
        {
            bt_thaydoi.Visible = true;
            bt_them.Visible = false;
            bt_capnhat.Visible = false;
            bt_xoa.Visible = false;
            bt_quaylai.Visible = false;
        }
        // Thêm ca
        private void bt_them_Click(object sender, EventArgs e)
        {
            LayDuLieu();
            if (KiemTra()==true)
            {
                query = "insert into ca values ('" + maca + "', N'" + tenca + "')";
                if (MessageBox.Show("Bạn có muốn thêm không?", "Thông báo", MessageBoxButtons.YesNoCancel,MessageBoxIcon.Information)==DialogResult.Yes)
                {
                    try
                    {
                        modify.Command(query);
                        MessageBox.Show("Thêm thành công!");
                        dgv_danhsachca.DataSource = modify.DataTable(query1);
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Lỗi thêm: " + ex);
                    }
                }    
            }   
            else
            {
                MessageBox.Show("Vui lòng nhập thông tin!");
            } 
        }
        // Cập nhật ca
        private void bt_capnhat_Click(object sender, EventArgs e)
        {
            tb_maca.ReadOnly = true;
            if (dgv_danhsachca.Rows.Count > 0)
            {
                LayDuLieu();
                if (KiemTra()==true)
                {
                    query = "update ca set tenca = N'" + tenca + "'";
                    query += " where maca = '" + maca + "'";
                    if (MessageBox.Show("Bạn có muốn cập nhật không?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information)== DialogResult.Yes)
                    {
                        try
                        {
                            modify.Command(query);
                            MessageBox.Show("Cập nhật thành công!");
                            dgv_danhsachca.DataSource = modify.DataTable(query1);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi cập nhật: " + ex);
                        }
                    }
                }   
                else
                {
                    MessageBox.Show("Vui lòng nhập thông tin!");
                }    
            }
            else
            {
                MessageBox.Show("Danh sách rỗng!");
            }    
        }
        // Xóa ca
        private void bt_xoa_Click(object sender, EventArgs e)
        {
            if (dgv_danhsachca.Rows.Count > 0)
            {
                string choose = dgv_danhsachca.SelectedRows[0].Cells[0].Value.ToString();
                    query = "delete ca ";
                    query += " where maca = '" + choose + "'";
                    if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        try
                        {
                            modify.Command(query);
                            MessageBox.Show("Xóa thành công!");
                            dgv_danhsachca.DataSource = modify.DataTable(query1);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi Xóa: " + ex);
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
