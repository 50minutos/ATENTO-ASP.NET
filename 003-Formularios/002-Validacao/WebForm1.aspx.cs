using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _002_Validacao
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed2_Click(object sender, EventArgs e)
        {
            LblNome.Text = Nome.Text;
            LblEmail.Text = Email.Text;
            LblSenha.Text = Senha.Text;
            LblIdade.Text = Idade.Text;

            MV.ActiveViewIndex = 1;
        }

        protected void Unnamed4_Click(object sender, EventArgs e)
        {
            MV.ActiveViewIndex = 0;
        }
    }
}