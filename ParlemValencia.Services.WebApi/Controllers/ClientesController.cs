using Microsoft.AspNetCore.Mvc;
using ParlemValencia.Business.Interfaces;

namespace ParlemValencia.Services.WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
   
    public class ClientesController : ControllerBase
    {


        private readonly IClienteCore _clienteCore;


        public ClientesController(IClienteCore clienteCore)
        {

            _clienteCore = clienteCore;
        }


        [HttpGet]
        public IActionResult GetAll()
        {

            var lista = _clienteCore.GetAll();


            return Ok(lista);

        }
        [HttpPost]
        public IActionResult Insert()
        {

            try
            {
                _clienteCore.Insert();

                return Ok("se insertó");
            }
            catch (Exception)
            {

                return BadRequest("Ocurrió un problema");
            }
         

        }



    }
}
