using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace QUANLYHT
{
    public class KiemTraDangNhap
    {
        private string username;

        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public int CheckLogin(string username, string password)
        {
            AccessData acc = new AccessData();
            SqlDataReader reader = acc.ExecuteReader("SELECT USERNAME, PASSWORD FROM USER_INFO");
            while (reader.Read())
            {
                if (reader[0].ToString() == username && reader[1].ToString() == password)
                {
                    return 1;
                }
            }
            return 0;
        }
    }
}
