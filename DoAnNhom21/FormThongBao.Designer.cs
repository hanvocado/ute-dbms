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
        private Label lblTieuDe;
        private Label lblNoiDung;
        private Label lblPBGoi;
        private Label lblNgayGui;
        private TextBox txtTieuDe;
        private TextBox txtNoiDung;
        private DateTimePicker dtpNgayGui;
        private DataGridView dataGridViewThongBao;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private GroupBox groupBoxThongBao;
        private GroupBox groupBoxDanhSachThongBao;
        private GroupBox groupBoxChucNang;
        private Button btnThem;
        private Button btnXoa;
        private Button btnThoat;
        private Button btnSua;

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
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.lblNoiDung = new System.Windows.Forms.Label();
            this.lblPBGoi = new System.Windows.Forms.Label();
            this.lblNgayGui = new System.Windows.Forms.Label();
            this.txtTieuDe = new System.Windows.Forms.TextBox();
            this.txtNoiDung = new System.Windows.Forms.TextBox();
            this.dtpNgayGui = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewThongBao = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxThongBao = new System.Windows.Forms.GroupBox();
            this.lblId = new System.Windows.Forms.Label();
            this.cbbId = new System.Windows.Forms.ComboBox();
            this.cbbMaPB = new System.Windows.Forms.ComboBox();
            this.groupBoxDanhSachThongBao = new System.Windows.Forms.GroupBox();
            this.groupBoxChucNang = new System.Windows.Forms.GroupBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThongBao)).BeginInit();
            this.groupBoxThongBao.SuspendLayout();
            this.groupBoxDanhSachThongBao.SuspendLayout();
            this.groupBoxChucNang.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.Location = new System.Drawing.Point(47, 71);
            this.lblTieuDe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(190, 27);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "Tiêu đề thông báo:";
            // 
            // lblNoiDung
            // 
            this.lblNoiDung.AutoSize = true;
            this.lblNoiDung.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoiDung.Location = new System.Drawing.Point(47, 127);
            this.lblNoiDung.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNoiDung.Name = "lblNoiDung";
            this.lblNoiDung.Size = new System.Drawing.Size(207, 27);
            this.lblNoiDung.TabIndex = 0;
            this.lblNoiDung.Text = "Nội dung thông báo:";
            // 
            // lblPBGoi
            // 
            this.lblPBGoi.AutoSize = true;
            this.lblPBGoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPBGoi.Location = new System.Drawing.Point(553, 122);
            this.lblPBGoi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPBGoi.Name = "lblPBGoi";
            this.lblPBGoi.Size = new System.Drawing.Size(162, 27);
            this.lblPBGoi.TabIndex = 0;
            this.lblPBGoi.Text = "Phòng ban gửi: ";
            // 
            // lblNgayGui
            // 
            this.lblNgayGui.AutoSize = true;
            this.lblNgayGui.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayGui.Location = new System.Drawing.Point(553, 71);
            this.lblNgayGui.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNgayGui.Name = "lblNgayGui";
            this.lblNgayGui.Size = new System.Drawing.Size(111, 27);
            this.lblNgayGui.TabIndex = 0;
            this.lblNgayGui.Text = "Ngày gửi: ";
            // 
            // txtTieuDe
            // 
            this.txtTieuDe.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTieuDe.Location = new System.Drawing.Point(252, 68);
            this.txtTieuDe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTieuDe.Name = "txtTieuDe";
            this.txtTieuDe.Size = new System.Drawing.Size(234, 31);
            this.txtTieuDe.TabIndex = 1;
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtNoiDung.Location = new System.Drawing.Point(252, 122);
            this.txtNoiDung.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(234, 31);
            this.txtNoiDung.TabIndex = 1;
            // 
            // dtpNgayGui
            // 
            this.dtpNgayGui.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpNgayGui.Location = new System.Drawing.Point(755, 65);
            this.dtpNgayGui.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpNgayGui.Name = "dtpNgayGui";
            this.dtpNgayGui.Size = new System.Drawing.Size(234, 31);
            this.dtpNgayGui.TabIndex = 2;
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
            this.dataGridViewThongBao.Location = new System.Drawing.Point(22, 35);
            this.dataGridViewThongBao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewThongBao.Name = "dataGridViewThongBao";
            this.dataGridViewThongBao.ReadOnly = true;
            this.dataGridViewThongBao.RowHeadersVisible = false;
            this.dataGridViewThongBao.RowHeadersWidth = 51;
            this.dataGridViewThongBao.RowTemplate.Height = 24;
            this.dataGridViewThongBao.Size = new System.Drawing.Size(1007, 343);
            this.dataGridViewThongBao.TabIndex = 4;
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
            // groupBoxThongBao
            // 
            this.groupBoxThongBao.Controls.Add(this.lblId);
            this.groupBoxThongBao.Controls.Add(this.cbbId);
            this.groupBoxThongBao.Controls.Add(this.cbbMaPB);
            this.groupBoxThongBao.Controls.Add(this.dtpNgayGui);
            this.groupBoxThongBao.Controls.Add(this.txtNoiDung);
            this.groupBoxThongBao.Controls.Add(this.txtTieuDe);
            this.groupBoxThongBao.Controls.Add(this.lblTieuDe);
            this.groupBoxThongBao.Controls.Add(this.lblNoiDung);
            this.groupBoxThongBao.Controls.Add(this.lblPBGoi);
            this.groupBoxThongBao.Controls.Add(this.lblNgayGui);
            this.groupBoxThongBao.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBoxThongBao.Location = new System.Drawing.Point(84, 36);
            this.groupBoxThongBao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxThongBao.Name = "groupBoxThongBao";
            this.groupBoxThongBao.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxThongBao.Size = new System.Drawing.Size(1052, 246);
            this.groupBoxThongBao.TabIndex = 5;
            this.groupBoxThongBao.TabStop = false;
            this.groupBoxThongBao.Text = "THÔNG BÁO";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(553, 187);
            this.lblId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(37, 27);
            this.lblId.TabIndex = 8;
            this.lblId.Text = "ID";
            // 
            // cbbId
            // 
            this.cbbId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbId.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbbId.FormattingEnabled = true;
            this.cbbId.Location = new System.Drawing.Point(755, 187);
            this.cbbId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbbId.Name = "cbbId";
            this.cbbId.Size = new System.Drawing.Size(234, 35);
            this.cbbId.Sorted = true;
            this.cbbId.TabIndex = 7;
            // 
            // cbbMaPB
            // 
            this.cbbMaPB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMaPB.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbbMaPB.FormattingEnabled = true;
            this.cbbMaPB.Location = new System.Drawing.Point(755, 118);
            this.cbbMaPB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbbMaPB.Name = "cbbMaPB";
            this.cbbMaPB.Size = new System.Drawing.Size(234, 35);
            this.cbbMaPB.Sorted = true;
            this.cbbMaPB.TabIndex = 6;
            // 
            // groupBoxDanhSachThongBao
            // 
            this.groupBoxDanhSachThongBao.Controls.Add(this.dataGridViewThongBao);
            this.groupBoxDanhSachThongBao.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBoxDanhSachThongBao.Location = new System.Drawing.Point(84, 539);
            this.groupBoxDanhSachThongBao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxDanhSachThongBao.Name = "groupBoxDanhSachThongBao";
            this.groupBoxDanhSachThongBao.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxDanhSachThongBao.Size = new System.Drawing.Size(1052, 385);
            this.groupBoxDanhSachThongBao.TabIndex = 7;
            this.groupBoxDanhSachThongBao.TabStop = false;
            this.groupBoxDanhSachThongBao.Text = "DANH SÁCH THÔNG BÁO";
            this.groupBoxDanhSachThongBao.UseCompatibleTextRendering = true;
            // 
            // groupBoxChucNang
            // 
            this.groupBoxChucNang.Controls.Add(this.btnThem);
            this.groupBoxChucNang.Controls.Add(this.btnXoa);
            this.groupBoxChucNang.Controls.Add(this.btnThoat);
            this.groupBoxChucNang.Controls.Add(this.btnSua);
            this.groupBoxChucNang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxChucNang.Location = new System.Drawing.Point(84, 317);
            this.groupBoxChucNang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxChucNang.Name = "groupBoxChucNang";
            this.groupBoxChucNang.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxChucNang.Size = new System.Drawing.Size(1052, 200);
            this.groupBoxChucNang.TabIndex = 6;
            this.groupBoxChucNang.TabStop = false;
            this.groupBoxChucNang.Text = "CHỨC NĂNG";
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.Black;
            this.btnThem.Location = new System.Drawing.Point(89, 53);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(264, 46);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(692, 53);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(264, 46);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(391, 120);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(264, 46);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(391, 53);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(264, 46);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // FormThongBao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(1249, 961);
            this.ControlBox = false;
            this.Controls.Add(this.groupBoxChucNang);
            this.Controls.Add(this.groupBoxDanhSachThongBao);
            this.Controls.Add(this.groupBoxThongBao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormThongBao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông Báo";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThongBao)).EndInit();
            this.groupBoxThongBao.ResumeLayout(false);
            this.groupBoxThongBao.PerformLayout();
            this.groupBoxDanhSachThongBao.ResumeLayout(false);
            this.groupBoxChucNang.ResumeLayout(false);
            this.ResumeLayout(false);

        }

       



        #endregion

        private ComboBox cbbMaPB;
        private Label lblId;
        private ComboBox cbbId;
    }
    
    

}