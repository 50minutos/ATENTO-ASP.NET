using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _012_DynamicData
{
    partial class Pessoa
    {
        public String Imprimir()
        {
            return String.Format("{0} -> {1}", Codigo, Nome);
        }
    }
}