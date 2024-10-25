using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DoAnNhom21
{
    partial class FormPhuCap
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtLoaiPC = new System.Windows.Forms.TextBox();
            this.txtMaPC = new System.Windows.Forms.TextBox();
            this.lblLoaiPhuCap = new System.Windows.Forms.Label();
            this.lblMaPC = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvPhuCap = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbbMaPhuCapctPhuCap = new System.Windows.Forms.ComboBox();
            this.cbbMaNV = new System.Windows.Forms.ComboBox();
            this.txtSoTien = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpNgayPhuCap = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnLoc = new System.Windows.Forms.Button();
            this.btnSuact = new System.Windows.Forms.Button();
            this.btnThemct = new System.Windows.Forms.Button();
            this.btnXoact = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dgvctPhuCap = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaThang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayPC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhuCap)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvctPhuCap)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtLoaiPC);
            this.groupBox2.Controls.Add(this.txtMaPC);
            this.groupBox2.Controls.Add(this.lblLoaiPhuCap);
            this.groupBox2.Controls.Add(this.lblMaPC);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(239, 156);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(356, 141);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "THÔNG TIN LOẠI PHỤ CẤP";
            // 
            // txtLoaiPC
            // 
            this.txtLoaiPC.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtLoaiPC.Location = new System.Drawing.Point(138, 74);
            this.txtLoaiPC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLoaiPC.Name = "txtLoaiPC";
            this.txtLoaiPC.Size = new System.Drawing.Size(199, 30);
            this.txtLoaiPC.TabIndex = 2;
            // 
            // txtMaPC
            // 
            this.txtMaPC.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaPC.Location = new System.Drawing.Point(138, 34);
            this.txtMaPC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaPC.Name = "txtMaPC";
            this.txtMaPC.Size = new System.Drawing.Size(199, 30);
            this.txtMaPC.TabIndex = 2;
            // 
            // lblLoaiPhuCap
            // 
            this.lblLoaiPhuCap.AutoSize = true;
            this.lblLoaiPhuCap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblLoaiPhuCap.Location = new System.Drawing.Point(19, 74);
            this.lblLoaiPhuCap.Name = "lblLoaiPhuCap";
            this.lblLoaiPhuCap.Size = new System.Drawing.Size(118, 22);
            this.lblLoaiPhuCap.TabIndex = 1;
            this.lblLoaiPhuCap.Text = "Loại phụ cấp:";
            // 
            // lblMaPC
            // 
            this.lblMaPC.AutoSize = true;
            this.lblMaPC.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMaPC.Location = new System.Drawing.Point(19, 41);
            this.lblMaPC.Name = "lblMaPC";
            this.lblMaPC.Size = new System.Drawing.Size(113, 22);
            this.lblMaPC.TabIndex = 1;
            this.lblMaPC.Text = "Mã phụ cấp: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(239, 314);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(356, 106);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CHỨC NĂNG";
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnSua.Location = new System.Drawing.Point(163, 44);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(63, 34);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSua.UseVisualStyleBackColor = false;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnThem.Location = new System.Drawing.Point(19, 44);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(69, 34);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnXoa.Location = new System.Drawing.Point(94, 44);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(63, 34);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvPhuCap);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox3.Location = new System.Drawing.Point(239, 433);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(356, 232);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "DANH SÁCH LOẠI PHỤ CẤP";
            // 
            // dgvPhuCap
            // 
            this.dgvPhuCap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhuCap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhuCap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvPhuCap.Location = new System.Drawing.Point(6, 28);
            this.dgvPhuCap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvPhuCap.Name = "dgvPhuCap";
            this.dgvPhuCap.ReadOnly = true;
            this.dgvPhuCap.RowHeadersVisible = false;
            this.dgvPhuCap.RowHeadersWidth = 51;
            this.dgvPhuCap.RowTemplate.Height = 24;
            this.dgvPhuCap.Size = new System.Drawing.Size(344, 199);
            this.dgvPhuCap.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaPhuCap";
            this.Column1.HeaderText = "Mã Phụ Cấp";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "LoaiPhuCap";
            this.Column2.HeaderText = "Loại Phụ Cấp";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbbMaPhuCapctPhuCap);
            this.groupBox4.Controls.Add(this.cbbMaNV);
            this.groupBox4.Controls.Add(this.txtSoTien);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.dtpNgayPhuCap);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox4.Location = new System.Drawing.Point(616, 114);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(552, 190);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "THÔNG TIN PHỤ CẤP";
            // 
            // cbbMaPhuCapctPhuCap
            // 
            this.cbbMaPhuCapctPhuCap.FormattingEnabled = true;
            this.cbbMaPhuCapctPhuCap.Location = new System.Drawing.Point(219, 67);
            this.cbbMaPhuCapctPhuCap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbMaPhuCapctPhuCap.Name = "cbbMaPhuCapctPhuCap";
            this.cbbMaPhuCapctPhuCap.Size = new System.Drawing.Size(199, 31);
            this.cbbMaPhuCapctPhuCap.TabIndex = 17;
            // 
            // cbbMaNV
            // 
            this.cbbMaNV.FormattingEnabled = true;
            this.cbbMaNV.Location = new System.Drawing.Point(219, 34);
            this.cbbMaNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbMaNV.Name = "cbbMaNV";
            this.cbbMaNV.Size = new System.Drawing.Size(199, 31);
            this.cbbMaNV.TabIndex = 16;
            // 
            // txtSoTien
            // 
            this.txtSoTien.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtSoTien.Location = new System.Drawing.Point(219, 144);
            this.txtSoTien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoTien.Name = "txtSoTien";
            this.txtSoTien.Size = new System.Drawing.Size(199, 30);
            this.txtSoTien.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(52, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "Số tiền: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(52, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ngày thêm phụ cấp";
            // 
            // dtpNgayPhuCap
            // 
            this.dtpNgayPhuCap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayPhuCap.Location = new System.Drawing.Point(262, 113);
            this.dtpNgayPhuCap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpNgayPhuCap.Name = "dtpNgayPhuCap";
            this.dtpNgayPhuCap.Size = new System.Drawing.Size(156, 30);
            this.dtpNgayPhuCap.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(52, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã phụ cấp:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(52, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã nhân viên: ";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnLamMoi);
            this.groupBox5.Controls.Add(this.btnLoc);
            this.groupBox5.Controls.Add(this.btnSuact);
            this.groupBox5.Controls.Add(this.btnThemct);
            this.groupBox5.Controls.Add(this.btnXoact);
            this.groupBox5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox5.Location = new System.Drawing.Point(616, 321);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Size = new System.Drawing.Size(552, 106);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "CHỨC NĂNG";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnLamMoi.Location = new System.Drawing.Point(421, 37);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(97, 34);
            this.btnLamMoi.TabIndex = 4;
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLamMoi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLamMoi.UseVisualStyleBackColor = false;
            // 
            // btnLoc
            // 
            this.btnLoc.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnLoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoc.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnLoc.Location = new System.Drawing.Point(329, 37);
            this.btnLoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(63, 34);
            this.btnLoc.TabIndex = 3;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLoc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLoc.UseVisualStyleBackColor = false;
            // 
            // btnSuact
            // 
            this.btnSuact.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnSuact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuact.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnSuact.Location = new System.Drawing.Point(234, 37);
            this.btnSuact.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSuact.Name = "btnSuact";
            this.btnSuact.Size = new System.Drawing.Size(63, 34);
            this.btnSuact.TabIndex = 3;
            this.btnSuact.Text = "Sửa";
            this.btnSuact.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSuact.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSuact.UseVisualStyleBackColor = false;
            // 
            // btnThemct
            // 
            this.btnThemct.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnThemct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemct.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnThemct.Location = new System.Drawing.Point(49, 37);
            this.btnThemct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemct.Name = "btnThemct";
            this.btnThemct.Size = new System.Drawing.Size(64, 34);
            this.btnThemct.TabIndex = 3;
            this.btnThemct.Text = "Thêm";
            this.btnThemct.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThemct.UseVisualStyleBackColor = false;
            // 
            // btnXoact
            // 
            this.btnXoact.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnXoact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoact.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnXoact.Location = new System.Drawing.Point(148, 37);
            this.btnXoact.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoact.Name = "btnXoact";
            this.btnXoact.Size = new System.Drawing.Size(63, 34);
            this.btnXoact.TabIndex = 3;
            this.btnXoact.Text = "Xoá";
            this.btnXoact.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoact.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoact.UseVisualStyleBackColor = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dgvctPhuCap);
            this.groupBox6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox6.Location = new System.Drawing.Point(616, 440);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox6.Size = new System.Drawing.Size(558, 225);
            this.groupBox6.TabIndex = 15;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "DANH SÁCH CHI TIẾT PHỤ CẤP";
            // 
            // dgvctPhuCap
            // 
            this.dgvctPhuCap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvctPhuCap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvctPhuCap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.MaThang,
            this.NgayPC,
            this.SoTien});
            this.dgvctPhuCap.Location = new System.Drawing.Point(19, 28);
            this.dgvctPhuCap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvctPhuCap.Name = "dgvctPhuCap";
            this.dgvctPhuCap.ReadOnly = true;
            this.dgvctPhuCap.RowHeadersVisible = false;
            this.dgvctPhuCap.RowHeadersWidth = 51;
            this.dgvctPhuCap.RowTemplate.Height = 24;
            this.dgvctPhuCap.Size = new System.Drawing.Size(516, 192);
            this.dgvctPhuCap.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaNV";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã Nhân Viên";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MaPhuCap";
            this.dataGridViewTextBoxColumn2.HeaderText = "Mã Phụ Cấp";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // MaThang
            // 
            this.MaThang.DataPropertyName = "MaThang";
            this.MaThang.HeaderText = "Mã Tháng";
            this.MaThang.MinimumWidth = 6;
            this.MaThang.Name = "MaThang";
            this.MaThang.ReadOnly = true;
            // 
            // NgayPC
            // 
            this.NgayPC.DataPropertyName = "NgayPhuCap";
            this.NgayPC.HeaderText = "Ngày Phụ Cấp";
            this.NgayPC.MinimumWidth = 6;
            this.NgayPC.Name = "NgayPC";
            this.NgayPC.ReadOnly = true;
            // 
            // SoTien
            // 
            this.SoTien.DataPropertyName = "SoTien";
            this.SoTien.HeaderText = "Số Tiền";
            this.SoTien.MinimumWidth = 6;
            this.SoTien.Name = "SoTien";
            this.SoTien.ReadOnly = true;
            // 
            // FormPhuCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1413, 778);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormPhuCap";
            this.Text = "FormPhuCap";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhuCap)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvctPhuCap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox2;
        private TextBox txtLoaiPC;
        private TextBox txtMaPC;
        private Label lblLoaiPhuCap;
        private Label lblMaPC;
        private GroupBox groupBox1;
        private Button btnSua;
        private Button btnThem;
        private Button btnXoa;
        private GroupBox groupBox3;
        private DataGridView dgvPhuCap;
        private GroupBox groupBox4;
        private Label label1;
        private Label label2;
        private GroupBox groupBox5;
        private Button btnLoc;
        private Button btnSuact;
        private Button btnThemct;
        private Button btnXoact;
        private GroupBox groupBox6;
        private DataGridView dgvctPhuCap;
        private TextBox txtSoTien;
        private Label label4;
        private Label label3;
        private DateTimePicker dtpNgayPhuCap;
        private ComboBox cbbMaNV;
        private ComboBox cbbMaPhuCapctPhuCap;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn MaThang;
        private DataGridViewTextBoxColumn NgayPC;
        private DataGridViewTextBoxColumn SoTien;
        private Button btnLamMoi;
    }
}