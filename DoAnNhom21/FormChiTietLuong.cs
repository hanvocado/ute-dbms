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
    public partial class FormChiTietLuong : Form
    {
        public FormChiTietLuong()
        {
            InitializeComponent();
        }
        void load()
        {
                SqlCommand cmd = new SqlCommand("sp_TinhLuongChiTietTatCaNhanVien");
                DataSet dataSet = new DataSet();

                using (SqlConnection connection = new SqlConnection(Connection.connectString))
                {
                    using (SqlCommand command = new SqlCommand("sp_TinhLuongChiTietTatCaNhanVien", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        SqlDataAdapter adapter = new SqlDataAdapter(command);

                        try
                        {
                            connection.Open();
                            adapter.Fill(dataSet);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
                        }
                    }
                }
                if (dataSet.Tables.Count > 0)
                {
                    dataGridViewLuongChiuThue.DataSource = dataSet.Tables[0];
                    dataGridViewLuongThucLanh.DataSource = dataSet.Tables[1];
                    dataGridViewChamCong.DataSource = dataSet.Tables[2];
                    dataGridViewPhuCap.DataSource = dataSet.Tables[3];
                    dataGridViewThuongPhat.DataSource = dataSet.Tables[4];
                    dataGridViewBaoHiem.DataSource = dataSet.Tables[5];

            }
                else
                {
                    MessageBox.Show("Không có dữ liệu trả về.");
                }
        }

        private void FormChiTietLuong_Load(object sender, EventArgs e)
        {
            load();
        }
    }
}
