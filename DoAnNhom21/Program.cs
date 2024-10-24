using System;
using System.Windows.Forms;

namespace DoAnNhom21
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FormBaoHiemNV());
<<<<<<< HEAD
            Application.Run(new FormThuongPhat());
=======
            Application.Run(new FormPhongBan());
>>>>>>> 4574ba0ab9d0dcaf1aeaff86f52e09a8f5a7727d
        }
    }
}
