﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace BUS
{
    public class MonHon
    {
        public DataTable Show()
        {
            string sql = @"select * from tblMonHoc";
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(ConnectDB.getconnect());
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
         
            return dt;
        }
    }
}
