using AirportRESRfulApi.BLL.Interfaces;
using AirportRESRfulApi.Shared.DTO;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace AirportRESRfulApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PilotsController : ControllerBase
    {
        private IPilotsService _pilotsSrvice;
        public PilotsController(IPilotsService pilotsSrvice)
        {
            _pilotsSrvice = pilotsSrvice;
        }

        // GET api/Tickets
        [HttpGet]
        public ActionResult<IEnumerable<PilotDto>> Get()
        {
            return _pilotsSrvice.Get().ToList();
        }

        // GET api/Tickets/2
        [HttpGet("{id}")]
        public ActionResult<PilotDto> Get(int id)
        {
            var ticket = _pilotsSrvice.GetById(id);

            if (ticket == null) return NotFound();

            return _pilotsSrvice.GetById(id);
        }

        // POST api/Tickets
        [HttpPost]
        public ActionResult<PilotDto> Post([FromBody] PilotDto entity)
        {
            return _pilotsSrvice.Make(entity);
        }

        // PUT api/Tickets/2
        [HttpPut("{id}")]
        public PilotDto Put(int id, [FromBody] PilotDto entity)
        {
            return _pilotsSrvice.Update(entity);
        }

        // DELETE api/Tickets/2
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if(_pilotsSrvice.Delete(id))
            {
                return Ok();
            }
            return NotFound();
        }
    }
}
