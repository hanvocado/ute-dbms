using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DoAnNhom21
{
    public partial class FormThongTinHopDong : Form
    {
        SqlConnection conn;
        public FormThongTinHopDong()
        {
            InitializeComponent();
        }

        private void FormThongTinHopDong_Load(object sender, EventArgs e)
        {
            conn = Connection.getConnection();
            conn.Open();
            string data = "Select * from View_HopDongNhanVien";
            dataGridViewThongTinHopDong.DataSource = Connection.LoadDataTable(data);
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {

        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
