namespace QLthuvien.GUI
{
    partial class FormMuonTra
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMuonTra));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_HoTen = new Guna.UI.WinForms.GunaTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_GioiTinh = new Guna.UI.WinForms.GunaTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gunaDataGridView1 = new Guna.UI.WinForms.GunaDataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_DiaChi = new Guna.UI.WinForms.GunaTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_SDT = new Guna.UI.WinForms.GunaTextBox();
            this.btn_title = new Guna.UI.WinForms.GunaGradientButton();
            this.picture_avatar = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.gunaDateTimePicker1 = new Guna.UI.WinForms.GunaDateTimePicker();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gunaDateTimePicker1);
            this.panel1.Controls.Add(this.txt_SDT);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txt_DiaChi);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_GioiTinh);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_HoTen);
            this.panel1.Controls.Add(this.picture_avatar);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(355, 511);
            this.panel1.TabIndex = 1;
            // 
            // txt_HoTen
            // 
            this.txt_HoTen.BaseColor = System.Drawing.Color.White;
            this.txt_HoTen.BorderColor = System.Drawing.Color.Black;
            this.txt_HoTen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_HoTen.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_HoTen.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.txt_HoTen.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_HoTen.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_HoTen.Location = new System.Drawing.Point(101, 159);
            this.txt_HoTen.Name = "txt_HoTen";
            this.txt_HoTen.PasswordChar = '\0';
            this.txt_HoTen.Size = new System.Drawing.Size(202, 41);
            this.txt_HoTen.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Họ tên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ngày sinh:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Giới tính:";
            // 
            // txt_GioiTinh
            // 
            this.txt_GioiTinh.BaseColor = System.Drawing.Color.White;
            this.txt_GioiTinh.BorderColor = System.Drawing.Color.Black;
            this.txt_GioiTinh.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_GioiTinh.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_GioiTinh.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.txt_GioiTinh.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_GioiTinh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_GioiTinh.Location = new System.Drawing.Point(101, 277);
            this.txt_GioiTinh.Name = "txt_GioiTinh";
            this.txt_GioiTinh.PasswordChar = '\0';
            this.txt_GioiTinh.Size = new System.Drawing.Size(202, 41);
            this.txt_GioiTinh.TabIndex = 6;
            this.txt_GioiTinh.Text = "gunaTextBox2";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_title);
            this.panel2.Controls.Add(this.gunaDataGridView1);
            this.panel2.Location = new System.Drawing.Point(363, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(968, 511);
            this.panel2.TabIndex = 2;
            // 
            // gunaDataGridView1
            // 
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.gunaDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gunaDataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.gunaDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gunaDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.gunaDataGridView1.ColumnHeadersHeight = 4;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gunaDataGridView1.DefaultCellStyle = dataGridViewCellStyle18;
            this.gunaDataGridView1.EnableHeadersVisualStyles = false;
            this.gunaDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDataGridView1.Location = new System.Drawing.Point(4, 84);
            this.gunaDataGridView1.Name = "gunaDataGridView1";
            this.gunaDataGridView1.RowHeadersVisible = false;
            this.gunaDataGridView1.RowTemplate.Height = 24;
            this.gunaDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gunaDataGridView1.Size = new System.Drawing.Size(955, 418);
            this.gunaDataGridView1.TabIndex = 0;
            this.gunaDataGridView1.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.Height = 4;
            this.gunaDataGridView1.ThemeStyle.ReadOnly = false;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gunaDataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gunaDataGridView1.ThemeStyle.RowsStyle.Height = 24;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 345);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Địa chỉ:";
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.BaseColor = System.Drawing.Color.White;
            this.txt_DiaChi.BorderColor = System.Drawing.Color.Black;
            this.txt_DiaChi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_DiaChi.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_DiaChi.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.txt_DiaChi.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_DiaChi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_DiaChi.Location = new System.Drawing.Point(101, 334);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.PasswordChar = '\0';
            this.txt_DiaChi.Size = new System.Drawing.Size(202, 41);
            this.txt_DiaChi.TabIndex = 8;
            this.txt_DiaChi.Text = "gunaTextBox2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 398);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Số điện thoại:";
            // 
            // txt_SDT
            // 
            this.txt_SDT.BaseColor = System.Drawing.Color.White;
            this.txt_SDT.BorderColor = System.Drawing.Color.Black;
            this.txt_SDT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_SDT.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_SDT.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.txt_SDT.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_SDT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_SDT.Location = new System.Drawing.Point(101, 389);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.PasswordChar = '\0';
            this.txt_SDT.Size = new System.Drawing.Size(202, 41);
            this.txt_SDT.TabIndex = 10;
            this.txt_SDT.Text = "gunaTextBox2";
            // 
            // btn_title
            // 
            this.btn_title.AnimationHoverSpeed = 0.07F;
            this.btn_title.AnimationSpeed = 0.03F;
            this.btn_title.BaseColor1 = System.Drawing.Color.SlateBlue;
            this.btn_title.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_title.BorderColor = System.Drawing.Color.Black;
            this.btn_title.FocusedColor = System.Drawing.Color.Empty;
            this.btn_title.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_title.ForeColor = System.Drawing.Color.White;
            this.btn_title.Image = ((System.Drawing.Image)(resources.GetObject("btn_title.Image")));
            this.btn_title.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_title.Location = new System.Drawing.Point(4, 11);
            this.btn_title.Name = "btn_title";
            this.btn_title.OnHoverBaseColor1 = System.Drawing.Color.SkyBlue;
            this.btn_title.OnHoverBaseColor2 = System.Drawing.Color.MediumTurquoise;
            this.btn_title.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_title.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_title.OnHoverImage = null;
            this.btn_title.OnPressedColor = System.Drawing.Color.Black;
            this.btn_title.Size = new System.Drawing.Size(955, 67);
            this.btn_title.TabIndex = 1;
            this.btn_title.Text = "QUẢN LÝ MƯỢN TRẢ SÁCH";
            this.btn_title.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // picture_avatar
            // 
            this.picture_avatar.BaseColor = System.Drawing.Color.White;
            this.picture_avatar.Image = global::QLthuvien.Properties.Resources.avatar;
            this.picture_avatar.Location = new System.Drawing.Point(116, 0);
            this.picture_avatar.Name = "picture_avatar";
            this.picture_avatar.Size = new System.Drawing.Size(162, 142);
            this.picture_avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_avatar.TabIndex = 0;
            this.picture_avatar.TabStop = false;
            this.picture_avatar.UseTransfarantBackground = false;
            // 
            // gunaDateTimePicker1
            // 
            this.gunaDateTimePicker1.BaseColor = System.Drawing.Color.White;
            this.gunaDateTimePicker1.BorderColor = System.Drawing.Color.Black;
            this.gunaDateTimePicker1.CustomFormat = null;
            this.gunaDateTimePicker1.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.gunaDateTimePicker1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaDateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaDateTimePicker1.ForeColor = System.Drawing.Color.Black;
            this.gunaDateTimePicker1.Location = new System.Drawing.Point(101, 216);
            this.gunaDateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.gunaDateTimePicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.gunaDateTimePicker1.Name = "gunaDateTimePicker1";
            this.gunaDateTimePicker1.OnHoverBaseColor = System.Drawing.Color.White;
            this.gunaDateTimePicker1.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.gunaDateTimePicker1.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaDateTimePicker1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaDateTimePicker1.Size = new System.Drawing.Size(202, 41);
            this.gunaDateTimePicker1.TabIndex = 11;
            this.gunaDateTimePicker1.Text = "Friday, October 4, 2019";
            this.gunaDateTimePicker1.Value = new System.DateTime(2019, 10, 4, 16, 28, 55, 456);
            // 
            // FormMuonTra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 530);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormMuonTra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý mượn trả";
            this.Load += new System.EventHandler(this.FormMuonTra_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_avatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaCirclePictureBox picture_avatar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaTextBox txt_HoTen;
        private Guna.UI.WinForms.GunaTextBox txt_GioiTinh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaTextBox txt_SDT;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaTextBox txt_DiaChi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaDataGridView gunaDataGridView1;
        private Guna.UI.WinForms.GunaGradientButton btn_title;
        private Guna.UI.WinForms.GunaDateTimePicker gunaDateTimePicker1;
    }
}