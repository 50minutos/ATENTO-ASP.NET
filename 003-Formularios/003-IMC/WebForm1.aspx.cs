using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _003_IMC
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Calcular(Object sender, EventArgs e)
        {
            IMC.Text = (Double.Parse(Massa.Text) / (Double.Parse(Altura.Text) * Double.Parse(Altura.Text))).ToString("N2");

            MultiView1.ActiveViewIndex = 1;
        }
    }
}

