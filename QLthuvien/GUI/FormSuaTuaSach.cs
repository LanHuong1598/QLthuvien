using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLthuvien.GUI
{
    public partial class FormSuaTuaSach : Form
    {
        public static string Idsach ;
        public FormSuaTuaSach(string id)
        {
            InitializeComponent();
            Idsach = id; 
            txtma.Enabled = false;
            Show();

        }


        public void Show()
        {
            string query = "select * from TuaSach where MaTS like '" + Idsach + "'" ;
            ConnectString cnn = new ConnectString();
            string con = cnn.getConnectionString(Form1.checkConnectionString);
            DataTable data = new DataTable();

            using (SqlConnection connect = new SqlConnection(con))
            {
                connect.Open();
                SqlDataAdapter apter = new SqlDataAdapter(query, connect);
                apter.Fill(data);
                txtma.Text = data.Rows[0]["mats"].ToString();
                txtten.Text = data.Rows[0]["tents"].ToString();
                txtnamxb.Text = data.Rows[0]["namxb"].ToString();
                txttheloai.Text = data.Rows[0]["theloai"].ToString();
                txtnxb.Text = data.Rows[0]["manxb"].ToString();
                txtkesach.Text = data.Rows[0]["make"].ToString();
                connect.Close();
            }

            
        }
        private void gunaLabel6_Click(object sender, EventArgs e)
        {

        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sửa thành công");
        }

        private void txttheloai_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtten_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaLabel2_Click(object sender, EventArgs e)
        {

        }

        private void txtnxb_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaLabel3_Click(object sender, EventArgs e)
        {

        }

        private void txtnamxb_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaLabel5_Click(object sender, EventArgs e)
        {

        }

        private void txtkesach_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaLabel4_Click(object sender, EventArgs e)
        {

        }

        private void txtma_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel7_Click(object sender, EventArgs e)
        {

        }

        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void gunaPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
