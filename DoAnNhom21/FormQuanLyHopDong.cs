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
    public partial class FormQuanLyHopDong : Form
    {
        public FormQuanLyHopDong()
        {
            InitializeComponent();
            load();
        }
        void load()
        {
            string query = "select * from HopDong";
            this.dataGridViewHopDong.DataSource = Connection.LoadDataTable(query);

        }
        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            
        }
        private void btnThem_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = Connection.getConnection())
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("AddHopDong");
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaNV", this.txtMaNhanVien.Text);
                    cmd.Parameters.AddWithValue("@MaHD", this.txtMaHopDong.Text);
                    cmd.Parameters.AddWithValue("@LuongCoBan", this.txtLuongCoBan.Text);
                    cmd.Parameters.AddWithValue("@NgayBD", this.dtpNgayBd.Value);
                    cmd.Parameters.AddWithValue("@NgayKT", this.dtpNgayKt.Value);
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
                using (SqlCommand command = new SqlCommand("DeleteHopDong"))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@MaHD", this.txtMaHopDong.Text);
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

        private void dataGridViewHopDong_DoubleClick_1(object sender, EventArgs e)
        {
            this.txtMaHopDong.Text = this.dataGridViewHopDong.CurrentRow.Cells[0].Value.ToString();
            this.txtMaNhanVien.Text = this.dataGridViewHopDong.CurrentRow.Cells[1].Value.ToString();
            this.txtLuongCoBan.Text = this.dataGridViewHopDong.CurrentRow.Cells[2].Value.ToString();
            this.dtpNgayBd.Text = this.dataGridViewHopDong.CurrentRow.Cells[3].Value.ToString();
            this.dtpNgayKt.Text = this.dataGridViewHopDong.CurrentRow.Cells[4].Value.ToString();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (SqlCommand command = new SqlCommand("UpdateHopDong"))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@MaHD", this.txtMaHopDong.Text);
                    command.Parameters.AddWithValue("@NgayBD", this.dtpNgayBd.Value);
                    command.Parameters.AddWithValue("@NgayKT", this.dtpNgayKt.Value);
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

        private void btnLamMoi_Click_1(object sender, EventArgs e)
        {
            txtLuongCoBan.Text = txtMaHopDong.Text = txtMaNhanVien.Text = "";
            load();
        }

        private void btnXemChiTiet_Click_1(object sender, EventArgs e)
        {
            FormHopDongNhanVien form = new FormHopDongNhanVien(this.txtMaNhanVien.Text);
            form.ShowDialog();
        }
    }
    }

