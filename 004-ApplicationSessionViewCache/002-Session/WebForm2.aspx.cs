using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _002_Session
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["NOME"] != null)
                Nome.Text = Session["NOME"].ToString();

            //ADICIONAR
            //Session.Add("ELEMENTO", "CONTEUDO");

            //REMOVER
            //Session.Remove("ELEMENTO");
            //Session.RemoveAll();
            //Session.RemoveAt(1);

            //ABANDONAR
            //Session.Abandon();

            //PERCORRE A COLEÇÃO DE CHAVES
            //foreach (String item in Session.Keys)
            //{
            //    Response.Write(String.Format("<p>{0} -> {1}</p>",
            //        item, Session[item]));
            //}
        }
    }
}