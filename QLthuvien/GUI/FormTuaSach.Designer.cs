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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbQLTuaSach
            // 
            this.lbQLTuaSach.Font = new System.Drawing.Font("Times New Roman", 24F);
            this.lbQLTuaSach.ForeColor = System.Drawing.Color.Red;
            this.lbQLTuaSach.Location = new System.Drawing.Point(0, 1);
            this.lbQLTuaSach.Name = "lbQLTuaSach";
            this.lbQLTuaSach.Size = new System.Drawing.Size(981, 63);
            this.lbQLTuaSach.TabIndex = 0;
            this.lbQLTuaSach.Text = "QUẢN LÝ TỰA SÁCH";
            this.lbQLTuaSach.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbTimKiem
            // 
            this.tbTimKiem.Location = new System.Drawing.Point(618, 110);
            this.tbTimKiem.Multiline = true;
            this.tbTimKiem.Name = "tbTimKiem";
            this.tbTimKiem.Size = new System.Drawing.Size(225, 35);
            this.tbTimKiem.TabIndex = 2;
            // 
            // btXoasach
            // 
            this.btXoasach.BackgroundImage = global::QLthuvien.Properties.Resources.xoasach;
            this.btXoasach.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btXoasach.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btXoasach.ForeColor = System.Drawing.Color.White;
            this.btXoasach.Location = new System.Drawing.Point(32, 332);
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
            this.btSuaSach.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btSuaSach.ForeColor = System.Drawing.Color.White;
            this.btSuaSach.Location = new System.Drawing.Point(32, 276);
            this.btSuaSach.Name = "btSuaSach";
            this.btSuaSach.Size = new System.Drawing.Size(175, 41);
            this.btSuaSach.TabIndex = 1;
            this.btSuaSach.Text = "    Sửa tựa sách";
            this.btSuaSach.UseVisualStyleBackColor = true;
            // 
            // btTimKiem
            // 
            this.btTimKiem.BackgroundImage = global::QLthuvien.Properties.Resources.search;
            this.btTimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btTimKiem.ForeColor = System.Drawing.Color.White;
            this.btTimKiem.Location = new System.Drawing.Point(847, 110);
            this.btTimKiem.Name = "btTimKiem";
            this.btTimKiem.Size = new System.Drawing.Size(93, 35);
            this.btTimKiem.TabIndex = 4;
            this.btTimKiem.Text = "         Tìm kiếm";
            this.btTimKiem.UseVisualStyleBackColor = true;
            // 
            // btThemSach
            // 
            this.btThemSach.BackgroundImage = global::QLthuvien.Properties.Resources.themsach;
            this.btThemSach.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btThemSach.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btThemSach.ForeColor = System.Drawing.Color.White;
            this.btThemSach.Location = new System.Drawing.Point(32, 216);
            this.btThemSach.Name = "btThemSach";
            this.btThemSach.Size = new System.Drawing.Size(175, 41);
            this.btThemSach.TabIndex = 1;
            this.btThemSach.Text = "    Sửa tựa sách";
            this.btThemSach.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(238, 172);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(743, 378);
            this.dataGridView1.TabIndex = 5;
            // 
            // FormTuaSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(981, 552);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btTimKiem);
            this.Controls.Add(this.tbTimKiem);
            this.Controls.Add(this.btXoasach);
            this.Controls.Add(this.btThemSach);
            this.Controls.Add(this.btSuaSach);
            this.Controls.Add(this.lbQLTuaSach);
            this.Name = "FormTuaSach";
            this.Text = "FormTuaSach";
            this.Load += new System.EventHandler(this.FormTuaSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbQLTuaSach;
        private System.Windows.Forms.Button btSuaSach;
        private System.Windows.Forms.Button btXoasach;
        private System.Windows.Forms.TextBox tbTimKiem;
        private System.Windows.Forms.Button btTimKiem;
        private System.Windows.Forms.Button btThemSach;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}