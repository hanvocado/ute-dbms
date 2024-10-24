using System.Drawing;
using System.Windows.Forms;

namespace ProjectCuoiKy_QLNSG21
{
    partial class FormThongKeLuong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btnXemLuong = new Guna.UI2.WinForms.Guna2GradientButton();
            cbbMaThang = new Guna.UI2.WinForms.Guna2ComboBox();
            dgvLuong = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvLuong).BeginInit();
            SuspendLayout();
            // 
            // btnXemLuong
            // 
            btnXemLuong.BorderRadius = 30;
            btnXemLuong.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            btnXemLuong.CustomizableEdges = customizableEdges1;
            btnXemLuong.DisabledState.BorderColor = Color.DarkGray;
            btnXemLuong.DisabledState.CustomBorderColor = Color.DarkGray;
            btnXemLuong.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnXemLuong.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            btnXemLuong.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnXemLuong.Font = new Font("Segoe UI", 9F);
            btnXemLuong.ForeColor = Color.White;
            btnXemLuong.Location = new Point(288, 62);
            btnXemLuong.Name = "btnXemLuong";
            btnXemLuong.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnXemLuong.Size = new Size(72, 63);
            btnXemLuong.TabIndex = 1;
            btnXemLuong.Text = "Lọc";
            btnXemLuong.Click += btnXemLuong_Click;
            // 
            // cbbMaThang
            // 
            cbbMaThang.BackColor = Color.Transparent;
            cbbMaThang.CustomizableEdges = customizableEdges3;
            cbbMaThang.DrawMode = DrawMode.OwnerDrawFixed;
            cbbMaThang.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbMaThang.FocusedColor = Color.FromArgb(94, 148, 255);
            cbbMaThang.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbbMaThang.Font = new Font("Segoe UI", 10F);
            cbbMaThang.ForeColor = Color.FromArgb(68, 88, 112);
            cbbMaThang.ItemHeight = 30;
            cbbMaThang.Location = new Point(34, 78);
            cbbMaThang.Name = "cbbMaThang";
            cbbMaThang.ShadowDecoration.CustomizableEdges = customizableEdges4;
            cbbMaThang.Size = new Size(212, 36);
            cbbMaThang.TabIndex = 2;
            // 
            // dgvLuong
            // 
            dgvLuong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLuong.Location = new Point(34, 157);
            dgvLuong.Name = "dgvLuong";
            dgvLuong.RowHeadersWidth = 51;
            dgvLuong.Size = new Size(982, 576);
            dgvLuong.TabIndex = 3;
            // 
            // ThongKeLuong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1042, 758);
            Controls.Add(dgvLuong);
            Controls.Add(cbbMaThang);
            Controls.Add(btnXemLuong);
            Name = "FormThongKeLuong";
            Text = "FormThongKeLuong";
            Load += FormThongKeLuong_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLuong).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Guna.UI2.WinForms.Guna2GradientButton btnXemLuong;
        private Guna.UI2.WinForms.Guna2ComboBox cbbMaThang;
        private DataGridView dgvLuong;
    }
}