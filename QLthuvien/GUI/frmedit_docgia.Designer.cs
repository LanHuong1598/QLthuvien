namespace QLthuvien.GUI
{
    partial class frmedit_docgia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmedit_docgia));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.ra_nu = new Guna.UI.WinForms.GunaRadioButton();
            this.ra_nam = new Guna.UI.WinForms.GunaRadioButton();
            this.ngay_sinh = new Guna.UI.WinForms.GunaDateTimePicker();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.text_sdt = new Guna.UI.WinForms.GunaTextBox();
            this.text_diachi = new Guna.UI.WinForms.GunaTextBox();
            this.Tex_tendocgia = new Guna.UI.WinForms.GunaTextBox();
            this.tex_MA_docgia = new Guna.UI.WinForms.GunaTextBox();
            this.gunaPanel2 = new Guna.UI.WinForms.GunaPanel();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.gunaButton2 = new Guna.UI.WinForms.GunaButton();
            this.showData = new Guna.UI.WinForms.GunaDataGridView();
            this.gunaPanel1.SuspendLayout();
            this.gunaPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showData)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.White;
            this.gunaPanel1.Controls.Add(this.ra_nu);
            this.gunaPanel1.Controls.Add(this.ra_nam);
            this.gunaPanel1.Location = new System.Drawing.Point(9, 277);
            this.gunaPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(214, 39);
            this.gunaPanel1.TabIndex = 27;
            // 
            // ra_nu
            // 
            this.ra_nu.BaseColor = System.Drawing.SystemColors.Control;
            this.ra_nu.CheckedOffColor = System.Drawing.Color.Gray;
            this.ra_nu.CheckedOnColor = System.Drawing.Color.Black;
            this.ra_nu.FillColor = System.Drawing.Color.White;
            this.ra_nu.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.ra_nu.Location = new System.Drawing.Point(107, 10);
            this.ra_nu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ra_nu.Name = "ra_nu";
            this.ra_nu.Size = new System.Drawing.Size(49, 22);
            this.ra_nu.TabIndex = 35;
            this.ra_nu.Text = "Nữ";
            // 
            // ra_nam
            // 
            this.ra_nam.BaseColor = System.Drawing.SystemColors.Control;
            this.ra_nam.CheckedOffColor = System.Drawing.Color.Gray;
            this.ra_nam.CheckedOnColor = System.Drawing.Color.Black;
            this.ra_nam.FillColor = System.Drawing.Color.White;
            this.ra_nam.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.ra_nam.Location = new System.Drawing.Point(21, 10);
            this.ra_nam.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ra_nam.Name = "ra_nam";
            this.ra_nam.Size = new System.Drawing.Size(60, 22);
            this.ra_nam.TabIndex = 34;
            this.ra_nam.Text = "Nam";
            // 
            // ngay_sinh
            // 
            this.ngay_sinh.BaseColor = System.Drawing.Color.White;
            this.ngay_sinh.BorderColor = System.Drawing.Color.Silver;
            this.ngay_sinh.CustomFormat = null;
            this.ngay_sinh.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.ngay_sinh.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ngay_sinh.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ngay_sinh.ForeColor = System.Drawing.Color.Black;
            this.ngay_sinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ngay_sinh.Location = new System.Drawing.Point(9, 202);
            this.ngay_sinh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ngay_sinh.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.ngay_sinh.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.ngay_sinh.Name = "ngay_sinh";
            this.ngay_sinh.OnHoverBaseColor = System.Drawing.Color.White;
            this.ngay_sinh.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ngay_sinh.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ngay_sinh.OnPressedColor = System.Drawing.Color.Black;
            this.ngay_sinh.Size = new System.Drawing.Size(214, 34);
            this.ngay_sinh.TabIndex = 26;
            this.ngay_sinh.Text = "10/3/2019";
            this.ngay_sinh.Value = new System.DateTime(2019, 10, 3, 20, 47, 44, 195);
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel6.Location = new System.Drawing.Point(266, 245);
            this.gunaLabel6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(107, 29);
            this.gunaLabel6.TabIndex = 25;
            this.gunaLabel6.Text = "Số điện thoại:";
            this.gunaLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel5.Location = new System.Drawing.Point(241, 164);
            this.gunaLabel5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(107, 36);
            this.gunaLabel5.TabIndex = 24;
            this.gunaLabel5.Text = "Địa chỉ:";
            this.gunaLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.Location = new System.Drawing.Point(5, 239);
            this.gunaLabel4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(107, 36);
            this.gunaLabel4.TabIndex = 23;
            this.gunaLabel4.Text = "Giới tính:";
            this.gunaLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(5, 165);
            this.gunaLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(107, 36);
            this.gunaLabel3.TabIndex = 22;
            this.gunaLabel3.Text = "Ngày sinh:";
            this.gunaLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(259, 84);
            this.gunaLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(107, 36);
            this.gunaLabel2.TabIndex = 21;
            this.gunaLabel2.Text = "Tên độc giả:";
            this.gunaLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(9, 84);
            this.gunaLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(107, 36);
            this.gunaLabel1.TabIndex = 20;
            this.gunaLabel1.Text = "Mã độc giả:";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // text_sdt
            // 
            this.text_sdt.BaseColor = System.Drawing.Color.White;
            this.text_sdt.BorderColor = System.Drawing.Color.Silver;
            this.text_sdt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_sdt.FocusedBaseColor = System.Drawing.Color.White;
            this.text_sdt.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.text_sdt.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.text_sdt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.text_sdt.Location = new System.Drawing.Point(270, 277);
            this.text_sdt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.text_sdt.Name = "text_sdt";
            this.text_sdt.PasswordChar = '\0';
            this.text_sdt.Size = new System.Drawing.Size(208, 39);
            this.text_sdt.TabIndex = 19;
            // 
            // text_diachi
            // 
            this.text_diachi.BaseColor = System.Drawing.Color.White;
            this.text_diachi.BorderColor = System.Drawing.Color.Silver;
            this.text_diachi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_diachi.FocusedBaseColor = System.Drawing.Color.White;
            this.text_diachi.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.text_diachi.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.text_diachi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.text_diachi.Location = new System.Drawing.Point(270, 202);
            this.text_diachi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.text_diachi.Name = "text_diachi";
            this.text_diachi.PasswordChar = '\0';
            this.text_diachi.Size = new System.Drawing.Size(208, 41);
            this.text_diachi.TabIndex = 18;
            // 
            // Tex_tendocgia
            // 
            this.Tex_tendocgia.BaseColor = System.Drawing.Color.White;
            this.Tex_tendocgia.BorderColor = System.Drawing.Color.Silver;
            this.Tex_tendocgia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Tex_tendocgia.FocusedBaseColor = System.Drawing.Color.White;
            this.Tex_tendocgia.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Tex_tendocgia.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.Tex_tendocgia.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Tex_tendocgia.Location = new System.Drawing.Point(270, 122);
            this.Tex_tendocgia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Tex_tendocgia.Name = "Tex_tendocgia";
            this.Tex_tendocgia.PasswordChar = '\0';
            this.Tex_tendocgia.Size = new System.Drawing.Size(208, 39);
            this.Tex_tendocgia.TabIndex = 17;
            // 
            // tex_MA_docgia
            // 
            this.tex_MA_docgia.BaseColor = System.Drawing.Color.White;
            this.tex_MA_docgia.BorderColor = System.Drawing.Color.Silver;
            this.tex_MA_docgia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tex_MA_docgia.Enabled = false;
            this.tex_MA_docgia.FocusedBaseColor = System.Drawing.Color.White;
            this.tex_MA_docgia.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tex_MA_docgia.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tex_MA_docgia.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tex_MA_docgia.Location = new System.Drawing.Point(9, 123);
            this.tex_MA_docgia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tex_MA_docgia.Name = "tex_MA_docgia";
            this.tex_MA_docgia.PasswordChar = '\0';
            this.tex_MA_docgia.Size = new System.Drawing.Size(214, 40);
            this.tex_MA_docgia.TabIndex = 16;
            // 
            // gunaPanel2
            // 
            this.gunaPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(109)))), ((int)(((byte)(163)))));
            this.gunaPanel2.Controls.Add(this.gunaLabel7);
            this.gunaPanel2.Controls.Add(this.gunaPictureBox1);
            this.gunaPanel2.Location = new System.Drawing.Point(0, 2);
            this.gunaPanel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gunaPanel2.Name = "gunaPanel2";
            this.gunaPanel2.Size = new System.Drawing.Size(1048, 68);
            this.gunaPanel2.TabIndex = 28;
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel7.Location = new System.Drawing.Point(386, 15);
            this.gunaLabel7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(272, 37);
            this.gunaLabel7.TabIndex = 17;
            this.gunaLabel7.Text = "Sửa thông tin độc giả";
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = global::QLthuvien.Properties.Resources.doc_gia;
            this.gunaPictureBox1.Location = new System.Drawing.Point(2, 2);
            this.gunaPictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(72, 66);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox1.TabIndex = 16;
            this.gunaPictureBox1.TabStop = false;
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton1.ForeColor = System.Drawing.Color.Black;
            this.gunaButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton1.Image")));
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(109, 356);
            this.gunaButton1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Size = new System.Drawing.Size(120, 34);
            this.gunaButton1.TabIndex = 29;
            this.gunaButton1.Text = "Lưu";
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // gunaButton2
            // 
            this.gunaButton2.AnimationHoverSpeed = 0.07F;
            this.gunaButton2.AnimationSpeed = 0.03F;
            this.gunaButton2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaButton2.BorderColor = System.Drawing.Color.Black;
            this.gunaButton2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton2.ForeColor = System.Drawing.Color.Black;
            this.gunaButton2.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton2.Image")));
            this.gunaButton2.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton2.Location = new System.Drawing.Point(262, 356);
            this.gunaButton2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gunaButton2.Name = "gunaButton2";
            this.gunaButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton2.OnHoverImage = null;
            this.gunaButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton2.Size = new System.Drawing.Size(120, 34);
            this.gunaButton2.TabIndex = 32;
            this.gunaButton2.Text = "Hủy";
            this.gunaButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton2.Click += new System.EventHandler(this.gunaButton2_Click);
            // 
            // showData
            // 
            this.showData.AllowUserToAddRows = false;
            this.showData.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.showData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.showData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.showData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.showData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.showData.BackgroundColor = System.Drawing.Color.White;
            this.showData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.showData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.showData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.showData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.showData.ColumnHeadersHeight = 25;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(217)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.showData.DefaultCellStyle = dataGridViewCellStyle3;
            this.showData.EnableHeadersVisualStyles = false;
            this.showData.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(65)))), ((int)(((byte)(171)))));
            this.showData.Location = new System.Drawing.Point(482, 98);
            this.showData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.showData.Name = "showData";
            this.showData.ReadOnly = true;
            this.showData.RowHeadersVisible = false;
            this.showData.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.showData.RowTemplate.Height = 24;
            this.showData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.showData.Size = new System.Drawing.Size(561, 436);
            this.showData.TabIndex = 33;
            this.showData.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.showData.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.showData.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.showData.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.showData.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.showData.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.showData.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.showData.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(65)))), ((int)(((byte)(171)))));
            this.showData.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.showData.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.showData.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.showData.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.showData.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.showData.ThemeStyle.HeaderStyle.Height = 25;
            this.showData.ThemeStyle.ReadOnly = true;
            this.showData.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.showData.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.showData.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.showData.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            this.showData.ThemeStyle.RowsStyle.Height = 24;
            this.showData.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(217)))), ((int)(((byte)(244)))));
            this.showData.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.showData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.showData_CellContentClick);
            this.showData.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.showData_CellMouseClick_1);
            // 
            // frmedit_docgia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(1052, 542);
            this.Controls.Add(this.showData);
            this.Controls.Add(this.gunaButton2);
            this.Controls.Add(this.gunaButton1);
            this.Controls.Add(this.gunaPanel2);
            this.Controls.Add(this.gunaPanel1);
            this.Controls.Add(this.ngay_sinh);
            this.Controls.Add(this.gunaLabel6);
            this.Controls.Add(this.gunaLabel5);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.text_sdt);
            this.Controls.Add(this.text_diachi);
            this.Controls.Add(this.Tex_tendocgia);
            this.Controls.Add(this.tex_MA_docgia);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmedit_docgia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sửa thông tin độc giả";
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            this.gunaPanel2.ResumeLayout(false);
            this.gunaPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaDateTimePicker ngay_sinh;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaTextBox text_sdt;
        private Guna.UI.WinForms.GunaTextBox text_diachi;
        private Guna.UI.WinForms.GunaTextBox Tex_tendocgia;
        private Guna.UI.WinForms.GunaTextBox tex_MA_docgia;
        private Guna.UI.WinForms.GunaPanel gunaPanel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private Guna.UI.WinForms.GunaButton gunaButton2;
        private Guna.UI.WinForms.GunaDataGridView showData;
        private Guna.UI.WinForms.GunaRadioButton ra_nam;
        private Guna.UI.WinForms.GunaRadioButton ra_nu;
    }
}