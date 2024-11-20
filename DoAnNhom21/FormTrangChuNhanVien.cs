
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DoAnNhom21
{
    public partial class FormTrangChuNhanVien : Form
    {
        string maNv;
        public FormTrangChuNhanVien()
        {
            InitializeComponent();
        }
        public FormTrangChuNhanVien(string maNv)
        {
            InitializeComponent();
            this.maNv = maNv;
        }
        private Form currentFormChild;

        private void OpenForm(Form form)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(form);
            pnlContent.Tag = form;
            form.BringToFront();
            form.Show();
        }
        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            OpenForm(new FormThongTinNhanVien(this.maNv));
        }

        private void btnXemLuong_Click(object sender, EventArgs e)
        {
            OpenForm(new FormLuongNhanVien(this.maNv));
        }

        private void btnHopDong_Click(object sender, EventArgs e)
        {
            OpenForm(new FormHopDongNhanVien(this.maNv));
        }

        private void btnChamCong_Click(object sender, EventArgs e)
        {
            OpenForm(new FormChamCong());
        }

        private void btnNghiPhep_Click(object sender, EventArgs e)
        {
            OpenForm(new FormNghiPhep());
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDangNhap form = new FormDangNhap();
            form.Show();
            this.Close();
        }

        private void btnXemThongBao_Click(object sender, EventArgs e)
        {
            OpenForm(new FormThongBaoNhanVien(this.maNv));
           
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            OpenForm(new FormThongBaoPhongBan(this.maNv));
        }
    }
}