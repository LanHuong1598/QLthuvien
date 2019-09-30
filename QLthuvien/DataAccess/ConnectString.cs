﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLthuvien
{
    class ConnectString
    {
        public string getConnectionString(int value)
        {
            if(value == 0)
            {
                return @"Data Source=localhost;Initial Catalog=QuanLyThuVien;Integrated Security=True";
            }
            else
            {
                return @"Data Source=./EXPRESS:Initial Catalog=QuanLyThuVien;Integrated Security=True";
            }
        }
        public int checkCnn()
        {
            try
            {
                string temp = @"Data Source=.//SQLEXPRESS:Initial Catalog=QuanLyThuVien;Integrated Security=True";
                using (SqlConnection connect = new SqlConnection(temp))
                {

                    connect.Open();
                    connect.Close();
                }
                return 1;
            }
            catch
            {
               
                string temp = @"Data Source=localhost;Initial Catalog=QuanLyThuVien;Integrated Security=True";
                using (SqlConnection connect = new SqlConnection(temp))
                {

                    connect.Open();
                    connect.Close();
                }
                return 0;
            }
           
        }
    }
}
