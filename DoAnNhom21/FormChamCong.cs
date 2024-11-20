using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DoAnNhom21
{
    public partial class FormChamCong : Form
    {
        public FormChamCong()
        {
            InitializeComponent();
        }

        private void load()
        {
            SqlCommand cmd = new SqlCommand("sp_GetChamCongByMaNV");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaNV", SessionInfo.MaNV);
            dataGridViewChamCong.DataSource = Connection.LoadDataTable(cmd);

            txtMaNV.Text = SessionInfo.MaNV;
        }

        private void FormChamCong_Load(object sender, EventArgs e)
        {
            load();
        }

        private void btnChamCong_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime today = DateTime.Now;
                string month = today.Month.ToString();
                if (month.Length == 1)
                {
                    month = "0" + month;
                }
                string year = today.Year.ToString();

                using (SqlCommand command = new SqlCommand("sp_AddctChamCong"))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@MaNV", SessionInfo.MaNV);
                    command.Parameters.AddWithValue("@MaThang", month + year);
                    command.Parameters.AddWithValue("@NgayChamCong", today.Day);
                    command.Parameters.AddWithValue("@MaCC", "CC01");
                    Connection.ExecuteCommand(command);
                    load();
                    MessageBox.Show("Chấm công thành công");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
