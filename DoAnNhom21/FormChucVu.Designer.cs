using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DoAnNhom21
{
    partial class FormChucVu
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox2 = new GroupBox();
            txtTenCV = new TextBox();
            txtMaCV = new TextBox();
            lblTenCV = new Label();
            lblMaCV = new Label();
            groupBox1 = new GroupBox();
            btnLamMoi = new Button();
            btnSua = new Button();
            btnThem = new Button();
            btnXoa = new Button();
            groupBox3 = new GroupBox();
            dataGridViewChucVu = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            btnThoat = new Button();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewChucVu).BeginInit();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtTenCV);
            groupBox2.Controls.Add(txtMaCV);
            groupBox2.Controls.Add(lblTenCV);
            groupBox2.Controls.Add(lblMaCV);
            groupBox2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            groupBox2.Location = new Point(40, 126);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(876, 176);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "THÔNG TIN CHỨC VỤ";
            // 
            // txtTenCV
            // 
            txtTenCV.Font = new Font("Times New Roman", 12F);
            txtTenCV.Location = new Point(355, 80);
            txtTenCV.Name = "txtTenCV";
            txtTenCV.Size = new Size(338, 30);
            txtTenCV.TabIndex = 2;
            // 
            // txtMaCV
            // 
            txtMaCV.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtMaCV.Location = new Point(355, 39);
            txtMaCV.Name = "txtMaCV";
            txtMaCV.Size = new Size(338, 30);
            txtMaCV.TabIndex = 2;
            // 
            // lblTenCV
            // 
            lblTenCV.AutoSize = true;
            lblTenCV.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lblTenCV.Location = new Point(171, 83);
            lblTenCV.Name = "lblTenCV";
            lblTenCV.Size = new Size(113, 22);
            lblTenCV.TabIndex = 1;
            lblTenCV.Text = "Tên chức vụ:";
            // 
            // lblMaCV
            // 
            lblMaCV.AutoSize = true;
            lblMaCV.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lblMaCV.Location = new Point(171, 42);
            lblMaCV.Name = "lblMaCV";
            lblMaCV.Size = new Size(114, 22);
            lblMaCV.TabIndex = 1;
            lblMaCV.Text = "Mã chức vụ: ";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnLamMoi);
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            groupBox1.Location = new Point(40, 339);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(876, 133);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "CHỨC NĂNG";
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.LavenderBlush;
            btnLamMoi.FlatStyle = FlatStyle.Flat;
            btnLamMoi.Font = new Font("Times New Roman", 12F);
            btnLamMoi.Location = new Point(535, 55);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(133, 42);
            btnLamMoi.TabIndex = 3;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.TextAlign = ContentAlignment.MiddleRight;
            btnLamMoi.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.LavenderBlush;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Font = new Font("Times New Roman", 12F);
            btnSua.Location = new Point(370, 55);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(133, 42);
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
            btnThem.Location = new Point(37, 55);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(133, 42);
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
            btnXoa.Location = new Point(203, 55);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(133, 42);
            btnXoa.TabIndex = 3;
            btnXoa.Text = "Xoá";
            btnXoa.TextAlign = ContentAlignment.MiddleRight;
            btnXoa.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dataGridViewChucVu);
            groupBox3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            groupBox3.Location = new Point(40, 509);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(876, 203);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "DANH SÁCH CHỨC VỤ ";
            // 
            // dataGridViewChucVu
            // 
            dataGridViewChucVu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewChucVu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewChucVu.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dataGridViewChucVu.Location = new Point(6, 35);
            dataGridViewChucVu.Name = "dataGridViewChucVu";
            dataGridViewChucVu.ReadOnly = true;
            dataGridViewChucVu.RowHeadersVisible = false;
            dataGridViewChucVu.RowHeadersWidth = 51;
            dataGridViewChucVu.RowTemplate.Height = 24;
            dataGridViewChucVu.Size = new Size(864, 162);
            dataGridViewChucVu.TabIndex = 0;
            dataGridViewChucVu.DoubleClick += dataGridViewChucVu_DoubleClick;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "MaCV";
            Column1.HeaderText = "Mã chức vụ";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "TenCV";
            Column2.HeaderText = "Tên chức vụ ";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.LavenderBlush;
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.Font = new Font("Times New Roman", 12F);
            btnThoat.Location = new Point(705, 55);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(133, 42);
            btnThoat.TabIndex = 3;
            btnThoat.Text = "Thoát";
            btnThoat.TextAlign = ContentAlignment.MiddleRight;
            btnThoat.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // FormChucVu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(957, 838);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(groupBox3);
            Name = "FormChucVu";
            Text = "FormChucVu";
            Load += FormChucVu_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewChucVu).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private TextBox txtTenCV;
        private TextBox txtMaCV;
        private Label lblTenCV;
        private Label lblMaCV;
        private GroupBox groupBox1;
        private Button btnLamMoi;
        private Button btnSua;
        private Button btnThem;
        private Button btnXoa;
        private GroupBox groupBox3;
        private DataGridView dataGridViewChucVu;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private Button btnThoat;
    }
}
