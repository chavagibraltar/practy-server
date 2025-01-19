using Microsoft.AspNetCore.Mvc;
using Practy.Core.Entities;
using Practy.Core.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Practy.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly IClientService _clientService;

        public ClientController(IClientService clientService)
        {
            _clientService = clientService;
        }

        // GET: api/<ClientController>
        [HttpGet]
        //public IEnumerable<string> Get()
        public ActionResult Get()
        {
            var clients = _clientService.GetList();
            return Ok(clients);
           // return new string[] { "value1", "value2" };
        }

        // GET api/<ClientController>/5
        [HttpGet("{id}")]
        //public string Get(int id)
        public ActionResult Get(int id)
        {
            var client = _clientService.GetById(id);
            return Ok(client);
            //return "value";
        }

        // POST api/<ClientController>
        [HttpPost]
        public ActionResult Post([FromBody] Client client)
        {
            var newClient = _clientService.Add(client);
            return Ok(newClient);
        }

        // PUT api/<ClientController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Client client)
        {
            var updatedClient = _clientService.Update(client);
            return Ok(updatedClient);
        }

        // DELETE api/<ClientController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _clientService.Delete(id);
            return Ok();
        }
    }
}
