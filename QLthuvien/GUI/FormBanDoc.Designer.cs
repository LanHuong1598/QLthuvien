﻿namespace QLthuvien.GUI
{
    partial class FormBanDoc
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBanDoc));
            this.key_search = new Guna.UI.WinForms.GunaTextBox();
            this.showData = new Guna.UI.WinForms.GunaDataGridView();
            this.type_search = new Guna.UI.WinForms.GunaComboBox();
            this.gunaPanel2 = new Guna.UI.WinForms.GunaPanel();
            this.gunaButton4 = new Guna.UI.WinForms.GunaButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gunaButton3 = new Guna.UI.WinForms.GunaButton();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.gunaAdvenceButton1 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.load_data_btn = new Guna.UI.WinForms.GunaAdvenceButton();
            ((System.ComponentModel.ISupportInitialize)(this.showData)).BeginInit();
            this.gunaPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // key_search
            // 
            this.key_search.BaseColor = System.Drawing.Color.White;
            this.key_search.BorderColor = System.Drawing.Color.Silver;
            this.key_search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.key_search.FocusedBaseColor = System.Drawing.Color.White;
            this.key_search.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.key_search.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.key_search.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.key_search.Location = new System.Drawing.Point(0, 0);
            this.key_search.Name = "key_search";
            this.key_search.PasswordChar = '\0';
            this.key_search.Size = new System.Drawing.Size(160, 30);
            this.key_search.TabIndex = 33;
            // 
            // showData
            // 
            this.showData.AllowUserToAddRows = false;
            this.showData.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.showData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.showData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.showData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.showData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.showData.BackgroundColor = System.Drawing.Color.White;
            this.showData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.showData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.showData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;

            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.showData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.showData.ColumnHeadersHeight = 25;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(217)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.showData.DefaultCellStyle = dataGridViewCellStyle9;

            this.showData.EnableHeadersVisualStyles = false;
            this.showData.GridColor = System.Drawing.Color.White;
            this.showData.Location = new System.Drawing.Point(239, 82);
            this.showData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.showData.Name = "showData";
            this.showData.ReadOnly = true;
            this.showData.RowHeadersVisible = false;
            this.showData.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.showData.RowTemplate.Height = 24;
            this.showData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.showData.Size = new System.Drawing.Size(806, 428);
            this.showData.TabIndex = 30;
            this.showData.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.showData.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.showData.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.showData.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.showData.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.showData.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.showData.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.showData.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.showData.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(143)))));
            this.showData.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.showData.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.showData.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.showData.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.showData.ThemeStyle.HeaderStyle.Height = 25;
            this.showData.ThemeStyle.ReadOnly = true;
            this.showData.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.showData.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.showData.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.showData.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.showData.ThemeStyle.RowsStyle.Height = 24;
            this.showData.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.showData.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.showData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.showData_CellContentClick);
            this.showData.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.showData_CellContentDoubleClick);
            this.showData.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.showData_CellDoubleClick);
            this.showData.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.showData_CellMouseClick);
            this.showData.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.showData_CellMouseDoubleClick);
            this.showData.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.showData_CellMouseDown);
            this.showData.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.showData_CellMouseEnter);
            this.showData.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.showData_CellMouseLeave);
            this.showData.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.showData_CellMouseMove);
            // 
            // type_search
            // 
            this.type_search.BackColor = System.Drawing.Color.Transparent;
            this.type_search.BaseColor = System.Drawing.Color.White;
            this.type_search.BorderColor = System.Drawing.Color.Silver;
            this.type_search.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.type_search.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.type_search.FocusedColor = System.Drawing.Color.Empty;
            this.type_search.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.type_search.ForeColor = System.Drawing.Color.Black;
            this.type_search.FormattingEnabled = true;
            this.type_search.Items.AddRange(new object[] {
            "Mã",
            "Họ tên",
            "Địa chỉ",
            "Sđt"});
            this.type_search.Location = new System.Drawing.Point(14, 9);
            this.type_search.Name = "type_search";
            this.type_search.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.type_search.OnHoverItemForeColor = System.Drawing.Color.White;
            this.type_search.Size = new System.Drawing.Size(136, 26);
            this.type_search.TabIndex = 32;
            // 
            // gunaPanel2
            // 
            this.gunaPanel2.Controls.Add(this.type_search);
            this.gunaPanel2.Controls.Add(this.key_search);
            this.gunaPanel2.Controls.Add(this.gunaButton4);
            this.gunaPanel2.Location = new System.Drawing.Point(708, 115);
            this.gunaPanel2.Name = "gunaPanel2";
            this.gunaPanel2.Size = new System.Drawing.Size(588, 43);
            this.gunaPanel2.TabIndex = 33;
            // 
            // gunaButton4
            // 
            this.gunaButton4.AnimationHoverSpeed = 0.07F;
            this.gunaButton4.AnimationSpeed = 0.03F;
            this.gunaButton4.BaseColor = System.Drawing.Color.Transparent;
            this.gunaButton4.BorderColor = System.Drawing.Color.Black;
            this.gunaButton4.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton4.ForeColor = System.Drawing.Color.Black;
            this.gunaButton4.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton4.Image")));
            this.gunaButton4.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton4.Location = new System.Drawing.Point(1124, 109);
            this.gunaButton4.Name = "gunaButton4";
            this.gunaButton4.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gunaButton4.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton4.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton4.OnHoverImage = null;
            this.gunaButton4.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton4.Size = new System.Drawing.Size(92, 26);
            this.gunaButton4.TabIndex = 7;
            this.gunaButton4.Text = "Search";
            this.gunaButton4.Click += new System.EventHandler(this.gunaButton4_Click);
            // 
            // gunaButton3
            // 
            this.gunaButton3.AnimationHoverSpeed = 0.07F;
            this.gunaButton3.AnimationSpeed = 0.03F;
            this.gunaButton3.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.gunaButton3.BorderColor = System.Drawing.Color.Black;
            this.gunaButton3.BorderSize = 1;
            this.gunaButton3.Cursor = System.Windows.Forms.Cursors.No;
            this.gunaButton3.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton3.ForeColor = System.Drawing.Color.White;
            this.gunaButton3.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton3.Image")));
            this.gunaButton3.ImageSize = new System.Drawing.Size(20, 20);

            this.gunaButton3.Location = new System.Drawing.Point(12, 283);

            this.gunaButton3.Location = new System.Drawing.Point(12, 215);

            this.gunaButton3.Name = "gunaButton3";
            this.gunaButton3.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(179)))), ((int)(((byte)(230)))));
            this.gunaButton3.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton3.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton3.OnHoverImage = null;
            this.gunaButton3.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton3.Size = new System.Drawing.Size(200, 38);
            this.gunaButton3.TabIndex = 5;
            this.gunaButton3.Text = "Xóa độc giả";
            this.gunaButton3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton3.Click += new System.EventHandler(this.gunaButton3_Click);
            // 

            // gunaButton2
            // 
            this.gunaButton2.AnimationHoverSpeed = 0.07F;
            this.gunaButton2.AnimationSpeed = 0.03F;
            this.gunaButton2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.gunaButton2.BorderColor = System.Drawing.Color.Black;
            this.gunaButton2.BorderSize = 1;
            this.gunaButton2.Cursor = System.Windows.Forms.Cursors.No;
            this.gunaButton2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton2.ForeColor = System.Drawing.Color.White;
            this.gunaButton2.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton2.Image")));
            this.gunaButton2.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton2.Location = new System.Drawing.Point(12, 216);
            this.gunaButton2.Name = "gunaButton2";
            this.gunaButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(179)))), ((int)(((byte)(230)))));
            this.gunaButton2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton2.OnHoverImage = null;
            this.gunaButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton2.Size = new System.Drawing.Size(200, 38);
            this.gunaButton2.TabIndex = 4;
            this.gunaButton2.Text = "Tìm kiếm độc giả";
            this.gunaButton2.Click += new System.EventHandler(this.gunaButton2_Click);
            // 

            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.BorderSize = 1;
            this.gunaButton1.Cursor = System.Windows.Forms.Cursors.No;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton1.Image")));
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(12, 149);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(179)))), ((int)(((byte)(230)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Size = new System.Drawing.Size(200, 38);
            this.gunaButton1.TabIndex = 1;
            this.gunaButton1.Text = "Sửa thông tin độc giả";
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // gunaAdvenceButton1
            // 
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
            this.gunaAdvenceButton1.Cursor = System.Windows.Forms.Cursors.No;
            this.gunaAdvenceButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceButton1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaAdvenceButton1.ForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton1.Image")));
            this.gunaAdvenceButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaAdvenceButton1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton1.Location = new System.Drawing.Point(12, 86);
            this.gunaAdvenceButton1.Name = "gunaAdvenceButton1";
            this.gunaAdvenceButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(179)))), ((int)(((byte)(230)))));
            this.gunaAdvenceButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.OnHoverImage = null;
            this.gunaAdvenceButton1.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.Size = new System.Drawing.Size(200, 34);
            this.gunaAdvenceButton1.TabIndex = 0;
            this.gunaAdvenceButton1.Text = "Thêm mới độc giả";
            this.gunaAdvenceButton1.Click += new System.EventHandler(this.gunaAdvenceButton1_Click);
            // 
            // load_data_btn
            // 
            this.load_data_btn.AnimationHoverSpeed = 0.07F;
            this.load_data_btn.AnimationSpeed = 0.03F;
            this.load_data_btn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.load_data_btn.BorderColor = System.Drawing.Color.Black;
            this.load_data_btn.CheckedBaseColor = System.Drawing.Color.Gray;
            this.load_data_btn.CheckedBorderColor = System.Drawing.Color.Black;
            this.load_data_btn.CheckedForeColor = System.Drawing.Color.White;
            this.load_data_btn.CheckedImage = ((System.Drawing.Image)(resources.GetObject("load_data_btn.CheckedImage")));
            this.load_data_btn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.load_data_btn.FocusedColor = System.Drawing.Color.Empty;
            this.load_data_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.load_data_btn.ForeColor = System.Drawing.Color.White;
            this.load_data_btn.Image = ((System.Drawing.Image)(resources.GetObject("load_data_btn.Image")));
            this.load_data_btn.ImageSize = new System.Drawing.Size(20, 20);
            this.load_data_btn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.load_data_btn.Location = new System.Drawing.Point(52, 174);
            this.load_data_btn.Name = "load_data_btn";
            this.load_data_btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.load_data_btn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.load_data_btn.OnHoverForeColor = System.Drawing.Color.White;
            this.load_data_btn.OnHoverImage = null;
            this.load_data_btn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.load_data_btn.OnPressedColor = System.Drawing.Color.Black;
            this.load_data_btn.Size = new System.Drawing.Size(205, 42);
            this.load_data_btn.TabIndex = 34;
            this.load_data_btn.Text = "Load dữ liệu";
            this.load_data_btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.load_data_btn.Click += new System.EventHandler(this.load_data_btn_Click);
            // 

            // gunaAdvenceButton2
            // 
            this.gunaAdvenceButton2.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceButton2.AnimationSpeed = 0.03F;
            this.gunaAdvenceButton2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.gunaAdvenceButton2.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton2.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gunaAdvenceButton2.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton2.CheckedForeColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton2.CheckedImage = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton2.CheckedImage")));
            this.gunaAdvenceButton2.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaAdvenceButton2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceButton2.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaAdvenceButton2.ForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton2.Image = null;
            this.gunaAdvenceButton2.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaAdvenceButton2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.gunaAdvenceButton2.Location = new System.Drawing.Point(0, 0);
            this.gunaAdvenceButton2.Name = "gunaAdvenceButton2";
            this.gunaAdvenceButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.gunaAdvenceButton2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton2.OnHoverImage = null;
            this.gunaAdvenceButton2.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.gunaAdvenceButton2.OnPressedColor = System.Drawing.Color.White;
            this.gunaAdvenceButton2.Size = new System.Drawing.Size(1057, 63);
            this.gunaAdvenceButton2.TabIndex = 31;
            this.gunaAdvenceButton2.Text = "Quản lý bạn đọc";
            this.gunaAdvenceButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;

            // gunaTextBox1
            // 
            this.gunaTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaTextBox1.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox1.BorderColor = System.Drawing.Color.Silver;
            this.gunaTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox1.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox1.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaTextBox1.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaTextBox1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.gunaTextBox1.Location = new System.Drawing.Point(12, 281);
            this.gunaTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.gunaTextBox1.Name = "gunaTextBox1";
            this.gunaTextBox1.PasswordChar = '\0';
            this.gunaTextBox1.Size = new System.Drawing.Size(154, 43);
            this.gunaTextBox1.TabIndex = 12;
            this.gunaTextBox1.Text = "Tìm kiếm tại đây";
            this.gunaTextBox1.TextChanged += new System.EventHandler(this.gunaTextBox1_TextChanged);
            // 
            // btTimKiem
            // 
            this.btTimKiem.BackgroundImage = global::QLthuvien.Properties.Resources.iconsearch;
            this.btTimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btTimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btTimKiem.ForeColor = System.Drawing.Color.White;
            this.btTimKiem.Location = new System.Drawing.Point(170, 281);
            this.btTimKiem.Name = "btTimKiem";
            this.btTimKiem.Size = new System.Drawing.Size(47, 42);
            this.btTimKiem.TabIndex = 11;
            this.btTimKiem.UseVisualStyleBackColor = true;
            this.btTimKiem.Click += new System.EventHandler(this.btTimKiem_Click);

            // 
            // FormBanDoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;

            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1057, 521);
            this.Controls.Add(this.gunaAdvenceButton2);

            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(765, 508);
            this.Controls.Add(this.gunaTextBox1);
            this.Controls.Add(this.btTimKiem);
            this.Controls.Add(this.gunaPanel1);

            this.Controls.Add(this.showData);
            this.Controls.Add(this.gunaButton3);
            this.Controls.Add(this.gunaButton1);
            this.Controls.Add(this.gunaAdvenceButton1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormBanDoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản lý bạn đọc";
            ((System.ComponentModel.ISupportInitialize)(this.showData)).EndInit();
            this.gunaPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaButton gunaButton1;

        private Guna.UI.WinForms.GunaButton gunaButton2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;

        private Guna.UI.WinForms.GunaButton gunaButton3;
        private Guna.UI.WinForms.GunaTextBox key_search;
        private Guna.UI.WinForms.GunaButton gunaButton4;
        private Guna.UI.WinForms.GunaDataGridView showData;
        private Guna.UI.WinForms.GunaComboBox type_search;
        private Guna.UI.WinForms.GunaPanel gunaPanel2;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton1;
        private Guna.UI.WinForms.GunaAdvenceButton load_data_btn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;

        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton2;

        private Guna.UI.WinForms.GunaTextBox gunaTextBox1;
        private System.Windows.Forms.Button btTimKiem;

    }
}