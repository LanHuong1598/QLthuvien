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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMuonTra));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cb_MaDG = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtp_NgaySinh = new Guna.UI.WinForms.GunaDateTimePicker();
            this.txt_SDT = new Guna.UI.WinForms.GunaTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_DiaChi = new Guna.UI.WinForms.GunaTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_GioiTinh = new Guna.UI.WinForms.GunaTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_HoTen = new Guna.UI.WinForms.GunaTextBox();
            this.picture_avatar = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.dtgv_MuonTra = new Guna.UI.WinForms.GunaDataGridView();
            this.gunaGradientButton1 = new Guna.UI.WinForms.GunaGradientButton();
            this.gunaAdvenceButton1 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_avatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_MuonTra)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cb_MaDG);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.dtp_NgaySinh);
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
            this.panel1.Location = new System.Drawing.Point(9, 75);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(322, 522);
            this.panel1.TabIndex = 1;
            // 
            // cb_MaDG
            // 
            this.cb_MaDG.DropDownHeight = 41;
            this.cb_MaDG.FormattingEnabled = true;
            this.cb_MaDG.IntegralHeight = false;
            this.cb_MaDG.Location = new System.Drawing.Point(112, 141);
            this.cb_MaDG.Margin = new System.Windows.Forms.Padding(2);
            this.cb_MaDG.Name = "cb_MaDG";
            this.cb_MaDG.Size = new System.Drawing.Size(180, 21);
            this.cb_MaDG.TabIndex = 14;
            this.cb_MaDG.SelectedIndexChanged += new System.EventHandler(this.cb_MaDG_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 145);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Mã độc giả:";
            // 
            // dtp_NgaySinh
            // 
            this.dtp_NgaySinh.BaseColor = System.Drawing.Color.White;
            this.dtp_NgaySinh.BorderColor = System.Drawing.Color.Black;
            this.dtp_NgaySinh.CustomFormat = null;
            this.dtp_NgaySinh.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtp_NgaySinh.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtp_NgaySinh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtp_NgaySinh.ForeColor = System.Drawing.Color.Black;
            this.dtp_NgaySinh.Location = new System.Drawing.Point(112, 244);
            this.dtp_NgaySinh.Margin = new System.Windows.Forms.Padding(2);
            this.dtp_NgaySinh.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_NgaySinh.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtp_NgaySinh.Name = "dtp_NgaySinh";
            this.dtp_NgaySinh.OnHoverBaseColor = System.Drawing.Color.White;
            this.dtp_NgaySinh.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.dtp_NgaySinh.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtp_NgaySinh.OnPressedColor = System.Drawing.Color.Black;
            this.dtp_NgaySinh.Size = new System.Drawing.Size(180, 38);
            this.dtp_NgaySinh.TabIndex = 11;
            this.dtp_NgaySinh.Text = "Friday, October 4, 2019";
            this.dtp_NgaySinh.Value = new System.DateTime(2019, 10, 4, 16, 28, 55, 456);
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
            this.txt_SDT.Location = new System.Drawing.Point(112, 424);
            this.txt_SDT.Margin = new System.Windows.Forms.Padding(2);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.PasswordChar = '\0';
            this.txt_SDT.Size = new System.Drawing.Size(180, 38);
            this.txt_SDT.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 435);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Số điện thoại:";
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
            this.txt_DiaChi.Location = new System.Drawing.Point(112, 364);
            this.txt_DiaChi.Margin = new System.Windows.Forms.Padding(2);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.PasswordChar = '\0';
            this.txt_DiaChi.Size = new System.Drawing.Size(180, 38);
            this.txt_DiaChi.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 377);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Địa chỉ:";
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
            this.txt_GioiTinh.Location = new System.Drawing.Point(112, 304);
            this.txt_GioiTinh.Margin = new System.Windows.Forms.Padding(2);
            this.txt_GioiTinh.Name = "txt_GioiTinh";
            this.txt_GioiTinh.PasswordChar = '\0';
            this.txt_GioiTinh.Size = new System.Drawing.Size(180, 38);
            this.txt_GioiTinh.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 261);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Giới tính:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 319);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ngày sinh:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 203);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Họ tên:";
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
            this.txt_HoTen.Location = new System.Drawing.Point(112, 184);
            this.txt_HoTen.Margin = new System.Windows.Forms.Padding(2);
            this.txt_HoTen.Name = "txt_HoTen";
            this.txt_HoTen.PasswordChar = '\0';
            this.txt_HoTen.Size = new System.Drawing.Size(180, 38);
            this.txt_HoTen.TabIndex = 1;
            // 
            // picture_avatar
            // 
            this.picture_avatar.BaseColor = System.Drawing.Color.White;
            this.picture_avatar.Image = global::QLthuvien.Properties.Resources.avatar;
            this.picture_avatar.Location = new System.Drawing.Point(112, 15);
            this.picture_avatar.Margin = new System.Windows.Forms.Padding(2);
            this.picture_avatar.Name = "picture_avatar";
            this.picture_avatar.Size = new System.Drawing.Size(106, 118);
            this.picture_avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_avatar.TabIndex = 15;
            this.picture_avatar.TabStop = false;
            this.picture_avatar.UseTransfarantBackground = false;
            // 
            // dtgv_MuonTra
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtgv_MuonTra.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgv_MuonTra.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgv_MuonTra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_MuonTra.BackgroundColor = System.Drawing.Color.White;
            this.dtgv_MuonTra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgv_MuonTra.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgv_MuonTra.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(143)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv_MuonTra.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgv_MuonTra.ColumnHeadersHeight = 20;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgv_MuonTra.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgv_MuonTra.EnableHeadersVisualStyles = false;
            this.dtgv_MuonTra.GridColor = System.Drawing.Color.White;
            this.dtgv_MuonTra.Location = new System.Drawing.Point(335, 90);
            this.dtgv_MuonTra.Margin = new System.Windows.Forms.Padding(2);
            this.dtgv_MuonTra.Name = "dtgv_MuonTra";
            this.dtgv_MuonTra.RowHeadersVisible = false;
            this.dtgv_MuonTra.RowTemplate.Height = 24;
            this.dtgv_MuonTra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv_MuonTra.Size = new System.Drawing.Size(775, 463);
            this.dtgv_MuonTra.TabIndex = 0;
            this.dtgv_MuonTra.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dtgv_MuonTra.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgv_MuonTra.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgv_MuonTra.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgv_MuonTra.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgv_MuonTra.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgv_MuonTra.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtgv_MuonTra.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.dtgv_MuonTra.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(143)))));
            this.dtgv_MuonTra.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgv_MuonTra.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dtgv_MuonTra.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgv_MuonTra.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgv_MuonTra.ThemeStyle.HeaderStyle.Height = 20;
            this.dtgv_MuonTra.ThemeStyle.ReadOnly = false;
            this.dtgv_MuonTra.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgv_MuonTra.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgv_MuonTra.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dtgv_MuonTra.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dtgv_MuonTra.ThemeStyle.RowsStyle.Height = 24;
            this.dtgv_MuonTra.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.dtgv_MuonTra.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dtgv_MuonTra.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_MuonTra_CellContentClick);
            // 
            // gunaGradientButton1
            // 
            this.gunaGradientButton1.Animated = true;
            this.gunaGradientButton1.AnimationHoverSpeed = 0.07F;
            this.gunaGradientButton1.AnimationSpeed = 0.03F;
            this.gunaGradientButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.gunaGradientButton1.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.gunaGradientButton1.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.gunaGradientButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaGradientButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaGradientButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaGradientButton1.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaGradientButton1.ForeColor = System.Drawing.Color.White;
            this.gunaGradientButton1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gunaGradientButton1.Image = null;
            this.gunaGradientButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaGradientButton1.Location = new System.Drawing.Point(0, 0);
            this.gunaGradientButton1.Name = "gunaGradientButton1";
            this.gunaGradientButton1.OnHoverBaseColor1 = System.Drawing.Color.DeepSkyBlue;
            this.gunaGradientButton1.OnHoverBaseColor2 = System.Drawing.Color.SkyBlue;
            this.gunaGradientButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton1.OnHoverForeColor = System.Drawing.Color.WhiteSmoke;
            this.gunaGradientButton1.OnHoverImage = null;
            this.gunaGradientButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaGradientButton1.Size = new System.Drawing.Size(1121, 66);
            this.gunaGradientButton1.TabIndex = 11;
            this.gunaGradientButton1.Text = "QUẢN LÝ MƯỢN TRẢ";
            this.gunaGradientButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gunaAdvenceButton1
            // 
            this.gunaAdvenceButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaAdvenceButton1.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceButton1.AnimationSpeed = 0.03F;
            this.gunaAdvenceButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.gunaAdvenceButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.BorderSize = 1;
            this.gunaAdvenceButton1.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gunaAdvenceButton1.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.CheckedForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.CheckedImage = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton1.CheckedImage")));
            this.gunaAdvenceButton1.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaAdvenceButton1.ForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.Image = null;
            this.gunaAdvenceButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaAdvenceButton1.LineColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.Location = new System.Drawing.Point(868, 568);
            this.gunaAdvenceButton1.Margin = new System.Windows.Forms.Padding(2);
            this.gunaAdvenceButton1.Name = "gunaAdvenceButton1";
            this.gunaAdvenceButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(184)))), ((int)(((byte)(234)))));
            this.gunaAdvenceButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.OnHoverImage = null;
            this.gunaAdvenceButton1.OnHoverLineColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.Size = new System.Drawing.Size(242, 38);
            this.gunaAdvenceButton1.TabIndex = 12;
            this.gunaAdvenceButton1.Text = "Mượn sách";
            this.gunaAdvenceButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaAdvenceButton1.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // FormMuonTra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 617);
            this.Controls.Add(this.gunaAdvenceButton1);
            this.Controls.Add(this.gunaGradientButton1);
            this.Controls.Add(this.dtgv_MuonTra);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMuonTra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý mượn trả";
            this.Load += new System.EventHandler(this.FormMuonTra_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_avatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_MuonTra)).EndInit();
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
        private Guna.UI.WinForms.GunaDataGridView dtgv_MuonTra;
        private Guna.UI.WinForms.GunaDateTimePicker dtp_NgaySinh;
        protected internal System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_MaDG;
        private Guna.UI.WinForms.GunaGradientButton gunaGradientButton1;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton1;
    }
}