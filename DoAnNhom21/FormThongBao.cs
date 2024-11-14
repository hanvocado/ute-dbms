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
    public partial class FormThongBao : Form
    {
        public FormThongBao()
        {
            InitializeComponent();
        }
        private void FormThongBao_Load(object sender, EventArgs e)
        {
            load();
        }
        private void load()
        {
            string queryAllTB = "Select * from ThongBao";
            dataGridViewThongBao.DataSource = Connection.LoadDataTable(queryAllTB);
            string query = "SELECT * FROM PhongBan";
            cbbMaPB.DataSource = Connection.LoadDataTable(query);
            cbbMaPB.DisplayMember = "MaPB";
            string queryId = "SELECT * from ThongBao";
            cbbId.DataSource = Connection.LoadDataTable(queryId);
            cbbId.DisplayMember = "Id";
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_ThemThongBao");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@TieuDe", txtTieuDe.Text);
                cmd.Parameters.AddWithValue("@NoiDung", txtNoiDung.Text);
                cmd.Parameters.AddWithValue("@MaPB", cbbMaPB.Text);
                cmd.Parameters.AddWithValue("@NgayGui", dtpNgayGui.Value);
                Connection.ExecuteCommand(cmd);
                load();
                MessageBox.Show("Thêm thành công!");
                
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi:" + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormThongBao_Load_1(object sender, EventArgs e)
        {
            load();
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_CapNhatThongBao");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@TieuDe", txtTieuDe.Text);
                cmd.Parameters.AddWithValue("@NoiDung", txtNoiDung.Text);
                cmd.Parameters.AddWithValue("@MaPB", cbbMaPB.Text);
                cmd.Parameters.AddWithValue("@NgayGui", dtpNgayGui.Value);
                Connection.ExecuteCommand(cmd);
                load();
                MessageBox.Show("Thêm thành công!");

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi:" + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_XoaThongBao");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", cbbId.Text);
                Connection.ExecuteCommand(cmd);
                load();
                MessageBox.Show("Xóa thành công!");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi:" + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("CapNhatThongBao");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", cbbId.Text);
                cmd.Parameters.AddWithValue("@TieuDe", txtTieuDe.Text);
                cmd.Parameters.AddWithValue("@NoiDung", txtNoiDung.Text);
                cmd.Parameters.AddWithValue("@MaPB", cbbMaPB.Text);
                cmd.Parameters.AddWithValue("@NgayGui", dtpNgayGui.Value);
                Connection.ExecuteCommand(cmd);
                load();
                MessageBox.Show("Sửa thành công!");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi:" + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
