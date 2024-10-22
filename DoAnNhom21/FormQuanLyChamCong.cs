using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DoAnNhom21
{
    public partial class FormQuanLyChamCong : Form
    {
        public FormQuanLyChamCong()
        {
            InitializeComponent();

            string queryMaNV = "Select MaNV from NhanVien";
            DataTable dtMaNV = Connection.LoadDataTable(queryMaNV);
            cbbMaNV.Items.Clear();
            cbbMaNV.DataSource = new BindingSource(dtMaNV, null);
            cbbMaNV.DisplayMember = "MaNV";
            cbbMaNV.ValueMember = "MaNV";

            string queryAllCC = "Select MaCC, MoTa from ChamCong";
            DataTable dtCC = Connection.LoadDataTable(queryAllCC);
            cbbLoaiCong.Items.Clear();
            cbbLoaiCong.DataSource = new BindingSource(dtCC, null);
            cbbLoaiCong.DisplayMember = "MoTa";
            cbbLoaiCong.ValueMember = "MaCC";

            string queryAllThang = "Select MaThang, MoTa from Thang ORDER By MaThang DESC";
            DataTable dtThang = Connection.LoadDataTable(queryAllThang);
            cbbThang.Items.Clear();
            cbbThang.DataSource = new BindingSource(dtThang, null);
            cbbThang.DisplayMember = "MoTa";
            cbbThang.ValueMember = "MaThang";
        }

        private void load()
        {
            SqlCommand cmd = new SqlCommand("sp_GetAllctChamCong");
            cmd.CommandType = CommandType.StoredProcedure;
            dataGVctChamCong.DataSource = Connection.LoadDataTable(cmd);
        }

        private void FormQuanLyChamCong_Load(object sender, EventArgs e)
        {
            load();
        }

        private void dataGVctChamCong_DoubleClick(object sender, EventArgs e)
        {
            cbbMaNV.Enabled = false;
            txtNgayCC.Enabled = false;
            cbbThang.Enabled = false;
            cbbMaNV.Text = dataGVctChamCong.CurrentRow.Cells[0].Value.ToString();
            txtNgayCC.Text = dataGVctChamCong.CurrentRow.Cells[1].Value.ToString();
            cbbThang.Text = dataGVctChamCong.CurrentRow.Cells[2].Value.ToString();
            cbbLoaiCong.Text = dataGVctChamCong.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("sp_GetctChamCong");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaNV", cbbMaNV.Text);
            cmd.Parameters.AddWithValue("@MaThang", cbbThang.SelectedValue ?? DBNull.Value);
            dataGVctChamCong.DataSource = Connection.LoadDataTable(cmd);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlCommand command = new SqlCommand("sp_AddctChamCong"))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@MaNV", cbbMaNV.Text);
                    command.Parameters.AddWithValue("@MaThang", cbbThang.SelectedValue.ToString());
                    command.Parameters.AddWithValue("@NgayChamCong", txtNgayCC.Text);
                    command.Parameters.AddWithValue("@MaCC", cbbLoaiCong.SelectedValue);
                    Connection.ExecuteCommand(command);
                    MessageBox.Show("Chấm công thành công");

                    load();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlCommand command = new SqlCommand("sp_UpdatectChamCong"))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@MaNV", cbbMaNV.Text);
                    command.Parameters.AddWithValue("@MaThang", cbbThang.SelectedValue.ToString());
                    command.Parameters.AddWithValue("@NgayChamCong", txtNgayCC.Text);
                    command.Parameters.AddWithValue("@MaCC", cbbLoaiCong.SelectedValue);
                    Connection.ExecuteCommand(command);
                    MessageBox.Show("Cập nhật thành công");
                    load();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlCommand command = new SqlCommand("sp_DeletectChamCong"))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@MaNV", cbbMaNV.Text);
                    command.Parameters.AddWithValue("@MaThang", cbbThang.SelectedValue);
                    command.Parameters.AddWithValue("@NgayChamCong", txtNgayCC.Text);
                    Connection.ExecuteCommand(command);
                    MessageBox.Show("Xóa thành công");
                    clearFields();
                    load();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            clearFields();
            load();
        }

        private void clearFields()
        {
            cbbMaNV.Enabled = true;
            txtNgayCC.Enabled = true;
            cbbThang.Enabled = true;
            cbbMaNV.Text = txtNgayCC.Text = cbbThang.Text = cbbLoaiCong.Text = "";
            cbbThang.SelectedValue = "";
        }
    }
}
