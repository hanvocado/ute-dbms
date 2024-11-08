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
    public partial class FormThuongPhat : Form
    {
        public FormThuongPhat()
        {
            InitializeComponent();
            
            
        }
        private void FormThuongPhat_Load(object sender, EventArgs e)
        {
            load();
        }
        private void load()
        {
            try
            {
                string query = "SELECT * FROM ThuongPhat";
                SqlCommand cmd = new SqlCommand(query);
                dataGridViewTP.DataSource = Connection.LoadDataTable(cmd);
                string queryAllCTTP = "SELECT * FROM ctThuongPhat";
                dataGridViewCTTP.DataSource = Connection.LoadDataTable(queryAllCTTP);
                string queryMaNV = "SELECT * FROM NhanVien";
                cbbMaNV.DataSource = Connection.LoadDataTable(queryMaNV);
                cbbMaNV.DisplayMember = "MaNV";
                string queryMaTP = "SELECT * FROM ThuongPhat";
                cbbMaTP.DataSource = Connection.LoadDataTable(queryMaTP);
                cbbMaTP.DisplayMember = "MaThuongPhat";
                string queryMaThang = "SELECT * FROM Thang";
                cbbMaThang.DataSource = Connection.LoadDataTable(queryMaThang);
                cbbMaThang.DisplayMember = "MaThang";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlCommand command = new SqlCommand("sp_ThemThuongPhat"))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@MaThuongPhat", this.txtMaTP.Text);
                    command.Parameters.AddWithValue("@Loai", this.cbbLoai.Text);
                    command.Parameters.AddWithValue("@SoTien", this.txtTien.Text);
                    command.Parameters.AddWithValue("@LyDo", this.txtLyDo.Text);
                    Connection.ExecuteCommand(command);
                    MessageBox.Show("Thêm thành công");

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
                using (SqlCommand command = new SqlCommand("sp_XoaThuongPhat"))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@MaThuongPhat", this.txtMaTP.Text);
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


        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlCommand command = new SqlCommand("sp_CapNhatThuongPhat"))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@MaThuongPhat", this.txtMaTP.Text);
                    command.Parameters.AddWithValue("@Loai", this.cbbLoai.Text);
                    command.Parameters.AddWithValue("@SoTien", this.txtTien.Text);
                    command.Parameters.AddWithValue("@LyDo", this.txtLyDo.Text);
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


        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnThemTPNV_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlCommand command = new SqlCommand("sp_ThemctThuongPhat"))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@MaThuongPhat", this.cbbMaTP.Text);
                    command.Parameters.AddWithValue("@MaNV", this.cbbMaNV.Text);
                    command.Parameters.AddWithValue("@MaThang", this.cbbMaThang.Text);
                    command.Parameters.AddWithValue("@NgayThuongPhat", this.txtNgayTP.Text);
                    Connection.ExecuteCommand(command);
                    MessageBox.Show("Thêm thành công");

                    load();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSuaTPNV_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlCommand command = new SqlCommand("sp_CapNhatNgayThangThuongPhat"))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@MaNV", this.cbbMaNV.Text);
                    command.Parameters.AddWithValue("MaThuongPhat", this.cbbMaTP.Text);
                    command.Parameters.AddWithValue("@MaThang", this.cbbMaThang.Text);
                    command.Parameters.AddWithValue("@NgayThuongPhat", this.txtNgayTP.Text);
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
        private void btnXoaTPNV_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlCommand command = new SqlCommand("sp_XoactThuongPhat"))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@MaNV", this.cbbMaNV.Text);
                    command.Parameters.AddWithValue("@MaThang", this.cbbMaThang.Text);
                    command.Parameters.AddWithValue("@NgayThuongPhat", this.txtNgayTP.Text);
                    command.Parameters.AddWithValue("@MaTP", this.cbbMaTP.Text);
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

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaTP.Enabled = true;
            txtMaTP.Text = txtLyDo.Text = cbbLoai.Text = txtTien.Text = " ";
            cbbMaTP.Enabled = true;
            cbbMaTP.Text = cbbMaNV.Text = cbbMaThang.Text = txtNgayTP.Text = " ";
            this.panelFormCTThuongPhat.Visible = false;
            load();
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("sp_LocctThuongPhat"))
                {
                   
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaNV", cbbMaNV.Text);
                    dataGridViewCTTP.DataSource = Connection.LoadDataTable(cmd);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rbThuongPhat_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb != null && rb.Checked)
            {
                MessageBox.Show(rb.Text + " đã được chọn.");
            }
        }

        private void btnXemThuongHayPhat_Click(object sender, EventArgs e)
        {
            try
            {
                string loai = string.Empty;

                if (rbThuong.Checked)
                {
                    loai = "Thưởng";
                }
                else if (rbPhat.Checked)
                {
                    loai = "Phạt";
                }

                using (SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.ft_LocThuongPhatNhanVien(@MaNV, @Loai)"))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@MaNV", cbbMaNV.Text);
                    cmd.Parameters.AddWithValue("@Loai", loai);
                    
                    // Hiển thị FormCTThuongPhat trong Panel
                    this.panelFormCTThuongPhat.Visible = true;
                    FormCTThuongPhat formCTThuongPhat = new FormCTThuongPhat();
                    formCTThuongPhat.TopLevel = false;
                    formCTThuongPhat.FormBorderStyle = FormBorderStyle.None;
                    formCTThuongPhat.Dock = DockStyle.Fill;
                    this.panelFormCTThuongPhat.Controls.Clear();
                    this.panelFormCTThuongPhat.Controls.Add(formCTThuongPhat);
                    formCTThuongPhat.dataGridView1.DataSource = Connection.LoadDataTable(cmd);
                    formCTThuongPhat.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}
