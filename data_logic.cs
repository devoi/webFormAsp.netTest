﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplication6
{
    public class sql_con
    {
        public int GetData(string s)
        {
            SqlConnection con = new SqlConnection("Initial catalog=corporate; integrated security=true; server=VDILEWVPNTH511");
            con.Open();
            SqlCommand cmd = new SqlCommand(s, con);
            int i = cmd.ExecuteNonQuery();
            return i;
        }

    }
    public class sql_ad
    {
        public DataSet GetData(string s)
        {
            SqlConnection con = new SqlConnection("Initial catalog=corporate; integrated security=true; server=VDILEWVPNTH511");
            SqlDataAdapter da = new SqlDataAdapter(s, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
    }
}