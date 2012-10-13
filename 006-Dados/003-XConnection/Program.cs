using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace _003_XConnection
{
    class Program
    {
        static void Main(string[] args)
        {
            var cs = @"Data Source=.\sqlexpress;Initial Catalog=MASTER;Integrated Security=true;";

            using(var c = new SqlConnection(cs))
            {
                Console.WriteLine(c.State);

                c.Open();

                Console.WriteLine(c.State);

                c.Close();

                Console.WriteLine(c.State);
            }

            Console.ReadKey();
        }
    }
}
