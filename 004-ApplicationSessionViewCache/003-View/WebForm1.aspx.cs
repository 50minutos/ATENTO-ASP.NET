using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _003_View
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Gravar_Click(object sender, EventArgs e)
        {
            ViewState["NOME"] = Nome.Text;
            LblNome.Text = String.Empty;
        }

        protected void Ler_Click(object sender, EventArgs e)
        {
            if (ViewState["NOME"] != null)
                LblNome.Text = ViewState["NOME"].ToString();
        }

        protected void Context_Click(object sender, EventArgs e)
        {
            Context.Items["NOME"] = Nome.Text;
            Server.Transfer("~/WebForm2.aspx");
        }

        protected void Session_Click(object sender, EventArgs e)
        {
            Session["NOME"] = Nome.Text;
            Server.Transfer("~/WebForm3.aspx");
        }
    }
}