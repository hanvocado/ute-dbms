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

namespace DoAnNhom21
{
    public partial class FormCapNhatMatKhau : Form
    {
        public FormCapNhatMatKhau()
        {
            InitializeComponent();
            string query = "select ManV from nhanvien ";
            this.cbbMaNV.DataSource = Connection.LoadDataTable(query);
            this.cbbMaNV.DisplayMember = "MaNV";
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlCommand command = new SqlCommand("sp_UpdateTaiKhoan"))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@TenDangNhap", this.cbbMaNV.SelectedValue.ToString());
                    command.Parameters.AddWithValue("@MatKhau", this.txtMatKhauMoi.Text);
                    command.Parameters.AddWithValue("@NhapLaiMatKhau ", this.txtNhapLaiMatkhau.Text);

                    Connection.ExecuteCommand(command);
  
                     Connection.pass = txtMatKhauMoi.Text;
                    MessageBox.Show("Cap Nhat Mat Khau Thang Cong");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
