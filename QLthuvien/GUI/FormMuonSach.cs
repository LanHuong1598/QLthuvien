using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace QLthuvien.GUI
{
    public partial class FormMuonSach : Form
    {
        ConnectString cnn=new ConnectString();  
        SqlConnection conn;
        string query = "";
        SqlDataAdapter adap;
        int id=0;
        public FormMuonSach()
        {
            InitializeComponent();
            dssach.Columns.Add("MaPhieu", "MaPhieu");
            dssach.Columns.Add("MaSach", "MaSach");

        }
        public void setId(int _id)
        {
            id = _id;
        }
        string Check_MaTs(string TenTs)
        {
            string MaSach = "";
            try {
                DataTable data_Sach = new DataTable();
                string query = "exec DS_Sach " + "'" + TenTs + "'";

                ConnectString cnn = new ConnectString();
                string con = cnn.getConnectionString(Form1.checkConnectionString);
                using (SqlConnection connect = new SqlConnection(con))
                {
                    connect.Open();
                    SqlDataAdapter apter = new SqlDataAdapter(query, connect);
                    apter.Fill(data_Sach);
                    connect.Close();
                }
                MaSach = data_Sach.Rows[0]["MaCS"].ToString();

                

            }
            catch
                {
                
                MaSach = "";
            }
            return MaSach;

        }
        string Check_MaPhieu()
        {
            string MaPhieu = "";
            try
            {
                ConnectString cnn = new ConnectString();
                string con = cnn.getConnectionString(Form1.checkConnectionString);
                DataTable data = new DataTable();

                query = "select *from PhieuMuon order by MaPM desc";
                using (SqlConnection connect = new SqlConnection(con))
                {

                    connect.Open();
                    SqlDataAdapter apter = new SqlDataAdapter(query, connect);
                    apter.Fill(data);
                    connect.Close();
                }
                
                string temp = "";
                temp = data.Rows[0]["MaPM"].ToString().Trim();
                for(int i=0;i<temp.Length;i++)
                {
                    
                    if(temp[i]>=48 && temp[i]<=57)
                    {
                        MaPhieu = MaPhieu + temp[i].ToString();
                    }
                    else
                    {
                        continue;
                    }

                }
            }
            catch
            {

            }
            if (MaPhieu != "")
            {
                int MaP = Convert.ToInt32(MaPhieu) + 1;
                MaPhieu = "PM" + MaP.ToString();
                return MaPhieu;
            }
            else
            {
                int MaP = 100;
                MaPhieu = "PM" + MaP.ToString();
                return MaPhieu;
            }
        }
        void load()
        {

            try
            {         
                txt_MaDG.Text = id.ToString();               
                txt_MaPhieu.Text = Check_MaPhieu();
                query = " select MaTS AS 'Mã Tựa sách',TenTS AS 'Tên sách',NamXB as 'Năm xuất bản', " +
"TheLoai AS 'Thể loại',dbo.NXB.TenNXB AS 'Nhà xuất bản', MaKe as 'Kệ sách'  FROM dbo.TuaSach, NXB " +
"where TuaSach.MaNXB = NXB.MaNXB";
                invalidate(query);
            }
            catch
            {

            }
        }
        private void invalidate(string query)
        {

            gunaDataGridView1.Columns.Clear();
            ConnectString cnn = new ConnectString();
            string con = cnn.getConnectionString(Form1.checkConnectionString);
            DataSet data = new DataSet();

            using (SqlConnection connect = new SqlConnection(con))
            {

                connect.Open();
                SqlDataAdapter apter = new SqlDataAdapter(query, connect);
                apter.Fill(data);
                connect.Close();
            }
            gunaDataGridView1.DataSource = data.Tables[0];
        }
        private void FormMuonSach_Load(object sender, EventArgs e)
        {

            txt_MaDG.Enabled = false;
            dtp_NgayMuon.Format = DateTimePickerFormat.Custom;
            dtp_NgayMuon.CustomFormat = "dd/MM/yyyy";

            load();
        }

        private void btn_MuonSach_Click(object sender, EventArgs e)
        {
            
                try
                {

                ConnectString cnn = new ConnectString();
                string con = cnn.getConnectionString(Form1.checkConnectionString);
                using (SqlConnection connect = new SqlConnection(con))
                {
                    connect.Open();
                    string query = "exec MuonSach '" + txt_MaDG.Text.Trim() + "', '" +
                        dtp_NgayMuon.Value + "', '" + txt_MaPhieu.Text.Trim() + "'";

                    SqlCommand cmd = connect.CreateCommand();
                    cmd.CommandText = query;           
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Mượn thành công!");
                    this.Close();
                    connect.Close();
                }

               

                }
                catch
                {
                    MessageBox.Show("Mượn sách thất bại");
                }
           
            
        }

        private void cb_TuaSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Check_MaTs(cb_TuaSach.Text.ToString());
        }

        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int posClicked;
            posClicked = gunaDataGridView1.SelectedRows[0].Index;
            DataGridViewRow temp = this.gunaDataGridView1.Rows[posClicked];
            string Ma = temp.Cells[0].Value.ToString();
            string sach = Check_MaTs(Ma);
         

           

            if (sach != "")
            {
                dssach.Rows.Add(txt_MaPhieu.Text, sach);
                string query = "exec Insert_CTM '" + txt_MaPhieu.Text + "','" +
                sach + "',N'" + "0" + "'";
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
                    }
                }
                catch
                {
                    MessageBox.Show("Đã hết sách");
                }
            }
            else
            {
                MessageBox.Show("Đã hết sách");
            }
        }
    }
}
