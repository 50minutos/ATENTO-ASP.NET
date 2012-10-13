using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using _005_ConsumidorWCFDados.Proxy;

namespace _005_ConsumidorWCFDados
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = new PessoaServiceClient();

            foreach (var item in c.GetAll())
            {
                Console.WriteLine("{0} {1} {2}", item.Codigo, item.Nome, item.Sexo);
            }

            Console.WriteLine();

            Console.WriteLine(c.Get(1).Nome);

            Console.ReadKey();
        }
    }
}
