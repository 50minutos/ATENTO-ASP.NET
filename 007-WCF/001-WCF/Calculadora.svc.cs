using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace _001_WCF
{
    public class Calculadora : ICalculadora
    {
        public double Somar(double x, double y)
        {
            return x + y;
        }

        public double Subtrair(double x, double y)
        {
            return x - y;
        }

        public double Multiplicar(double x, double y)
        {
            return x * y;
        }

        public double Dividir(double x, double y)
        {
            return x / y;
        }
    }
}
