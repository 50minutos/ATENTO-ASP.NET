using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Web.UI;

namespace _002_Login
{
    public class Pagina : Page
    {
        protected void Page_PreInit(Object o, EventArgs ea)
        {
            if (Session["USUARIO"] == null)
                Response.Redirect("~/Login.aspx");
        }
    }
}