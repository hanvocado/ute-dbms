﻿using System;
using System.Collections;
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
    public partial class FormPhongBan : Form
    {
        

        public FormPhongBan()
        {
            InitializeComponent();
           
        }
        private void FormPhongBan_Load(object sender, EventArgs e)
        {
            load();
        }
        private void load()
        {
            string queryAllPB = "Select * from PhongBan";
            dataGridViewPhongBan.DataSource = Connection.LoadDataTable(queryAllPB);
            string queryMaTrP = "Select * from NhanVien";
            cbbMaTrP.DataSource = Connection.LoadDataTable(queryMaTrP);
            cbbMaTrP.DisplayMember = "MaNV";
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlCommand command = new SqlCommand("sp_ThemPhongBan"))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@MaPB", this.txtMaPB.Text);
                    command.Parameters.AddWithValue("@TenPB", this.txtTenPB.Text);
                    command.Parameters.AddWithValue("@SDT", this.txtSDT.Text);
                    command.Parameters.AddWithValue("@MaTrP", this.cbbMaTrP.Text);

                    Connection.ExecuteCommand(command);
                    MessageBox.Show("Thêm thành công!");
                    load();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi:" + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlCommand command = new SqlCommand("sp_CapNhatPhongBan"))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@MaPB", this.txtMaPB.Text);
                    command.Parameters.AddWithValue("@TenPB", this.txtTenPB.Text);
                    command.Parameters.AddWithValue("@SDT", this.txtSDT.Text);
                    command.Parameters.AddWithValue("@MaTrP", this.cbbMaTrP.Text);

                    Connection.ExecuteCommand(command);
                    MessageBox.Show("Sửa thành công!");
                    load();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi:" + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlCommand command = new SqlCommand("sp_XoaPhongBan"))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@MaPB", this.txtMaPB.Text);
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
        
        private void btnXemThongTin_Click(object sender, EventArgs e)
        {

            try
            {
                using (SqlCommand command = new SqlCommand("SELECT * FROM dbo.ft_XemChiTietPhongBan()"))
                {
                    
                    command.CommandType = CommandType.Text;
                    Connection.ExecuteCommand(command);

                    FormXemChiTietPhongBan formXemChiTietPhongBan = new FormXemChiTietPhongBan();

                    formXemChiTietPhongBan.dataGridViewTTPB.DataSource = Connection.LoadDataTable(command);
                    
                    formXemChiTietPhongBan.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaPB.Enabled = true;
            txtMaPB.Text = txtTenPB.Text = cbbMaTrP.Text = txtSDT.Text = " ";
        }
        

        private void btnThongBao_Click(object sender, EventArgs e)
        {
            FormThongBao formTB = new FormThongBao();
            
            formTB.Show(); 

        }

        private void dataGridViewPhongBan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridViewPhongBan.Rows[e.RowIndex];
            txtMaPB.Text = row.Cells[0].Value.ToString();
            txtTenPB.Text = row.Cells[1].Value.ToString();
            txtSDT.Text = row.Cells[2].Value.ToString();
            cbbMaTrP.Text = row.Cells[3].Value.ToString();

        }
    }
}
