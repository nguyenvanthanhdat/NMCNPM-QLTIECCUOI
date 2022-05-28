using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyTiecCuoi
{
    class Modify
    {
        public Modify()
        {

        }
        // Tạo biến truy xuất dữ liệu vào bảng
        private SqlDataAdapter dataAdapter;
        // Tạo biến để thực hiện truy vấn dữ liệu
        private SqlCommand sqlCommand;
        public  DataTable DataTable(string query)
        {
            DataTable dataTable = new DataTable();
            // Đưa dữ liệu vào bảng
            using (SqlConnection sqlConnection = Connection._connection())
            {
                sqlConnection.Open();
                // Khởi tạo dataAdapter
                dataAdapter = new SqlDataAdapter(query, sqlConnection);
                // Đưa dữ liệu vào bảng
                dataAdapter.Fill(dataTable);
                sqlConnection.Close();
            }    
            return dataTable;
        }
        // Hàm truy vấn dữ liệu
        public void Command(string query)
        {
            using (SqlConnection sqlConnection = Connection._connection())
            {
                sqlConnection.Open();
                // Khởi tạo sqlCommand
                sqlCommand = new SqlCommand(query, sqlConnection);
                // Thực thi câu truy vấn
                sqlCommand.ExecuteNonQuery();

                sqlConnection.Close();
            }
        }
    }
}
