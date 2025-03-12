using ParlemValencia.Business.Entity;
using ParlemValencia.Infrastructure.Interfaces;

namespace ParlemValencia.Infrastructure.Repository
{
    public class Data : IData
    {

        public List<Cliente> lista =
        [
            new Cliente
            {
                Id = 555555,
                DocType = "nif",
                DocNum = "11223344E",
                Email = "it@parlem.com",
                CustomerId = "11111",
                GivenName = "Enriqueta",
                FamilyName1 = "Parlem",
                Phone = "668668668"
            } 
         ];

        //public void Crearlista()
        //{
        //    lista = new List<Cliente>();

        //    lista.Add(new Cliente
        //    {
        //        Id = 555555,
        //        DocType = "nif",
        //        DocNum = "11223344E",
        //        Email = "it@parlem.com",
        //        CustomerId = "11111",
        //        GivenName = "Enriqueta",
        //        FamilyName1 = "Parlem",
        //        Phone = "668668668"
        //    });
          
           
        //}

        public void addCliente(Cliente cliente) {
        
            lista.Add(cliente);
        }

        public IEnumerable<Cliente> GetlistaCliente()
        {
           return lista;
        }
    }
}
