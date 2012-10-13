using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace _004_XCommand
{
    class Program
    {
        static void Main(string[] args)
        {
            var cs = "Data Source=.\\sqlexpress;Initial Catalog=MASTER;Integrated Security=true;";

            using (var c = new SqlConnection(cs))
            {
                var cmd = "select getdate()";
                
                using (var k = new SqlCommand(cmd, c))
                {
                    c.Open();

                    Console.WriteLine("a hora do servidor é {0}", k.ExecuteScalar());

                    c.Close();
                }

            }

            Console.ReadKey();
        }
    }
}
