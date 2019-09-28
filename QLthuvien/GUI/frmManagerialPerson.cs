using System;
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
    public partial class frmManagerialPerson : Form
    {

        public frmManagerialPerson()
        {
            InitializeComponent();
            int a = Form1.checkConnectionString;
            MessageBox.Show(a.ToString());
        }
    }
}
