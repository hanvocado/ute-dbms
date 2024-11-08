using DoAnNhom21;
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

namespace DoAnNhom9
{
    public partial class FormQuanLyNguoiPhuThuoc : Form
    {
        public FormQuanLyNguoiPhuThuoc()
        {
            InitializeComponent();
        }

        void load()
        {
            string data = "Select * from NguoiPhuThuoc";
            dataGridViewNguoiPhuThuoc.DataSource = Connection.Docdulieu(data);
            string nhanVien = "select MaNV from NhanVien";
            cbbMaNV.DataSource = Connection.Docdulieu(nhanVien);
            cbbMaNV.ValueMember = "MaNV";
            cbbMaNV.DisplayMember = "MaNV";
        }
        private void dataGridViewNguoiPhuThuoc_DoubleClick(object sender, EventArgs e)
        {
            cbbMaNV.Text = dataGridViewNguoiPhuThuoc.CurrentRow.Cells[0].Value.ToString();
            txtHoTen.Text = dataGridViewNguoiPhuThuoc.CurrentRow.Cells[1].Value.ToString();
            dateTimePickerNgaySinh.Text = dataGridViewNguoiPhuThuoc.CurrentRow.Cells[2].Value.ToString();
            cbbQuanHe.Text = dataGridViewNguoiPhuThuoc.CurrentRow.Cells[3].Value.ToString();
        }

        private void FormNguoiPhuThuoc_Load(object sender, EventArgs e)
        {
            try
            {
                load();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlCommand command = new SqlCommand("sp_AddNguoiPhuThuoc"))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@MaNV", this.cbbMaNV.Text);
                    command.Parameters.AddWithValue("@HoTen", this.txtHoTen.Text);
                    command.Parameters.AddWithValue("@NgaySinh", this.dateTimePickerNgaySinh.Text);
                    command.Parameters.AddWithValue("@QuanHe", this.cbbQuanHe.Text);

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
                using (SqlCommand command = new SqlCommand("sp_DeleteNguoiPhuThuoc"))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@MaNV", this.cbbMaNV.Text);
                    command.Parameters.AddWithValue("@HoTen", this.txtHoTen.Text);

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

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            cbbMaNV.Text = cbbQuanHe.Text = txtHoTen.Text = dateTimePickerNgaySinh.Text = "";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
