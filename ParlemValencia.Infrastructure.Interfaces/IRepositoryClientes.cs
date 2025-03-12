using ParlemValencia.Business.Entity;


namespace ParlemValencia.Infrastructure.Interfaces
{
    public interface IRepositoryClientes
    {
        bool Insert();
        IEnumerable<Cliente> GetAll();
    }
}
