using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _002_ConsumidorWCF.Proxy;

namespace _002_ConsumidorWCF
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = new CalculadoraClient();

            Console.WriteLine(c.Somar(10, 3));
            Console.WriteLine(c.Subtrair(10, 3));
            Console.WriteLine(c.Multiplicar(10, 3));
            Console.WriteLine(c.Dividir(10, 3));

            Console.ReadKey();
        }
    }
}
