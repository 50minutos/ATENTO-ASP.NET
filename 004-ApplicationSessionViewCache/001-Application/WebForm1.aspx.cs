using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _001_Application
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Application["NOME_EMPRESA"] != null)
                Label1.Text = Application["NOME_EMPRESA"].ToString();

            if (Application["DESENVOLVEDOR"] != null)
                Label2.Text = Application["DESENVOLVEDOR"].ToString();

            if (Application["EMAIL"] != null)
                Label3.Text = Application["EMAIL"].ToString();
        }
    }
}