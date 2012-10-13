using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _011_EntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            var e = new _011_EntityFramework.DbEntities();

            foreach (var item in e.Pessoas.Where(p => p.Sexo == "F"))
            {
                Console.WriteLine(item.Nome);
            }

            Console.ReadKey();
        }
    }
}
