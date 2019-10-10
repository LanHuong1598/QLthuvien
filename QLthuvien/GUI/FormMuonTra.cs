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
            conectionString = cnn.getConnectionString(Form1.checkConnectionString);
            query = "select MaDG from DocGia";
            conn = new SqlConnection(conectionString);
            DataTable data_MaDG = new DataTable();
            SqlDataAdapter adap = new SqlDataAdapter(query, conn);
            adap.Fill(data_MaDG);
            cb_MaDG.ValueMember = "MaDG";
            cb_MaDG.DisplayMember = "MaDG";
            cb_MaDG.DataSource = data_MaDG;
            cb_MaDG.SelectedIndex = 0;
            ThongTinDocGia(cb_MaDG.Text.ToString().Trim());
            DataGridViewButtonColumn button = new DataGridViewButtonColumn();
            {
                button.Name = "ChangeRow";
                button.HeaderText = "";
                button.Text = "Trả";
                button.UseColumnTextForButtonValue = true; //dont forget this line
                this.dtgv_MuonTra.Columns.Add(button);
            }
        }
        private void FormMuonTra_Load(object sender, EventArgs e)
        {
            dtp_NgaySinh.Format = DateTimePickerFormat.Custom;
            dtp_NgaySinh.CustomFormat = "dd/MM/yyyy";
            load();

        }
        void load()
        {

            
        }

        void ThongTinDocGia(string MaDG)
        {
            try
            {
                query = "select * from DocGia where MaDG like '" + MaDG + "'";

                ConnectString cnn = new ConnectString();
                string con = cnn.getConnectionString(Form1.checkConnectionString);
                DataTable data = new DataTable();

                using (SqlConnection connect = new SqlConnection(con))
                {
                    connect.Open();
                    SqlDataAdapter apter = new SqlDataAdapter(query, connect);
                    apter.Fill(data);
                    txt_HoTen.Text = data.Rows[0]["TenDG"].ToString();
                    txt_DiaChi.Text = data.Rows[0]["DiaChi"].ToString();
                    txt_GioiTinh.Text = data.Rows[0]["GioiTinh"].ToString();
                    txt_SDT.Text = data.Rows[0]["SDT"].ToString();
                    dtp_NgaySinh.Value = Convert.ToDateTime(data.Rows[0]["NgaySinh"].ToString());
                    connect.Close();
                }
            }
            catch
                {

            }   
            


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
            this.Hide();
            fr.ShowDialog();
            this.Show();
        }

        private void dtgv_MuonTra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int posClicked;
            posClicked = dtgv_MuonTra.SelectedRows[0].Index;
            DataGridViewRow temp = this.dtgv_MuonTra.Rows[posClicked];
            string MaPM = temp.Cells[1].Value.ToString();
            string MaSach = temp.Cells[4].Value.ToString();
          

            if (dtgv_MuonTra.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().Equals("Trả"))
            {
                DialogResult dialogResult = MessageBox.Show("Bạn muốn trả " + dtgv_MuonTra.Rows[e.RowIndex].Cells["Mã Sách"].Value.ToString() + " ? ", "Xác nhận", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        query = "update ChiTietMuon set tinhtrang = '" + 1 + "' " +
                            "where MaPM = '" + MaPM +"' and MaCS = '"  + MaSach + "'" ;

                        ConnectString cnn = new ConnectString();
                        string con = cnn.getConnectionString(Form1.checkConnectionString);
                        
                        using (SqlConnection connect = new SqlConnection(con))
                        {
                            connect.Open();
                            SqlCommand cmd = connect.CreateCommand();
                            cmd.CommandText = query;
                            cmd.ExecuteNonQuery();
                            connect.Close();
                        }
                    }
                    catch
                    {

                    }

                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                }
            }
        }
    }
}
