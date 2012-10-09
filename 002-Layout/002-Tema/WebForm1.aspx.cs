using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _002_Tema
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                DropDownList1.SelectedIndex =
                    Session["TEMA"].ToString().Equals("Cinza")
                    ? 0
                    : 1;
        }

        protected void Page_PreInit(object sender, EventArgs e)
        {
            if (Session["TEMA"] == null)
            {
                Session["TEMA"] = "Amarelo";
            }

            Theme = Session["TEMA"].ToString();
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Session["TEMA"] = DropDownList1.SelectedValue;
            Response.Redirect(Request.ServerVariables["URL"]);
        }
    }
}