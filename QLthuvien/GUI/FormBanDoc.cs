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
            show_badoc.DataSource = data.Tables[0];
        }
    }
}
