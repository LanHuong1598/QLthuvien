using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLthuvien.GUI;
namespace QLthuvien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            FormSach fs = new FormSach();
            fs.Show();

        }

        private void label2_Click(object sender, EventArgs e)
        {
            FormBanDoc fr = new FormBanDoc();
            fr.Show();

        }
    }
}
