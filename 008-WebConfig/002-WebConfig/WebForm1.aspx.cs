using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;

namespace _002_WebConfig
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = ConfigurationManager.ConnectionStrings["LocalDb"].ConnectionString;

            Label2.Text = ConfigurationManager.AppSettings["EMAIL"];

            Label3.Text = ConfigurationManager.ConnectionStrings[ConfigurationManager.AppSettings["DB"]].ConnectionString;
        }
    }
}