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
    public partial class FormBanDoc : Form    
    {
        public FormBanDoc()
        {
            InitializeComponent();
            gunaPanel2.Visible = false;
            initData();
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

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            gunaPanel2.Visible = false;
            frmadd_docgia fr = new frmadd_docgia();
            fr.ShowDialog();
            initData();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            

                frmedit_docgia fr = new frmedit_docgia();
                fr.ShowDialog();
                initData();
            
            
        }

        private void showData_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int posClicked;
            posClicked = showData.SelectedRows[0].Index;
            DataGridViewRow temp = this.showData.Rows[posClicked];
            string Ma = temp.Cells[0].Value.ToString();
            FormBanDoc.Mabandoc = Ma;
            string ten = temp.Cells[1].Value.ToString();
            FormBanDoc.Tenbandoc = ten;
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            gunaPanel2.Visible = true;
        }
      

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            string valueCol = type_search.GetItemText(this.type_search.SelectedItem);
            string keyRow = key_search.Text;
            if (valueCol == "" || keyRow == "")
            {
                MessageBox.Show("Vui lòng điền đủ thông tin tìm kiếm  !");
            }
            else
            {

                string query = "";
                //set value of query if valuaCol change 
                if (valueCol == "Mã") query = "SELECT * FROM dbo.DocGia where MaDG like ";
                if (valueCol == "Họ tên") query = "SELECT * FROM dbo.DocGia where TenDG like ";
                if (valueCol == "Địa chỉ") query = "SELECT * FROM dbo.DocGia where DiaChi like ";
                if (valueCol == "Sđt") query = "SELECT * FROM dbo.DocGia where SDT like ";
                SearchByKey(query, keyRow);
            }

        }
        public void SearchByKey(string query, string value)
        {
            query = query + "N'%" + value + "%'";
            ConnectString b = new ConnectString();
            string con = b.getConnectionString(Form1.checkConnectionString);
            using (SqlConnection connection = new SqlConnection(con))
            {
                connection.Open();

                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = query;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);



                DataTable data = new DataTable();
                adapter.Fill(data);
                showData.DataSource = data;
                //          int i = cmd.ExecuteNonQuery();
                connection.Close();

            }
        }

        private void load_data_btn_Click(object sender, EventArgs e)
        {
            gunaPanel2.Visible = false;
            initData();
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            gunaPanel2.Visible = false;
            if (FormBanDoc.Mabandoc == null)
            {
                MessageBox.Show("Chưa chọn độc giả để xóa, vui lòng chọn lại!");
            }
            else
            {
                DialogResult res = MessageBox.Show("Bạn có thực sự muốn xóa bạn đọc có mã là"+ FormBanDoc.Mabandoc.TrimEnd() +" và có tên là "+ FormBanDoc.Tenbandoc, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (res == DialogResult.Yes)
                {
                    delete_docgia(FormBanDoc.Mabandoc);
                    initData();
                }
                if (res == DialogResult.No)
                {
                   
                }
            }
        }
        public void delete_docgia(string key)
        {
            string query1 = "DELETE FROM DocGia WHERE MaDG = @ID";
            ConnectString b = new ConnectString();
            string con = b.getConnectionString(Form1.checkConnectionString);
            using (SqlConnection connection = new SqlConnection(con))
            {
                connection.Open();

                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = query1;
                cmd.Parameters.Add("@ID", SqlDbType.Int).Value = key;
                int i = cmd.ExecuteNonQuery();
                connection.Close();

            }
        }
    }
}
