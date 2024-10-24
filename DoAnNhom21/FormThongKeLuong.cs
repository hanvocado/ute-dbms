using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DoAnNhom21
{
    public partial class FormThongKeLuong : Form
    {
        public FormThongKeLuong()
        {
            InitializeComponent();
        }
        void load()
        {
            string queryAllThang = "SELECT MaThang, MoTa FROM Thang ORDER By MaThang DESC";
            DataTable dtThang = Connection.LoadDataTable(queryAllThang);
            cbbMaThang.Items.Clear();
            cbbMaThang.DataSource = new BindingSource(dtThang, null);
            cbbMaThang.DisplayMember = "MoTa";
            cbbMaThang.ValueMember = "MaThang";
            dgvLuong.AutoGenerateColumns = false;
        }

        private void FormThongKeLuong_Load(object sender, EventArgs e)
        {
            load();
        }

        private void btnXemLuong_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("sp_TinhLuongTheoThang");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaThang", cbbMaThang.SelectedValue);
            dgvLuong.DataSource = Connection.LoadDataTable(cmd);
        }
    }
}
