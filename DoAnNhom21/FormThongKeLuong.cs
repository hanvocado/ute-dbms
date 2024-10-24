using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DoAnNhom21;

namespace ProjectCuoiKy_QLNSG21
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
            //string data2 = "Select * from ctPhuCap";
            //dgvPhuCap.DataSource = Connection.Docdulieu(data1);
            dgvLuong.DataSource = Connection.Docdulieu(data1);
            string maThang = "select MaThang from Thang";
            cbbMaThang.DataSource = Connection.Docdulieu(maThang);
            cbbMaThang.ValueMember = "MaThang";
            cbbMaThang.DisplayMember = "MaThang";
            //string data2 = "Select * from PhuCap";
            //dgvPhuCap.DataSource = Connection.Docdulieu(data2);
        }

        private void FormThongKeLuong_Load(object sender, EventArgs e)
        {
            load();
        }

        private void btnXemLuong_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy giá trị MaThang từ ComboBox
                string maThang = cbbMaThang.Text;

                // Tạo truy vấn SQL có điều kiện WHERE dựa trên MaThang
                string query = $"SELECT * FROM v_QuanLyLuong WHERE MaThang = '{maThang}'";

                // Đổ dữ liệu vào DataGridView từ kết quả truy vấn
                dgvLuong.DataSource = Connection.Docdulieu(query);


            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi khi lọc dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
