using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace AgriPro
{
    public partial class Resgistration : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        private void reset()
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox7.Text = "";
            TextBox8.Text = "";
            TextBox9.Text = "";
            //DropDownList1.SelectedItem.Value = "";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
       
            SqlConnection connection = new SqlConnection("Data Source=VENKY\\SQLEXPRESS;Initial Catalog=AgriProj;Integrated Security=True");

            SqlCommand cmd = new SqlCommand("INSERT INTO USERS(fname,lname,edu,address,dist,username,password)"+"VALUES('"+TextBox1.Text+"','"+TextBox2.Text+"','"+TextBox4.Text+"','"+TextBox5.Text+"','"+DropDownList1.SelectedItem.Value+"','"+TextBox7.Text+"','"+TextBox8.Text+"')");

            cmd.Connection= connection;
            try
            {
                connection.Open();
                cmd.ExecuteNonQuery();
               Literal1.Text = "Successfully created the Account!!!";
                connection.Close();
                reset();
            }
            catch(Exception ex)
            {
                Literal1.Text = ex.Message;
            }

        }
    }
}