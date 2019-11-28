namespace QLthuvien.GUI
{
    partial class FormMuonSach
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMuonSach));
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.dtpNgaytra = new Guna.UI.WinForms.GunaDateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.gunaDataGridView1 = new Guna.UI.WinForms.GunaDataGridView();
            this.txt_MaPhieu = new Guna.UI.WinForms.GunaTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp_NgayMuon = new Guna.UI.WinForms.GunaDateTimePicker();
            this.txt_MaDG = new Guna.UI.WinForms.GunaTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dssach = new Guna.UI.WinForms.GunaDataGridView();
            this.gunaAdvenceButton1 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dssach)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaPanel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.gunaPanel1.Controls.Add(this.gunaAdvenceButton1);
            this.gunaPanel1.Controls.Add(this.gunaDataGridView1);
            this.gunaPanel1.Controls.Add(this.txt_MaPhieu);
            this.gunaPanel1.Controls.Add(this.dtp_NgayMuon);
            this.gunaPanel1.Controls.Add(this.txt_MaDG);
            this.gunaPanel1.Controls.Add(this.groupBox1);
            this.gunaPanel1.Location = new System.Drawing.Point(2, 2);
            this.gunaPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(1128, 616);
            this.gunaPanel1.TabIndex = 0;
            // 
            // dtpNgaytra
            // 
            this.dtpNgaytra.BaseColor = System.Drawing.Color.White;
            this.dtpNgaytra.BorderColor = System.Drawing.Color.Black;
            this.dtpNgaytra.CustomFormat = null;
            this.dtpNgaytra.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpNgaytra.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpNgaytra.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpNgaytra.ForeColor = System.Drawing.Color.Black;
            this.dtpNgaytra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaytra.Location = new System.Drawing.Point(137, 187);
            this.dtpNgaytra.Margin = new System.Windows.Forms.Padding(2);
            this.dtpNgaytra.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgaytra.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgaytra.Name = "dtpNgaytra";
            this.dtpNgaytra.OnHoverBaseColor = System.Drawing.Color.White;
            this.dtpNgaytra.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpNgaytra.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpNgaytra.OnPressedColor = System.Drawing.Color.Black;
            this.dtpNgaytra.Size = new System.Drawing.Size(151, 38);
            this.dtpNgaytra.TabIndex = 13;
            this.dtpNgaytra.Text = "10/12/2019";
            this.dtpNgaytra.Value = new System.DateTime(2019, 10, 12, 23, 19, 39, 316);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 198);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 14);
            this.label2.TabIndex = 12;
            this.label2.Text = "Ngày trả: ";
            // 
            // gunaDataGridView1
            // 
            this.gunaDataGridView1.AllowUserToAddRows = false;
            this.gunaDataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gunaDataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gunaDataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.gunaDataGridView1.BackgroundColor = System.Drawing.Color.LightGray;
            this.gunaDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(143)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gunaDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gunaDataGridView1.ColumnHeadersHeight = 25;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gunaDataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.gunaDataGridView1.EnableHeadersVisualStyles = false;
            this.gunaDataGridView1.GridColor = System.Drawing.Color.White;
            this.gunaDataGridView1.Location = new System.Drawing.Point(332, 15);
            this.gunaDataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.gunaDataGridView1.Name = "gunaDataGridView1";
            this.gunaDataGridView1.ReadOnly = true;
            this.gunaDataGridView1.RowHeadersVisible = false;
            this.gunaDataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.RowTemplate.Height = 24;
            this.gunaDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gunaDataGridView1.Size = new System.Drawing.Size(771, 517);
            this.gunaDataGridView1.TabIndex = 11;
            this.gunaDataGridView1.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.BackColor = System.Drawing.Color.LightGray;
            this.gunaDataGridView1.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(143)))));
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.Height = 25;
            this.gunaDataGridView1.ThemeStyle.ReadOnly = true;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gunaDataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.Height = 24;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.gunaDataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.gunaDataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gunaDataGridView1_CellContentClick);
            // 
            // txt_MaPhieu
            // 
            this.txt_MaPhieu.BaseColor = System.Drawing.Color.White;
            this.txt_MaPhieu.BorderColor = System.Drawing.Color.Black;
            this.txt_MaPhieu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_MaPhieu.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_MaPhieu.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_MaPhieu.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_MaPhieu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_MaPhieu.Location = new System.Drawing.Point(146, 21);
            this.txt_MaPhieu.Margin = new System.Windows.Forms.Padding(2);
            this.txt_MaPhieu.Name = "txt_MaPhieu";
            this.txt_MaPhieu.PasswordChar = '\0';
            this.txt_MaPhieu.Size = new System.Drawing.Size(151, 38);
            this.txt_MaPhieu.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 24);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 14);
            this.label5.TabIndex = 9;
            this.label5.Text = "Mã phiếu mượn:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 132);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 14);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ngày mượn:";
            // 
            // dtp_NgayMuon
            // 
            this.dtp_NgayMuon.BaseColor = System.Drawing.Color.White;
            this.dtp_NgayMuon.BorderColor = System.Drawing.Color.Black;
            this.dtp_NgayMuon.CustomFormat = null;
            this.dtp_NgayMuon.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtp_NgayMuon.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtp_NgayMuon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtp_NgayMuon.ForeColor = System.Drawing.Color.Black;
            this.dtp_NgayMuon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_NgayMuon.Location = new System.Drawing.Point(147, 131);
            this.dtp_NgayMuon.Margin = new System.Windows.Forms.Padding(2);
            this.dtp_NgayMuon.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_NgayMuon.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtp_NgayMuon.Name = "dtp_NgayMuon";
            this.dtp_NgayMuon.OnHoverBaseColor = System.Drawing.Color.White;
            this.dtp_NgayMuon.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtp_NgayMuon.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtp_NgayMuon.OnPressedColor = System.Drawing.Color.Black;
            this.dtp_NgayMuon.Size = new System.Drawing.Size(151, 38);
            this.dtp_NgayMuon.TabIndex = 4;
            this.dtp_NgayMuon.Text = "10/12/2019";
            this.dtp_NgayMuon.Value = new System.DateTime(2019, 10, 12, 23, 19, 39, 316);
            // 
            // txt_MaDG
            // 
            this.txt_MaDG.BaseColor = System.Drawing.Color.White;
            this.txt_MaDG.BorderColor = System.Drawing.Color.Black;
            this.txt_MaDG.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_MaDG.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_MaDG.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_MaDG.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_MaDG.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_MaDG.Location = new System.Drawing.Point(147, 76);
            this.txt_MaDG.Margin = new System.Windows.Forms.Padding(2);
            this.txt_MaDG.Name = "txt_MaDG";
            this.txt_MaDG.PasswordChar = '\0';
            this.txt_MaDG.Size = new System.Drawing.Size(151, 38);
            this.txt_MaDG.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã độc giả:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpNgaytra);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dssach);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(299, 558);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // dssach
            // 
            this.dssach.AllowUserToAddRows = false;
            this.dssach.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dssach.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dssach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dssach.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dssach.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dssach.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dssach.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dssach.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(143)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dssach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dssach.ColumnHeadersHeight = 25;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dssach.DefaultCellStyle = dataGridViewCellStyle6;
            this.dssach.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dssach.EnableHeadersVisualStyles = false;
            this.dssach.GridColor = System.Drawing.Color.White;
            this.dssach.Location = new System.Drawing.Point(3, 241);
            this.dssach.Margin = new System.Windows.Forms.Padding(2);
            this.dssach.Name = "dssach";
            this.dssach.ReadOnly = true;
            this.dssach.RowHeadersVisible = false;
            this.dssach.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dssach.RowTemplate.Height = 24;
            this.dssach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dssach.Size = new System.Drawing.Size(293, 314);
            this.dssach.TabIndex = 15;
            this.dssach.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dssach.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dssach.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dssach.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dssach.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dssach.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dssach.ThemeStyle.BackColor = System.Drawing.Color.DarkGray;
            this.dssach.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.dssach.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(143)))));
            this.dssach.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dssach.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dssach.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dssach.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dssach.ThemeStyle.HeaderStyle.Height = 25;
            this.dssach.ThemeStyle.ReadOnly = true;
            this.dssach.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dssach.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dssach.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dssach.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dssach.ThemeStyle.RowsStyle.Height = 24;
            this.dssach.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.dssach.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            // 
            // gunaAdvenceButton1
            // 
            this.gunaAdvenceButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaAdvenceButton1.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceButton1.AnimationSpeed = 0.03F;
            this.gunaAdvenceButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.gunaAdvenceButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.BorderSize = 2;
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
            this.gunaAdvenceButton1.Location = new System.Drawing.Point(861, 569);
            this.gunaAdvenceButton1.Margin = new System.Windows.Forms.Padding(2);
            this.gunaAdvenceButton1.Name = "gunaAdvenceButton1";
            this.gunaAdvenceButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(184)))), ((int)(((byte)(234)))));
            this.gunaAdvenceButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.OnHoverImage = null;
            this.gunaAdvenceButton1.OnHoverLineColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.Size = new System.Drawing.Size(242, 38);
            this.gunaAdvenceButton1.TabIndex = 15;
            this.gunaAdvenceButton1.Text = "Mượn sách";
            this.gunaAdvenceButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaAdvenceButton1.Click += new System.EventHandler(this.btn_MuonSach_Click);
            // 
            // FormMuonSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 620);
            this.Controls.Add(this.gunaPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMuonSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mượn sách";
            this.Load += new System.EventHandler(this.FormMuonSach_Load);
            this.gunaPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dssach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaDateTimePicker dtp_NgayMuon;
        private Guna.UI.WinForms.GunaTextBox txt_MaDG;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaTextBox txt_MaPhieu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaDataGridView gunaDataGridView1;
        private Guna.UI.WinForms.GunaDateTimePicker dtpNgaytra;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI.WinForms.GunaDataGridView dssach;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton1;
    }
}