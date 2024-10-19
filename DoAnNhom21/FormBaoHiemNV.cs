using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace DoAnNhom21
{
    public partial class FormBaoHiemNV : Form
    {
        public FormBaoHiemNV()
        {
            InitializeComponent();

            string queryMaNV = "Select MaNV from NhanVien";
            List<string> listMaNV = Connection.LoadDataTable(queryMaNV).AsEnumerable()
                           .Select(r => r.Field<string>("MaNV"))
                           .ToList();
            cbbMaNV.Items.Clear();
            foreach (string maNV in listMaNV)
            {
                cbbMaNV.Items.Add(maNV);
            }

            string queryLoaiBH = "Select MaLoai from BaoHiem";
            List<string> listLoaiBH = Connection.LoadDataTable(queryLoaiBH).AsEnumerable()
                           .Select(r => r.Field<string>("MaLoai"))
                           .ToList();
            cbbLoaiBH.Items.Clear();
            foreach (string loai in listLoaiBH)
            {
                cbbLoaiBH.Items.Add(loai);
            }
        }

        private void load()
        {
            string queryAllBH = "Select * from ctBaoHiem";
            dataGridViewBaoHiemNV.DataSource = Connection.LoadDataTable(queryAllBH);
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from ctBaoHiem where MaNV = @maNV");
            cmd.Parameters.AddWithValue("@maNV", this.cbbMaNV.Text);
            dataGridViewBaoHiemNV.DataSource = Connection.LoadDataTable(cmd);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlCommand command = new SqlCommand("INSERT INTO ctBaoHiem (MaNV, MaBH, MaLoai, NgayBD, NgayKT) VALUES (@MaNV, @MaBH, @MaLoai, @NgayBD, @NgayKT)"))
                {
                    command.Parameters.AddWithValue("@MaNV", this.cbbMaNV.Text);
                    command.Parameters.AddWithValue("@MaLoai", this.cbbLoaiBH.Text);
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
                using (SqlCommand command = new SqlCommand("UPDATE ctBaoHiem SET MaLoai=@LoaiBH, NgayBD=@NgayBD, NgayKT=@NgayKT WHERE MaBH=@MaBH"))
                {
                    command.Parameters.AddWithValue("@LoaiBH", this.cbbLoaiBH.Text);
                    command.Parameters.AddWithValue("@MaBH", this.txtMaBH.Text);
                    command.Parameters.AddWithValue("@NgayBD", this.dateTimePickerNgayBD.Value);
                    command.Parameters.AddWithValue("@NgayKT", this.dateTimePickerNgayKT.Value);
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
                using (SqlCommand command = new SqlCommand("DELETE FROM ctBaoHiem WHERE MaBH=@MaBH"))
                {
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
            txtMaBH.Text = dataGridViewBaoHiemNV.CurrentRow.Cells[1].Value.ToString();
            cbbLoaiBH.Text = dataGridViewBaoHiemNV.CurrentRow.Cells[2].Value.ToString();
            dateTimePickerNgayBD.Text = dataGridViewBaoHiemNV.CurrentRow.Cells[3].Value.ToString();
            dateTimePickerNgayKT.Text = dataGridViewBaoHiemNV.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            cbbMaNV.Enabled = true;
            txtMaBH.Enabled = true;
            cbbMaNV.Text = cbbLoaiBH.Text = txtMaBH.Text = dateTimePickerNgayBD.Text = dateTimePickerNgayKT.Text = "";
        }
    }
}
