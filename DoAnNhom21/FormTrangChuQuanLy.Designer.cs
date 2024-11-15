using System;

namespace DoAnNhom21
{
    partial class FormTrangChuQuanLy
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
            this.components = new System.ComponentModel.Container();
            this.cbbQuanLy = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pnlContent = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnDangXuat = new Guna.UI2.WinForms.Guna2Button();
            this.btnThongKeLuong = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbbQuanLy
            // 
            this.cbbQuanLy.BackColor = System.Drawing.Color.Transparent;
            this.cbbQuanLy.BorderColor = System.Drawing.Color.White;
            this.cbbQuanLy.BorderThickness = 0;
            this.cbbQuanLy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbQuanLy.DropDownHeight = 600;
            this.cbbQuanLy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbQuanLy.DropDownWidth = 450;
            this.cbbQuanLy.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(81)))), ((int)(((byte)(57)))));
            this.cbbQuanLy.FocusedColor = System.Drawing.Color.Empty;
            this.cbbQuanLy.FocusedState.FillColor = System.Drawing.Color.Transparent;
            this.cbbQuanLy.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.cbbQuanLy.ForeColor = System.Drawing.Color.Black;
            this.cbbQuanLy.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbbQuanLy.HoverState.ForeColor = System.Drawing.Color.Transparent;
            this.cbbQuanLy.IntegralHeight = false;
            this.cbbQuanLy.ItemHeight = 50;
            this.cbbQuanLy.Items.AddRange(new object[] {
            "Quản lý",
            "Quản lý nhân viên",
            "Quản lý phòng ban",
            "Quản lý chức vụ",
            "Quản lý phụ cấp",
            "Quản lý hợp đồng",
            "Quản lý thưởng phạt",
            "Quản lý tháng và công",
            "Quản lý bảo hiểm",
            "Quản lý phụ thuộc"});
            this.cbbQuanLy.ItemsAppearance.BackColor = System.Drawing.Color.White;
            this.cbbQuanLy.ItemsAppearance.ForeColor = System.Drawing.Color.Black;
            this.cbbQuanLy.ItemsAppearance.SelectedBackColor = System.Drawing.Color.Silver;
            this.cbbQuanLy.Location = new System.Drawing.Point(394, 13);
            this.cbbQuanLy.Margin = new System.Windows.Forms.Padding(29, 9, 3, 2);
            this.cbbQuanLy.Name = "cbbQuanLy";
            this.cbbQuanLy.Size = new System.Drawing.Size(314, 56);
            this.cbbQuanLy.StartIndex = 1;
            this.cbbQuanLy.TabIndex = 0;
            this.cbbQuanLy.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox1_SelectedIndexChanged);
            this.cbbQuanLy.MouseHover += new System.EventHandler(this.guna2ComboBox1_MouseHover);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.SystemColors.Control;
            this.pnlContent.CustomizableEdges.BottomLeft = false;
            this.pnlContent.CustomizableEdges.BottomRight = false;
            this.pnlContent.CustomizableEdges.TopLeft = false;
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlContent.Location = new System.Drawing.Point(0, 87);
            this.pnlContent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1413, 778);
            this.pnlContent.TabIndex = 2;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(81)))), ((int)(((byte)(57)))));
            this.guna2Panel1.BorderColor = System.Drawing.Color.Black;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.btnThongKeLuong);
            this.guna2Panel1.Controls.Add(this.btnDangXuat);
            this.guna2Panel1.Controls.Add(this.cbbQuanLy);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1413, 84);
            this.guna2Panel1.TabIndex = 4;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDangXuat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDangXuat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDangXuat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDangXuat.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(81)))), ((int)(((byte)(57)))));
            this.btnDangXuat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.ForeColor = System.Drawing.Color.Black;
            this.btnDangXuat.Location = new System.Drawing.Point(1249, 13);
            this.btnDangXuat.Margin = new System.Windows.Forms.Padding(4);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(151, 55);
            this.btnDangXuat.TabIndex = 4;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // btnThongKeLuong
            // 
            this.btnThongKeLuong.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThongKeLuong.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThongKeLuong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThongKeLuong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThongKeLuong.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(81)))), ((int)(((byte)(57)))));
            this.btnThongKeLuong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKeLuong.ForeColor = System.Drawing.Color.Black;
            this.btnThongKeLuong.Location = new System.Drawing.Point(735, 12);
            this.btnThongKeLuong.Margin = new System.Windows.Forms.Padding(4);
            this.btnThongKeLuong.Name = "btnThongKeLuong";
            this.btnThongKeLuong.Size = new System.Drawing.Size(199, 55);
            this.btnThongKeLuong.TabIndex = 6;
            this.btnThongKeLuong.Text = "Thống kê lương";
            this.btnThongKeLuong.Click += new System.EventHandler(this.btnThongKeLuong_Click);
            // 
            // FormTrangChuQuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1413, 865);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.pnlContent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormTrangChuQuanLy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTrangChuQuanLy";
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ComboBox cbbQuanLy;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel pnlContent;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnDangXuat;
        private Guna.UI2.WinForms.Guna2Button btnThongKeLuong;
    }
}