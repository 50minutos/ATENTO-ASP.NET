using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace _002_XConnectionStringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            var csb = new SqlConnectionStringBuilder();

            csb.DataSource = @".\sqlexpress";
            csb.InitialCatalog = "MASTER";
         
            //ou é isso:
            csb.IntegratedSecurity = true;

            //ou essas duas linhas:
            //csb.UserID = "NomeDoUsuario";
            //csb.Password = "SenhaDoUsuario";

            Console.WriteLine(csb.ToString());

            //http://www.connectionstrings.com

            Console.ReadKey();
        }
    }
}
