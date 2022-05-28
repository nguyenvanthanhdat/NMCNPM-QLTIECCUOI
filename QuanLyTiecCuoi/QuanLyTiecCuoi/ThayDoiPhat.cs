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
    public partial class form_thaydoiphat : Form
    {
        public form_thaydoiphat()
        {
            InitializeComponent();
        }

        private void bt_thaydoi_Click(object sender, EventArgs e)
        {
            dgv_thongtinphat.ReadOnly = false;
            bt_luu.Visible = true;
            bt_thaydoi.Visible = false;
        }

        private void bt_luu_Click(object sender, EventArgs e)
        {
            dgv_thongtinphat.ReadOnly = true;
            bt_thaydoi.Visible = true;
            bt_luu.Visible = false;
        }
    }
}
