using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _004_Triangulos
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Calcular(Object o, EventArgs e)
        {
            int a = Int32.Parse(LadoA.Text);
            int b = Int32.Parse(LadoB.Text);
            int c = Int32.Parse(LadoC.Text);

            if (a <= 0 || b <= 0 || c <= 0 || a + b <= c || a + c <= b || c + b <= a)
            {
                Mensagem.Text = "Não é um triângulo";
                Imagem.ImageUrl = "Images/Erro.png";
            }
            else if (a == b && b == c)
            {
                Mensagem.Text = "É um triângulo equilátero";
                Imagem.ImageUrl = "Images/Equilatero.png";
            }
            else if (a != b && b != c && c != a)
            {
                Mensagem.Text = "É um triângulo escaleno";
                Imagem.ImageUrl = "Images/Escaleno.png";
            }
            else
            {
                Mensagem.Text = "É um triângulo isósceles";
                Imagem.ImageUrl = "Images/Isosceles.png";
            }

            MultiView1.ActiveViewIndex = 1;
        }
    }
}