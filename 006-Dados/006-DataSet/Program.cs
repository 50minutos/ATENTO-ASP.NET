using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace _006_DataSet
{
    class Program
    {
        static void Main(string[] args)
        {
            var ds = new DataSet();

            var dt = new DataTable("PESSOA");

            ds.Tables.Add(dt);

            Console.WriteLine(ds.Tables[0]);
            Console.WriteLine(ds.Tables["PESSOA"]);

            dt.Columns.Add("CODIGO", typeof(Int32));
            dt.Columns.Add("NOME", typeof(String));
            dt.Columns.Add("SEXO", typeof(Char));

            dt.Columns["NOME"].MaxLength = 50;

            var dr = dt.NewRow();

            dr["CODIGO"] = 1;
            dr["NOME"] = "ADÃO";
            dr["SEXO"] = 'M';

            dt.Rows.Add(dr);

            dr = dt.NewRow();

            dr["CODIGO"] = 2;
            dr["NOME"] = "EVA";
            dr["SEXO"] = 'F';

            dt.Rows.Add(dr);

            Console.WriteLine();

            foreach (DataRow linha in dt.Rows)
            {
                foreach (DataColumn coluna in dt.Columns)
                {
                    Console.WriteLine("{0} -> {1}", coluna.ColumnName, linha[coluna]);
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
