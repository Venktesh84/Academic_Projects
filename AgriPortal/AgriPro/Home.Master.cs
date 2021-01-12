using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AgriPro
{
    public partial class Home : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

         // Application["Visits"] = (int)Application["Visits"] + 1;
         // Label1.Text = Application["Visits"].ToString();
          Label2.Text = DateTime.Now.ToString();
        }

           }
}