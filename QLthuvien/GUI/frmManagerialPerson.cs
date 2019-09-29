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
    public partial class frmManagerialPerson : Form
    {

        public frmManagerialPerson()
        {
            InitializeComponent();
            string query = "select * from thuthu";
            initData(query);
          
        }
        private void initData(string query)
        {
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
            showDataUser.DataSource = data.Tables[0];
        }
    }
}
