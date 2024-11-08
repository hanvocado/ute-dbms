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
        public string MaThang { get; set; }
        void load()
        {
                SqlCommand cmd = new SqlCommand("sp_TinhLuongTheoThangTraVeNhieuBang");
                string connectionString = Properties.Settings.Default.ConnectionString;
                DataSet dataSet = new DataSet();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand("sp_TinhLuongTheoThangTraVeNhieuBang", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@MaThang", MaThang);
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
                    dataGridViewChamCong.DataSource = dataSet.Tables[1];
                    dataGridViewPhuCapThang.DataSource = dataSet.Tables[2];
                    dataGridViewThuongPhatThang.DataSource = dataSet.Tables[3];
                    dataGridViewBaoHiem.DataSource = dataSet.Tables[4];

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
