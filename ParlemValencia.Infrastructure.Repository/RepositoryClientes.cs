using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParlemValencia.Business.Entity;
using ParlemValencia.Infrastructure.Interfaces;

namespace ParlemValencia.Infrastructure.Repository
{
    public class RepositoryClientes : IRepositoryClientes
    {

        private readonly IData _data;
      

        public RepositoryClientes(IData data)
        {

            _data = data;
         
        }

        public IEnumerable<Cliente> GetAll()
        {
            return _data.GetlistaCliente();
        }

        public bool Insert()
        {
           
            var random = new Random();

            try
            {               
                Cliente cliente = new Cliente()
                {

                    Id = random.Next(100000, 999999),
                    DocType = "nif",
                    DocNum = "",
                    Email = "",
                    CustomerId = random.Next(10000, 99999).ToString(),
                    GivenName = "",
                    FamilyName1 = "",
                    Phone = $"{random.Next(600000000, 699999999)}"
                };

                _data.addCliente(cliente);
               
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
