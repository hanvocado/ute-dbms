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
            string data1 = "Select * from v_QuanLyLuong";
            dgvLuong.DataSource = Connection.LoadDataTable(data1);
            string queryAllThang = "SELECT MaThang, MoTa FROM Thang ORDER By MaThang DESC";
            DataTable dtThang = Connection.LoadDataTable(queryAllThang);
            cbbMaThang.Items.Clear();
            cbbMaThang.DataSource = new BindingSource(dtThang, null);
            cbbMaThang.DisplayMember = "MoTa";
            cbbMaThang.ValueMember = "MaThang";
        }

        private void FormThongKeLuong_Load(object sender, EventArgs e)
        {
            load();
        }

        private void btnXemLuong_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM v_QuanLyLuong WHERE MaThang = @MaThang");
                cmd.Parameters.AddWithValue("@MaThang", this.cbbMaThang.SelectedValue.ToString());

                dgvLuong.DataSource = Connection.LoadDataTable(cmd);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi khi lọc dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
