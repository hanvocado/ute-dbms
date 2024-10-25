using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DoAnNhom21
{
    public partial class FormQuanLyBaoHiem : Form
    {
        public FormQuanLyBaoHiem()
        {
            InitializeComponent();

            string queryMaNV = "Select MaNV from NhanVien";
            DataTable dtMaNV = Connection.LoadDataTable(queryMaNV);
            cbbMaNV.Items.Clear();
            cbbMaNV.DataSource = new BindingSource(dtMaNV, null);
            cbbMaNV.DisplayMember = "MaNV";
            cbbMaNV.ValueMember = "MaNV";

            string queryLoaiBH = "Select MaLoai, TenBH from BaoHiem";
            DataTable dtLoaiBH = Connection.LoadDataTable(queryLoaiBH);
            cbbLoaiBH.Items.Clear();
            cbbLoaiBH.DataSource = new BindingSource(dtLoaiBH, null);
            cbbLoaiBH.DisplayMember = "TenBH";
            cbbLoaiBH.ValueMember = "MaLoai";
        }

        private void load()
        {
            string queryAllBH = "Select * from vw_QuanLyBaoHiem";
            dataGridViewBaoHiemNV.DataSource = Connection.LoadDataTable(queryAllBH);
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("sp_GetctBaoHiemByMaNV");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaNV", this.cbbMaNV.Text);
            dataGridViewBaoHiemNV.DataSource = Connection.LoadDataTable(cmd);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlCommand command = new SqlCommand("sp_AddctBaoHiem"))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@MaNV", this.cbbMaNV.Text);
                    command.Parameters.AddWithValue("@MaLoai", this.cbbLoaiBH.SelectedValue.ToString());
                    command.Parameters.AddWithValue("@MaBH", this.txtMaBH.Text);
                    command.Parameters.AddWithValue("@NgayBD", this.dateTimePickerNgayBD.Value);
                    command.Parameters.AddWithValue("@NgayKT", this.dateTimePickerNgayKT.Value);
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

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlCommand command = new SqlCommand("sp_UpdatectBaoHiem"))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@LoaiBH", this.cbbLoaiBH.SelectedValue.ToString());
                    command.Parameters.AddWithValue("@MaBH", this.txtMaBH.Text);
                    command.Parameters.AddWithValue("@NgayBD", this.dateTimePickerNgayBD.Value);
                    command.Parameters.AddWithValue("@NgayKT", this.dateTimePickerNgayKT.Value);
                    Connection.ExecuteCommand(command);
                    load();
                    MessageBox.Show("Cập nhật thành công");
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
                using (SqlCommand command = new SqlCommand("sp_DeletectBaoHiem"))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@MaBH", this.txtMaBH.Text);
                    Connection.ExecuteCommand(command);
                    MessageBox.Show("Xóa thành công");
                    load();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormBaoHiemNV_Load(object sender, EventArgs e)
        {
            load();
        }

        private void dataGridViewBaoHiemNV_DoubleClick(object sender, EventArgs e)
        {
            cbbMaNV.Enabled = false;
            txtMaBH.Enabled = false;
            cbbMaNV.Text = dataGridViewBaoHiemNV.CurrentRow.Cells[0].Value.ToString();
            txtMaBH.Text = dataGridViewBaoHiemNV.CurrentRow.Cells[4].Value.ToString();
            cbbLoaiBH.Text = dataGridViewBaoHiemNV.CurrentRow.Cells[3].Value.ToString();
            dateTimePickerNgayBD.Text = dataGridViewBaoHiemNV.CurrentRow.Cells[5].Value.ToString();
            dateTimePickerNgayKT.Text = dataGridViewBaoHiemNV.CurrentRow.Cells[6].Value.ToString();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            cbbMaNV.Enabled = true;
            txtMaBH.Enabled = true;
            cbbMaNV.Text = cbbLoaiBH.Text = txtMaBH.Text = dateTimePickerNgayBD.Text = dateTimePickerNgayKT.Text = "";
        }
    }
}
