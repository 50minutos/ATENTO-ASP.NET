using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _002_Login
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Logar(Object o, EventArgs ea)
        {
            if (Usuario.Text.Equals("abc") && Senha.Text.Equals("123"))
            {
                Session["USUARIO"] = Usuario.Text;
                Response.Redirect("~/WebForm1.aspx");
            }
        }
    }
}