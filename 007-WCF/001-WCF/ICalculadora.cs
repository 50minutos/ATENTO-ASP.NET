using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace _001_WCF
{
    [ServiceContract]
    public interface ICalculadora
    {
        [OperationContract] 
        double Somar(double x, double y);

        [OperationContract]
        double Subtrair(double x, double y);
        
        [OperationContract]
        double Multiplicar(double x, double y);
        
        [OperationContract]
        double Dividir(double x, double y);
    }
}
