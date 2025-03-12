using ParlemValencia.Business.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParlemValencia.Infrastructure.Interfaces
{
    public interface IData
    {
     //   void Crearlista();

        void addCliente(Cliente cliente);

        IEnumerable<Cliente> GetlistaCliente();
    }
}
