using DoAnNhom21;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            using(SqlConnection conn = Connection.getConnection())
            {
                conn.Open();
                string query = "select * from ViewTinhLuong where MaNV = @MaNv and MaThang = @MaThang";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaNV", txtMaNV.Text);
                cmd.Parameters.AddWithValue("@MaThang", this.guna2DateTimePicker1.Value.ToString("MMyyyy"));
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtMaNV.Text = reader["MaNV"].ToString();
                    txtLuongCoBan.Text = reader["LuongCoBan"].ToString();
                    txtBHTN.Text = reader["TienBaoHiemBH03"].ToString();
                    txtBHXH.Text = reader["TienBaoHiemBH02"].ToString();
                    txtBHYT.Text = reader["TienBaoHiemBH01"].ToString();
                    txtPhuCap.Text = reader["TongPhuCap"].ToString();
                    txtGiamTruGiaCanh.Text = reader["GiamTruGiaCanh"].ToString();
                    txtLuongCoBan.Text= reader["LuongCoBan"].ToString();
                    txtLuongThucTe.Text = reader["LuongThucTe"].ToString();
                    txtThucLanh.Text = reader["LuongThucLanh"].ToString(); 
                    txtSoNgayCongChuan.Text = reader["SoNgayCongChuan"].ToString();
                    txtSoNgayLamViec.Text = reader["SoNgayLamViec"].ToString();
                    txtTongBaoHiem.Text = reader["TongTienBaoHiem"].ToString();
                    txtThue.Text = reader["ThueThuNhapCaNhan"].ToString();
                    txtThuongPhat.Text = reader["TongThuongPhat"].ToString(); 
                }
            }
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
