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
        public static string ma;
        public frmedit_docgia()
        {
            InitializeComponent();
           
            initData();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            string Id = tex_MA_docgia.Text;
            string name = Tex_tendocgia.Text;
            DateTime date = ngay_sinh.Value;
            string sdt = text_sdt.Text;
            string gioitinh;
            if (ra_nam.Checked == true)
            {
                gioitinh = "Nam";
            }
            else
            {
                gioitinh = "Nữ";
            }
            string diachi = text_diachi.Text;
            if (Id == "" || name == "")
            {
                MessageBox.Show("Vui lòng điền đủ thông tin Mã độc giả và tên độc giả!");
                return;
            }
            else
            {
                int check = 1;// UpDate_data(Id, name, date, gioitinh, diachi, sdt, FormBanDoc.Mabandoc);
                if (check == 1)
                {
                    MessageBox.Show("Update thành công");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Update không thành công, vui lòng kiểm tra lại!");
                }

            }

        }
        public void show()
        {
            
                DataTable data = connectionTable(frmedit_docgia.ma);
                tex_MA_docgia.Text = data.Rows[0]["MaDG"].ToString();
                Tex_tendocgia.Text = data.Rows[0]["TenDG"].ToString();

                string gioitinh = data.Rows[0]["GioiTinh"].ToString().TrimEnd();
                if (gioitinh == "Nam")
                {
                    ra_nam.Checked = true;
                    ra_nu.Checked = false;
                }
                else
                {
                    ra_nam.Checked = false;
                    ra_nu.Checked = true;
                }
                text_diachi.Text = data.Rows[0]["DiaChi"].ToString();
                text_sdt.Text = data.Rows[0]["SDT"].ToString();
                string temp = data.Rows[0]["NgaySinh"].ToString();
                int n2 = temp.IndexOf(" ");
                string temp1 = temp.Substring(0, n2);
                ngay_sinh.Value = DateTime.ParseExact(temp1, "M/d/yyyy", CultureInfo.InvariantCulture);
            
            
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

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn muốn hủy thao tác và quay về trang chủ ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (res == DialogResult.Yes)
            {
                this.Close();
            }
            if (res == DialogResult.No)
            {

            }
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

        private void showData_CellMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            int posClicked;
            posClicked = showData.SelectedRows[0].Index;
            DataGridViewRow temp = this.showData.Rows[posClicked];
            string Ma = temp.Cells[0].Value.ToString();
            frmedit_docgia.ma = Ma;
            string ten = temp.Cells[1].Value.ToString();
            //FormBanDoc.Tenbandoc = ten;
            show();
        }

        private void showData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
