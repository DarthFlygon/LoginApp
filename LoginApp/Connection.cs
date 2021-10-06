using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace LoginApp
{
    public class Connection
    {
        public static SqlConnection GetConnection()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=DESKTOP-R2VIKLU\SQLEXPRESS;Integrated Security = true;Initial Catalog = sample;persist security info = True;user id = flygon; password = aytech";
            return con;
        }
    }
}