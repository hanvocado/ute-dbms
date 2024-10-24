using System.Windows.Forms;

namespace DoAnNhom21
{
    partial class FormXemChiTietPhongBan
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
        public void InitializeComponent()
        {
            this.listViewPBChiTiet = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // listViewPBChiTiet
            // 
            this.listViewPBChiTiet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewPBChiTiet.HideSelection = false;
            this.listViewPBChiTiet.Location = new System.Drawing.Point(12, 12);
            this.listViewPBChiTiet.Name = "listViewPBChiTiet";
            this.listViewPBChiTiet.Size = new System.Drawing.Size(1018, 734);
            this.listViewPBChiTiet.TabIndex = 0;
            this.listViewPBChiTiet.UseCompatibleStateImageBehavior = false;
            // 
            // FormXemChiTietPhongBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1042, 758);
            this.Controls.Add(this.listViewPBChiTiet);
            this.Name = "FormXemChiTietPhongBan";
            this.Text = "FormXemChiTietPhongBan";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListView listViewPBChiTiet;
    }
}