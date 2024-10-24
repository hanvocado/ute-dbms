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
            this.guna2ComboBox2 = new Guna.UI2.WinForms.Guna2ComboBox();
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
            this.cbbQuanLy.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            "Quản lý bảo hiểm",
            "Quản lý phụ thuộc"});
            this.cbbQuanLy.ItemsAppearance.BackColor = System.Drawing.Color.White;
            this.cbbQuanLy.ItemsAppearance.ForeColor = System.Drawing.Color.Black;
            this.cbbQuanLy.ItemsAppearance.SelectedBackColor = System.Drawing.Color.Silver;
            this.cbbQuanLy.Location = new System.Drawing.Point(237, 10);
            this.cbbQuanLy.Margin = new System.Windows.Forms.Padding(22, 7, 2, 2);
            this.cbbQuanLy.Name = "cbbQuanLy";
            this.cbbQuanLy.Size = new System.Drawing.Size(241, 56);
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
            this.pnlContent.Location = new System.Drawing.Point(0, 72);
            this.pnlContent.Margin = new System.Windows.Forms.Padding(2);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1060, 712);
            this.pnlContent.TabIndex = 2;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(81)))), ((int)(((byte)(57)))));
            this.guna2Panel1.BorderColor = System.Drawing.Color.Black;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.btnDangXuat);
            this.guna2Panel1.Controls.Add(this.guna2ComboBox2);
            this.guna2Panel1.Controls.Add(this.cbbQuanLy);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1060, 72);
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
            this.btnDangXuat.Location = new System.Drawing.Point(935, 21);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(113, 45);
            this.btnDangXuat.TabIndex = 4;
            this.btnDangXuat.Text = "Đăng xuất";
            // 
            // guna2ComboBox2
            // 
            this.guna2ComboBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox2.BorderColor = System.Drawing.Color.White;
            this.guna2ComboBox2.BorderThickness = 0;
            this.guna2ComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox2.DropDownHeight = 600;
            this.guna2ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox2.DropDownWidth = 600;
            this.guna2ComboBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(81)))), ((int)(((byte)(57)))));
            this.guna2ComboBox2.FocusedColor = System.Drawing.Color.Empty;
            this.guna2ComboBox2.FocusedState.FillColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2ComboBox2.ForeColor = System.Drawing.Color.Black;
            this.guna2ComboBox2.HoverState.ForeColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox2.IntegralHeight = false;
            this.guna2ComboBox2.ItemHeight = 50;
            this.guna2ComboBox2.Items.AddRange(new object[] {
            "Thống kê",
            "Thống kê lương ",
            "Thống kê bảo hiểm",
            "Thống kê thông tin nhân viên",
            "Thống kê hợp đồng "});
            this.guna2ComboBox2.ItemsAppearance.BackColor = System.Drawing.Color.White;
            this.guna2ComboBox2.ItemsAppearance.ForeColor = System.Drawing.Color.Black;
            this.guna2ComboBox2.ItemsAppearance.SelectedBackColor = System.Drawing.Color.Silver;
            this.guna2ComboBox2.Location = new System.Drawing.Point(583, 10);
            this.guna2ComboBox2.Margin = new System.Windows.Forms.Padding(22, 7, 2, 2);
            this.guna2ComboBox2.Name = "guna2ComboBox2";
            this.guna2ComboBox2.Size = new System.Drawing.Size(241, 56);
            this.guna2ComboBox2.StartIndex = 0;
            this.guna2ComboBox2.TabIndex = 2;
            // 
            // FormTrangChuQuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 784);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.pnlContent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox2;
        private Guna.UI2.WinForms.Guna2Button btnDangXuat;
    }
}