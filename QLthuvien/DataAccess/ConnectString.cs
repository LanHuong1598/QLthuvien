using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLthuvien
{
    class ConnectString
    {
        public string getConnectionString()
        {
            string connectionString = "";
            try
            {
                connectionString = @"Data Source=" + Environment.MachineName + ";Initial Catalog=QuanLyThuVien;Integrated Security=True";
                using (SqlConnection connect = new SqlConnection(connectionString))
                {

                    connect.Open();
                }
                return connectionString;
            }
            catch
            {
                string connectionString1 = @"Data Source=DESKTOP-LQQ51RU\SON" + Environment.MachineName + ";" + " Initial Catalog=QuanLyThuVien;Integrated Security=True";
                return connectionString1;
            }
        }
    }
}
