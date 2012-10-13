using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _010_DBML
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = new _010_DBML.DataClasses1DataContext();

            var pessoas = c.Pessoas
                .Where(p => p.Sexo == 'M');

            foreach (var item in pessoas)
            {
                Console.WriteLine(item.Nome);
            }

            Console.ReadKey();
        }
    }
}
