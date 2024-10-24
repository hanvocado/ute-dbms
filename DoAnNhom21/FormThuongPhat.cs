using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnNhom21
{
    public partial class FormThuongPhat : Form
    {
        public FormThuongPhat()
        {
            InitializeComponent();
        }
        private void FormThuongPhat_Load(object sender, EventArgs e)
        {
            load();
        }
        private void load()
        {
            string query = "select * from ThuongPhat";
            dataGridViewTP.DataSource = Connection.LoadDataTable(query);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
