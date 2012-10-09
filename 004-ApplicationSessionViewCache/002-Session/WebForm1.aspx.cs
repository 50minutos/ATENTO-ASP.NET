using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _002_Session
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["URL"] != null)
                URL.Text = Session["URL"].ToString();

            ID.Text = Session.SessionID;

            if (!IsPostBack && Session["NOME"] != null)
                Nome.Text = Session["NOME"].ToString();
        }

        protected void Enviar(object sender, EventArgs e)
        {
            Session["NOME"] = Nome.Text;
            Response.Redirect(Request.ServerVariables["URL"].ToString());
        }
    }
}