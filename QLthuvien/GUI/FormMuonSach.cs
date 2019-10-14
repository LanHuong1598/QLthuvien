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
    }
}
