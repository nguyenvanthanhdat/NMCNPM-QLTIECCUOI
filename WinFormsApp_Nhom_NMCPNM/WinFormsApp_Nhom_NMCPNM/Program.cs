using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp_Nhom_NMCPNM
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new form_dangnhap());
            //Application.Run(new form_tiepnhansanh());
            
            //Application.Run(new form_tracuutieccuoi());
            //Application.Run(new form_thongtintaikhoan());
            //Application.Run(new form_thaydoiquydinh());
            //Application.Run(new form_hoadon());
            //Application.Run(new form_dattieccuoi());
            //Application.Run(new form_baocaodoanhso());
            Application.Run(new form_manhinhchinh());

        }
    }
}
