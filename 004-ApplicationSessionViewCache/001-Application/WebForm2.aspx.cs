using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _001_Application
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Application["NOME_EMPRESA"] != null)
                    NomeEmpresa.Text = Application["NOME_EMPRESA"].ToString();

                if (Application["DESENVOLVEDOR"] != null)
                    Desenvolvedor.Text = Application["DESENVOLVEDOR"].ToString();

                if (Application["EMAIL"] != null)
                    Email.Text = Application["EMAIL"].ToString();
            }
        }

        protected void Gravar(Object sender, EventArgs e)
        {
            Application.Lock();
            
            Application["NOME_EMPRESA"] = NomeEmpresa.Text;
            Application["DESENVOLVEDOR"] = Desenvolvedor.Text;
            Application["EMAIL"] = Email.Text;
            
            Application.UnLock();

            Response.Redirect("~/WebForm1.aspx");
        }
    }
}