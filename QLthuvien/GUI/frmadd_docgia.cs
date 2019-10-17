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
    public partial class frmadd_docgia : Form
    {
        public frmadd_docgia()
        {
            InitializeComponent();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            string Id = tex_MA_docgia.Text;
            string name = Tex_tendocgia.Text;
            DateTime date  = ngay_sinh_docgia.Value;
            string sdt = txt_sodienthoai.Text;
            string gioitinh;
            if(ra_nam.Checked==true)
            {
                gioitinh = "Nam";
            }
            else
            {
                gioitinh = "Nữ";
            }
            string diachi = text_diachi.Text;
            if (Id == "" || name == "" )
            {
                MessageBox.Show("Vui lòng điền đủ thông tin Mã độc giả và tên độc giả!");
                return;
            }
            else
            {
                int check = insert_data(Id, name, date,gioitinh ,diachi,sdt);
                if (check == 1)
                {
                    DialogResult res = MessageBox.Show("Thêm thành công, bạn có muốn tiếp tục?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (res == DialogResult.Yes)
                    {
                        tex_MA_docgia.Text = "";
                        Tex_tendocgia.Text = "";
                       
                        txt_sodienthoai.Text = "";
                        
                        text_diachi.Text = "";
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
        public int insert_data(string Ma, string name, DateTime date, string sex, string diachi,string sdt)
        {
            string query = "INSERT dbo.DocGia( MaDG ,TenDG ,NgaySinh ,GioiTinh ,DiaChi ,SDT) VALUES  ( @ma , @name ,@date , @sex , @diachi , @sdt)";
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
                    cmd.Parameters.Add("@ma", SqlDbType.Char).Value = Ma;
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
                MessageBox.Show("Thêm không thành công, vui lòng kiểm tra lại!");
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
    }
}
