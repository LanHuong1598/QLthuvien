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
        internal static int checkConnectionString;
        
        public Form1()
        {
            InitializeComponent();
            ConnectString check = new ConnectString();
            checkConnectionString = check.checkCnn();
           

        }

        private void btn_newAcc_Click(object sender, EventArgs e)
        {
            FrNewAccount acc = new FrNewAccount();
            acc.ShowDialog();
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            frmManagerialPerson a = new frmManagerialPerson();
            this.Visible = true;
            a.ShowDialog();
        }
    }
}
