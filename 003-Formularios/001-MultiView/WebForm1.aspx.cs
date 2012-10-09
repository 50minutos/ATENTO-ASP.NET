using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _001_MultiView
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Nome.MaxLength = 50;
        }

        protected void Unnamed2_Click(object sender, EventArgs e)
        {
            //Enviar
            LblNome.Text = Nome.Text;
            LblEmail.Text = Email.Text;
            LblEmailConfirmacao.Text = EmailConfirmacao.Text;

            MV.ActiveViewIndex = 1;
        }

        protected void Unnamed4_Click(object sender, EventArgs e)
        {
            //Voltar
            MV.ActiveViewIndex = 0;
        }
    }
}