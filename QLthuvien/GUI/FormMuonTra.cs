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
    public partial class FormMuonTra : Form
    {
        ConnectString cnn = new ConnectString();
        string conectionString="";
        public FormMuonTra()
        {
            InitializeComponent();
        }
        void load()
        {
            conectionString = cnn.getConnectionString(1);

        }
        private void FormMuonTra_Load(object sender, EventArgs e)
        {
            gunaDateTimePicker1.Format = DateTimePickerFormat.Custom;
            gunaDateTimePicker1.CustomFormat = "dd/MM/yyyy";

        }
    }
}
