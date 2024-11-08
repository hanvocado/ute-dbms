namespace DoAnNhom21
{
    partial class FormNghiPhep
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
            this.dataGVoffHistory = new System.Windows.Forms.DataGridView();
            this.Ngay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LyDo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txtLyDo = new System.Windows.Forms.TextBox();
            this.txtNgayNghi = new System.Windows.Forms.TextBox();
            this.btnNghiPhep = new System.Windows.Forms.Button();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.tblMaNV = new System.Windows.Forms.Label();
            this.lblNgayNghi = new System.Windows.Forms.Label();
            this.cbbThang = new System.Windows.Forms.ComboBox();
            this.lblLyDo = new System.Windows.Forms.Label();
            this.lblNgayNghiPhep = new System.Windows.Forms.Label();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVoffHistory)).BeginInit();
            this.guna2GroupBox1.SuspendLayout();
            this.guna2GroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGVoffHistory
            // 
            this.dataGVoffHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGVoffHistory.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGVoffHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVoffHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ngay,
            this.Thang,
            this.LyDo});
            this.dataGVoffHistory.Location = new System.Drawing.Point(35, 71);
            this.dataGVoffHistory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGVoffHistory.Name = "dataGVoffHistory";
            this.dataGVoffHistory.RowHeadersWidth = 62;
            this.dataGVoffHistory.RowTemplate.Height = 28;
            this.dataGVoffHistory.Size = new System.Drawing.Size(769, 193);
            this.dataGVoffHistory.TabIndex = 0;
            // 
            // Ngay
            // 
            this.Ngay.DataPropertyName = "NgayNghiPhep";
            this.Ngay.HeaderText = "Ngày";
            this.Ngay.MinimumWidth = 8;
            this.Ngay.Name = "Ngay";
            // 
            // Thang
            // 
            this.Thang.DataPropertyName = "Thang";
            this.Thang.HeaderText = "Tháng";
            this.Thang.MinimumWidth = 8;
            this.Thang.Name = "Thang";
            // 
            // LyDo
            // 
            this.LyDo.DataPropertyName = "GhiChu";
            this.LyDo.HeaderText = "Lý do";
            this.LyDo.MinimumWidth = 8;
            this.LyDo.Name = "LyDo";
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(81)))), ((int)(((byte)(57)))));
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(81)))), ((int)(((byte)(57)))));
            this.guna2GroupBox1.Controls.Add(this.txtLyDo);
            this.guna2GroupBox1.Controls.Add(this.txtNgayNghi);
            this.guna2GroupBox1.Controls.Add(this.btnNghiPhep);
            this.guna2GroupBox1.Controls.Add(this.txtMaNV);
            this.guna2GroupBox1.Controls.Add(this.tblMaNV);
            this.guna2GroupBox1.Controls.Add(this.lblNgayNghi);
            this.guna2GroupBox1.Controls.Add(this.cbbThang);
            this.guna2GroupBox1.Controls.Add(this.lblLyDo);
            this.guna2GroupBox1.Controls.Add(this.lblNgayNghiPhep);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(81)))), ((int)(((byte)(57)))));
            this.guna2GroupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox1.Location = new System.Drawing.Point(260, 31);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(892, 304);
            this.guna2GroupBox1.TabIndex = 16;
            this.guna2GroupBox1.Text = "ĐĂNG KÝ NGHỈ PHÉP ";
            // 
            // txtLyDo
            // 
            this.txtLyDo.Location = new System.Drawing.Point(614, 129);
            this.txtLyDo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLyDo.Name = "txtLyDo";
            this.txtLyDo.Size = new System.Drawing.Size(251, 30);
            this.txtLyDo.TabIndex = 22;
            // 
            // txtNgayNghi
            // 
            this.txtNgayNghi.Location = new System.Drawing.Point(614, 77);
            this.txtNgayNghi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNgayNghi.Name = "txtNgayNghi";
            this.txtNgayNghi.Size = new System.Drawing.Size(251, 30);
            this.txtNgayNghi.TabIndex = 21;
            // 
            // btnNghiPhep
            // 
            this.btnNghiPhep.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnNghiPhep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNghiPhep.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnNghiPhep.Location = new System.Drawing.Point(348, 187);
            this.btnNghiPhep.Name = "btnNghiPhep";
            this.btnNghiPhep.Size = new System.Drawing.Size(184, 40);
            this.btnNghiPhep.TabIndex = 15;
            this.btnNghiPhep.Text = "Đăng ký nghỉ";
            this.btnNghiPhep.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNghiPhep.UseVisualStyleBackColor = false;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(142, 77);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.ReadOnly = true;
            this.txtMaNV.Size = new System.Drawing.Size(251, 30);
            this.txtMaNV.TabIndex = 20;
            // 
            // tblMaNV
            // 
            this.tblMaNV.AutoSize = true;
            this.tblMaNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(220)))));
            this.tblMaNV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tblMaNV.Location = new System.Drawing.Point(31, 80);
            this.tblMaNV.Name = "tblMaNV";
            this.tblMaNV.Size = new System.Drawing.Size(78, 22);
            this.tblMaNV.TabIndex = 19;
            this.tblMaNV.Text = "Mã NV: ";
            // 
            // lblNgayNghi
            // 
            this.lblNgayNghi.AutoSize = true;
            this.lblNgayNghi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(220)))));
            this.lblNgayNghi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNgayNghi.Location = new System.Drawing.Point(503, 80);
            this.lblNgayNghi.Name = "lblNgayNghi";
            this.lblNgayNghi.Size = new System.Drawing.Size(62, 22);
            this.lblNgayNghi.TabIndex = 18;
            this.lblNgayNghi.Text = "Ngày: ";
            // 
            // cbbThang
            // 
            this.cbbThang.FormattingEnabled = true;
            this.cbbThang.Location = new System.Drawing.Point(142, 129);
            this.cbbThang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbThang.Name = "cbbThang";
            this.cbbThang.Size = new System.Drawing.Size(251, 31);
            this.cbbThang.TabIndex = 17;
            // 
            // lblLyDo
            // 
            this.lblLyDo.AutoSize = true;
            this.lblLyDo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(220)))));
            this.lblLyDo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblLyDo.Location = new System.Drawing.Point(503, 132);
            this.lblLyDo.Name = "lblLyDo";
            this.lblLyDo.Size = new System.Drawing.Size(67, 22);
            this.lblLyDo.TabIndex = 16;
            this.lblLyDo.Text = "Lý do: ";
            // 
            // lblNgayNghiPhep
            // 
            this.lblNgayNghiPhep.AutoSize = true;
            this.lblNgayNghiPhep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(220)))));
            this.lblNgayNghiPhep.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNgayNghiPhep.Location = new System.Drawing.Point(28, 134);
            this.lblNgayNghiPhep.Name = "lblNgayNghiPhep";
            this.lblNgayNghiPhep.Size = new System.Drawing.Size(69, 22);
            this.lblNgayNghiPhep.TabIndex = 14;
            this.lblNgayNghiPhep.Text = "Tháng: ";
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(81)))), ((int)(((byte)(57)))));
            this.guna2GroupBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(81)))), ((int)(((byte)(57)))));
            this.guna2GroupBox2.Controls.Add(this.dataGVoffHistory);
            this.guna2GroupBox2.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(81)))), ((int)(((byte)(57)))));
            this.guna2GroupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox2.Location = new System.Drawing.Point(260, 373);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.Size = new System.Drawing.Size(892, 304);
            this.guna2GroupBox2.TabIndex = 17;
            this.guna2GroupBox2.Text = "LỊCH SỬ XIN NGHỈ PHÉP ";
            // 
            // FormNghiPhep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(1413, 778);
            this.Controls.Add(this.guna2GroupBox2);
            this.Controls.Add(this.guna2GroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormNghiPhep";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormNghiPhep";
            this.Load += new System.EventHandler(this.FormNghiPhep_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVoffHistory)).EndInit();
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.guna2GroupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGVoffHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngay;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thang;
        private System.Windows.Forms.DataGridViewTextBoxColumn LyDo;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private System.Windows.Forms.TextBox txtLyDo;
        private System.Windows.Forms.TextBox txtNgayNghi;
        private System.Windows.Forms.Button btnNghiPhep;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label tblMaNV;
        private System.Windows.Forms.Label lblNgayNghi;
        private System.Windows.Forms.ComboBox cbbThang;
        private System.Windows.Forms.Label lblLyDo;
        private System.Windows.Forms.Label lblNgayNghiPhep;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
    }
}