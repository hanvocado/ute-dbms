namespace DoAnNhom21
{
    partial class FormChamCong
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
            this.dataGridViewChamCong = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HeSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnChamCong = new System.Windows.Forms.Button();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChamCong)).BeginInit();
            this.guna2GroupBox1.SuspendLayout();
            this.guna2GroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewChamCong
            // 
            this.dataGridViewChamCong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewChamCong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewChamCong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Thang,
            this.Column3,
            this.HeSo});
            this.dataGridViewChamCong.Location = new System.Drawing.Point(6, 43);
            this.dataGridViewChamCong.Name = "dataGridViewChamCong";
            this.dataGridViewChamCong.ReadOnly = true;
            this.dataGridViewChamCong.RowHeadersVisible = false;
            this.dataGridViewChamCong.RowHeadersWidth = 51;
            this.dataGridViewChamCong.RowTemplate.Height = 24;
            this.dataGridViewChamCong.Size = new System.Drawing.Size(868, 325);
            this.dataGridViewChamCong.TabIndex = 4;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "NgayChamCong";
            this.Column2.HeaderText = "Ngày chấm công";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Thang
            // 
            this.Thang.DataPropertyName = "Thang";
            this.Thang.HeaderText = "Tháng";
            this.Thang.MinimumWidth = 8;
            this.Thang.Name = "Thang";
            this.Thang.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "MoTa";
            this.Column3.HeaderText = "Mô tả";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // HeSo
            // 
            this.HeSo.DataPropertyName = "HeSo";
            this.HeSo.HeaderText = "Hệ số";
            this.HeSo.MinimumWidth = 8;
            this.HeSo.Name = "HeSo";
            this.HeSo.ReadOnly = true;
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.btnChamCong);
            this.guna2GroupBox1.Controls.Add(this.txtMaNV);
            this.guna2GroupBox1.Controls.Add(this.lblMaNV);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(81)))), ((int)(((byte)(57)))));
            this.guna2GroupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox1.Location = new System.Drawing.Point(69, 48);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(877, 243);
            this.guna2GroupBox1.TabIndex = 10;
            this.guna2GroupBox1.Text = "THÔNG TIN CHẤM CÔNG";
            // 
            // btnChamCong
            // 
            this.btnChamCong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(81)))), ((int)(((byte)(57)))));
            this.btnChamCong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChamCong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnChamCong.Location = new System.Drawing.Point(320, 173);
            this.btnChamCong.Name = "btnChamCong";
            this.btnChamCong.Size = new System.Drawing.Size(237, 44);
            this.btnChamCong.TabIndex = 11;
            this.btnChamCong.Text = "Chấm công";
            this.btnChamCong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChamCong.UseVisualStyleBackColor = false;
            this.btnChamCong.Click += new System.EventHandler(this.btnChamCong_Click);
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(407, 83);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.ReadOnly = true;
            this.txtMaNV.Size = new System.Drawing.Size(310, 30);
            this.txtMaNV.TabIndex = 12;
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMaNV.Location = new System.Drawing.Point(238, 91);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(127, 22);
            this.lblMaNV.TabIndex = 10;
            this.lblMaNV.Text = "Mã nhân viên: ";
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.Controls.Add(this.dataGridViewChamCong);
            this.guna2GroupBox2.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(81)))), ((int)(((byte)(57)))));
            this.guna2GroupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox2.Location = new System.Drawing.Point(69, 370);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.Size = new System.Drawing.Size(877, 385);
            this.guna2GroupBox2.TabIndex = 11;
            this.guna2GroupBox2.Text = "DANH SÁCH CHẤM CÔNG";
            // 
            // FormChamCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(1060, 805);
            this.Controls.Add(this.guna2GroupBox2);
            this.Controls.Add(this.guna2GroupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormChamCong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormChamCong";
            this.Load += new System.EventHandler(this.FormChamCong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChamCong)).EndInit();
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.guna2GroupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewChamCong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn HeSo;
        private System.Windows.Forms.FontDialog fontDialog1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private System.Windows.Forms.Button btnChamCong;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label lblMaNV;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
    }
}