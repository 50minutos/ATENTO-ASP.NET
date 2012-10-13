using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _006_Cache
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Cache["NOME"] != null)
                Nome.Text = Cache["NOME"].ToString();

            if (Cache["EMAIL"] != null)
                Email.Text = Cache["EMAIL"].ToString();
        }
    }
}