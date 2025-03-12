using ParlemValencia.Business.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParlemValencia.Business.Interfaces
{
    public interface IClienteInterface
    {
        bool Insert();
        IEnumerable<Cliente> GetAll();
    }
}
