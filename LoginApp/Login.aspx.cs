using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.SqlClient;
//Add configuration library when using webconfig file
using System.Configuration;

namespace LoginApp
{ 
    public partial class Login : System.Web.UI.Page
    {
        SqlConnection con;
        SqlDataAdapter ada;
        DataTable dt;
        protected void Page_Load(object sender, EventArgs e)
        {
            //Connecting to database using webconfig file
            string constring = ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
            con = new SqlConnection(constring);
            con.Open();
            Response.Write("connected");
            con.Close();

            //Code for connecting to database using class.
            //SqlConnection ob1 = new SqlConnection();
            //ob1 = Connection.GetConnection();
            //ob1.Open();
            //Response.Write("Connected with class");
            //ob1.Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Simple login logic
            String cmd = "select * from credentials where Username='" + TextBox1.Text + "' and Password='" + TextBox2.Text+"'";
            ada = new SqlDataAdapter(cmd, con);
            dt = new DataTable();
            con.Open();
            ada.Fill(dt);
            con.Close();
            if (dt.Rows.Count > 0)
            {
                Response.Write("Login Success");
            }
            else
            {
                Response.Write("Login Failure");
            }
        }
    }
}