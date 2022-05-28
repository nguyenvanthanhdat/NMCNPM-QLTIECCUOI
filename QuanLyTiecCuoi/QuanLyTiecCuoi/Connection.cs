using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QuanLyTiecCuoi
{
    // Lớp tạo kết nối với cơ sở dữ liệu
    class Connection
    {
        // Biến lưu chuỗi kết nối vớp cơ sở dữ liệu
        private static string strCon = @"Data Source=DESKTOP-UU6MF1V\SQLEXPRESS;Initial Catalog=QUANLYTIECCUOI;Integrated Security=True";
        // Hàm kết nối
        public static SqlConnection _connection()
        {
            return new SqlConnection(strCon);
        }
    }
}
