using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _009_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //MostrarForEach();
            //MostrarSelect();
            //MostrarWhere();
            MostrarList();

            Console.ReadKey();
        }

        private static void MostrarList()
        {
            var pessoas = new List<Pessoa>();

            pessoas.Add(new Pessoa { Codigo = 1, Nome = "ADÃO" });
            pessoas.Add(new Pessoa { Codigo = 2, Nome = "EVA" });

            var x = from p in pessoas
                    where p.Codigo == 1
                    select p;

            foreach (var item in x)
            {
                Console.WriteLine("{0} -> {1}", item.Codigo, item.Nome);
            }

            var y = pessoas
                .Where(p => p.Codigo == 2);

            Console.WriteLine();

            foreach (var item in y)
            {
                Console.WriteLine("{0} -> {1}", item.Codigo, item.Nome);
            }
        }

        private static void MostrarWhere()
        {
            var numeros = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };

            var pares = from x in numeros
                        where x % 2 == 0
                        select x;

            foreach (var item in pares)
                Console.WriteLine(item);

            Console.WriteLine();

            var impares = numeros
               .Where(x => x % 2 != 0);

            Console.WriteLine(impares.GetType());

            foreach (var item in impares)
                Console.WriteLine(item);
        }

        private static void MostrarSelect()
        {
            var s = "SQL Server 2012 é um servidor de banco de dados";

            var letras = from x in s
                         select x;

            Console.WriteLine(letras.GetType());

            foreach (var item in letras)
            {
                Console.Write("{0} ", item);
            }

            Console.WriteLine();

            var maisLetras = s.Select(x => x);

            Console.WriteLine(maisLetras.GetType());

            foreach (var item in maisLetras)
            {
                Console.Write("{0} ", item);
            }

            Console.WriteLine();

            var outrasLetras = s.Select(Selecionar);

            Console.WriteLine(outrasLetras.GetType());

            foreach (var item in outrasLetras)
            {
                Console.Write("{0} ", item);
            }

            Console.WriteLine();
        }

        private static char Selecionar(char c)
        {
            return c;
        }

        private static void MostrarForEach()
        {
            var s = "qualquer coisa";

            foreach (var item in s)
            {
                Console.WriteLine("{0} -> {1}",
                    item.GetType(), item);
            }
        }
    }

    class Pessoa
    {
        public int Codigo { get; set; }
        public String Nome { get; set; }
    }
}
