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
            this.lblNgayNghiPhep = new System.Windows.Forms.Label();
            this.lblLyDo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtLyDo = new System.Windows.Forms.TextBox();
            this.txtNgayNghi = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.tblMaNV = new System.Windows.Forms.Label();
            this.lblNgayNghi = new System.Windows.Forms.Label();
            this.cbbThang = new System.Windows.Forms.ComboBox();
            this.btnNghiPhep = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNgayNghiPhep
            // 
            this.lblNgayNghiPhep.AutoSize = true;
            this.lblNgayNghiPhep.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNgayNghiPhep.Location = new System.Drawing.Point(253, 116);
            this.lblNgayNghiPhep.Name = "lblNgayNghiPhep";
            this.lblNgayNghiPhep.Size = new System.Drawing.Size(84, 27);
            this.lblNgayNghiPhep.TabIndex = 3;
            this.lblNgayNghiPhep.Text = "Tháng: ";
            // 
            // lblLyDo
            // 
            this.lblLyDo.AutoSize = true;
            this.lblLyDo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblLyDo.Location = new System.Drawing.Point(256, 242);
            this.lblLyDo.Name = "lblLyDo";
            this.lblLyDo.Size = new System.Drawing.Size(81, 27);
            this.lblLyDo.TabIndex = 5;
            this.lblLyDo.Text = "Lý do: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtLyDo);
            this.groupBox1.Controls.Add(this.txtNgayNghi);
            this.groupBox1.Controls.Add(this.txtMaNV);
            this.groupBox1.Controls.Add(this.tblMaNV);
            this.groupBox1.Controls.Add(this.lblNgayNghi);
            this.groupBox1.Controls.Add(this.cbbThang);
            this.groupBox1.Controls.Add(this.lblLyDo);
            this.groupBox1.Controls.Add(this.lblNgayNghiPhep);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(76, 171);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(966, 330);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ĐĂNG KÝ NGHỈ PHÉP";
            // 
            // txtLyDo
            // 
            this.txtLyDo.Location = new System.Drawing.Point(381, 239);
            this.txtLyDo.Name = "txtLyDo";
            this.txtLyDo.Size = new System.Drawing.Size(282, 35);
            this.txtLyDo.TabIndex = 13;
            // 
            // txtNgayNghi
            // 
            this.txtNgayNghi.Location = new System.Drawing.Point(381, 174);
            this.txtNgayNghi.Name = "txtNgayNghi";
            this.txtNgayNghi.Size = new System.Drawing.Size(282, 35);
            this.txtNgayNghi.TabIndex = 12;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(381, 45);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.ReadOnly = true;
            this.txtMaNV.Size = new System.Drawing.Size(282, 35);
            this.txtMaNV.TabIndex = 11;
            // 
            // tblMaNV
            // 
            this.tblMaNV.AutoSize = true;
            this.tblMaNV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tblMaNV.Location = new System.Drawing.Point(256, 48);
            this.tblMaNV.Name = "tblMaNV";
            this.tblMaNV.Size = new System.Drawing.Size(93, 27);
            this.tblMaNV.TabIndex = 10;
            this.tblMaNV.Text = "Mã NV: ";
            // 
            // lblNgayNghi
            // 
            this.lblNgayNghi.AutoSize = true;
            this.lblNgayNghi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNgayNghi.Location = new System.Drawing.Point(256, 177);
            this.lblNgayNghi.Name = "lblNgayNghi";
            this.lblNgayNghi.Size = new System.Drawing.Size(75, 27);
            this.lblNgayNghi.TabIndex = 8;
            this.lblNgayNghi.Text = "Ngày: ";
            // 
            // cbbThang
            // 
            this.cbbThang.FormattingEnabled = true;
            this.cbbThang.Location = new System.Drawing.Point(381, 109);
            this.cbbThang.Name = "cbbThang";
            this.cbbThang.Size = new System.Drawing.Size(282, 34);
            this.cbbThang.TabIndex = 7;
            // 
            // btnNghiPhep
            // 
            this.btnNghiPhep.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnNghiPhep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNghiPhep.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnNghiPhep.Location = new System.Drawing.Point(457, 547);
            this.btnNghiPhep.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNghiPhep.Name = "btnNghiPhep";
            this.btnNghiPhep.Size = new System.Drawing.Size(207, 50);
            this.btnNghiPhep.TabIndex = 4;
            this.btnNghiPhep.Text = "Đăng ký nghỉ";
            this.btnNghiPhep.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNghiPhep.UseVisualStyleBackColor = false;
            this.btnNghiPhep.Click += new System.EventHandler(this.btnNghiPhep_Click);
            // 
            // FormNghiPhep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1171, 1001);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnNghiPhep);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormNghiPhep";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormNghiPhep";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblNgayNghiPhep;
        private System.Windows.Forms.Button btnNghiPhep;
        private System.Windows.Forms.Label lblLyDo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblNgayNghi;
        private System.Windows.Forms.ComboBox cbbThang;
        private System.Windows.Forms.Label tblMaNV;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.TextBox txtLyDo;
        private System.Windows.Forms.TextBox txtNgayNghi;
    }
}