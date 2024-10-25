using System;
using System.Windows.Forms;

namespace DoAnNhom21
{
    partial class FormThuongPhat
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
            this.lblNgay = new System.Windows.Forms.Label();
            this.cbbMaNV = new System.Windows.Forms.ComboBox();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMaTP = new System.Windows.Forms.TextBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.lblMaTP = new System.Windows.Forms.Label();
            this.lblLoai = new System.Windows.Forms.Label();
            this.cbbLoai = new System.Windows.Forms.ComboBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTien = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtTien = new System.Windows.Forms.TextBox();
            this.txtLyDo = new System.Windows.Forms.TextBox();
            this.dataGridViewTP = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtNgayTP = new System.Windows.Forms.TextBox();
            this.cbbMaThang = new System.Windows.Forms.ComboBox();
            this.lblMaThang = new System.Windows.Forms.Label();
            this.btnLoc = new System.Windows.Forms.Button();
            this.cbbMaTP = new System.Windows.Forms.ComboBox();
            this.dataGridViewCTTP = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSuaTPNV = new System.Windows.Forms.Button();
            this.btnXoaTPNV = new System.Windows.Forms.Button();
            this.btnThemTPNV = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTP)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCTTP)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNgay
            // 
            this.lblNgay.AutoSize = true;
            this.lblNgay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNgay.Location = new System.Drawing.Point(20, 246);
            this.lblNgay.Name = "lblNgay";
            this.lblNgay.Size = new System.Drawing.Size(197, 27);
            this.lblNgay.TabIndex = 32;
            this.lblNgay.Text = "Ngày thưởng phạt: ";
            // 
            // cbbMaNV
            // 
            this.cbbMaNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMaNV.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.cbbMaNV.FormattingEnabled = true;
            this.cbbMaNV.Location = new System.Drawing.Point(237, 89);
            this.cbbMaNV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbbMaNV.Name = "cbbMaNV";
            this.cbbMaNV.Size = new System.Drawing.Size(282, 35);
            this.cbbMaNV.Sorted = true;
            this.cbbMaNV.TabIndex = 31;
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblMaNV.Location = new System.Drawing.Point(20, 92);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(150, 27);
            this.lblMaNV.TabIndex = 24;
            this.lblMaNV.Text = "Mã nhân viên:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMaTP);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.lblMaTP);
            this.groupBox1.Controls.Add(this.lblLoai);
            this.groupBox1.Controls.Add(this.cbbLoai);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblTien);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.txtTien);
            this.groupBox1.Controls.Add(this.txtLyDo);
            this.groupBox1.Controls.Add(this.dataGridViewTP);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(237, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(498, 781);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "THƯỞNG PHẠT ";
            // 
            // txtMaTP
            // 
            this.txtMaTP.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtMaTP.Location = new System.Drawing.Point(235, 92);
            this.txtMaTP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaTP.Name = "txtMaTP";
            this.txtMaTP.Size = new System.Drawing.Size(213, 35);
            this.txtMaTP.TabIndex = 31;
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnSua.Location = new System.Drawing.Point(335, 325);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(116, 49);
            this.btnSua.TabIndex = 37;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // lblMaTP
            // 
            this.lblMaTP.AutoSize = true;
            this.lblMaTP.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblMaTP.Location = new System.Drawing.Point(47, 96);
            this.lblMaTP.Name = "lblMaTP";
            this.lblMaTP.Size = new System.Drawing.Size(178, 27);
            this.lblMaTP.TabIndex = 0;
            this.lblMaTP.Text = "Mã thưởng phạt: ";
            // 
            // lblLoai
            // 
            this.lblLoai.AutoSize = true;
            this.lblLoai.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblLoai.Location = new System.Drawing.Point(47, 146);
            this.lblLoai.Name = "lblLoai";
            this.lblLoai.Size = new System.Drawing.Size(68, 27);
            this.lblLoai.TabIndex = 19;
            this.lblLoai.Text = "Loại: ";
            // 
            // cbbLoai
            // 
            this.cbbLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLoai.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.cbbLoai.FormattingEnabled = true;
            this.cbbLoai.Items.AddRange(new object[] {
            "Thưởng",
            "Phạt"});
            this.cbbLoai.Location = new System.Drawing.Point(235, 142);
            this.cbbLoai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbbLoai.Name = "cbbLoai";
            this.cbbLoai.Size = new System.Drawing.Size(213, 35);
            this.cbbLoai.TabIndex = 30;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoa.Location = new System.Drawing.Point(194, 325);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(116, 49);
            this.btnXoa.TabIndex = 38;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label1.Location = new System.Drawing.Point(47, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 27);
            this.label1.TabIndex = 22;
            this.label1.Text = "Lý do:";
            // 
            // lblTien
            // 
            this.lblTien.AutoSize = true;
            this.lblTien.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblTien.Location = new System.Drawing.Point(47, 198);
            this.lblTien.Name = "lblTien";
            this.lblTien.Size = new System.Drawing.Size(60, 27);
            this.lblTien.TabIndex = 20;
            this.lblTien.Text = "Tiền:";
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnThem.Location = new System.Drawing.Point(52, 325);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(116, 49);
            this.btnThem.TabIndex = 39;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtTien
            // 
            this.txtTien.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtTien.Location = new System.Drawing.Point(235, 194);
            this.txtTien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTien.Name = "txtTien";
            this.txtTien.Size = new System.Drawing.Size(213, 35);
            this.txtTien.TabIndex = 25;
            // 
            // txtLyDo
            // 
            this.txtLyDo.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtLyDo.Location = new System.Drawing.Point(235, 242);
            this.txtLyDo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLyDo.Name = "txtLyDo";
            this.txtLyDo.Size = new System.Drawing.Size(213, 35);
            this.txtLyDo.TabIndex = 27;
            // 
            // dataGridViewTP
            // 
            this.dataGridViewTP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridViewTP.Location = new System.Drawing.Point(22, 422);
            this.dataGridViewTP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewTP.Name = "dataGridViewTP";
            this.dataGridViewTP.RowHeadersVisible = false;
            this.dataGridViewTP.RowHeadersWidth = 51;
            this.dataGridViewTP.RowTemplate.Height = 24;
            this.dataGridViewTP.Size = new System.Drawing.Size(454, 351);
            this.dataGridViewTP.TabIndex = 40;
            this.dataGridViewTP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTP_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaThuongPhat";
            this.Column1.HeaderText = "Mã thưởng phạt";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Loai";
            this.Column2.HeaderText = "Loại";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "SoTien";
            this.Column3.HeaderText = "Số Tiền";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "LyDo";
            this.Column4.HeaderText = "Lý do";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtNgayTP);
            this.groupBox2.Controls.Add(this.cbbMaThang);
            this.groupBox2.Controls.Add(this.lblMaThang);
            this.groupBox2.Controls.Add(this.btnLoc);
            this.groupBox2.Controls.Add(this.cbbMaTP);
            this.groupBox2.Controls.Add(this.dataGridViewCTTP);
            this.groupBox2.Controls.Add(this.btnSuaTPNV);
            this.groupBox2.Controls.Add(this.lblMaNV);
            this.groupBox2.Controls.Add(this.cbbMaNV);
            this.groupBox2.Controls.Add(this.btnXoaTPNV);
            this.groupBox2.Controls.Add(this.lblNgay);
            this.groupBox2.Controls.Add(this.btnThemTPNV);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(686, 46);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(550, 781);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CHI TIẾT THƯỞNG PHẠT";
            // 
            // txtNgayTP
            // 
            this.txtNgayTP.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtNgayTP.Location = new System.Drawing.Point(211, 197);
            this.txtNgayTP.Name = "txtNgayTP";
            this.txtNgayTP.Size = new System.Drawing.Size(251, 30);
            this.txtNgayTP.TabIndex = 41;
            // 
            // cbbMaThang
            // 
            this.cbbMaThang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMaThang.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.cbbMaThang.FormattingEnabled = true;
            this.cbbMaThang.Location = new System.Drawing.Point(211, 155);
            this.cbbMaThang.Name = "cbbMaThang";
            this.cbbMaThang.Size = new System.Drawing.Size(251, 30);
            this.cbbMaThang.TabIndex = 44;
            // 
            // lblMaThang
            // 
            this.lblMaThang.AutoSize = true;
            this.lblMaThang.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblMaThang.Location = new System.Drawing.Point(18, 158);
            this.lblMaThang.Name = "lblMaThang";
            this.lblMaThang.Size = new System.Drawing.Size(82, 22);
            this.lblMaThang.TabIndex = 43;
            this.lblMaThang.Text = "Mã tháng";
            // 
            // btnLoc
            // 
            this.btnLoc.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnLoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLoc.Location = new System.Drawing.Point(394, 325);
            this.btnLoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(126, 49);
            this.btnLoc.TabIndex = 42;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLoc.UseVisualStyleBackColor = false;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // cbbMaTP
            // 
            this.cbbMaTP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMaTP.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.cbbMaTP.FormattingEnabled = true;
            this.cbbMaTP.Location = new System.Drawing.Point(237, 142);
            this.cbbMaTP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbbMaTP.Name = "cbbMaTP";
            this.cbbMaTP.Size = new System.Drawing.Size(282, 35);
            this.cbbMaTP.TabIndex = 41;
            // 
            // dataGridViewCTTP
            // 
            this.dataGridViewCTTP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCTTP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCTTP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dataGridViewCTTP.Location = new System.Drawing.Point(18, 422);
            this.dataGridViewCTTP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewCTTP.Name = "dataGridViewCTTP";
            this.dataGridViewCTTP.RowHeadersVisible = false;
            this.dataGridViewCTTP.RowHeadersWidth = 51;
            this.dataGridViewCTTP.RowTemplate.Height = 24;
            this.dataGridViewCTTP.Size = new System.Drawing.Size(514, 351);
            this.dataGridViewCTTP.TabIndex = 40;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaNV";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã nhân viên";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MaThuongPhat";
            this.dataGridViewTextBoxColumn2.HeaderText = "Mã thưởng phạt";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "MaThang";
            this.dataGridViewTextBoxColumn3.HeaderText = "Mã Tháng";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "NgayThuongPhat";
            this.dataGridViewTextBoxColumn4.HeaderText = "Ngày thưởng phạt";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // btnSuaTPNV
            // 
            this.btnSuaTPNV.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnSuaTPNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaTPNV.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnSuaTPNV.Location = new System.Drawing.Point(270, 325);
            this.btnSuaTPNV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSuaTPNV.Name = "btnSuaTPNV";
            this.btnSuaTPNV.Size = new System.Drawing.Size(116, 49);
            this.btnSuaTPNV.TabIndex = 37;
            this.btnSuaTPNV.Text = "Sửa";
            this.btnSuaTPNV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSuaTPNV.UseVisualStyleBackColor = false;
            this.btnSuaTPNV.Click += new System.EventHandler(this.btnSuaTPNV_Click);
            // 
            // btnXoaTPNV
            // 
            this.btnXoaTPNV.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnXoaTPNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaTPNV.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnXoaTPNV.Location = new System.Drawing.Point(147, 325);
            this.btnXoaTPNV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXoaTPNV.Name = "btnXoaTPNV";
            this.btnXoaTPNV.Size = new System.Drawing.Size(116, 49);
            this.btnXoaTPNV.TabIndex = 38;
            this.btnXoaTPNV.Text = "Xoá";
            this.btnXoaTPNV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoaTPNV.UseVisualStyleBackColor = false;
            this.btnXoaTPNV.Click += new System.EventHandler(this.btnXoaTPNV_Click);
            // 
            // btnThemTPNV
            // 
            this.btnThemTPNV.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnThemTPNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemTPNV.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnThemTPNV.ForeColor = System.Drawing.Color.Black;
            this.btnThemTPNV.Location = new System.Drawing.Point(25, 325);
            this.btnThemTPNV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThemTPNV.Name = "btnThemTPNV";
            this.btnThemTPNV.Size = new System.Drawing.Size(116, 49);
            this.btnThemTPNV.TabIndex = 39;
            this.btnThemTPNV.Text = "Thêm";
            this.btnThemTPNV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThemTPNV.UseVisualStyleBackColor = false;
            this.btnThemTPNV.Click += new System.EventHandler(this.btnThemTPNV_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label2.Location = new System.Drawing.Point(20, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã thưởng phạt:";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnLamMoi.Location = new System.Drawing.Point(423, 692);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(289, 50);
            this.btnLamMoi.TabIndex = 35;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnThoat.Location = new System.Drawing.Point(686, 692);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(289, 50);
            this.btnThoat.TabIndex = 29;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // FormThuongPhat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1413, 778);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnThoat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormThuongPhat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormThemThuongPhat";
            this.Load += new System.EventHandler(this.FormThuongPhat_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTP)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCTTP)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion
        private System.Windows.Forms.Label lblNgay;
        private System.Windows.Forms.ComboBox cbbMaNV;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewTP;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewCTTP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbMaTP;
        private System.Windows.Forms.TextBox txtMaTP;
        private System.Windows.Forms.Label lblMaTP;
        private System.Windows.Forms.Label lblLoai;
        private System.Windows.Forms.ComboBox cbbLoai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTien;
        private System.Windows.Forms.TextBox txtTien;
        private System.Windows.Forms.TextBox txtLyDo;
        private System.Windows.Forms.Button btnSuaTPNV;
        private System.Windows.Forms.Button btnXoaTPNV;
        private System.Windows.Forms.Button btnThemTPNV;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private ComboBox cbbMaThang;
        private Label lblMaThang;
        private TextBox txtNgayTP;
    }
}