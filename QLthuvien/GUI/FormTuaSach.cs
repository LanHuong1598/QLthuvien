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
    public partial class FormTuaSach : Form
    {
        public static string idtuasach;
        public FormTuaSach()
        {

            InitializeComponent();
            gunaDataGridView1.CellClick += new DataGridViewCellEventHandler(datagridview_cell_click);
            string query = " select MaTS AS 'Mã Tựa sách',TenTS AS 'Tên sách',NamXB as 'Năm xuất bản', " +
"TheLoai AS 'Thể loại',dbo.NXB.TenNXB AS 'Nhà xuất bản', MaKe as 'Kệ sách'  FROM dbo.TuaSach, NXB " +
"where TuaSach.MaNXB = NXB.MaNXB";
            invalidate(query);

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
        private void datagridview_cell_click(object sender, DataGridViewCellEventArgs e)
        {


        }
        private void FormTuaSach_Load(object sender, EventArgs e)
        {
            gunaAdvenceButton2.Enabled = true;
        }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {

        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            FormAddTuaSach fr = new FormAddTuaSach();
            fr.ShowDialog();
        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            FormSuaTuaSach fr = new FormSuaTuaSach(FormTuaSach.idtuasach);
            fr.ShowDialog();
        }

        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int posClicked;
            posClicked = gunaDataGridView1.SelectedRows[0].Index;
            DataGridViewRow temp = this.gunaDataGridView1.Rows[posClicked];
            string Ma = temp.Cells[0].Value.ToString();
            FormTuaSach.idtuasach = Ma;

        }

        private void gunaAdvenceButton4_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn có thực sự muốn xóa sách có mã là " + FormTuaSach.idtuasach, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (res == DialogResult.Yes)
            {
                try
                {

                    delete(FormTuaSach.idtuasach);
                    MessageBox.Show("Xóa thành công");

                    string query = " select MaTS AS 'Mã Tựa sách',TenTS AS 'Tên sách',NamXB as 'Năm xuất bản', " +
    "TheLoai AS 'Thể loại',dbo.NXB.TenNXB AS 'Nhà xuất bản', MaKe as 'Kệ sách'  FROM dbo.TuaSach, NXB " +
    "where TuaSach.MaNXB = NXB.MaNXB";
                    invalidate(query);

                }
                catch
                {
                    MessageBox.Show("Xóa không thành công");
                }
            }
            if (res == DialogResult.No)
            {

            }
           
        }
        public void delete(string key)
        {
            string query1 = "DELETE	FROM dbo.tuasach WHERE mats=  @id";
            ConnectString cnn = new ConnectString();
            string con = cnn.getConnectionString(Form1.checkConnectionString);
            DataSet data = new DataSet();

            using (SqlConnection connect = new SqlConnection(con))
            {

                connect.Open();
                SqlCommand cmd = connect.CreateCommand();
                cmd.CommandText = query1;
                cmd.Parameters.Add("@id", SqlDbType.NVarChar).Value = key;
                cmd.ExecuteNonQuery();
                connect.Close();
            }
        }

        private void gunaDataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int posClicked;
            posClicked = gunaDataGridView1.SelectedRows[0].Index;
            DataGridViewRow temp = this.gunaDataGridView1.Rows[posClicked];
            string Ma = temp.Cells[0].Value.ToString();
            FormTuaSach.idtuasach = Ma;
            //FormBanDoc.Tenbandoc = ten;
        }

        private void gunaDataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int posClicked;
            posClicked = gunaDataGridView1.SelectedRows[0].Index;
            DataGridViewRow temp = this.gunaDataGridView1.Rows[posClicked];
            string Ma = temp.Cells[0].Value.ToString();
            FormTuaSach.idtuasach = Ma;
            //FormBanDoc.Tenbandoc = ten;
        }

        private void gunaDataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int posClicked;
            posClicked = gunaDataGridView1.SelectedRows[0].Index;
            DataGridViewRow temp = this.gunaDataGridView1.Rows[posClicked];
            string Ma = temp.Cells[0].Value.ToString();
            FormTuaSach.idtuasach = Ma;
            //FormBanDoc.Tenbandoc = ten;
        }

        private void gunaDataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int posClicked;
            posClicked = gunaDataGridView1.SelectedRows[0].Index;
            DataGridViewRow temp = this.gunaDataGridView1.Rows[posClicked];
            string Ma = temp.Cells[0].Value.ToString();
            FormTuaSach.idtuasach = Ma;
            //FormBanDoc.Tenbandoc = ten;
        }

        private void gunaTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            string query = " select MaTS AS 'Mã Tựa sách',TenTS AS 'Tên sách',NamXB as 'Năm xuất bản', " +
