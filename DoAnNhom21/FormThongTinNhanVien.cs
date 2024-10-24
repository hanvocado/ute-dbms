using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DoAnNhom21
{
    public partial class FormThongTinNhanVien : Form
    {
        SqlConnection conn;
        public FormThongTinNhanVien(string nv)
        {
            InitializeComponent();
            txtMaNV.Text = nv;
        }
        private void dateTimePickerNgaySinh_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerNgaySinh.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormThongTinNhanVien_Load(object sender, EventArgs e)
        {
            conn = Connection.getConnection();
            conn.Open();
            string data = "Select * from view_ThongTinNhanVien where MaNV = '" + txtMaNV.Text + "'";
            SqlCommand cmd = new SqlCommand(data, conn);

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                txtMaNV.Text = reader["MaNV"].ToString();
                txtEmail.Text = reader["Email"].ToString();
                txtChucVu.Text = reader["TenChucVu"].ToString();
                txtDiaChi.Text = reader["DiaChi"].ToString();
                txtGioiTinh.Text = reader["GioiTinh"].ToString();
                //dateTimePickerNgaySinh.Text = reader["NamSinh"].ToString();
                txtHo.Text = reader["Ho"].ToString();
                txtTen.Text = reader["Ten"].ToString();
                txtPhongBan.Text = reader["TenPhongBan"].ToString();
                txtCCCD.Text = reader["CCCD"].ToString();
                txtSDT.Text = reader["SDT"].ToString();
            }
            reader.Close();

            conn.Close();
        }
    }
}
