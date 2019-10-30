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
    public partial class FormMuonTra : Form   
    {
        ConnectString cnn = new ConnectString();   
        string conectionString="";
        string query = "";
        SqlConnection conn;
        public FormMuonTra()
        {
            InitializeComponent();
        }
        void ThongTinDocGia(string MaDG)
        {
            try
            {
                query = "select *from DocGia where MaDG='" + MaDG + "'";
                conn = new SqlConnection(cnn.getConnectionString(1));
                SqlDataAdapter adap = new SqlDataAdapter(query, conn);
                DataTable data_DocGia = new DataTable();
                adap.Fill(data_DocGia); 
                txt_HoTen.Text = data_DocGia.Rows[0]["TenDG"].ToString();
                txt_DiaChi.Text = data_DocGia.Rows[0]["DiaChi"].ToString();
                txt_GioiTinh.Text = data_DocGia.Rows[0]["GioiTinh"].ToString();
                txt_SDT.Text = data_DocGia.Rows[0]["SDT"].ToString();
                dtp_NgaySinh.Value = Convert.ToDateTime(data_DocGia.Rows[0]["NgaySinh"].ToString());
            }
            catch
                {

            }   
            


        }
        void load()
        {

            conectionString = cnn.getConnectionString(Form1.checkConnectionString);
            query = "select *from DocGia";
            conn = new SqlConnection(conectionString);
            DataTable data_MaDG = new DataTable();
            SqlDataAdapter adap = new SqlDataAdapter(query,conn);
            adap.Fill(data_MaDG);
            cb_MaDG.ValueMember = "MaDG";
            cb_MaDG.DisplayMember = "MaDG";
            cb_MaDG.DataSource = data_MaDG;
            cb_MaDG.SelectedIndex = 0;
            ThongTinDocGia(cb_MaDG.Text.ToString().Trim());
        }
        private void FormMuonTra_Load(object sender, EventArgs e)
        {
            dtp_NgaySinh.Format = DateTimePickerFormat.Custom;
            dtp_NgaySinh.CustomFormat = "dd/MM/yyyy";
            load();

        }

        private void cb_MaDG_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            conn = new SqlConnection(cnn.getConnectionString(Form1.checkConnectionString));
            SqlCommand cmd = new SqlCommand("dbo.DS_MuonTra", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaDG", cb_MaDG.Text.Trim());
            SqlDataAdapter adap = new SqlDataAdapter(cmd);
            DataTable data_MuonTra = new DataTable();
            adap.Fill(data_MuonTra);
            dtgv_MuonTra.DataSource = data_MuonTra;
            ThongTinDocGia(cb_MaDG.Text);
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            FormMuonSach fr = new FormMuonSach();
            fr.setId(Convert.ToInt32(cb_MaDG.Text.Trim()));
            fr.Show();
        }
    }
}
