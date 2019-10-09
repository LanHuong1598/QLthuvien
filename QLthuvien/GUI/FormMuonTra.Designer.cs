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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMuonTra));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_title = new Guna.UI.WinForms.GunaGradientButton();
            this.dtgv_MuonTra = new Guna.UI.WinForms.GunaDataGridView();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_avatar)).BeginInit();
            this.panel2.SuspendLayout();
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
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(355, 511);
            this.panel1.TabIndex = 1;
            // 
            // cb_MaDG
            // 
            this.cb_MaDG.DropDownHeight = 41;
            this.cb_MaDG.FormattingEnabled = true;
            this.cb_MaDG.IntegralHeight = false;
            this.cb_MaDG.Location = new System.Drawing.Point(101, 178);
            this.cb_MaDG.Name = "cb_MaDG";
            this.cb_MaDG.Size = new System.Drawing.Size(202, 24);
            this.cb_MaDG.TabIndex = 14;
            this.cb_MaDG.SelectedIndexChanged += new System.EventHandler(this.cb_MaDG_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 17);
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
            this.dtp_NgaySinh.Location = new System.Drawing.Point(101, 286);
            this.dtp_NgaySinh.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_NgaySinh.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtp_NgaySinh.Name = "dtp_NgaySinh";
            this.dtp_NgaySinh.OnHoverBaseColor = System.Drawing.Color.White;
            this.dtp_NgaySinh.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.dtp_NgaySinh.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtp_NgaySinh.OnPressedColor = System.Drawing.Color.Black;
            this.dtp_NgaySinh.Size = new System.Drawing.Size(202, 41);
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
            this.txt_SDT.Location = new System.Drawing.Point(101, 459);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.PasswordChar = '\0';
            this.txt_SDT.Size = new System.Drawing.Size(202, 41);
            this.txt_SDT.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 468);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 17);
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
            this.txt_DiaChi.Location = new System.Drawing.Point(101, 404);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.PasswordChar = '\0';
            this.txt_DiaChi.Size = new System.Drawing.Size(202, 41);
            this.txt_DiaChi.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 415);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
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
            this.txt_GioiTinh.Location = new System.Drawing.Point(101, 347);
            this.txt_GioiTinh.Name = "txt_GioiTinh";
            this.txt_GioiTinh.PasswordChar = '\0';
            this.txt_GioiTinh.Size = new System.Drawing.Size(202, 41);
            this.txt_GioiTinh.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 362);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Giới tính:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ngày sinh:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
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
            this.txt_HoTen.Location = new System.Drawing.Point(101, 229);
            this.txt_HoTen.Name = "txt_HoTen";
            this.txt_HoTen.PasswordChar = '\0';
            this.txt_HoTen.Size = new System.Drawing.Size(202, 41);
            this.txt_HoTen.TabIndex = 1;
            // 
            // picture_avatar
            // 
            this.picture_avatar.BaseColor = System.Drawing.Color.White;
            this.picture_avatar.Location = new System.Drawing.Point(0, 0);
            this.picture_avatar.Name = "picture_avatar";
            this.picture_avatar.Size = new System.Drawing.Size(120, 120);
            this.picture_avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_avatar.TabIndex = 15;
            this.picture_avatar.TabStop = false;
            this.picture_avatar.UseTransfarantBackground = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_title);
            this.panel2.Controls.Add(this.dtgv_MuonTra);
            this.panel2.Location = new System.Drawing.Point(363, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(968, 511);
            this.panel2.TabIndex = 2;
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
            // dtgv_MuonTra
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtgv_MuonTra.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgv_MuonTra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_MuonTra.BackgroundColor = System.Drawing.Color.White;
            this.dtgv_MuonTra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgv_MuonTra.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgv_MuonTra.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
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
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgv_MuonTra.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgv_MuonTra.EnableHeadersVisualStyles = false;
            this.dtgv_MuonTra.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgv_MuonTra.Location = new System.Drawing.Point(4, 84);
            this.dtgv_MuonTra.Name = "dtgv_MuonTra";
            this.dtgv_MuonTra.RowHeadersVisible = false;
            this.dtgv_MuonTra.RowTemplate.Height = 24;
            this.dtgv_MuonTra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv_MuonTra.Size = new System.Drawing.Size(955, 418);
            this.dtgv_MuonTra.TabIndex = 0;
            this.dtgv_MuonTra.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dtgv_MuonTra.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgv_MuonTra.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgv_MuonTra.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgv_MuonTra.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgv_MuonTra.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgv_MuonTra.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtgv_MuonTra.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgv_MuonTra.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtgv_MuonTra.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgv_MuonTra.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dtgv_MuonTra.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgv_MuonTra.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgv_MuonTra.ThemeStyle.HeaderStyle.Height = 20;
            this.dtgv_MuonTra.ThemeStyle.ReadOnly = false;
            this.dtgv_MuonTra.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgv_MuonTra.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgv_MuonTra.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dtgv_MuonTra.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgv_MuonTra.ThemeStyle.RowsStyle.Height = 24;
            this.dtgv_MuonTra.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgv_MuonTra.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton1.Image")));
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(103, 546);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Size = new System.Drawing.Size(202, 42);
            this.gunaButton1.TabIndex = 3;
            this.gunaButton1.Text = "Mượn sách";
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "bunifuFlatButton1";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(445, 544);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(321, 59);
            this.bunifuFlatButton1.TabIndex = 4;
            this.bunifuFlatButton1.Text = "bunifuFlatButton1";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // FormMuonTra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 589);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.gunaButton1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormMuonTra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý mượn trả";
            this.Load += new System.EventHandler(this.FormMuonTra_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_avatar)).EndInit();
            this.panel2.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaDataGridView dtgv_MuonTra;
        private Guna.UI.WinForms.GunaGradientButton btn_title;
        private Guna.UI.WinForms.GunaDateTimePicker dtp_NgaySinh;
        protected internal System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_MaDG;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
    }
}