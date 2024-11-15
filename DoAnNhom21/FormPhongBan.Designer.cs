using System;
using System.Drawing;
using System.Windows.Forms;

namespace DoAnNhom21
{
    partial class FormPhongBan
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            this.dataGridViewPhongBan = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.cbbMaTrP = new System.Windows.Forms.ComboBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.lblMaPB = new System.Windows.Forms.Label();
            this.lblTenPB = new System.Windows.Forms.Label();
            this.lblMaTrP = new System.Windows.Forms.Label();
            this.txtTenPB = new System.Windows.Forms.TextBox();
            this.lblSDT = new System.Windows.Forms.Label();
            this.txtMaPB = new System.Windows.Forms.TextBox();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnThongBao = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnXemThongTin = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhongBan)).BeginInit();
            this.guna2GroupBox1.SuspendLayout();
            this.guna2GroupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewPhongBan
            // 
            this.dataGridViewPhongBan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPhongBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPhongBan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridViewPhongBan.Location = new System.Drawing.Point(13, 43);
            this.dataGridViewPhongBan.Name = "dataGridViewPhongBan";
            this.dataGridViewPhongBan.ReadOnly = true;
            this.dataGridViewPhongBan.RowHeadersVisible = false;
            this.dataGridViewPhongBan.RowHeadersWidth = 51;
            this.dataGridViewPhongBan.RowTemplate.Height = 24;
            this.dataGridViewPhongBan.Size = new System.Drawing.Size(865, 159);
            this.dataGridViewPhongBan.TabIndex = 4;
            this.dataGridViewPhongBan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPhongBan_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaPB";
            this.Column1.HeaderText = "Mã phòng ban";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenPB";
            this.Column2.HeaderText = "Tên phòng ban";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "MaTrP";
            this.Column3.HeaderText = "Mã trưởng phòng";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "SDT";
            this.Column4.HeaderText = "Số điện thoại";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(81)))), ((int)(((byte)(57)))));
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(81)))), ((int)(((byte)(57)))));
            this.guna2GroupBox1.Controls.Add(this.cbbMaTrP);
            this.guna2GroupBox1.Controls.Add(this.txtSDT);
            this.guna2GroupBox1.Controls.Add(this.lblMaPB);
            this.guna2GroupBox1.Controls.Add(this.lblTenPB);
            this.guna2GroupBox1.Controls.Add(this.lblMaTrP);
            this.guna2GroupBox1.Controls.Add(this.txtTenPB);
            this.guna2GroupBox1.Controls.Add(this.lblSDT);
            this.guna2GroupBox1.Controls.Add(this.txtMaPB);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(81)))), ((int)(((byte)(57)))));
            this.guna2GroupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox1.Location = new System.Drawing.Point(143, 37);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(892, 205);
            this.guna2GroupBox1.TabIndex = 17;
            this.guna2GroupBox1.Text = "THÔNG TIN PHÒNG BAN ";
            // 
            // cbbMaTrP
            // 
            this.cbbMaTrP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMaTrP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbbMaTrP.FormattingEnabled = true;
            this.cbbMaTrP.Location = new System.Drawing.Point(643, 109);
            this.cbbMaTrP.Name = "cbbMaTrP";
            this.cbbMaTrP.Size = new System.Drawing.Size(196, 30);
            this.cbbMaTrP.Sorted = true;
            this.cbbMaTrP.TabIndex = 13;
            // 
            // txtSDT
            // 
            this.txtSDT.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSDT.Location = new System.Drawing.Point(643, 65);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(196, 27);
            this.txtSDT.TabIndex = 10;
            // 
            // lblMaPB
            // 
            this.lblMaPB.AutoSize = true;
            this.lblMaPB.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaPB.Location = new System.Drawing.Point(53, 70);
            this.lblMaPB.Name = "lblMaPB";
            this.lblMaPB.Size = new System.Drawing.Size(127, 22);
            this.lblMaPB.TabIndex = 6;
            this.lblMaPB.Text = "Mã phòng ban:";
            // 
            // lblTenPB
            // 
            this.lblTenPB.AutoSize = true;
            this.lblTenPB.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenPB.Location = new System.Drawing.Point(53, 117);
            this.lblTenPB.Name = "lblTenPB";
            this.lblTenPB.Size = new System.Drawing.Size(136, 22);
            this.lblTenPB.TabIndex = 7;
            this.lblTenPB.Text = "Tên phòng ban: ";
            // 
            // lblMaTrP
            // 
            this.lblMaTrP.AutoSize = true;
            this.lblMaTrP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaTrP.Location = new System.Drawing.Point(475, 113);
            this.lblMaTrP.Name = "lblMaTrP";
            this.lblMaTrP.Size = new System.Drawing.Size(156, 22);
            this.lblMaTrP.TabIndex = 8;
            this.lblMaTrP.Text = "Mã trưởng phòng: ";
            // 
            // txtTenPB
            // 
            this.txtTenPB.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenPB.Location = new System.Drawing.Point(224, 113);
            this.txtTenPB.Name = "txtTenPB";
            this.txtTenPB.Size = new System.Drawing.Size(196, 27);
            this.txtTenPB.TabIndex = 11;
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSDT.Location = new System.Drawing.Point(475, 70);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(125, 22);
            this.lblSDT.TabIndex = 9;
            this.lblSDT.Text = "Số điện thoại: ";
            // 
            // txtMaPB
            // 
            this.txtMaPB.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaPB.Location = new System.Drawing.Point(224, 68);
            this.txtMaPB.Name = "txtMaPB";
            this.txtMaPB.Size = new System.Drawing.Size(196, 27);
            this.txtMaPB.TabIndex = 12;
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(81)))), ((int)(((byte)(57)))));
            this.guna2GroupBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(81)))), ((int)(((byte)(57)))));
            this.guna2GroupBox2.Controls.Add(this.dataGridViewPhongBan);
            this.guna2GroupBox2.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(81)))), ((int)(((byte)(57)))));
            this.guna2GroupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox2.Location = new System.Drawing.Point(143, 274);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.Size = new System.Drawing.Size(892, 205);
            this.guna2GroupBox2.TabIndex = 18;
            this.guna2GroupBox2.Text = "DANH SÁCH PHÒNG BAN ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(81)))), ((int)(((byte)(57)))));
            this.panel1.Controls.Add(this.btnThongBao);
            this.panel1.Controls.Add(this.btnLamMoi);
            this.panel1.Controls.Add(this.btnXemThongTin);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 500);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1178, 148);
            this.panel1.TabIndex = 19;
            // 
            // btnThongBao
            // 
            this.btnThongBao.BackColor = System.Drawing.Color.White;
            this.btnThongBao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongBao.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongBao.ForeColor = System.Drawing.Color.Black;
            this.btnThongBao.Location = new System.Drawing.Point(538, 84);
            this.btnThongBao.Name = "btnThongBao";
            this.btnThongBao.Size = new System.Drawing.Size(220, 40);
            this.btnThongBao.TabIndex = 12;
            this.btnThongBao.Text = "Thông Báo";
            this.btnThongBao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThongBao.UseVisualStyleBackColor = false;
            this.btnThongBao.Click += new System.EventHandler(this.btnThongBao_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.White;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLamMoi.Location = new System.Drawing.Point(287, 84);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(220, 38);
            this.btnLamMoi.TabIndex = 11;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnXemThongTin
            // 
            this.btnXemThongTin.BackColor = System.Drawing.Color.White;
            this.btnXemThongTin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemThongTin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemThongTin.Location = new System.Drawing.Point(35, 84);
            this.btnXemThongTin.Name = "btnXemThongTin";
            this.btnXemThongTin.Size = new System.Drawing.Size(220, 38);
            this.btnXemThongTin.TabIndex = 10;
            this.btnXemThongTin.Text = "Xem thông tin chi tiết";
            this.btnXemThongTin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXemThongTin.UseVisualStyleBackColor = false;
            this.btnXemThongTin.Click += new System.EventHandler(this.btnXemThongTin_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.White;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.Black;
            this.btnThem.Location = new System.Drawing.Point(35, 24);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(220, 38);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.White;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(538, 24);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(220, 38);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.White;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(936, 55);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(220, 38);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.White;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(287, 24);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(220, 38);
            this.btnSua.TabIndex = 9;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // FormPhongBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(1178, 648);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.guna2GroupBox2);
            this.Controls.Add(this.guna2GroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPhongBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phòng Ban";
            this.Load += new System.EventHandler(this.FormPhongBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhongBan)).EndInit();
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.guna2GroupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        #endregion
        private System.Windows.Forms.DataGridView dataGridViewPhongBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private ComboBox cbbMaTrP;
        private TextBox txtSDT;
        private Label lblMaPB;
        private Label lblTenPB;
        private Label lblMaTrP;
        private TextBox txtTenPB;
        private Label lblSDT;
        private TextBox txtMaPB;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private Panel panel1;
        private Button btnThongBao;
        private Button btnLamMoi;
        private Button btnXemThongTin;
        private Button btnThem;
        private Button btnXoa;
        private Button btnThoat;
        private Button btnSua;
    }
}