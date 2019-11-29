namespace QLthuvien.GUI
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBanDoc));
            this.key_search = new Guna.UI.WinForms.GunaTextBox();
            this.showData = new Guna.UI.WinForms.GunaDataGridView();
            this.type_search = new Guna.UI.WinForms.GunaComboBox();
            this.gunaPanel2 = new Guna.UI.WinForms.GunaPanel();
            this.gunaButton4 = new Guna.UI.WinForms.GunaButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.gunaAdvenceButton1 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.load_data_btn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaButton5 = new Guna.UI.WinForms.GunaButton();
            this.gunaGradientButton1 = new Guna.UI.WinForms.GunaGradientButton();
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
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.showData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.showData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.showData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.showData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.showData.BackgroundColor = System.Drawing.Color.White;
            this.showData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.showData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.showData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(143)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.showData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.showData.ColumnHeadersHeight = 25;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.showData.DefaultCellStyle = dataGridViewCellStyle6;
            this.showData.EnableHeadersVisualStyles = false;
            this.showData.GridColor = System.Drawing.Color.White;
            this.showData.Location = new System.Drawing.Point(271, 102);
            this.showData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.showData.Name = "showData";
            this.showData.ReadOnly = true;
            this.showData.RowHeadersVisible = false;
            this.showData.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.showData.RowTemplate.Height = 24;
            this.showData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.showData.Size = new System.Drawing.Size(773, 426);
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
            this.gunaButton1.Location = new System.Drawing.Point(34, 165);
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
            this.gunaAdvenceButton1.Location = new System.Drawing.Point(34, 102);
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
            // gunaButton5
            // 
            this.gunaButton5.AnimationHoverSpeed = 0.07F;
            this.gunaButton5.AnimationSpeed = 0.03F;
            this.gunaButton5.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.gunaButton5.BorderColor = System.Drawing.Color.Black;
            this.gunaButton5.BorderSize = 1;
            this.gunaButton5.Cursor = System.Windows.Forms.Cursors.No;
            this.gunaButton5.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton5.ForeColor = System.Drawing.Color.White;
            this.gunaButton5.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton5.Image")));
            this.gunaButton5.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton5.Location = new System.Drawing.Point(34, 238);
            this.gunaButton5.Name = "gunaButton5";
            this.gunaButton5.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(179)))), ((int)(((byte)(230)))));
            this.gunaButton5.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton5.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton5.OnHoverImage = null;
            this.gunaButton5.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton5.Size = new System.Drawing.Size(200, 38);
            this.gunaButton5.TabIndex = 32;
            this.gunaButton5.Text = "Xóa thông tin độc giả";
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
            this.gunaGradientButton1.Size = new System.Drawing.Size(1056, 66);
            this.gunaGradientButton1.TabIndex = 33;
            this.gunaGradientButton1.Text = "Quản lý bạn đọc";
            this.gunaGradientButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FormBanDoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1056, 539);
            this.Controls.Add(this.gunaGradientButton1);
            this.Controls.Add(this.gunaButton5);
            this.Controls.Add(this.showData);
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
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaButton gunaButton2;
        private Guna.UI.WinForms.GunaTextBox key_search;
        private Guna.UI.WinForms.GunaButton gunaButton4;
        private Guna.UI.WinForms.GunaDataGridView showData;
        private Guna.UI.WinForms.GunaComboBox type_search;
        private Guna.UI.WinForms.GunaPanel gunaPanel2;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton1;
        private Guna.UI.WinForms.GunaAdvenceButton load_data_btn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Guna.UI.WinForms.GunaButton gunaButton5;
        private Guna.UI.WinForms.GunaGradientButton gunaGradientButton1;
    }
}