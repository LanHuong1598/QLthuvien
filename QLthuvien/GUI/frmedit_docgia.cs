using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLthuvien.GUI
{
    public partial class frmedit_docgia : Form
    {
        public frmedit_docgia()
        {
            InitializeComponent();
            show();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            

        }
        public void show()
        {
            DataTable data = connectionTable(FormBanDoc.Mabandoc);
            tex_MA_docgia.Text = data.Rows[0]["MaDG"].ToString();
            Tex_tendocgia.Text = data.Rows[0]["TenDG"].ToString();
            
            string gioitinh = data.Rows[0]["GioiTinh"].ToString();
            if(gioitinh=="Nam")
            {
                check_nam.Checked = true;
                check_nu.Checked = false;
            }
            else
            {
                check_nam.Checked = false;
                check_nu.Checked = true;
            }
            text_diachi.Text = data.Rows[0]["DiaChi"].ToString();
            text_sdt.Text = data.Rows[0]["SDT"].ToString();
        }
        private DataTable connectionTable(string ma)
        {
            DataTable data = new DataTable();
            // create datatable connect database Users
            string query = "SELECT * FROM dbo.DocGia WHERE MaDG='"+ma+"'";
            ConnectString cnn = new ConnectString();
            string con = cnn.getConnectionString(Form1.checkConnectionString);
            using (SqlConnection connection = new SqlConnection(con))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(data);
                connection.Close();
            }

            return data;
        }
        public int UpDate_data(string Ma2, string name, DateTime date, string sex, string diachi, string sdt,string Ma1)
        {
            string query = " UPDATE dbo.DocGia SET MaDG=@ma2, TenDG=@name,NgaySinh=@date,GioiTinh=@sex,DiaChi=@diachi,SDT=@sdt WHERE MaDG=@ma1";
            ConnectString cnn = new ConnectString();
            string con = cnn.getConnectionString(Form1.checkConnectionString);
            try
            {
                using (SqlConnection connection = new SqlConnection(con))
                {
                    connection.Open();

                    SqlCommand cmd = connection.CreateCommand();
                    cmd.CommandText = query;
                    // insert value of Song in database
                    cmd.Parameters.Add("@ma2", SqlDbType.Char).Value = Ma2;
                    cmd.Parameters.Add("@ma1", SqlDbType.Char).Value = Ma1;
                    cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
                    cmd.Parameters.Add("@date", SqlDbType.Date).Value = date.ToShortDateString().ToString();
                    cmd.Parameters.Add("@sdt", SqlDbType.Char).Value = sdt;
                    cmd.Parameters.Add("@sex", SqlDbType.NChar).Value = sex;
                    cmd.Parameters.Add("@diachi", SqlDbType.NVarChar).Value = diachi;
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    return 1;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Cập nhật không thành công, vui lòng kiểm tra lại!");
                return 0;
            }
        }
    }
}
