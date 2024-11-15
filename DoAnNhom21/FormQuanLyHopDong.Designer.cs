namespace DoAnNhom21
{
    partial class FormQuanLyHopDong
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXemChiTiet = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.dtpNgayBd = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpNgayKt = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtLuongCoBan = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMaNhanVien = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMaHopDong = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblNgayKT = new System.Windows.Forms.Label();
            this.sd = new System.Windows.Forms.Label();
            this.lblHeSoLuong = new System.Windows.Forms.Label();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.guna2GroupBox3 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.lblMaHD = new System.Windows.Forms.Label();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiemMaNV = new Guna.UI2.WinForms.Guna2TextBox();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewHopDong = new System.Windows.Forms.DataGridView();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.guna2Panel1.SuspendLayout();
            this.guna2GroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHopDong)).BeginInit();
            this.guna2GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(81)))), ((int)(((byte)(57)))));
            this.guna2Panel1.BorderColor = System.Drawing.Color.Black;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.guna2Button1);
            this.guna2Panel1.Controls.Add(this.btnThem);
            this.guna2Panel1.Controls.Add(this.btnXoa);
            this.guna2Panel1.Controls.Add(this.btnSua);
            this.guna2Panel1.Controls.Add(this.btnXemChiTiet);
            this.guna2Panel1.Controls.Add(this.btnLamMoi);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 778);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1413, 98);
            this.guna2Panel1.TabIndex = 33;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(220)))));
            this.guna2Button1.BorderThickness = 1;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(220)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(8)))), ((int)(((byte)(23)))));
            this.guna2Button1.Location = new System.Drawing.Point(1168, 30);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(147, 41);
            this.guna2Button1.TabIndex = 8;
            this.guna2Button1.Text = "Thoát";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(220)))));
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.Black;
            this.btnThem.Location = new System.Drawing.Point(373, 30);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(147, 41);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click_1);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(220)))));
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.Black;
            this.btnXoa.Location = new System.Drawing.Point(572, 30);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(147, 41);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click_1);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(220)))));
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.Black;
            this.btnSua.Location = new System.Drawing.Point(771, 30);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(147, 41);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click_1);
            // 
            // btnXemChiTiet
            // 
            this.btnXemChiTiet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(220)))));
            this.btnXemChiTiet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemChiTiet.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemChiTiet.ForeColor = System.Drawing.Color.Black;
            this.btnXemChiTiet.Location = new System.Drawing.Point(76, 30);
            this.btnXemChiTiet.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnXemChiTiet.Name = "btnXemChiTiet";
            this.btnXemChiTiet.Size = new System.Drawing.Size(245, 41);
            this.btnXemChiTiet.TabIndex = 5;
            this.btnXemChiTiet.Text = "Xem thông tin chi tiết";
            this.btnXemChiTiet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXemChiTiet.UseVisualStyleBackColor = false;
            this.btnXemChiTiet.Click += new System.EventHandler(this.btnXemChiTiet_Click_1);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(220)))));
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.ForeColor = System.Drawing.Color.Black;
            this.btnLamMoi.Location = new System.Drawing.Point(969, 30);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(147, 41);
            this.btnLamMoi.TabIndex = 6;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click_1);
            // 
            // dtpNgayBd
            // 
            this.dtpNgayBd.Checked = true;
            this.dtpNgayBd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpNgayBd.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpNgayBd.Location = new System.Drawing.Point(839, 92);
            this.dtpNgayBd.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgayBd.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgayBd.Name = "dtpNgayBd";
            this.dtpNgayBd.Size = new System.Drawing.Size(231, 48);
            this.dtpNgayBd.TabIndex = 20;
            this.dtpNgayBd.Value = new System.DateTime(2024, 10, 25, 1, 43, 6, 269);
            // 
            // dtpNgayKt
            // 
            this.dtpNgayKt.Checked = true;
            this.dtpNgayKt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpNgayKt.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpNgayKt.Location = new System.Drawing.Point(839, 160);
            this.dtpNgayKt.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgayKt.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgayKt.Name = "dtpNgayKt";
            this.dtpNgayKt.Size = new System.Drawing.Size(231, 48);
            this.dtpNgayKt.TabIndex = 19;
            this.dtpNgayKt.Value = new System.DateTime(2024, 10, 25, 1, 43, 6, 269);
            // 
            // txtLuongCoBan
            // 
            this.txtLuongCoBan.BackColor = System.Drawing.Color.White;
            this.txtLuongCoBan.BorderThickness = 0;
            this.txtLuongCoBan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLuongCoBan.DefaultText = "";
            this.txtLuongCoBan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLuongCoBan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLuongCoBan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLuongCoBan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLuongCoBan.FillColor = System.Drawing.SystemColors.Control;
            this.txtLuongCoBan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLuongCoBan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLuongCoBan.ForeColor = System.Drawing.Color.Black;
            this.txtLuongCoBan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLuongCoBan.Location = new System.Drawing.Point(262, 228);
            this.txtLuongCoBan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLuongCoBan.Name = "txtLuongCoBan";
            this.txtLuongCoBan.PasswordChar = '\0';
            this.txtLuongCoBan.PlaceholderText = "";
            this.txtLuongCoBan.SelectedText = "";
            this.txtLuongCoBan.Size = new System.Drawing.Size(229, 48);
            this.txtLuongCoBan.TabIndex = 18;
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.BackColor = System.Drawing.Color.White;
            this.txtMaNhanVien.BorderThickness = 0;
            this.txtMaNhanVien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaNhanVien.DefaultText = "";
            this.txtMaNhanVien.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaNhanVien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaNhanVien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaNhanVien.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaNhanVien.FillColor = System.Drawing.SystemColors.Control;
            this.txtMaNhanVien.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaNhanVien.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMaNhanVien.ForeColor = System.Drawing.Color.Black;
            this.txtMaNhanVien.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaNhanVien.Location = new System.Drawing.Point(262, 160);
            this.txtMaNhanVien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.PasswordChar = '\0';
            this.txtMaNhanVien.PlaceholderText = "";
            this.txtMaNhanVien.SelectedText = "";
            this.txtMaNhanVien.Size = new System.Drawing.Size(229, 48);
            this.txtMaNhanVien.TabIndex = 17;
            // 
            // txtMaHopDong
            // 
            this.txtMaHopDong.BackColor = System.Drawing.Color.White;
            this.txtMaHopDong.BorderThickness = 0;
            this.txtMaHopDong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaHopDong.DefaultText = "";
            this.txtMaHopDong.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaHopDong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaHopDong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaHopDong.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaHopDong.FillColor = System.Drawing.SystemColors.Control;
            this.txtMaHopDong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaHopDong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMaHopDong.ForeColor = System.Drawing.Color.Black;
            this.txtMaHopDong.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaHopDong.Location = new System.Drawing.Point(262, 92);
            this.txtMaHopDong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaHopDong.Name = "txtMaHopDong";
            this.txtMaHopDong.PasswordChar = '\0';
            this.txtMaHopDong.PlaceholderText = "";
            this.txtMaHopDong.SelectedText = "";
            this.txtMaHopDong.Size = new System.Drawing.Size(229, 48);
            this.txtMaHopDong.TabIndex = 16;
            // 
            // lblNgayKT
            // 
            this.lblNgayKT.AutoSize = true;
            this.lblNgayKT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayKT.Location = new System.Drawing.Point(661, 178);
            this.lblNgayKT.Name = "lblNgayKT";
            this.lblNgayKT.Size = new System.Drawing.Size(141, 23);
            this.lblNgayKT.TabIndex = 5;
            this.lblNgayKT.Text = "Ngày kết thúc: ";
            // 
            // sd
            // 
            this.sd.AutoSize = true;
            this.sd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sd.Location = new System.Drawing.Point(661, 110);
            this.sd.Name = "sd";
            this.sd.Size = new System.Drawing.Size(133, 23);
            this.sd.TabIndex = 6;
            this.sd.Text = "Ngày bắt đầu: ";
            // 
            // lblHeSoLuong
            // 
            this.lblHeSoLuong.AutoSize = true;
            this.lblHeSoLuong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeSoLuong.Location = new System.Drawing.Point(74, 244);
            this.lblHeSoLuong.Name = "lblHeSoLuong";
            this.lblHeSoLuong.Size = new System.Drawing.Size(133, 23);
            this.lblHeSoLuong.TabIndex = 7;
            this.lblHeSoLuong.Text = "Lương cơ bản:";
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaNV.Location = new System.Drawing.Point(73, 177);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(134, 23);
            this.lblMaNV.TabIndex = 8;
            this.lblMaNV.Text = "Mã nhân viên: ";
            // 
            // guna2GroupBox3
            // 
            this.guna2GroupBox3.Controls.Add(this.dtpNgayBd);
            this.guna2GroupBox3.Controls.Add(this.dtpNgayKt);
            this.guna2GroupBox3.Controls.Add(this.txtLuongCoBan);
            this.guna2GroupBox3.Controls.Add(this.txtMaNhanVien);
            this.guna2GroupBox3.Controls.Add(this.txtMaHopDong);
            this.guna2GroupBox3.Controls.Add(this.lblNgayKT);
            this.guna2GroupBox3.Controls.Add(this.sd);
            this.guna2GroupBox3.Controls.Add(this.lblHeSoLuong);
            this.guna2GroupBox3.Controls.Add(this.lblMaNV);
            this.guna2GroupBox3.Controls.Add(this.lblMaHD);
            this.guna2GroupBox3.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(81)))), ((int)(((byte)(57)))));
            this.guna2GroupBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.guna2GroupBox3.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox3.Location = new System.Drawing.Point(59, 14);
            this.guna2GroupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2GroupBox3.Name = "guna2GroupBox3";
            this.guna2GroupBox3.Size = new System.Drawing.Size(1255, 369);
            this.guna2GroupBox3.TabIndex = 34;
            this.guna2GroupBox3.Text = "THÔNG TIN HỢP ĐỒNG";
            // 
            // lblMaHD
            // 
            this.lblMaHD.AutoSize = true;
            this.lblMaHD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaHD.Location = new System.Drawing.Point(72, 110);
            this.lblMaHD.Name = "lblMaHD";
            this.lblMaHD.Size = new System.Drawing.Size(131, 23);
            this.lblMaHD.TabIndex = 9;
            this.lblMaHD.Text = "Mã hợp đồng: ";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(81)))), ((int)(((byte)(57)))));
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnTimKiem.Location = new System.Drawing.Point(1117, 1);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(137, 44);
            this.btnTimKiem.TabIndex = 3;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            // 
            // txtTimKiemMaNV
            // 
            this.txtTimKiemMaNV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimKiemMaNV.DefaultText = "";
            this.txtTimKiemMaNV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTimKiemMaNV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTimKiemMaNV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKiemMaNV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKiemMaNV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimKiemMaNV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTimKiemMaNV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimKiemMaNV.Location = new System.Drawing.Point(764, 1);
            this.txtTimKiemMaNV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTimKiemMaNV.Name = "txtTimKiemMaNV";
            this.txtTimKiemMaNV.PasswordChar = '\0';
            this.txtTimKiemMaNV.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtTimKiemMaNV.PlaceholderText = "Tìm kiếm theo mã nhân viên";
            this.txtTimKiemMaNV.SelectedText = "";
            this.txtTimKiemMaNV.Size = new System.Drawing.Size(363, 44);
            this.txtTimKiemMaNV.TabIndex = 9;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "NgayKT";
            this.Column5.HeaderText = "Ngày kết thúc";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "NgayBD";
            this.Column4.HeaderText = "Ngày bắt đầu";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "LuongCoBan";
            this.Column3.HeaderText = "Lương cơ bản";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "MaNV";
            this.Column2.HeaderText = "Mã nhân viên";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaHD";
            this.Column1.HeaderText = "Mã hợp đồng";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // dataGridViewHopDong
            // 
            this.dataGridViewHopDong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewHopDong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHopDong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridViewHopDong.Location = new System.Drawing.Point(3, 53);
            this.dataGridViewHopDong.Name = "dataGridViewHopDong";
            this.dataGridViewHopDong.ReadOnly = true;
            this.dataGridViewHopDong.RowHeadersVisible = false;
            this.dataGridViewHopDong.RowHeadersWidth = 51;
            this.dataGridViewHopDong.RowTemplate.Height = 24;
            this.dataGridViewHopDong.Size = new System.Drawing.Size(1249, 329);
            this.dataGridViewHopDong.TabIndex = 10;
            this.dataGridViewHopDong.DoubleClick += new System.EventHandler(this.dataGridViewHopDong_DoubleClick_1);
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.dataGridViewHopDong);
            this.guna2GroupBox1.Controls.Add(this.btnTimKiem);
            this.guna2GroupBox1.Controls.Add(this.txtTimKiemMaNV);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(81)))), ((int)(((byte)(57)))));
            this.guna2GroupBox1.CustomBorderThickness = new System.Windows.Forms.Padding(0, 45, 0, 0);
            this.guna2GroupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox1.Location = new System.Drawing.Point(60, 446);
            this.guna2GroupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(1255, 287);
            this.guna2GroupBox1.TabIndex = 35;
            this.guna2GroupBox1.Text = "DANH SÁCH HỢP ĐỒNG";
            // 
            // FormQuanLyHopDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(1413, 876);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2GroupBox3);
            this.Controls.Add(this.guna2GroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormQuanLyHopDong";
            this.Text = "FormQuanLyHopDong";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2GroupBox3.ResumeLayout(false);
            this.guna2GroupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHopDong)).EndInit();
            this.guna2GroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXemChiTiet;
        private System.Windows.Forms.Button btnLamMoi;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgayBd;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgayKt;
        private Guna.UI2.WinForms.Guna2TextBox txtLuongCoBan;
        private Guna.UI2.WinForms.Guna2TextBox txtMaNhanVien;
        private Guna.UI2.WinForms.Guna2TextBox txtMaHopDong;
        private System.Windows.Forms.Label lblNgayKT;
        private System.Windows.Forms.Label sd;
        private System.Windows.Forms.Label lblHeSoLuong;
        private System.Windows.Forms.Label lblMaNV;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox3;
        private System.Windows.Forms.Label lblMaHD;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnTimKiem;
        private Guna.UI2.WinForms.Guna2TextBox txtTimKiemMaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridView dataGridViewHopDong;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
    }
}