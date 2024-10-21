using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DoAnNhom21
{
    public partial class FormNghiPhep : Form
    {
        public FormNghiPhep()
        {
            InitializeComponent();

            txtMaNV.Text = SessionInfo.MaNV;

            string queryAllThang = "Select MaThang, MoTa from Thang";
            DataTable dtThang = Connection.LoadDataTable(queryAllThang);
            cbbThang.Items.Clear();
            cbbThang.DataSource = new BindingSource(dtThang, null);
            cbbThang.DisplayMember = "MoTa";
            cbbThang.ValueMember = "MaThang";
        }

        private void btnNghiPhep_Click(object sender, System.EventArgs e)
        {
            try
            {
                using (SqlCommand command = new SqlCommand("INSERT INTO NghiPhep (MaNV, MaThang, NgayNghiPhep, GhiChu) VALUES (@MaNV, @MaThang, @NgayNghiPhep, @GhiChu)"))
                {
                    command.Parameters.AddWithValue("@MaNV", this.txtMaNV.Text);
                    command.Parameters.AddWithValue("@MaThang", this.cbbThang.SelectedValue.ToString());
                    command.Parameters.AddWithValue("@NgayNghiPhep", this.txtNgayNghi.Text);
                    command.Parameters.AddWithValue("@GhiChu", this.txtLyDo.Text);
                    Connection.ExecuteCommand(command);
                    MessageBox.Show("Đăng ký nghỉ thành công");
                    txtMaNV.Text = cbbThang.Text = txtNgayNghi.Text = txtLyDo.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
