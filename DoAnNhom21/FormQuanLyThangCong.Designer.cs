﻿namespace DoAnNhom21
{
    partial class FormQuanLyThangCong
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
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.dataGVThang = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSuaThang = new System.Windows.Forms.Button();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.txtMaThang = new System.Windows.Forms.TextBox();
            this.lblSoNgayCong = new System.Windows.Forms.Label();
            this.btnThemThang = new System.Windows.Forms.Button();
            this.lblMoTa = new System.Windows.Forms.Label();
            this.txtSoNgayCong = new System.Windows.Forms.TextBox();
            this.lblMaThang = new System.Windows.Forms.Label();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnLamMoiCong = new System.Windows.Forms.Button();
            this.dataGVCong = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSuaCong = new System.Windows.Forms.Button();
            this.txtMoTaCong = new System.Windows.Forms.TextBox();
            this.btnThemCong = new System.Windows.Forms.Button();
            this.txtMaCC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHeSo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVThang)).BeginInit();
            this.guna2GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVCong)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(81)))), ((int)(((byte)(57)))));
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(81)))), ((int)(((byte)(57)))));
            this.guna2GroupBox1.Controls.Add(this.btnLamMoi);
            this.guna2GroupBox1.Controls.Add(this.dataGVThang);
            this.guna2GroupBox1.Controls.Add(this.btnSuaThang);
            this.guna2GroupBox1.Controls.Add(this.txtMoTa);
            this.guna2GroupBox1.Controls.Add(this.txtMaThang);
            this.guna2GroupBox1.Controls.Add(this.lblSoNgayCong);
            this.guna2GroupBox1.Controls.Add(this.btnThemThang);
            this.guna2GroupBox1.Controls.Add(this.lblMoTa);
            this.guna2GroupBox1.Controls.Add(this.txtSoNgayCong);
            this.guna2GroupBox1.Controls.Add(this.lblMaThang);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(81)))), ((int)(((byte)(57)))));
            this.guna2GroupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox1.Location = new System.Drawing.Point(18, 91);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(1023, 295);
            this.guna2GroupBox1.TabIndex = 23;
            this.guna2GroupBox1.Text = "QUẢN LÝ THÁNG ";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLamMoi.Location = new System.Drawing.Point(286, 243);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(112, 34);
            this.btnLamMoi.TabIndex = 20;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLamMoi.UseVisualStyleBackColor = false;
            // 
            // dataGVThang
            // 
            this.dataGVThang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGVThang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVThang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dataGVThang.Location = new System.Drawing.Point(417, 43);
            this.dataGVThang.Name = "dataGVThang";
            this.dataGVThang.ReadOnly = true;
            this.dataGVThang.RowHeadersVisible = false;
            this.dataGVThang.RowHeadersWidth = 51;
            this.dataGVThang.RowTemplate.Height = 24;
            this.dataGVThang.Size = new System.Drawing.Size(584, 234);
            this.dataGVThang.TabIndex = 19;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaThang";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã tháng";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MoTa";
            this.dataGridViewTextBoxColumn2.HeaderText = "Mô tả";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "SoNgayCongChuan";
            this.dataGridViewTextBoxColumn3.HeaderText = "Số ngày công";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // btnSuaThang
            // 
            this.btnSuaThang.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnSuaThang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaThang.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaThang.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSuaThang.Location = new System.Drawing.Point(152, 243);
            this.btnSuaThang.Name = "btnSuaThang";
            this.btnSuaThang.Size = new System.Drawing.Size(112, 34);
            this.btnSuaThang.TabIndex = 17;
            this.btnSuaThang.Text = "Sửa";
            this.btnSuaThang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSuaThang.UseVisualStyleBackColor = false;
            // 
            // txtMoTa
            // 
            this.txtMoTa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMoTa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoTa.Location = new System.Drawing.Point(196, 97);
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(202, 30);
            this.txtMoTa.TabIndex = 18;
            // 
            // txtMaThang
            // 
            this.txtMaThang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaThang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaThang.Location = new System.Drawing.Point(196, 43);
            this.txtMaThang.Name = "txtMaThang";
            this.txtMaThang.Size = new System.Drawing.Size(202, 30);
            this.txtMaThang.TabIndex = 16;
            // 
            // lblSoNgayCong
            // 
            this.lblSoNgayCong.AutoSize = true;
            this.lblSoNgayCong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoNgayCong.Location = new System.Drawing.Point(33, 159);
            this.lblSoNgayCong.Name = "lblSoNgayCong";
            this.lblSoNgayCong.Size = new System.Drawing.Size(175, 22);
            this.lblSoNgayCong.TabIndex = 11;
            this.lblSoNgayCong.Text = "Số ngày công chuẩn: ";
            // 
            // btnThemThang
            // 
            this.btnThemThang.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnThemThang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemThang.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemThang.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemThang.Location = new System.Drawing.Point(26, 243);
            this.btnThemThang.Name = "btnThemThang";
            this.btnThemThang.Size = new System.Drawing.Size(112, 34);
            this.btnThemThang.TabIndex = 15;
            this.btnThemThang.Text = "Thêm";
            this.btnThemThang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThemThang.UseVisualStyleBackColor = false;
            // 
            // lblMoTa
            // 
            this.lblMoTa.AutoSize = true;
            this.lblMoTa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoTa.Location = new System.Drawing.Point(33, 105);
            this.lblMoTa.Name = "lblMoTa";
            this.lblMoTa.Size = new System.Drawing.Size(67, 22);
            this.lblMoTa.TabIndex = 12;
            this.lblMoTa.Text = "Mô tả: ";
            // 
            // txtSoNgayCong
            // 
            this.txtSoNgayCong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSoNgayCong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoNgayCong.Location = new System.Drawing.Point(239, 157);
            this.txtSoNgayCong.Name = "txtSoNgayCong";
            this.txtSoNgayCong.Size = new System.Drawing.Size(159, 30);
            this.txtSoNgayCong.TabIndex = 14;
            // 
            // lblMaThang
            // 
            this.lblMaThang.AutoSize = true;
            this.lblMaThang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaThang.Location = new System.Drawing.Point(33, 51);
            this.lblMaThang.Name = "lblMaThang";
            this.lblMaThang.Size = new System.Drawing.Size(93, 22);
            this.lblMaThang.TabIndex = 13;
            this.lblMaThang.Text = "Mã tháng: ";
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(81)))), ((int)(((byte)(57)))));
            this.guna2GroupBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(81)))), ((int)(((byte)(57)))));
            this.guna2GroupBox2.Controls.Add(this.btnLamMoiCong);
            this.guna2GroupBox2.Controls.Add(this.dataGVCong);
            this.guna2GroupBox2.Controls.Add(this.btnSuaCong);
            this.guna2GroupBox2.Controls.Add(this.txtMoTaCong);
            this.guna2GroupBox2.Controls.Add(this.btnThemCong);
            this.guna2GroupBox2.Controls.Add(this.txtMaCC);
            this.guna2GroupBox2.Controls.Add(this.label1);
            this.guna2GroupBox2.Controls.Add(this.label2);
            this.guna2GroupBox2.Controls.Add(this.txtHeSo);
            this.guna2GroupBox2.Controls.Add(this.label3);
            this.guna2GroupBox2.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(81)))), ((int)(((byte)(57)))));
            this.guna2GroupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox2.Location = new System.Drawing.Point(18, 419);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.Size = new System.Drawing.Size(1023, 295);
            this.guna2GroupBox2.TabIndex = 24;
            this.guna2GroupBox2.Text = "QUẢN LÝ THÁNG ";
            // 
            // btnLamMoiCong
            // 
            this.btnLamMoiCong.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnLamMoiCong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoiCong.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoiCong.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLamMoiCong.Location = new System.Drawing.Point(286, 241);
            this.btnLamMoiCong.Name = "btnLamMoiCong";
            this.btnLamMoiCong.Size = new System.Drawing.Size(112, 34);
            this.btnLamMoiCong.TabIndex = 21;
            this.btnLamMoiCong.Text = "Làm mới";
            this.btnLamMoiCong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLamMoiCong.UseVisualStyleBackColor = false;
            // 
            // dataGVCong
            // 
            this.dataGVCong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGVCong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVCong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dataGVCong.Location = new System.Drawing.Point(417, 65);
            this.dataGVCong.Name = "dataGVCong";
            this.dataGVCong.ReadOnly = true;
            this.dataGVCong.RowHeadersVisible = false;
            this.dataGVCong.RowHeadersWidth = 51;
            this.dataGVCong.RowTemplate.Height = 24;
            this.dataGVCong.Size = new System.Drawing.Size(590, 210);
            this.dataGVCong.TabIndex = 19;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "MaCC";
            this.dataGridViewTextBoxColumn4.HeaderText = "Mã chấm công";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "MoTa";
            this.dataGridViewTextBoxColumn5.HeaderText = "Mô tả";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "HeSo";
            this.dataGridViewTextBoxColumn6.HeaderText = "Hệ số";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // btnSuaCong
            // 
            this.btnSuaCong.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnSuaCong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaCong.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaCong.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSuaCong.Location = new System.Drawing.Point(152, 241);
            this.btnSuaCong.Name = "btnSuaCong";
            this.btnSuaCong.Size = new System.Drawing.Size(112, 34);
            this.btnSuaCong.TabIndex = 22;
            this.btnSuaCong.Text = "Sửa";
            this.btnSuaCong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSuaCong.UseVisualStyleBackColor = false;
            // 
            // txtMoTaCong
            // 
            this.txtMoTaCong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMoTaCong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoTaCong.Location = new System.Drawing.Point(196, 120);
            this.txtMoTaCong.Name = "txtMoTaCong";
            this.txtMoTaCong.Size = new System.Drawing.Size(198, 30);
            this.txtMoTaCong.TabIndex = 18;
            // 
            // btnThemCong
            // 
            this.btnThemCong.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnThemCong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemCong.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemCong.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemCong.Location = new System.Drawing.Point(26, 241);
            this.btnThemCong.Name = "btnThemCong";
            this.btnThemCong.Size = new System.Drawing.Size(112, 34);
            this.btnThemCong.TabIndex = 20;
            this.btnThemCong.Text = "Thêm";
            this.btnThemCong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThemCong.UseVisualStyleBackColor = false;
            // 
            // txtMaCC
            // 
            this.txtMaCC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaCC.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaCC.Location = new System.Drawing.Point(196, 66);
            this.txtMaCC.Name = "txtMaCC";
            this.txtMaCC.Size = new System.Drawing.Size(198, 30);
            this.txtMaCC.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 22);
            this.label1.TabIndex = 13;
            this.label1.Text = "Hệ số:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 22);
            this.label2.TabIndex = 14;
            this.label2.Text = "Mô tả: ";
            // 
            // txtHeSo
            // 
            this.txtHeSo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHeSo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeSo.Location = new System.Drawing.Point(239, 180);
            this.txtHeSo.Name = "txtHeSo";
            this.txtHeSo.Size = new System.Drawing.Size(155, 30);
            this.txtHeSo.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 22);
            this.label3.TabIndex = 15;
            this.label3.Text = "Mã chấm công: ";
            // 
            // FormQuanLyThangCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(1060, 805);
            this.Controls.Add(this.guna2GroupBox2);
            this.Controls.Add(this.guna2GroupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormQuanLyThangCong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormQuanLyCong";
            this.Load += new System.EventHandler(this.FormQuanLyThangCong_Load);
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVThang)).EndInit();
            this.guna2GroupBox2.ResumeLayout(false);
            this.guna2GroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVCong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.DataGridView dataGVThang;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button btnSuaThang;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.TextBox txtMaThang;
        private System.Windows.Forms.Label lblSoNgayCong;
        private System.Windows.Forms.Button btnThemThang;
        private System.Windows.Forms.Label lblMoTa;
        private System.Windows.Forms.TextBox txtSoNgayCong;
        private System.Windows.Forms.Label lblMaThang;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private System.Windows.Forms.Button btnLamMoiCong;
        private System.Windows.Forms.DataGridView dataGVCong;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Button btnSuaCong;
        private System.Windows.Forms.TextBox txtMoTaCong;
        private System.Windows.Forms.Button btnThemCong;
        private System.Windows.Forms.TextBox txtMaCC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHeSo;
        private System.Windows.Forms.Label label3;
    }
}