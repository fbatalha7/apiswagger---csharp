using apinetcore.Models;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace apinetcore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        // GET: api/<ClientesController>
        [HttpGet]
        public List<Clientes> Get()
        {
            List<Clientes> obj = Clientes.Getclients();

            return obj;
        }
        // GET api/<ClientesController>/5
        [HttpGet("{id}")]
        public List<Clientes> GetClient(int id)
        {

            List<Clientes> Cliente = Clientes.Mylist.Where(x=> x .Id == id).ToList();

            return Cliente;
        }

        // POST api/<ClientesController>
        [HttpPost]
        public void Post(Clientes obj)
        {
            Clientes.Mylist.Add(obj);

        }

        // PUT api/<ClientesController>/5
        [HttpPut()]
        public void Put(Clientes obj)
        {
          var cliente = Clientes.Getclients().Where(x=> x.Id == obj.Id).ToList(); 
                cliente.Contains(obj);

        }

        //// DELETE api/<ClientesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {            
           
        }
    }
}
