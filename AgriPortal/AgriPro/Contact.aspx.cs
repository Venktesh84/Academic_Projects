using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AgriPro
{
    public partial class Contact : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
             if(!IsPostBack)
            {
                SetImageUrl();
            }
        }
        protected void Timer1_Tick(object sender, EventArgs e)
        {
            SetImageUrl();
        }

        private void SetImageUrl()
        {
            Random ran = new Random();
            int i = ran.Next(1, 4);
            Image3.ImageUrl = "~/Images/" + i.ToString() + ".PNG";
        }

    }
}