"TheLoai AS 'Thể loại',dbo.NXB.TenNXB AS 'Nhà xuất bản', MaKe as 'Kệ sách'  FROM dbo.TuaSach, NXB " +
"where TuaSach.MaNXB = NXB.MaNXB and TenTS like N'%" + gunaTextBox1.Text.Trim() + "%'";
            invalidate(query);
        }

        private void gunaTextBox1_MouseEnter(object sender, EventArgs e)
        {
            if (gunaTextBox1.Text == "Tìm kiếm tại đây") gunaTextBox1.Text = "";
        }
    }
    /* public partial class FormTuaSach : Form
    {
        public static string idtuasach;
        public FormTuaSach()
        {

            InitializeComponent();
            gunaDataGridView1.CellClick += new DataGridViewCellEventHandler(datagridview_cell_click);
            string query = " select MaTS AS 'Mã Tựa sách',TenTS AS 'Tên sách',NamXB as 'Năm xuất bản', " +
"TheLoai AS 'Thể loại',dbo.NXB.TenNXB AS 'Nhà xuất bản', MaKe as 'Kệ sách'  FROM dbo.TuaSach, NXB " +
"where TuaSach.MaNXB = NXB.MaNXB";
            invalidate(query);

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
        private void datagridview_cell_click(object sender, DataGridViewCellEventArgs e)
        {


        }
        private void FormTuaSach_Load(object sender, EventArgs e)
        {
            gunaAdvenceButton2.Enabled = true;
        }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {

        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            FormAddTuaSach fr = new FormAddTuaSach();
            fr.ShowDialog();
        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            FormSuaTuaSach fr = new FormSuaTuaSach(FormTuaSach.idtuasach);
            fr.ShowDialog();
        }

        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int posClicked;
            posClicked = gunaDataGridView1.SelectedRows[0].Index;
            DataGridViewRow temp = this.gunaDataGridView1.Rows[posClicked];
            string Ma = temp.Cells[0].Value.ToString();
            FormTuaSach.idtuasach = Ma;
            
        }

        private void gunaAdvenceButton4_Click(object sender, EventArgs e)
        {
            try
            {

                delete(FormTuaSach.idtuasach);
                MessageBox.Show("Xóa thành công");

                string query = " select MaTS AS 'Mã Tựa sách',TenTS AS 'Tên sách',NamXB as 'Năm xuất bản', " +
"TheLoai AS 'Thể loại',dbo.NXB.TenNXB AS 'Nhà xuất bản', MaKe as 'Kệ sách'  FROM dbo.TuaSach, NXB " +
"where TuaSach.MaNXB = NXB.MaNXB";
                invalidate(query);

            }
            catch
            {
                MessageBox.Show("Xóa không thành công");
            }
        }
        public void delete(string key)
        {
            string query1 = "DELETE	FROM dbo.tuasach WHERE mats=  @id";
            ConnectString cnn = new ConnectString();
            string con = cnn.getConnectionString(Form1.checkConnectionString);
            DataSet data = new DataSet();

            using (SqlConnection connect = new SqlConnection(con))
            {

                connect.Open();
                SqlCommand cmd = connect.CreateCommand();
                cmd.CommandText = query1;
                cmd.Parameters.Add("@id", SqlDbType.NVarChar).Value = key;
                cmd.ExecuteNonQuery();
                connect.Close();
            }
        }

        private void gunaDataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int posClicked;
            posClicked = gunaDataGridView1.SelectedRows[0].Index;
            DataGridViewRow temp = this.gunaDataGridView1.Rows[posClicked];
            string Ma = temp.Cells[0].Value.ToString();
            FormTuaSach.idtuasach = Ma;
            //FormBanDoc.Tenbandoc = ten;
        }

        private void gunaDataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int posClicked;
            posClicked = gunaDataGridView1.SelectedRows[0].Index;
            DataGridViewRow temp = this.gunaDataGridView1.Rows[posClicked];
            string Ma = temp.Cells[0].Value.ToString();
            FormTuaSach.idtuasach = Ma;
            //FormBanDoc.Tenbandoc = ten;
        }

        private void gunaDataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int posClicked;
            posClicked = gunaDataGridView1.SelectedRows[0].Index;
            DataGridViewRow temp = this.gunaDataGridView1.Rows[posClicked];
            string Ma = temp.Cells[0].Value.ToString();
            FormTuaSach.idtuasach = Ma;
            //FormBanDoc.Tenbandoc = ten;
        }

        private void gunaDataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int posClicked;
            posClicked = gunaDataGridView1.SelectedRows[0].Index;
            DataGridViewRow temp = this.gunaDataGridView1.Rows[posClicked];
            string Ma = temp.Cells[0].Value.ToString();
            FormTuaSach.idtuasach = Ma;
            //FormBanDoc.Tenbandoc = ten;
        }
    }*/
}