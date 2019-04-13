using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace QUANLYHT
{
    class KiemTraDangNhap
    {
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
