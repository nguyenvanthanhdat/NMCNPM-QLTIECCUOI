using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
 
namespace QuanLyTiecCuoi
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new form_tracuutieccuoi());// Đã hoàn thành
            //Application.Run(new form_thongtinsanh());// Bị thay đổi
            //Application.Run(new form_thongtintaikhoan());// Đã hoàn thành
            //Application.Run(new form_thaydoimonan());// Đã hoàn thành
            //Application.Run(new form_thaydoidichvu());// Đã hoàn thành
            //Application.Run(new form_thaydoiloaisanh());// Dẫ hoàn thành
            //Application.Run(new form_thaydoica());
            Application.Run(new form_thaydoiphat());
        }
    }
}
