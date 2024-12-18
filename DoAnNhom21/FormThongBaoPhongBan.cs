﻿using System;
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
    public partial class FormThongBaoPhongBan : Form
    {
        public string manv;
        public FormThongBaoPhongBan(string manv)
        {
            InitializeComponent();
            this.manv = manv;
        }

        private void btnXemThongBao1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlCommand command = new SqlCommand("SELECT * FROM ft_TruongPhongNhanThongBao(@MaNV)"))
                {
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@MaNV", this.manv);
                    Connection.ExecuteCommand(command);
                    guna2DataGridViewThongBao.Visible = true;
                    guna2DataGridViewThongBao.DataSource = Connection.LoadDataTable(command);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
