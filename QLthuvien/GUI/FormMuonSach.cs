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
        }
        public void setId(int _id)
        {
            id = _id;
        }
        string Check_MaTs(string TenTs)
        {
            string MaSach = "";
            try {
                
                conn = new SqlConnection(cnn.getConnectionString(1));
                DataTable data_Sach = new DataTable();
                SqlCommand cmd = new SqlCommand("DS_Sach", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@TenTs", cb_TuaSach.Text.ToString().Trim());
                adap = new SqlDataAdapter(cmd);
                adap.Fill(data_Sach);
                MaSach = data_Sach.Rows[0]["MaCS"].ToString();
                
            }
            catch
                {
                MessageBox.Show("Không còn sách");
                MaSach = "";
            }
            txt_MaSach.Text = MaSach;
            return MaSach;

        }
        void load()
        {
            try
            {
                conn = new SqlConnection(cnn.getConnectionString(1));
                query = "select *from TuaSach";
                adap = new SqlDataAdapter(query, conn);
                DataTable data_sach = new DataTable();
                adap.Fill(data_sach);
                cb_TuaSach.ValueMember = "MaTS";
                cb_TuaSach.DisplayMember = "TenTS";
                cb_TuaSach.DataSource = data_sach;

                txt_MaDG.Text = id.ToString();
                txt_MaSach.Text = Check_MaTs(cb_TuaSach.Text.ToString());
            }
            catch
            {

            }
        }

        private void FormMuonSach_Load(object sender, EventArgs e)
        {

            txt_MaDG.Enabled = false;
            txt_MaSach.Enabled = false;
            dtp_NgayMuon.Format = DateTimePickerFormat.Custom;
            dtp_NgayMuon.CustomFormat = "dd/MM/yyyy";

            load();
        }

        private void btn_MuonSach_Click(object sender, EventArgs e)
        {

        }

        private void cb_TuaSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            Check_MaTs(cb_TuaSach.Text.ToString());
        }
    }
}
