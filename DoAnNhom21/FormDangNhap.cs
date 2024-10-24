using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DoAnNhom21
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string tenDangNhap = txtMaNhanVien.Text;
            string matKhau = txtPassword.Text;

            // Kiểm tra xem TextBox có trống không
            if (string.IsNullOrEmpty(tenDangNhap) || string.IsNullOrEmpty(matKhau))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Truy vấn dữ liệu từ cơ sở dữ liệu
            using (SqlConnection conn = Connection.getConnection())
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
                            else if (loaiTaiKhoan == "LTK02")
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
                }
            }
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}