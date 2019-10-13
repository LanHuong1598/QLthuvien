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
    public partial class FormBanDoc : Form
    {
        public static string Mabandoc;
        public FormBanDoc()
        {
            InitializeComponent();
            
            initData();
        }
        private void initData()
        {
            string query = "SELECT * FROM DocGia";
            DataSet data = new DataSet();
            ConnectString b = new ConnectString();
            string con = b.getConnectionString(Form1.checkConnectionString);
            using (SqlConnection connect = new SqlConnection(con))
            {

                connect.Open();
                SqlDataAdapter apter = new SqlDataAdapter(query, con);
                apter.Fill(data);
                connect.Close();
            }
            showData.DataSource = data.Tables[0];
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            frmadd_docgia fr = new frmadd_docgia();
            fr.ShowDialog();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            frmedit_docgia fr = new frmedit_docgia();
            fr.ShowDialog();
        }

        private void showData_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int posClicked;
            posClicked = showData.SelectedRows[0].Index;
            DataGridViewRow temp = this.showData.Rows[posClicked];
            string Ma = temp.Cells[0].Value.ToString();
            FormBanDoc.Mabandoc = Ma;
        }
    }
}
