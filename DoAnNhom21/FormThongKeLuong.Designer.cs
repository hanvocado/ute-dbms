using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DoAnNhom21
{
    partial class FormThongKeLuong
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
            this.dgvLuong = new System.Windows.Forms.DataGridView();
            this.cbbMaThang = new System.Windows.Forms.ComboBox();
            this.lblNgayNghiPhep = new System.Windows.Forms.Label();
            this.btnXemLuong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLuong
            // 
            this.dgvLuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLuong.Location = new System.Drawing.Point(38, 157);
            this.dgvLuong.Name = "dgvLuong";
            this.dgvLuong.RowHeadersWidth = 51;
            this.dgvLuong.Size = new System.Drawing.Size(1105, 576);
            this.dgvLuong.TabIndex = 3;
            // 
            // cbbMaThang
            // 
            this.cbbMaThang.FormattingEnabled = true;
            this.cbbMaThang.Location = new System.Drawing.Point(485, 34);
            this.cbbMaThang.Name = "cbbMaThang";
            this.cbbMaThang.Size = new System.Drawing.Size(282, 28);
            this.cbbMaThang.TabIndex = 9;
            // 
            // lblNgayNghiPhep
            // 
            this.lblNgayNghiPhep.AutoSize = true;
            this.lblNgayNghiPhep.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNgayNghiPhep.Location = new System.Drawing.Point(356, 32);
            this.lblNgayNghiPhep.Name = "lblNgayNghiPhep";
            this.lblNgayNghiPhep.Size = new System.Drawing.Size(84, 27);
            this.lblNgayNghiPhep.TabIndex = 8;
            this.lblNgayNghiPhep.Text = "Tháng: ";
            // 
            // btnXemLuong
            // 
            this.btnXemLuong.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnXemLuong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemLuong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXemLuong.Location = new System.Drawing.Point(485, 87);
            this.btnXemLuong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXemLuong.Name = "btnXemLuong";
            this.btnXemLuong.Size = new System.Drawing.Size(207, 50);
            this.btnXemLuong.TabIndex = 10;
            this.btnXemLuong.Text = "Xem lương";
            this.btnXemLuong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXemLuong.UseVisualStyleBackColor = false;
            this.btnXemLuong.Click += new System.EventHandler(this.btnXemLuong_Click);
            // 
            // FormThongKeLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 758);
            this.Controls.Add(this.btnXemLuong);
            this.Controls.Add(this.cbbMaThang);
            this.Controls.Add(this.lblNgayNghiPhep);
            this.Controls.Add(this.dgvLuong);
            this.Name = "FormThongKeLuong";
            this.Text = "FormThongKeLuong";
            this.Load += new System.EventHandler(this.FormThongKeLuong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataGridView dgvLuong;
        private ComboBox cbbMaThang;
        private Label lblNgayNghiPhep;
        private Button btnXemLuong;
    }
}