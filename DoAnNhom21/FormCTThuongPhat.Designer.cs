namespace DoAnNhom21
{
    partial class FormCTThuongPhat
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                new System.Windows.Forms.DataGridViewTextBoxColumn { DataPropertyName = "MaNhanVien", HeaderText = "Mã Nhân Viên", MinimumWidth = 6, Name = "Column1" },
                new System.Windows.Forms.DataGridViewTextBoxColumn { DataPropertyName = "Ho", HeaderText = "Họ", MinimumWidth = 6, Name = "Column2" },
                new System.Windows.Forms.DataGridViewTextBoxColumn { DataPropertyName = "Ten", HeaderText = "Tên", MinimumWidth = 6, Name = "Column3" },
                new System.Windows.Forms.DataGridViewTextBoxColumn { DataPropertyName = "Loai", HeaderText = "Loại", MinimumWidth = 6, Name = "Column4" },
                new System.Windows.Forms.DataGridViewTextBoxColumn { DataPropertyName = "LyDo", HeaderText = "Lý Do", MinimumWidth = 6, Name = "Column5" },
                new System.Windows.Forms.DataGridViewTextBoxColumn { DataPropertyName = "TienThuongPhat", HeaderText = "Tiền Thưởng/Phạt", MinimumWidth = 6, Name = "Column6" },
                new System.Windows.Forms.DataGridViewTextBoxColumn { DataPropertyName = "MaThang", HeaderText = "Mã Tháng", MinimumWidth = 6, Name = "Column7" },
                new System.Windows.Forms.DataGridViewTextBoxColumn { DataPropertyName = "NgayThuongPhat", HeaderText = "Ngày Thưởng/Phạt", MinimumWidth = 6, Name = "Column8" },
                new System.Windows.Forms.DataGridViewTextBoxColumn { DataPropertyName = "TenChucVu", HeaderText = "Tên Chức Vụ", MinimumWidth = 6, Name = "Column9" },
                new System.Windows.Forms.DataGridViewTextBoxColumn { DataPropertyName = "TenPhongBan", HeaderText = "Tên Phòng Ban", MinimumWidth = 6, Name = "Column10" }
            });
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(775, 425);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // FormCTThuongPhat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormCTThuongPhat";
            this.Text = "FormCTThuongPhat";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
    }
}