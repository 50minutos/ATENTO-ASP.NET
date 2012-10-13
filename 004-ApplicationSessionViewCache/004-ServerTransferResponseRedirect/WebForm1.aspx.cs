using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _004_ServerTransferResponseRedirect
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("escrevi na página 1");

            //Response.Redirect("~/WebForm2.aspx");
            Server.Transfer("~/WebForm2.aspx");

            Response.Write("sem chance");
        }
    }
}