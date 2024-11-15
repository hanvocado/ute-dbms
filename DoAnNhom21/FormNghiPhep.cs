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

            SqlCommand cmd = new SqlCommand("sp_GetThang");
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dtThang = Connection.LoadDataTable(cmd);
            cbbThang.Items.Clear();
            cbbThang.DataSource = new BindingSource(dtThang, null);
            cbbThang.DisplayMember = "MoTa";
            cbbThang.ValueMember = "MaThang";
        }

        private void btnNghiPhep_Click(object sender, System.EventArgs e)
        {
            try
            {
                using (SqlCommand command = new SqlCommand("sp_AddNghiPhep"))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@MaNV", this.txtMaNV.Text);
                    command.Parameters.AddWithValue("@MaThang", this.cbbThang.SelectedValue.ToString());
                    command.Parameters.AddWithValue("@NgayNghiPhep", this.txtNgayNghi.Text);
                    command.Parameters.AddWithValue("@GhiChu", this.txtLyDo.Text);
                    Connection.ExecuteCommand(command);
                    MessageBox.Show("Đăng ký nghỉ thành công");
                    txtNgayNghi.Text = txtLyDo.Text = "";
                    load();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormNghiPhep_Load(object sender, EventArgs e)
        {
            load();
        }

        private void load()
        {
            SqlCommand cmd = new SqlCommand("sp_GetNghiPhepByMaNV");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaNV", SessionInfo.MaNV);
            dataGVoffHistory.DataSource = Connection.LoadDataTable(cmd);
        }
    }
}
