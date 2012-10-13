using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _001_Trace
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var s = "AGNALDO";

            AtribuirSession(s);

            AtribuirApplication(s);
        }

        private void AtribuirApplication(String s)
        {
            Application["NOME"] = s.ToUpper();
        }

        private void AtribuirSession(String s)
        {
            Session["NOME"] = s;
        }
    }
}