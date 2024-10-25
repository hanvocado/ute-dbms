using System;
using System.Windows.Forms;

namespace DoAnNhom21
{
    public partial class FormTrangChuQuanLy : Form
    {
        public FormTrangChuQuanLy()
        {
            InitializeComponent();
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

        private void guna2ComboBox1_MouseHover(object sender, EventArgs e)
        {

            this.cbbQuanLy.DroppedDown = true;

        }
        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbQuanLy.SelectedItem.ToString() == "Quản lý nhân viên")
            {
                OpenForm(new FormQuanLyNhanVien());
            }
            else if (cbbQuanLy.SelectedItem.ToString() == "Quản lý bảo hiểm")
            {
                OpenForm(new FormQuanLyBaoHiem());
            }
            else if (cbbQuanLy.SelectedItem.ToString() == "Quản lý hợp đồng")
            {
                OpenForm(new FormQuanLyHopDong());

            }
        }
        private void btnDangXuat_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FormDangNhap form = new FormDangNhap();
            form.Show();
        }
    }
}