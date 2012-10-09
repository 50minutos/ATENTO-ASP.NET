using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _003_View
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["NOME"] == null)
                Server.Transfer("~/WebForm1.aspx");

            Nome.Text = Session["NOME"].ToString();
        }
    }
}