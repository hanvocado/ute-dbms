using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DoAnNhom21
{
    public partial class FormChucVu : Form
    {
        public FormChucVu()
        {
            InitializeComponent();
        }
        void load()
        {
            string data = "Select * from ChucVu";
            dataGridViewChucVu.DataSource = Connection.LoadDataTable(data);
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlCommand command = new SqlCommand("AddChucVu"))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@MaCV", this.txtMaCV.Text);
                    command.Parameters.AddWithValue("@TenCV", this.txtTenCV.Text);
                    //command.Parameters.AddWithValue("@PhuCapCV", this.txtPhuCapCV.Text);
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

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaCV.Enabled = true;
            //txtMaCV.Text = txtTenCV.Text = txtPhuCapCV.Text = "";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlCommand command = new SqlCommand("DeleteChucVu"))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@MaCV", this.txtMaCV.Text);
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
                using (SqlCommand command = new SqlCommand("UpdateChucVu"))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@MaCV", this.txtMaCV.Text);
                    command.Parameters.AddWithValue("@TenCV", this.txtTenCV.Text);
                    //command.Parameters.AddWithValue("@PhuCapCV", this.txtPhuCapCV.Text);
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

        private void dataGridViewChucVu_DoubleClick(object sender, EventArgs e)
        {
            txtMaCV.Enabled = false;
            txtMaCV.Text = dataGridViewChucVu.CurrentRow.Cells[0].Value.ToString();
            txtTenCV.Text = dataGridViewChucVu.CurrentRow.Cells[1].Value.ToString();
            //txtPhuCapCV.Text = dataGridViewChucVu.CurrentRow.Cells[2].Value.ToString();
        }

        private void FormChucVu_Load(object sender, EventArgs e)
        {
            load();
        }

    }
}
