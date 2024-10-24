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
            groupBox2 = new GroupBox();
            txtLoaiPC = new TextBox();
            txtMaPC = new TextBox();
            lblLoaiPhuCap = new Label();
            lblMaPC = new Label();
            groupBox1 = new GroupBox();
            btnSua = new Button();
            btnThem = new Button();
            btnXoa = new Button();
            groupBox3 = new GroupBox();
            dgvPhuCap = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            groupBox4 = new GroupBox();
            cbbMaPhuCapctPhuCap = new ComboBox();
            cbbMaNV = new ComboBox();
            txtSoTien = new TextBox();
            label4 = new Label();
            label3 = new Label();
            dtpNgayPhuCap = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            groupBox5 = new GroupBox();
            btnLamMoi = new Button();
            btnLoc = new Button();
            btnSuact = new Button();
            btnThemct = new Button();
            btnXoact = new Button();
            groupBox6 = new GroupBox();
            dgvctPhuCap = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            MaThang = new DataGridViewTextBoxColumn();
            NgayPC = new DataGridViewTextBoxColumn();
            SoTien = new DataGridViewTextBoxColumn();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPhuCap).BeginInit();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvctPhuCap).BeginInit();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtLoaiPC);
            groupBox2.Controls.Add(txtMaPC);
            groupBox2.Controls.Add(lblLoaiPhuCap);
            groupBox2.Controls.Add(lblMaPC);
            groupBox2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            groupBox2.Location = new Point(43, 88);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(356, 176);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "THÔNG TIN LOẠI PHỤ CẤP";
            // 
            // txtLoaiPC
            // 
            txtLoaiPC.Font = new Font("Times New Roman", 12F);
            txtLoaiPC.Location = new Point(138, 92);
            txtLoaiPC.Name = "txtLoaiPC";
            txtLoaiPC.Size = new Size(199, 30);
            txtLoaiPC.TabIndex = 2;
            // 
            // txtMaPC
            // 
            txtMaPC.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtMaPC.Location = new Point(138, 43);
            txtMaPC.Name = "txtMaPC";
            txtMaPC.Size = new Size(199, 30);
            txtMaPC.TabIndex = 2;
            // 
            // lblLoaiPhuCap
            // 
            lblLoaiPhuCap.AutoSize = true;
            lblLoaiPhuCap.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lblLoaiPhuCap.Location = new Point(19, 92);
            lblLoaiPhuCap.Name = "lblLoaiPhuCap";
            lblLoaiPhuCap.Size = new Size(118, 22);
            lblLoaiPhuCap.TabIndex = 1;
            lblLoaiPhuCap.Text = "Loại phụ cấp:";
            // 
            // lblMaPC
            // 
            lblMaPC.AutoSize = true;
            lblMaPC.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lblMaPC.Location = new Point(19, 51);
            lblMaPC.Name = "lblMaPC";
            lblMaPC.Size = new Size(113, 22);
            lblMaPC.TabIndex = 1;
            lblMaPC.Text = "Mã phụ cấp: ";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            groupBox1.Location = new Point(43, 285);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(356, 133);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "CHỨC NĂNG";
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.LavenderBlush;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Font = new Font("Times New Roman", 12F);
            btnSua.Location = new Point(163, 55);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(63, 42);
            btnSua.TabIndex = 3;
            btnSua.Text = "Sửa";
            btnSua.TextAlign = ContentAlignment.MiddleRight;
            btnSua.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.LavenderBlush;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Font = new Font("Times New Roman", 12F);
            btnThem.Location = new Point(19, 55);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(69, 42);
            btnThem.TabIndex = 3;
            btnThem.Text = "Thêm";
            btnThem.TextAlign = ContentAlignment.MiddleRight;
            btnThem.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.LavenderBlush;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Font = new Font("Times New Roman", 12F);
            btnXoa.Location = new Point(94, 55);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(63, 42);
            btnXoa.TabIndex = 3;
            btnXoa.Text = "Xoá";
            btnXoa.TextAlign = ContentAlignment.MiddleRight;
            btnXoa.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dgvPhuCap);
            groupBox3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            groupBox3.Location = new Point(43, 434);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(356, 290);
            groupBox3.TabIndex = 12;
            groupBox3.TabStop = false;
            groupBox3.Text = "DANH SÁCH LOẠI PHỤ CẤP";
            // 
            // dgvPhuCap
            // 
            dgvPhuCap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPhuCap.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPhuCap.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dgvPhuCap.Location = new Point(6, 35);
            dgvPhuCap.Name = "dgvPhuCap";
            dgvPhuCap.ReadOnly = true;
            dgvPhuCap.RowHeadersVisible = false;
            dgvPhuCap.RowHeadersWidth = 51;
            dgvPhuCap.RowTemplate.Height = 24;
            dgvPhuCap.Size = new Size(344, 249);
            dgvPhuCap.TabIndex = 0;
            dgvPhuCap.DoubleClick += dgvPhuCap_DoubleClick;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "MaPhuCap";
            Column1.HeaderText = "Mã Phụ Cấp";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "LoaiPhuCap";
            Column2.HeaderText = "Loại Phụ Cấp";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(cbbMaPhuCapctPhuCap);
            groupBox4.Controls.Add(cbbMaNV);
            groupBox4.Controls.Add(txtSoTien);
            groupBox4.Controls.Add(label4);
            groupBox4.Controls.Add(label3);
            groupBox4.Controls.Add(dtpNgayPhuCap);
            groupBox4.Controls.Add(label1);
            groupBox4.Controls.Add(label2);
            groupBox4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            groupBox4.Location = new Point(420, 35);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(552, 238);
            groupBox4.TabIndex = 14;
            groupBox4.TabStop = false;
            groupBox4.Text = "THÔNG TIN PHỤ CẤP";
            // 
            // cbbMaPhuCapctPhuCap
            // 
            cbbMaPhuCapctPhuCap.FormattingEnabled = true;
            cbbMaPhuCapctPhuCap.Location = new Point(219, 84);
            cbbMaPhuCapctPhuCap.Name = "cbbMaPhuCapctPhuCap";
            cbbMaPhuCapctPhuCap.Size = new Size(199, 31);
            cbbMaPhuCapctPhuCap.TabIndex = 17;
            // 
            // cbbMaNV
            // 
            cbbMaNV.FormattingEnabled = true;
            cbbMaNV.Location = new Point(219, 43);
            cbbMaNV.Name = "cbbMaNV";
            cbbMaNV.Size = new Size(199, 31);
            cbbMaNV.TabIndex = 16;
            // 
            // txtSoTien
            // 
            txtSoTien.Font = new Font("Times New Roman", 12F);
            txtSoTien.Location = new Point(219, 180);
            txtSoTien.Name = "txtSoTien";
            txtSoTien.Size = new Size(199, 30);
            txtSoTien.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label4.Location = new Point(52, 183);
            label4.Name = "label4";
            label4.Size = new Size(76, 22);
            label4.TabIndex = 5;
            label4.Text = "Số tiền: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label3.Location = new Point(52, 141);
            label3.Name = "label3";
            label3.Size = new Size(159, 22);
            label3.TabIndex = 4;
            label3.Text = "Ngày thêm phụ cấp";
            // 
            // dtpNgayPhuCap
            // 
            dtpNgayPhuCap.Format = DateTimePickerFormat.Custom;
            dtpNgayPhuCap.Location = new Point(262, 141);
            dtpNgayPhuCap.Name = "dtpNgayPhuCap";
            dtpNgayPhuCap.Size = new Size(156, 30);
            dtpNgayPhuCap.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label1.Location = new Point(52, 93);
            label1.Name = "label1";
            label1.Size = new Size(108, 22);
            label1.TabIndex = 1;
            label1.Text = "Mã phụ cấp:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label2.Location = new Point(52, 52);
            label2.Name = "label2";
            label2.Size = new Size(127, 22);
            label2.TabIndex = 1;
            label2.Text = "Mã nhân viên: ";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(btnLamMoi);
            groupBox5.Controls.Add(btnLoc);
            groupBox5.Controls.Add(btnSuact);
            groupBox5.Controls.Add(btnThemct);
            groupBox5.Controls.Add(btnXoact);
            groupBox5.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            groupBox5.Location = new Point(420, 294);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(552, 133);
            groupBox5.TabIndex = 13;
            groupBox5.TabStop = false;
            groupBox5.Text = "CHỨC NĂNG";
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.LavenderBlush;
            btnLamMoi.FlatStyle = FlatStyle.Flat;
            btnLamMoi.Font = new Font("Times New Roman", 12F);
            btnLamMoi.Location = new Point(421, 46);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(97, 42);
            btnLamMoi.TabIndex = 4;
            btnLamMoi.Text = "Làm Mới";
            btnLamMoi.TextAlign = ContentAlignment.MiddleRight;
            btnLamMoi.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnLoc
            // 
            btnLoc.BackColor = Color.LavenderBlush;
            btnLoc.FlatStyle = FlatStyle.Flat;
            btnLoc.Font = new Font("Times New Roman", 12F);
            btnLoc.Location = new Point(329, 46);
            btnLoc.Name = "btnLoc";
            btnLoc.Size = new Size(63, 42);
            btnLoc.TabIndex = 3;
            btnLoc.Text = "Lọc";
            btnLoc.TextAlign = ContentAlignment.MiddleRight;
            btnLoc.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLoc.UseVisualStyleBackColor = false;
            // 
            // btnSuact
            // 
            btnSuact.BackColor = Color.LavenderBlush;
            btnSuact.FlatStyle = FlatStyle.Flat;
            btnSuact.Font = new Font("Times New Roman", 12F);
            btnSuact.Location = new Point(234, 46);
            btnSuact.Name = "btnSuact";
            btnSuact.Size = new Size(63, 42);
            btnSuact.TabIndex = 3;
            btnSuact.Text = "Sửa";
            btnSuact.TextAlign = ContentAlignment.MiddleRight;
            btnSuact.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSuact.UseVisualStyleBackColor = false;
            btnSuact.Click += btnSuact_Click;
            // 
            // btnThemct
            // 
            btnThemct.BackColor = Color.LavenderBlush;
            btnThemct.FlatStyle = FlatStyle.Flat;
            btnThemct.Font = new Font("Times New Roman", 12F);
            btnThemct.Location = new Point(49, 46);
            btnThemct.Name = "btnThemct";
            btnThemct.Size = new Size(64, 42);
            btnThemct.TabIndex = 3;
            btnThemct.Text = "Thêm";
            btnThemct.TextAlign = ContentAlignment.MiddleRight;
            btnThemct.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnThemct.UseVisualStyleBackColor = false;
            btnThemct.Click += btnThemct_Click;
            // 
            // btnXoact
            // 
            btnXoact.BackColor = Color.LavenderBlush;
            btnXoact.FlatStyle = FlatStyle.Flat;
            btnXoact.Font = new Font("Times New Roman", 12F);
            btnXoact.Location = new Point(148, 46);
            btnXoact.Name = "btnXoact";
            btnXoact.Size = new Size(63, 42);
            btnXoact.TabIndex = 3;
            btnXoact.Text = "Xoá";
            btnXoact.TextAlign = ContentAlignment.MiddleRight;
            btnXoact.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnXoact.UseVisualStyleBackColor = false;
            btnXoact.Click += btnXoact_Click;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(dgvctPhuCap);
            groupBox6.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            groupBox6.Location = new Point(420, 443);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(558, 281);
            groupBox6.TabIndex = 15;
            groupBox6.TabStop = false;
            groupBox6.Text = "DANH SÁCH CHI TIẾT PHỤ CẤP";
            // 
            // dgvctPhuCap
            // 
            dgvctPhuCap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvctPhuCap.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvctPhuCap.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, MaThang, NgayPC, SoTien });
            dgvctPhuCap.Location = new Point(19, 35);
            dgvctPhuCap.Name = "dgvctPhuCap";
            dgvctPhuCap.ReadOnly = true;
            dgvctPhuCap.RowHeadersVisible = false;
            dgvctPhuCap.RowHeadersWidth = 51;
            dgvctPhuCap.RowTemplate.Height = 24;
            dgvctPhuCap.Size = new Size(516, 240);
            dgvctPhuCap.TabIndex = 0;
            dgvctPhuCap.DoubleClick += dgvctPhuCap_DoubleClick;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "MaNV";
            dataGridViewTextBoxColumn1.HeaderText = "Mã Nhân Viên";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "MaPhuCap";
            dataGridViewTextBoxColumn2.HeaderText = "Mã Phụ Cấp";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // MaThang
            // 
            MaThang.DataPropertyName = "MaThang";
            MaThang.HeaderText = "Mã Tháng";
            MaThang.MinimumWidth = 6;
            MaThang.Name = "MaThang";
            MaThang.ReadOnly = true;
            // 
            // NgayPC
            // 
            NgayPC.DataPropertyName = "NgayPhuCap";
            NgayPC.HeaderText = "Ngày Phụ Cấp";
            NgayPC.MinimumWidth = 6;
            NgayPC.Name = "NgayPC";
            NgayPC.ReadOnly = true;
            // 
            // SoTien
            // 
            SoTien.DataPropertyName = "SoTien";
            SoTien.HeaderText = "Số Tiền";
            SoTien.MinimumWidth = 6;
            SoTien.Name = "SoTien";
            SoTien.ReadOnly = true;
            // 
            // FormPhuCap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1042, 758);
            Controls.Add(groupBox4);
            Controls.Add(groupBox5);
            Controls.Add(groupBox6);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(groupBox3);
            Name = "FormPhuCap";
            Text = "FormPhuCap";
            Load += FormPhuCap_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPhuCap).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvctPhuCap).EndInit();
            ResumeLayout(false);
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