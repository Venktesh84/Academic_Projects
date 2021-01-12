using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data.Sql;
using System.Data;

namespace AgriPro
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        /*protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=VENKY\\SQLEXPRESS;Initial Catalog=AgriProj;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");
            connection.Open();
          
            String query = "Select * from Users where username = '"+ TextBox1.Text +"' and '"+ TextBox2.Text +"';";

            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet dt = new DataSet();
            da.Fill(dt);

            if(dt.Tables[0].Rows.Count > 0)
            {
               Response.Redirect("aflogin.aspx");
            }
            else
            {
                Literal1.Text="Login Failed";
            }

        }*/

        protected void Button1_Click1(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=VENKY\\SQLEXPRESS;Initial Catalog=AgriProj;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");
            connection.Open();

            //String query = "Select * from Users where username = @username and password=@password"';";

            SqlCommand cmd = new SqlCommand("Select * from Users where username = @username and password=@password", connection);
            cmd.Parameters.AddWithValue("@username", TextBox1.Text);
            cmd.Parameters.AddWithValue("@password", TextBox2.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                Response.Redirect("aflogin.aspx");
            }
            else
            {
                Literal1.Text = "Login Failed";
            }
        }
    }
}