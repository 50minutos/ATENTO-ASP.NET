using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Web.Caching;

namespace _005_CacheCacheDependency
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Cache["ARQUIVO"] == null)
            {
                //ler o arquivo e copiar para o cache
                var nomeArquivo = Server.MapPath("Arquivo.txt");
                var arquivo = new StreamReader(nomeArquivo);
                var cd = new CacheDependency(nomeArquivo);
                
                Cache.Insert("ARQUIVO", arquivo.ReadToEnd(), cd);

                arquivo.Close();

                //indicar que a leitura foi feita a partir do disco
                Label1.Text = "DISCO";
            }
            else
            {
                //indicar que a leitura foi feita a partir do Cache
                Label1.Text = "CACHE";
            }

            Label2.Text = Cache["ARQUIVO"].ToString().Replace("\n", "<br/>");
        }
    }
}