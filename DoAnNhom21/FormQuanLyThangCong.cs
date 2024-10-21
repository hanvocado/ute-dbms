using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DoAnNhom21
{
    public partial class FormQuanLyThangCong : Form
    {
        public FormQuanLyThangCong()
        {
            InitializeComponent();
        }

        private void load()
        {
            string queryAllThang = "Select * from Thang";
            dataGVThang.DataSource = Connection.LoadDataTable(queryAllThang);

            string queryAllCong = "Select * from ChamCong";
            dataGVCong.DataSource = Connection.LoadDataTable(queryAllCong);
        }

        private void FormQuanLyThangCong_Load(object sender, EventArgs e)
        {
            load();
        }

        private void btnThemThang_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlCommand command = new SqlCommand("INSERT INTO Thang (MaThang, MoTa, SoNgayCongChuan) VALUES (@MaThang, @MoTa, @SoNgayCongChuan)"))
                {
                    command.Parameters.AddWithValue("@MaThang", this.txtMaThang.Text);
                    command.Parameters.AddWithValue("@MoTa", this.txtMoTa.Text);
                    command.Parameters.AddWithValue("@SoNgayCongChuan", this.txtSoNgayCong.Text);
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

        private void dataGVThang_DoubleClick(object sender, EventArgs e)
        {
            txtMaThang.Enabled = false;
            txtMaThang.Text = dataGVThang.CurrentRow.Cells[0].Value.ToString();
            txtMoTa.Text = dataGVThang.CurrentRow.Cells[1].Value.ToString();
            txtSoNgayCong.Text = dataGVThang.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnSuaThang_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlCommand command = new SqlCommand("UPDATE Thang SET MoTa=@MoTa, SoNgayCongChuan=@SoNgayCong WHERE MaThang=@MaThang"))
                {
                    command.Parameters.AddWithValue("@MoTa", this.txtMoTa.Text);
                    command.Parameters.AddWithValue("@SoNgayCong", this.txtSoNgayCong.Text);
                    command.Parameters.AddWithValue("@MaThang", this.txtMaThang.Text);
                    Connection.ExecuteCommand(command);
                    MessageBox.Show("Cập nhật thành công");
                    txtMaThang.Enabled = true;
                    load();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThemCong_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlCommand command = new SqlCommand("INSERT INTO ChamCong (MaCC, MoTa, HeSo) VALUES (@MaCC, @MoTa, @HeSo)"))
                {
                    command.Parameters.AddWithValue("@MaCC", this.txtMaCC.Text);
                    command.Parameters.AddWithValue("@MoTa", this.txtMoTaCong.Text);
                    command.Parameters.AddWithValue("@HeSo", this.txtHeSo.Text);
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

        private void btnSuaCong_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlCommand command = new SqlCommand("UPDATE ChamCong SET MoTa=@MoTa, HeSo=@HeSo WHERE MaCC=@MaCC"))
                {
                    command.Parameters.AddWithValue("@MoTa", this.txtMoTaCong.Text);
                    command.Parameters.AddWithValue("@HeSo", this.txtHeSo.Text);
                    command.Parameters.AddWithValue("@MaCC", this.txtMaCC.Text);
                    Connection.ExecuteCommand(command);
                    MessageBox.Show("Cập nhật thành công");
                    txtMaCC.Enabled = true;
                    load();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGVCong_DoubleClick(object sender, EventArgs e)
        {
            txtMaCC.Enabled = false;
            txtMaCC.Text = dataGVCong.CurrentRow.Cells[0].Value.ToString();
            txtMoTaCong.Text = dataGVCong.CurrentRow.Cells[1].Value.ToString();
            txtHeSo.Text = dataGVCong.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnLamMoiCong_Click(object sender, EventArgs e)
        {
            txtMaCC.Enabled = true;
            txtMaCC.Text = txtMoTaCong.Text = txtHeSo.Text = "";
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaThang.Enabled = true;
            txtMaThang.Text = txtMoTa.Text = txtSoNgayCong.Text = "";
        }
    }
}
