using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace _005_XDataReader
{
    class Program
    {
        static void Main(string[] args)
        {
            var cs = "Data Source=.\\sqlexpress;Initial Catalog=MASTER;Integrated Security=true;";

            using (var c = new SqlConnection(cs))
            {
                var cmd = "select name from sys.objects";

                using (var k = new SqlCommand(cmd, c))
                {
                    c.Open();

                    var dr = k.ExecuteReader();

                    while (dr.Read())
                    {
                        Console.WriteLine(dr["name"]);
                    }

                    c.Close();
                }
            }

            Console.ReadKey();
        }
    }
}
