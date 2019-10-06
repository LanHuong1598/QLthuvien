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
        public FormTuaSach()
        {

            InitializeComponent();
            gunaDataGridView1.CellClick += new DataGridViewCellEventHandler(datagridview_cell_click);
            string query = " select MaTS AS 'Mã Tựa sách',TenTS AS 'Tên sách',NamXB as 'Năm xuất bản', "+
"TheLoai AS 'Thể loại',dbo.NXB.TenNXB AS 'Nhà xuất bản', MaKe as 'Kệ sách'  FROM dbo.TuaSach, NXB "+
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
            if (e.RowIndex != -1)
            {
                // MessageBox.Show(gunaDataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
                if (gunaDataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().Equals("Sửa"))
                {
                    DialogResult dialogResult = MessageBox.Show("Bạn muốn sửa " + gunaDataGridView1.Rows[e.RowIndex].Cells["Họ và tên"].Value.ToString() + " ? ", "Xác nhận", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        //do something
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        //do something else
                    }
                }
                else if (gunaDataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().Equals("Xóa"))
                {
                    DialogResult dialogResult = MessageBox.Show("Bạn muốn xóa " + gunaDataGridView1.Rows[e.RowIndex].Cells["Họ và tên"].Value.ToString() + " ? ", "Xác nhận", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        //do something
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        //do something else
                    }
                }
            }

            //   MessageBox.Show(e.RowIndex + " " + e.ColumnIndex + " ");

        }
        private void FormTuaSach_Load(object sender, EventArgs e)
        {

        }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
