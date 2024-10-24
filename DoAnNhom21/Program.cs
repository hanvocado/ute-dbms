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
<<<<<<< HEAD
            
            Application.Run(new FormThuongPhat());


=======
            //Application.Run(new FormBaoHiemNV());
            Application.Run(new FormThongKeLuong());
>>>>>>> 1fbbd7e1384315f970f8543922ed57884bed64f4
        }
    }
}
