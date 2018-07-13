using AirportRESRfulApi.BLL.Interfaces;
using AirportRESRfulApi.Shared.DTO;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace AirportRESRfulApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CrewsController : ControllerBase
    {
        private ICrewsService _crewsSrvice;
        public CrewsController(ICrewsService crewsSrvice)
        {
            _crewsSrvice = crewsSrvice;
        }

        // GET api/Flights
        [HttpGet]
        public ActionResult<IEnumerable<CrewDto>> Get()
        {
            return _crewsSrvice.Get().ToList();
        }

        // GET api/Flights/2
        [HttpGet("{id}")]
        public ActionResult<CrewDto> Get(int id)
        {
            var ticket = _crewsSrvice.GetById(id);

            if (ticket == null) return NotFound();

            return _crewsSrvice.GetById(id);
        }

        // POST api/Flights
        [HttpPost]
        public ActionResult<CrewDto> Post([FromBody] CrewDto entity)
        {
            return _crewsSrvice.Make(entity);
        }

        // PUT api/Flights/2
        [HttpPut("{id}")]
        public CrewDto Put(int id, [FromBody] CrewDto entity)
        {
            return _crewsSrvice.Update(entity);
        }

        // DELETE api/Flights/2
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if(_crewsSrvice.Delete(id))
            {
                return Ok();
            }
            return NotFound();
        }
    }
}
