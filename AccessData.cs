﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace QUANLYHT
{
    class AccessData
    {
        public SqlConnection GetConnection()
        {
            return new SqlConnection(@"Data Source=DESKTOP-S0LV1V2\SQLEXPRESS;Initial Catalog=QLHOMESTAY;Integrated Security=True");
        }
        public void ExcuteNonQuery(string sql)
        {
            SqlConnection conn = GetConnection();
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            cmd.Dispose();
        }
        public SqlDataReader ExecuteReader(string sql)
        {
            SqlConnection conn = GetConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }
    
    }
}
