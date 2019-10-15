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
    public partial class FormAddTuaSach : Form
    {
        public FormAddTuaSach()
        {
            InitializeComponent();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            string Id = txtma.Text;
            string name = txtten.Text;
            string nam = txtnamxb.Text;
            string nxb = txtnxb.Text;
            string kesach = txtkesach.Text; 
    
            if (Id == "" || name == "")
            {
                MessageBox.Show("Vui lòng điền đủ thông tin Mã sach và tên sach!");
                return;
            }
            else
            {
                int check = insert();
                if (check == 1)
                {
                    DialogResult res = MessageBox.Show("Thêm thành công, bạn có muốn tiếp tục?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (res == DialogResult.Yes)
                    {
                        txtnamxb.Text = "";
                        txtkesach.Text = "";
                        txtma.Text = "";
                        txtnxb.Text = "";
                        txtten.Text = "";
                        txttheloai.Text = "";
                    }
                    if (res == DialogResult.No)
                    {
                        this.Close();
                    }

                }
                else
                {

                }

            }
        }
        public int insert()
        {
            string Id = txtma.Text;
            string name = txtten.Text;
            string nam = txtnamxb.Text;
            string nxb = txtnxb.Text;
            string kesach = txtkesach.Text;
            string theloai = txttheloai.Text;
       
            string query = "exec Insert_TS '" + Id + "','" +
                name + "','" + nam + "','" + theloai + "','" + nxb + "','" +
                kesach + "','" + "1000'";
            ConnectString cnn = new ConnectString();
            string con = cnn.getConnectionString(Form1.checkConnectionString);
            try
            {
                using (SqlConnection connection = new SqlConnection(con))
                {
                    connection.Open();

                    SqlCommand cmd = connection.CreateCommand();
                    cmd.CommandText = query;
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    return 1;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Thêm không thành công, vui lòng kiểm tra lại!");
                return 0;
            }
        }
    }
}
