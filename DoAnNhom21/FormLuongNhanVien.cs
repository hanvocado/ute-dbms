using DoAnNhom21;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DoAnNhom9
{
    public partial class FormLuongNhanVien : Form
    {
        SqlConnection conn;
        public FormLuongNhanVien(string tk)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeComponent();
            this.Resize += YourForm_Resize;
            txtMaNV.Text = tk;
            this.guna2DateTimePicker1.Format = DateTimePickerFormat.Custom;
            guna2DateTimePicker1.CustomFormat = "MM/yyyy";
        }
        private void YourForm_Resize(object sender, EventArgs e)
        {
            // Nếu form được thay đổi kích thước, khôi phục lại kích thước ban đầu
            this.WindowState = FormWindowState.Normal;
        }


        private void btnTinhLuong_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("sp_TinhLuongTheoThang");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaNV", SessionInfo.MaNV);
            cmd.Parameters.AddWithValue("@MaThang", this.guna2DateTimePicker1.Value.ToString("MMyyyy"));
            DataTable dt = Connection.LoadDataTable(cmd);
            DataRow reader = dt.Rows[0];
            txtMaNV.Text = reader["MaNV"].ToString();
            txtLuongCoBan.Text = reader["LuongCoBan"].ToString();
            txtBHTN.Text = reader["BH03"].ToString();
            txtBHXH.Text = reader["BH02"].ToString();
            txtBHYT.Text = reader["BH01"].ToString();
            txtPhuCap.Text = reader["TongPhuCap"].ToString();
            txtGiamTruGiaCanh.Text = reader["GiamTruGiaCanh"].ToString();
            txtLuongThucTe.Text = reader["LuongChiuThue"].ToString();
            txtThucLanh.Text = reader["LuongThucLanh"].ToString();
            txtSoNgayCongChuan.Text = reader["SoNgayCongChuan"].ToString();
            txtSoNgayLamViec.Text = reader["SoNgayCong"].ToString();
            txtTongBaoHiem.Text = reader["TongTienBaoHiem"].ToString();
            txtThue.Text = reader["Thue"].ToString();
            txtThuongPhat.Text = reader["TongThuongPhat"].ToString();
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }
    }
}