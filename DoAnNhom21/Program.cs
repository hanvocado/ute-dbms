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
            Application.Run(new FormPhongBan());
=======
            Application.Run(new FormNghiPhep());
>>>>>>> e5a18f39a6bbc1574bd828bd838a70eb5d3a6a74
        }
    }
}
