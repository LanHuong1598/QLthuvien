﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLthuvien.GUI
{
    public partial class frmGiaoDien : Form
    {
        public frmGiaoDien()
        {
            InitializeComponent();
        }

        private void gunaCircleButton2_Click(object sender, EventArgs e)
        {
            FormBanDoc fmp = new FormBanDoc();
            fmp.ShowDialog();
        }

        private void exit_app_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gunaCircleButton1_Click(object sender, EventArgs e)
        {
            FormTuaSach a = new FormTuaSach();
            a.ShowDialog();
        }
    }
}
