using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace AgriPro
{
    public partial class aflogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.Visible = false;
            GridView2.Visible = false;
            GridView3.Visible = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            if (CheckBox1.Checked)
            {
                GridView1.Visible = true;
            }
            else if (CheckBox2.Checked)
            {
                GridView2.Visible = true;
            }
            else if (CheckBox3.Checked)
            {
                GridView3.Visible = true;
            }
            else if (CheckBox4.Checked)
            {
                GridView1.Visible = true;
                GridView2.Visible = true;
                GridView3.Visible = true;
            }
            else
            {
                Literal1.Text="**Please Select Option**";
            }
            
        }

    }
}