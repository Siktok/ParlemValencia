using ParlemValencia.Business.Entity;
using ParlemValencia.Business.Interfaces;
using ParlemValencia.Infrastructure.Interfaces;

namespace ParlemValencia.Business.Core
{
    public class ClienteCore : IClienteInterface
    {

        private readonly IRepositoryClientes _repositoryClientes;

        public ClienteCore(IRepositoryClientes repositoryClientes)
        {
            _repositoryClientes = repositoryClientes;
        }

        public IEnumerable<Cliente> GetAll()
        {
          return _repositoryClientes.GetAll();
        }

        public bool Insert()
        {
            return _repositoryClientes.Insert();
        }
    }
}
