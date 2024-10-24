using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DoAnNhom21
{
    public partial class FormHopDongNhanVien : Form
    {
        SqlConnection conn;
        string maNV = "";
        public FormHopDongNhanVien()
        {
            InitializeComponent();
        }
        public FormHopDongNhanVien(string maNV)
        {
            InitializeComponent();
            this.maNV = maNV;
        }
        private void FormHopDongNhanVien_Load(object sender, EventArgs e)
        {
            try
            {
                using (conn = Connection.getConnection())
                {
                    string query = "select * from HopDong where MaNV = @MaNV";
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MaNV", this.maNV);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        txtMaNV.Text = reader["MaNV"].ToString();
                        txtLuongCoBan.Text = reader["LuongCoBan"].ToString();
                        dateTimePickerNgayBD.Text = reader["NgayBD"].ToString();
                        dateTimePickerNgayKT.Text = reader["NgayKT"].ToString();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}