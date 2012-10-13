using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _006_Cache
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Cache.Insert("NOME", "AGNALDO", null, new DateTime(2012, 12, 31, 23, 59, 59), System.Web.Caching.Cache.NoSlidingExpiration);

            Cache.Insert("EMAIL", "agnaldo@50minutos.com.br", null, System.Web.Caching.Cache.NoAbsoluteExpiration, new TimeSpan(0, 0, 20));

            Response.Redirect("~/WebForm1.aspx");
        }
    }
}