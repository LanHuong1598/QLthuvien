namespace QLthuvien.GUI
{
    partial class FormTuaSach
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
            this.lbQLTuaSach = new System.Windows.Forms.Label();
            this.tbTimKiem = new System.Windows.Forms.TextBox();
            this.btXoasach = new System.Windows.Forms.Button();
            this.btSuaSach = new System.Windows.Forms.Button();
            this.btTimKiem = new System.Windows.Forms.Button();
            this.btThemSach = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbQLTuaSach
            // 
            this.lbQLTuaSach.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.lbQLTuaSach.Font = new System.Drawing.Font("Times New Roman", 24F);
            this.lbQLTuaSach.ForeColor = System.Drawing.SystemColors.Control;
            this.lbQLTuaSach.Location = new System.Drawing.Point(0, 0);
            this.lbQLTuaSach.Name = "lbQLTuaSach";
            this.lbQLTuaSach.Size = new System.Drawing.Size(981, 63);
            this.lbQLTuaSach.TabIndex = 0;
            this.lbQLTuaSach.Text = "QUẢN LÝ TỰA SÁCH";
            this.lbQLTuaSach.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbTimKiem
            // 
            this.tbTimKiem.Location = new System.Drawing.Point(6, 205);
            this.tbTimKiem.Multiline = true;
            this.tbTimKiem.Name = "tbTimKiem";
            this.tbTimKiem.Size = new System.Drawing.Size(175, 42);
            this.tbTimKiem.TabIndex = 2;
            // 
            // btXoasach
            // 
            this.btXoasach.BackgroundImage = global::QLthuvien.Properties.Resources.xoasach;
            this.btXoasach.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btXoasach.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoasach.ForeColor = System.Drawing.Color.White;
            this.btXoasach.Location = new System.Drawing.Point(29, 125);
            this.btXoasach.Name = "btXoasach";
            this.btXoasach.Size = new System.Drawing.Size(175, 41);
            this.btXoasach.TabIndex = 1;
            this.btXoasach.Text = "     Xóa tựa sách";
            this.btXoasach.UseVisualStyleBackColor = true;
            // 
            // btSuaSach
            // 
            this.btSuaSach.BackgroundImage = global::QLthuvien.Properties.Resources.suasach;
            this.btSuaSach.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btSuaSach.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSuaSach.ForeColor = System.Drawing.Color.White;
            this.btSuaSach.Location = new System.Drawing.Point(29, 78);
            this.btSuaSach.Name = "btSuaSach";
            this.btSuaSach.Size = new System.Drawing.Size(175, 41);
            this.btSuaSach.TabIndex = 1;
            this.btSuaSach.Text = "    Sửa tựa sách";
            this.btSuaSach.UseVisualStyleBackColor = true;
            // 
            // btTimKiem
            // 
            this.btTimKiem.BackgroundImage = global::QLthuvien.Properties.Resources.iconsearch;
            this.btTimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btTimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btTimKiem.ForeColor = System.Drawing.Color.White;
            this.btTimKiem.Location = new System.Drawing.Point(187, 205);
            this.btTimKiem.Name = "btTimKiem";
            this.btTimKiem.Size = new System.Drawing.Size(38, 42);
            this.btTimKiem.TabIndex = 4;
            this.btTimKiem.UseVisualStyleBackColor = true;
            // 
            // btThemSach
            // 
            this.btThemSach.BackgroundImage = global::QLthuvien.Properties.Resources.themsach;
            this.btThemSach.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btThemSach.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThemSach.ForeColor = System.Drawing.Color.White;
            this.btThemSach.Location = new System.Drawing.Point(29, 31);
            this.btThemSach.Name = "btThemSach";
            this.btThemSach.Size = new System.Drawing.Size(175, 41);
            this.btThemSach.TabIndex = 1;
            this.btThemSach.Text = "       Thêm tựa sách";
            this.btThemSach.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(231, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(750, 500);
            this.dataGridView1.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panel1.Controls.Add(this.btThemSach);
            this.panel1.Controls.Add(this.btSuaSach);
            this.panel1.Controls.Add(this.btTimKiem);
            this.panel1.Controls.Add(this.btXoasach);
            this.panel1.Controls.Add(this.tbTimKiem);
            this.panel1.Location = new System.Drawing.Point(0, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(235, 503);
            this.panel1.TabIndex = 6;
            // 
            // FormTuaSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(981, 552);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbQLTuaSach);
            this.Name = "FormTuaSach";
            this.Text = "FormTuaSach";
            this.Load += new System.EventHandler(this.FormTuaSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbQLTuaSach;
        private System.Windows.Forms.Button btSuaSach;
        private System.Windows.Forms.Button btXoasach;
        private System.Windows.Forms.TextBox tbTimKiem;
        private System.Windows.Forms.Button btTimKiem;
        private System.Windows.Forms.Button btThemSach;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
    }
}