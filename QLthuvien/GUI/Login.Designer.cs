﻿namespace QLthuvien
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.DragForm = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.txt_user = new Guna.UI.WinForms.GunaTextBox();
            this.txt_pass = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.chk_savedAcc = new Guna.UI.WinForms.GunaMediumCheckBox();
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.btn_newAcc = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaAdvenceButton1 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this;
            // 
            // DragForm
            // 
            this.DragForm.TargetControl = this;
            // 
            // txt_user
            // 
            this.txt_user.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_user.BaseColor = System.Drawing.Color.White;
            this.txt_user.BorderColor = System.Drawing.Color.Black;
            this.txt_user.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_user.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_user.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.txt_user.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_user.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user.Location = new System.Drawing.Point(727, 186);
            this.txt_user.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_user.Name = "txt_user";
            this.txt_user.PasswordChar = '\0';
            this.txt_user.Size = new System.Drawing.Size(245, 38);
            this.txt_user.TabIndex = 3;
            // 
            // txt_pass
            // 
            this.txt_pass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_pass.BaseColor = System.Drawing.Color.White;
            this.txt_pass.BorderColor = System.Drawing.Color.Black;
            this.txt_pass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_pass.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_pass.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.txt_pass.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_pass.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pass.Location = new System.Drawing.Point(727, 260);
            this.txt_pass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PasswordChar = '*';
            this.txt_pass.Size = new System.Drawing.Size(245, 38);
            this.txt_pass.TabIndex = 4;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.Location = new System.Drawing.Point(724, 167);
            this.gunaLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(63, 15);
            this.gunaLabel1.TabIndex = 5;
            this.gunaLabel1.Text = "Tài khoản :";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.Location = new System.Drawing.Point(728, 241);
            this.gunaLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(63, 15);
            this.gunaLabel2.TabIndex = 6;
            this.gunaLabel2.Text = "Mật khẩu :";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel3.Location = new System.Drawing.Point(752, 323);
            this.gunaLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(159, 15);
            this.gunaLabel3.TabIndex = 7;
            this.gunaLabel3.Text = "Bạn có muốn lưu mật khẩu ?";
            // 
            // chk_savedAcc
            // 
            this.chk_savedAcc.BaseColor = System.Drawing.Color.White;
            this.chk_savedAcc.CheckedOffColor = System.Drawing.Color.Black;
            this.chk_savedAcc.CheckedOnColor = System.Drawing.Color.Black;
            this.chk_savedAcc.FillColor = System.Drawing.Color.White;
            this.chk_savedAcc.Location = new System.Drawing.Point(728, 323);
            this.chk_savedAcc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chk_savedAcc.Name = "chk_savedAcc";
            this.chk_savedAcc.Size = new System.Drawing.Size(20, 20);
            this.chk_savedAcc.TabIndex = 8;
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this.gunaPictureBox1;
            // 
            // btn_newAcc
            // 
            this.btn_newAcc.AnimationHoverSpeed = 0.07F;
            this.btn_newAcc.AnimationSpeed = 0.03F;
            this.btn_newAcc.BaseColor = System.Drawing.Color.White;
            this.btn_newAcc.BorderColor = System.Drawing.Color.Black;
            this.btn_newAcc.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btn_newAcc.CheckedBorderColor = System.Drawing.Color.Black;
            this.btn_newAcc.CheckedForeColor = System.Drawing.Color.White;
            this.btn_newAcc.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btn_newAcc.CheckedImage")));
            this.btn_newAcc.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btn_newAcc.FocusedColor = System.Drawing.Color.Empty;
            this.btn_newAcc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_newAcc.ForeColor = System.Drawing.Color.Black;
            this.btn_newAcc.Image = null;
            this.btn_newAcc.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_newAcc.LineColor = System.Drawing.Color.White;
            this.btn_newAcc.Location = new System.Drawing.Point(730, 453);
            this.btn_newAcc.Margin = new System.Windows.Forms.Padding(2);
            this.btn_newAcc.Name = "btn_newAcc";
            this.btn_newAcc.OnHoverBaseColor = System.Drawing.Color.White;
            this.btn_newAcc.OnHoverBorderColor = System.Drawing.Color.White;
            this.btn_newAcc.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_newAcc.OnHoverImage = null;
            this.btn_newAcc.OnHoverLineColor = System.Drawing.Color.White;
            this.btn_newAcc.OnPressedColor = System.Drawing.Color.Transparent;
            this.btn_newAcc.Size = new System.Drawing.Size(135, 38);
            this.btn_newAcc.TabIndex = 11;
            this.btn_newAcc.Text = "Bạn chưa có tài khoản ?";
            this.btn_newAcc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_newAcc.Click += new System.EventHandler(this.btn_newAcc_Click);
            // 
            // gunaAdvenceButton1
            // 
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
            this.gunaAdvenceButton1.Location = new System.Drawing.Point(730, 373);
            this.gunaAdvenceButton1.Margin = new System.Windows.Forms.Padding(2);
            this.gunaAdvenceButton1.Name = "gunaAdvenceButton1";
            this.gunaAdvenceButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(184)))), ((int)(((byte)(234)))));
            this.gunaAdvenceButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.OnHoverImage = null;
            this.gunaAdvenceButton1.OnHoverLineColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.Size = new System.Drawing.Size(242, 38);
            this.gunaAdvenceButton1.TabIndex = 9;
            this.gunaAdvenceButton1.Text = "Đăng nhập";
            this.gunaAdvenceButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaAdvenceButton1.Click += new System.EventHandler(this.gunaAdvenceButton1_Click);
            // 
            // gunaControlBox1
            // 
            this.gunaControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox1.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox1.AnimationSpeed = 0.03F;
            this.gunaControlBox1.IconColor = System.Drawing.Color.Black;
            this.gunaControlBox1.IconSize = 15F;
            this.gunaControlBox1.Location = new System.Drawing.Point(977, 10);
            this.gunaControlBox1.Margin = new System.Windows.Forms.Padding(2);
            this.gunaControlBox1.Name = "gunaControlBox1";
            this.gunaControlBox1.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.gunaControlBox1.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox1.Size = new System.Drawing.Size(34, 24);
            this.gunaControlBox1.TabIndex = 1;
            this.gunaControlBox1.Click += new System.EventHandler(this.gunaControlBox1_Click);
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gunaPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox1.Image")));
            this.gunaPictureBox1.Location = new System.Drawing.Point(0, 0);
            this.gunaPictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(679, 526);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox1.TabIndex = 2;
            this.gunaPictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1020, 526);
            this.Controls.Add(this.btn_newAcc);
            this.Controls.Add(this.gunaAdvenceButton1);
            this.Controls.Add(this.chk_savedAcc);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_user);
            this.Controls.Add(this.gunaPictureBox1);
            this.Controls.Add(this.gunaControlBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Guna.UI.WinForms.GunaDragControl DragForm;
        private Guna.UI.WinForms.GunaMediumCheckBox chk_savedAcc;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaTextBox txt_pass;
        private Guna.UI.WinForms.GunaTextBox txt_user;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton1;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private Guna.UI.WinForms.GunaAdvenceButton btn_newAcc;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
    }
}

