using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DoAnNhom21
{
    public partial class FormQuanLyNhanVien : Form
    {
        string tempMaNV;
        SqlConnection conn;

        public FormQuanLyNhanVien()
        {
            InitializeComponent();
        }

        void load()
        {
            //Load dữ liệu từ bảng Nhân viên lên DataGridView
            string data = "Select * from NhanVien";
            dataGridViewNhanVien.DataSource = Connection.LoadDataTable(data);

            //Load dữ liệu lên combobox Phòng ban
            string phongban = "select MaPB, TenPB from PhongBan"; // Chọn cột MaPB và TenPB
            cbbPhongBan.DataSource = Connection.LoadDataTable(phongban);
            cbbPhongBan.ValueMember = "MaPB"; // Chọn MaPB làm giá trị
            cbbPhongBan.DisplayMember = "TenPB"; // Hiển thị TenPB trong ComboBox

            //Load dữ liệu lên combobox Chức vụ
            string chucvu = "select MaCV, TenCV from ChucVu"; // Chọn cột MaPB và TenPB
            cbbChucVu.DataSource = Connection.LoadDataTable(chucvu);
            cbbChucVu.ValueMember = "MaCV";
            cbbChucVu.DisplayMember = "TenCV";
        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            load();
        }
        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {

        }

        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            FormThongTinNhanVien formThongTinNhanVien = new FormThongTinNhanVien(tempMaNV);
            formThongTinNhanVien.ShowDialog();
        }
        private void FormQuanLyNhanVien_Load(object sender, EventArgs e)
        {
            load();
        }

        private void btnXemChiTiet_Click_1(object sender, EventArgs e)
        {
            FormThongTinNhanVien formThongTinNhanVien = new FormThongTinNhanVien(tempMaNV);
            formThongTinNhanVien.ShowDialog();
        }

        private void dataGridViewNhanVien_DoubleClick_1(object sender, EventArgs e)
        {
            txtMaNhanVien.Enabled = false;
            txtMaNhanVien.Text = dataGridViewNhanVien.CurrentRow.Cells[0].Value.ToString();
            txtHoVaTenLot.Text = dataGridViewNhanVien.CurrentRow.Cells[1].Value.ToString();
            txtTen.Text = dataGridViewNhanVien.CurrentRow.Cells[2].Value.ToString();
            cbbGioiTinh.Text = dataGridViewNhanVien.CurrentRow.Cells[3].Value.ToString();
            dateTimePickerNgaySinh.Text = dataGridViewNhanVien.CurrentRow.Cells[4].Value.ToString();
            txtDiaChi.Text = dataGridViewNhanVien.CurrentRow.Cells[5].Value.ToString();
            txtCCCD.Text = dataGridViewNhanVien.CurrentRow.Cells[6].Value.ToString();
            txtEmail.Text = dataGridViewNhanVien.CurrentRow.Cells[7].Value.ToString();
            txtSDT.Text = dataGridViewNhanVien.CurrentRow.Cells[8].Value.ToString();
            cbbPhongBan.Text = dataGridViewNhanVien.CurrentRow.Cells[9].Value.ToString();
            cbbChucVu.Text = dataGridViewNhanVien.CurrentRow.Cells[10].Value.ToString();
            txtHopDong.Text = dataGridViewNhanVien.CurrentRow.Cells[11].Value.ToString();
            tempMaNV = txtMaNhanVien.Text;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = Connection.getConnection())
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("AddNhanVien");
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaNV", this.txtMaNhanVien.Text);
                    cmd.Parameters.AddWithValue("@Ho", this.txtHoVaTenLot.Text);
                    cmd.Parameters.AddWithValue("@Ten", this.txtTen.Text);
                    cmd.Parameters.AddWithValue("@GioiTinh", this.cbbGioiTinh.Text);
                    cmd.Parameters.AddWithValue("@NgaySinh", this.dateTimePickerNgaySinh.Value);
                    cmd.Parameters.AddWithValue("@DiaChi", this.txtDiaChi.Text);
                    cmd.Parameters.AddWithValue("@CCCD", this.txtCCCD.Text);
                    cmd.Parameters.AddWithValue("@Email", this.txtEmail.Text);
                    cmd.Parameters.AddWithValue("@SDT", this.txtSDT.Text);
                    cmd.Parameters.AddWithValue("@MaPB", this.cbbPhongBan.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@MaCV", this.cbbChucVu.SelectedValue.ToString());

                    cmd.Connection = conn;
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Thêm thành công");

                    load();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (SqlCommand command = new SqlCommand("DeleteNhanVien"))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@MaNV", this.txtMaNhanVien.Text);
                    Connection.ExecuteCommand(command);
                    MessageBox.Show("Xoá thành công");
                    load();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLamMoi_Click_1(object sender, EventArgs e)
        {
            txtMaNhanVien.Enabled = true;
            txtMaNhanVien.Text = txtHoVaTenLot.Text = cbbGioiTinh.Text = txtTen.Text
             = txtCCCD.Text = txtEmail.Text = txtSDT.Text = txtDiaChi.Text = dateTimePickerNgaySinh.Text
             = cbbPhongBan.Text = cbbChucVu.Text = null;
            load();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnTimKiem_Click_2(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Connection.connectString))
                {
                    string TimKiemNV = "SELECT * FROM TimKiemNhanVien(@MaNV)";

                    using (SqlCommand command = new SqlCommand(TimKiemNV, connection))
                    {
                        command.Parameters.AddWithValue("@MaNV", txtTimKiemMaNV.Text);
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                txtMaNhanVien.Text = reader["MaNV"].ToString();
                                txtHoVaTenLot.Text = reader["Ho"].ToString();
                                txtTen.Text = reader["Ten"].ToString();
                                cbbGioiTinh.Text = reader["GioiTinh"].ToString();
                                dateTimePickerNgaySinh.Value = Convert.ToDateTime(reader["NgaySinh"]);
                                txtDiaChi.Text = reader["DiaChi"].ToString();
                                txtCCCD.Text = reader["CCCD"].ToString();
                                txtEmail.Text = reader["Email"].ToString();
                                txtSDT.Text = reader["SDT"].ToString();
                                cbbPhongBan.Text = reader["MaPB"].ToString();
                                cbbChucVu.Text = reader["MaCV"].ToString();
                                txtHopDong.Text = reader["MaHD"].ToString();


                                tempMaNV = txtMaNhanVien.Text;
                            }
                            else
                            {
                                MessageBox.Show("Không tìm thấy mã nhân viên này");
                                return;
                            }
                        }
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            this.dataGridViewNhanVien.DataSource = dt;
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (SqlCommand command = new SqlCommand("UpdateNhanVien"))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@MaNV", this.txtMaNhanVien.Text);
                    command.Parameters.AddWithValue("@Ho", this.txtHoVaTenLot.Text);
                    command.Parameters.AddWithValue("@Ten", this.txtTen.Text);
                    command.Parameters.AddWithValue("@GioiTinh", this.cbbGioiTinh.Text);
                    command.Parameters.AddWithValue("@NgaySinh", this.dateTimePickerNgaySinh.Value);
                    command.Parameters.AddWithValue("@DiaChi", this.txtDiaChi.Text);
                    command.Parameters.AddWithValue("@CCCD", this.txtCCCD.Text);
                    command.Parameters.AddWithValue("@Email", this.txtEmail.Text);
                    command.Parameters.AddWithValue("@SDT", this.txtSDT.Text);
                    command.Parameters.AddWithValue("@MaPB", this.cbbPhongBan.SelectedValue.ToString());
                    command.Parameters.AddWithValue("@MaCV", this.cbbChucVu.SelectedValue.ToString());
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
    }
}