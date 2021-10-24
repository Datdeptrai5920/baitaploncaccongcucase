
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTruongMamNon
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
            //Application.Run(new frm_ThongTinTre());
            //Application.Run(new frm_ThemHocSinh());
            Application.Run(new frm_DangNhap());
            //Application.Run(new frm_KhoiLop());
            //Application.Run(new frm_ThongTinGiaoVien());
            //Application.Run(new frm_ThemGiaoVien_update_());
            //Application.Run(new frm_PhanCong());
            //Application.Run(new frm_BuaAn());
            //Application.Run(new frm_TaiKhoan());
            //Application.Run(new frm_Report_HocPhi());
            //Application.Run(new frm_ThemGiaoVien());
            //Application.Run(new frm_Report_BuaAn());
        }
    }
}
