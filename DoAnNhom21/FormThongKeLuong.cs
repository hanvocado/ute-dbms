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
            SqlCommand cmd = new SqlCommand("sp_GetThang");
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dtThang = Connection.LoadDataTable(cmd);
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

        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            FormChiTietLuong formChiTiet = new FormChiTietLuong();
            formChiTiet.Show(); 
        }

    }
}
