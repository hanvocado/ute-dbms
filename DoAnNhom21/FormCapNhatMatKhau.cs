﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace DoAnNhom21
{
    public partial class FormCapNhatMatKhau : Form
    {
        SqlConnection conn;
        string maNV = "";
        public FormCapNhatMatKhau(string MaNV)
        {
            InitializeComponent();
            this.maNV = maNV;
        }

        /*private void btnLogin_Click(object sender, EventArgs e)
        {
           
            string matKhau = txtPassword.Text;

            // Kiểm tra xem TextBox có trống không
            if (string.IsNullOrEmpty(matKhau))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }
            
            Connection.pass = matKhau;
           // Connection.connectString = 
           //     string.Format(@"Data Source=PHUC-PC\MSSQLSERVER22;Initial Catalog=QLNSG21_Data;Encrypt=False;User Id={0};Password={1}", tenDangNhap, matKhau);
           Connection.connectString = Connection.GetConnectionString(tenDangNhap,matKhau);
            
            // Truy vấn dữ liệu từ cơ sở dữ liệu
            using (SqlConnection conn = new SqlConnection(Connection.connectString))
            {
                try
                {
                    conn.Open();
                   
                    // Câu truy vấn SQL để lấy dữ liệu từ bảng taikhoan
                    string query = "SELECT MaLoai FROM taikhoan WHERE tendangnhap = @tendangnhap AND matkhau  = @matkhau";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {

                        cmd.Parameters.AddWithValue("@tendangnhap", tenDangNhap);
                        cmd.Parameters.AddWithValue("@matkhau", matKhau);

                        object result = cmd.ExecuteScalar(); // Lấy giá trị đầu tiên trong kết quả

                        if (result != null) // Nếu tìm thấy bản ghi
                        {

                            string loaiTaiKhoan = result.ToString();
                            SessionInfo.MaNV = tenDangNhap;
                           

                            // Điều hướng sang form tương ứng dựa trên LoaiTaiKhoan
                            if (loaiTaiKhoan == "LTK01")
                            {
                                // Mở Form1
                                FormTrangChuQuanLy form1 = new FormTrangChuQuanLy();
                                form1.Show();
                            }
                            else
                            {
                                // Mở Form2
                                FormTrangChuNhanVien form2 = new FormTrangChuNhanVien(tenDangNhap);
                                form2.Show();
                            }

                            this.Hide(); // Ẩn form đăng nhập
                        }
                        else
                        {
                            // Sai tài khoản hoặc mật khẩu
                            MessageBox.Show("Sai tài khoản hoặc mật khẩu. Vui lòng thử lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   // MessageBox.Show(Connection.connectString);
                }
            }
        }*/

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void guna2ControlBox1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Enter)
            {
                btnUpdate.PerformClick();
                e.SuppressKeyPress = true; // Ngăn chặn âm thanh 'ding' khi nhấn Enter
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
           

            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu mới.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                
                    using (SqlCommand command = new SqlCommand("sp_CapNhatMatKhauDangNhap"))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@TenDangNhap", this.maNV);
                        command.Parameters.AddWithValue("@MatKhau", txtPassword.Text);

                        command.ExecuteNonQuery();
                    }
            }
            catch { 

                MessageBox.Show("Cập nhật mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
         
        }
    }
}