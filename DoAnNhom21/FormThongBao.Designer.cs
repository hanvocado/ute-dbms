using System;
using System.Windows.Forms;

namespace DoAnNhom21
{
    partial class FormThongBao
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
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.lblId = new System.Windows.Forms.Label();
            this.cbbId = new System.Windows.Forms.ComboBox();
            this.cbbMaPB = new System.Windows.Forms.ComboBox();
            this.dtpNgayGui = new System.Windows.Forms.DateTimePicker();
            this.txtNoiDung = new System.Windows.Forms.TextBox();
            this.txtTieuDe = new System.Windows.Forms.TextBox();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.lblNoiDung = new System.Windows.Forms.Label();
            this.lblPBGoi = new System.Windows.Forms.Label();
            this.lblNgayGui = new System.Windows.Forms.Label();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dataGridViewThongBao = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.guna2GroupBox1.SuspendLayout();
            this.guna2GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThongBao)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(81)))), ((int)(((byte)(57)))));
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(81)))), ((int)(((byte)(57)))));
            this.guna2GroupBox1.Controls.Add(this.lblId);
            this.guna2GroupBox1.Controls.Add(this.cbbId);
            this.guna2GroupBox1.Controls.Add(this.cbbMaPB);
            this.guna2GroupBox1.Controls.Add(this.dtpNgayGui);
            this.guna2GroupBox1.Controls.Add(this.txtNoiDung);
            this.guna2GroupBox1.Controls.Add(this.txtTieuDe);
            this.guna2GroupBox1.Controls.Add(this.lblTieuDe);
            this.guna2GroupBox1.Controls.Add(this.lblNoiDung);
            this.guna2GroupBox1.Controls.Add(this.lblPBGoi);
            this.guna2GroupBox1.Controls.Add(this.lblNgayGui);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(81)))), ((int)(((byte)(57)))));
            this.guna2GroupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox1.Location = new System.Drawing.Point(89, 157);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(877, 225);
            this.guna2GroupBox1.TabIndex = 24;
            this.guna2GroupBox1.Text = "THÔNG BÁO ";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(467, 183);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(30, 22);
            this.lblId.TabIndex = 18;
            this.lblId.Text = "ID";
            // 
            // cbbId
            // 
            this.cbbId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbId.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbbId.FormattingEnabled = true;
            this.cbbId.Location = new System.Drawing.Point(635, 183);
            this.cbbId.Name = "cbbId";
            this.cbbId.Size = new System.Drawing.Size(196, 30);
            this.cbbId.Sorted = true;
            this.cbbId.TabIndex = 17;
            // 
            // cbbMaPB
            // 
            this.cbbMaPB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMaPB.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbbMaPB.FormattingEnabled = true;
            this.cbbMaPB.Location = new System.Drawing.Point(635, 125);
            this.cbbMaPB.Name = "cbbMaPB";
            this.cbbMaPB.Size = new System.Drawing.Size(196, 30);
            this.cbbMaPB.Sorted = true;
            this.cbbMaPB.TabIndex = 16;
            // 
            // dtpNgayGui
            // 
            this.dtpNgayGui.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpNgayGui.Location = new System.Drawing.Point(635, 81);
            this.dtpNgayGui.Name = "dtpNgayGui";
            this.dtpNgayGui.Size = new System.Drawing.Size(196, 27);
            this.dtpNgayGui.TabIndex = 15;
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtNoiDung.Location = new System.Drawing.Point(238, 129);
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(196, 27);
            this.txtNoiDung.TabIndex = 13;
            // 
            // txtTieuDe
            // 
            this.txtTieuDe.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTieuDe.Location = new System.Drawing.Point(238, 84);
            this.txtTieuDe.Name = "txtTieuDe";
            this.txtTieuDe.Size = new System.Drawing.Size(196, 27);
            this.txtTieuDe.TabIndex = 14;
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.Location = new System.Drawing.Point(45, 86);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(156, 22);
            this.lblTieuDe.TabIndex = 9;
            this.lblTieuDe.Text = "Tiêu đề thông báo:";
            // 
            // lblNoiDung
            // 
            this.lblNoiDung.AutoSize = true;
            this.lblNoiDung.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoiDung.Location = new System.Drawing.Point(45, 133);
            this.lblNoiDung.Name = "lblNoiDung";
            this.lblNoiDung.Size = new System.Drawing.Size(169, 22);
            this.lblNoiDung.TabIndex = 10;
            this.lblNoiDung.Text = "Nội dung thông báo:";
            // 
            // lblPBGoi
            // 
            this.lblPBGoi.AutoSize = true;
            this.lblPBGoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPBGoi.Location = new System.Drawing.Point(467, 129);
            this.lblPBGoi.Name = "lblPBGoi";
            this.lblPBGoi.Size = new System.Drawing.Size(133, 22);
            this.lblPBGoi.TabIndex = 11;
            this.lblPBGoi.Text = "Phòng ban gửi: ";
            // 
            // lblNgayGui
            // 
            this.lblNgayGui.AutoSize = true;
            this.lblNgayGui.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayGui.Location = new System.Drawing.Point(467, 86);
            this.lblNgayGui.Name = "lblNgayGui";
            this.lblNgayGui.Size = new System.Drawing.Size(93, 22);
            this.lblNgayGui.TabIndex = 12;
            this.lblNgayGui.Text = "Ngày gửi: ";
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(81)))), ((int)(((byte)(57)))));
            this.guna2GroupBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(81)))), ((int)(((byte)(57)))));
            this.guna2GroupBox2.Controls.Add(this.dataGridViewThongBao);
            this.guna2GroupBox2.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(81)))), ((int)(((byte)(57)))));
            this.guna2GroupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox2.Location = new System.Drawing.Point(75, 418);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.Size = new System.Drawing.Size(877, 225);
            this.guna2GroupBox2.TabIndex = 25;
            this.guna2GroupBox2.Text = "DANH SÁCH THÔNG BÁO";
            // 
            // dataGridViewThongBao
            // 
            this.dataGridViewThongBao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewThongBao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewThongBao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridViewThongBao.Location = new System.Drawing.Point(14, 46);
            this.dataGridViewThongBao.Name = "dataGridViewThongBao";
            this.dataGridViewThongBao.ReadOnly = true;
            this.dataGridViewThongBao.RowHeadersVisible = false;
            this.dataGridViewThongBao.RowHeadersWidth = 51;
            this.dataGridViewThongBao.RowTemplate.Height = 24;
            this.dataGridViewThongBao.Size = new System.Drawing.Size(839, 286);
            this.dataGridViewThongBao.TabIndex = 5;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "TieuDe";
            this.Column1.HeaderText = "Tiêu đề thông báo";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "NoiDung";
            this.Column2.HeaderText = "Nội dung thông báo";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "PBGoi";
            this.Column3.HeaderText = "Phòng ban gửi";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "NgayGui";
            this.Column4.HeaderText = "Ngày gửi";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(81)))), ((int)(((byte)(57)))));
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 701);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1041, 100);
            this.panel1.TabIndex = 26;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.Black;
            this.btnThem.Location = new System.Drawing.Point(39, 31);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(186, 38);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click_1);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(542, 31);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(186, 38);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click_1);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(816, 31);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(186, 38);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click_1);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(291, 31);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(186, 38);
            this.btnSua.TabIndex = 7;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click_1);
            // 
            // FormThongBao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(1041, 801);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.guna2GroupBox2);
            this.Controls.Add(this.guna2GroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormThongBao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông Báo";
            this.Load += new System.EventHandler(this.FormThongBao_Load_1);
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.guna2GroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThongBao)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }





        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Label lblId;
        private ComboBox cbbId;
        private ComboBox cbbMaPB;
        private DateTimePicker dtpNgayGui;
        private TextBox txtNoiDung;
        private TextBox txtTieuDe;
        private Label lblTieuDe;
        private Label lblNoiDung;
        private Label lblPBGoi;
        private Label lblNgayGui;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private DataGridView dataGridViewThongBao;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private Panel panel1;
        private Button btnThem;
        private Button btnXoa;
        private Button btnThoat;
        private Button btnSua;
    }
    
    

}