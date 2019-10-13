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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMuonSach));
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.btn_MuonSach = new Guna.UI.WinForms.GunaButton();
            this.txt_MaSach = new Guna.UI.WinForms.GunaTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp_NgayMuon = new Guna.UI.WinForms.GunaDateTimePicker();
            this.cb_TuaSach = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_MaDG = new Guna.UI.WinForms.GunaTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gunaPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.gunaPanel1.Controls.Add(this.btn_MuonSach);
            this.gunaPanel1.Controls.Add(this.txt_MaSach);
            this.gunaPanel1.Controls.Add(this.label4);
            this.gunaPanel1.Controls.Add(this.label3);
            this.gunaPanel1.Controls.Add(this.dtp_NgayMuon);
            this.gunaPanel1.Controls.Add(this.cb_TuaSach);
            this.gunaPanel1.Controls.Add(this.label2);
            this.gunaPanel1.Controls.Add(this.txt_MaDG);
            this.gunaPanel1.Controls.Add(this.label1);
            this.gunaPanel1.Location = new System.Drawing.Point(2, 2);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(401, 446);
            this.gunaPanel1.TabIndex = 0;
            // 
            // btn_MuonSach
            // 
            this.btn_MuonSach.AnimationHoverSpeed = 0.07F;
            this.btn_MuonSach.AnimationSpeed = 0.03F;
            this.btn_MuonSach.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btn_MuonSach.BorderColor = System.Drawing.Color.Black;
            this.btn_MuonSach.FocusedColor = System.Drawing.Color.Empty;
            this.btn_MuonSach.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_MuonSach.ForeColor = System.Drawing.Color.White;
            this.btn_MuonSach.Image = ((System.Drawing.Image)(resources.GetObject("btn_MuonSach.Image")));
            this.btn_MuonSach.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_MuonSach.Location = new System.Drawing.Point(132, 350);
            this.btn_MuonSach.Name = "btn_MuonSach";
            this.btn_MuonSach.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_MuonSach.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_MuonSach.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_MuonSach.OnHoverImage = null;
            this.btn_MuonSach.OnPressedColor = System.Drawing.Color.Black;
            this.btn_MuonSach.Size = new System.Drawing.Size(201, 42);
            this.btn_MuonSach.TabIndex = 8;
            this.btn_MuonSach.Text = "Mượn sách";
            this.btn_MuonSach.Click += new System.EventHandler(this.btn_MuonSach_Click);
            // 
            // txt_MaSach
            // 
            this.txt_MaSach.BaseColor = System.Drawing.Color.White;
            this.txt_MaSach.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txt_MaSach.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_MaSach.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_MaSach.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_MaSach.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_MaSach.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_MaSach.Location = new System.Drawing.Point(132, 181);
            this.txt_MaSach.Name = "txt_MaSach";
            this.txt_MaSach.PasswordChar = '\0';
            this.txt_MaSach.Size = new System.Drawing.Size(201, 32);
            this.txt_MaSach.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mã sách:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ngày mượn:";
            // 
            // dtp_NgayMuon
            // 
            this.dtp_NgayMuon.BaseColor = System.Drawing.Color.White;
            this.dtp_NgayMuon.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dtp_NgayMuon.CustomFormat = null;
            this.dtp_NgayMuon.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtp_NgayMuon.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtp_NgayMuon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtp_NgayMuon.ForeColor = System.Drawing.Color.Black;
            this.dtp_NgayMuon.Location = new System.Drawing.Point(132, 253);
            this.dtp_NgayMuon.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_NgayMuon.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtp_NgayMuon.Name = "dtp_NgayMuon";
            this.dtp_NgayMuon.OnHoverBaseColor = System.Drawing.Color.White;
            this.dtp_NgayMuon.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtp_NgayMuon.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtp_NgayMuon.OnPressedColor = System.Drawing.Color.Black;
            this.dtp_NgayMuon.Size = new System.Drawing.Size(201, 30);
            this.dtp_NgayMuon.TabIndex = 4;
            this.dtp_NgayMuon.Text = "Saturday, October 12, 2019";
            this.dtp_NgayMuon.Value = new System.DateTime(2019, 10, 12, 23, 19, 39, 316);
            // 
            // cb_TuaSach
            // 
            this.cb_TuaSach.FormattingEnabled = true;
            this.cb_TuaSach.Location = new System.Drawing.Point(132, 128);
            this.cb_TuaSach.Name = "cb_TuaSach";
            this.cb_TuaSach.Size = new System.Drawing.Size(201, 24);
            this.cb_TuaSach.TabIndex = 3;
            this.cb_TuaSach.SelectedIndexChanged += new System.EventHandler(this.cb_TuaSach_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tựa sách:";
            // 
            // txt_MaDG
            // 
            this.txt_MaDG.BaseColor = System.Drawing.Color.White;
            this.txt_MaDG.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txt_MaDG.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_MaDG.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_MaDG.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_MaDG.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_MaDG.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_MaDG.Location = new System.Drawing.Point(132, 52);
            this.txt_MaDG.Name = "txt_MaDG";
            this.txt_MaDG.PasswordChar = '\0';
            this.txt_MaDG.Size = new System.Drawing.Size(201, 32);
            this.txt_MaDG.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã độc giả:";
            // 
            // FormMuonSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 450);
            this.Controls.Add(this.gunaPanel1);
            this.Name = "FormMuonSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mượn sách";
            this.Load += new System.EventHandler(this.FormMuonSach_Load);
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaButton btn_MuonSach;
        private Guna.UI.WinForms.GunaTextBox txt_MaSach;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaDateTimePicker dtp_NgayMuon;
        private System.Windows.Forms.ComboBox cb_TuaSach;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaTextBox txt_MaDG;
        private System.Windows.Forms.Label label1;
    }
}