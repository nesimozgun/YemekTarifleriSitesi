using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;


public class sqlsinif
{
    public SqlConnection baglanti()
    {
        SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-P9FF04F; Initial Catalog=dbo_yemektarifi; Integrated Security=True");
        baglan.Open();
        return baglan;
    }
}