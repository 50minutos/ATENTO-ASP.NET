using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace _004_WCFDados
{
    public class PessoaService : IPessoaService
    {
        public Pessoa Get(int codigo)
        {
            return Get().FirstOrDefault(p => p.Codigo == codigo);
        }

        public IEnumerable<Pessoa> Get()
        {
            return new DbEntities().Pessoas;
        }
    }
}
