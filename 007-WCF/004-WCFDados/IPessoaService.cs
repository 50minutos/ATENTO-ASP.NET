using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace _004_WCFDados
{
    [ServiceContract]
    public interface IPessoaService
    {
        [OperationContract]
        Pessoa Get(int codigo);

        [OperationContract(Name="GetAll")]
        IEnumerable<Pessoa> Get();
    }
}
