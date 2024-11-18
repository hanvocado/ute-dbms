using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DoAnNhom21
{
    public partial class FormPhuCap : Form
    {
        public FormPhuCap()
        {
            InitializeComponent();
        }
        void load()
        {
            string data1 = "Select * from PhuCap";
            string data2 = "Select * from ctPhuCap";
            dgvPhuCap.DataSource = Connection.LoadDataTable(data1);
            dgvctPhuCap.DataSource = Connection.LoadDataTable(data2);
            string nhanVien = "select MaNV from NhanVien";
            cbbMaNV.DataSource = Connection.LoadDataTable(nhanVien);
            cbbMaNV.ValueMember = "MaNV";
            cbbMaNV.DisplayMember = "MaNV";
            string phuCap = "select MaPhuCap from PhuCap";
            cbbMaPhuCapctPhuCap.DataSource = Connection.LoadDataTable(phuCap);
            cbbMaPhuCapctPhuCap.DisplayMember = "MaPhuCap";
        }

        private void FormPhuCap_Load(object sender, EventArgs e)
        {
            load();
        }

        private void dgvPhuCap_DoubleClick(object sender, EventArgs e)
        {
            txtMaPC.Enabled = false;
            txtMaPC.Text = dgvPhuCap.CurrentRow.Cells[0].Value.ToString();
            txtLoaiPC.Text = dgvPhuCap.CurrentRow.Cells[1].Value.ToString();
        }

        private void dgvctPhuCap_DoubleClick(object sender, EventArgs e)
        {
            if (dgvctPhuCap.CurrentRow != null)
            {
                cbbMaNV.Text = dgvctPhuCap.CurrentRow.Cells[0].Value.ToString(); // Cột 1
                cbbMaPhuCapctPhuCap.Text = dgvctPhuCap.CurrentRow.Cells[1].Value.ToString(); // Cột 2
                string maThang = dgvctPhuCap.CurrentRow.Cells[2].Value.ToString(); // Cột 3
                int ngayPhuCap = Convert.ToInt32(dgvctPhuCap.CurrentRow.Cells[3].Value); // Cột 4
                txtSoTien.Text = dgvctPhuCap.CurrentRow.Cells[4].Value.ToString();
                if (maThang.Length == 6)
                {
                    string month = maThang.Substring(0, 2);
                    string year = maThang.Substring(2, 4);
                    DateTime dateTimeValue = new DateTime(int.Parse(year), int.Parse(month), ngayPhuCap);
                    dtpNgayPhuCap.Value = dateTimeValue;
                }
                else
                {
                    MessageBox.Show("Mã tháng không hợp lệ. Vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Không có dòng dữ liệu nào được chọn.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlCommand command = new SqlCommand("sp_AddPhuCap"))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@MaPhuCap", this.txtMaPC.Text);
                    command.Parameters.AddWithValue("@LoaiPhuCap", this.txtLoaiPC.Text);
                    Connection.ExecuteCommand(command);
                    MessageBox.Show("Thêm phụ cấp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    load();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlCommand command = new SqlCommand("sp_DeletePhuCap"))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@MaPhuCap", this.txtMaPC.Text);
                    Connection.ExecuteCommand(command);
                    MessageBox.Show("Xóa phụ cấp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    load();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlCommand command = new SqlCommand("sp_UpdatePhuCap"))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@MaPhuCap", this.txtMaPC.Text);
                    command.Parameters.AddWithValue("@LoaiPhuCap", this.txtLoaiPC.Text);
                    Connection.ExecuteCommand(command);
                    MessageBox.Show("Sửa phụ cấp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    load();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThemct_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlCommand command = new SqlCommand("sp_AddctPhuCap"))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@MaNV", this.cbbMaNV.Text);
                    command.Parameters.AddWithValue("@MaPhuCap", this.cbbMaPhuCapctPhuCap.Text);
                    command.Parameters.AddWithValue("@SoTien", this.txtSoTien.Text);
                    string maThang = dtpNgayPhuCap.Value.ToString("MMyyyy");
                    string ngayPhuCap = dtpNgayPhuCap.Value.ToString("dd");
                    command.Parameters.AddWithValue("@MaThang", maThang);
                    command.Parameters.AddWithValue("@NgayPhuCap", ngayPhuCap);
                    Connection.ExecuteCommand(command);
                    MessageBox.Show("Thêm phụ cấp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    load();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoact_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlCommand command = new SqlCommand("sp_DeletectPhuCap"))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@MaNV", this.cbbMaNV.Text);
                    command.Parameters.AddWithValue("@MaPhuCap", this.cbbMaPhuCapctPhuCap.Text);
                    string maThang = dtpNgayPhuCap.Value.ToString("MMyyyy");
                    string ngayPhuCap = dtpNgayPhuCap.Value.ToString("dd");
                    command.Parameters.AddWithValue("@MaThang", maThang);
                    command.Parameters.AddWithValue("@NgayPhuCap", ngayPhuCap);
                    Connection.ExecuteCommand(command);
                    MessageBox.Show("Xóa phụ cấp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    load();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSuact_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlCommand command = new SqlCommand("sp_UpdatectPhuCap"))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@MaNV", this.cbbMaNV.Text);
                    command.Parameters.AddWithValue("@MaPhuCap", this.cbbMaPhuCapctPhuCap.Text);
                    string maThang = dtpNgayPhuCap.Value.ToString("MMyyyy");
                    string ngayPhuCap = dtpNgayPhuCap.Value.ToString("dd");
                    command.Parameters.AddWithValue("@MaThang", maThang);
                    command.Parameters.AddWithValue("@NgayPhuCap", ngayPhuCap);
                    command.Parameters.AddWithValue("@SoTien", this.txtSoTien.Text);
                    Connection.ExecuteCommand(command);
                    MessageBox.Show("Sửa phụ cấp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            //.Enabled = true;
            cbbMaNV.Text = cbbMaPhuCapctPhuCap.Text = txtSoTien.Text = "";
        }
    }
}
