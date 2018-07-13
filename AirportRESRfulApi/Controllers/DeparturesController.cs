using AirportRESRfulApi.BLL.Interfaces;
using AirportRESRfulApi.Shared.DTO;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace AirportRESRfulApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeparturesController : ControllerBase
    {
        private IDeparturesService _departuresSrvice;
        public DeparturesController(IDeparturesService departuresSrvice)
        {
            _departuresSrvice = departuresSrvice;
        }

        // GET api/Flights
        [HttpGet]
        public ActionResult<IEnumerable<DepartureDto>> Get()
        {
            return _departuresSrvice.Get().ToList();
        }

        // GET api/Flights/2
        [HttpGet("{id}")]
        public ActionResult<DepartureDto> Get(int id)
        {
            var ticket = _departuresSrvice.GetById(id);

            if (ticket == null) return NotFound();

            return _departuresSrvice.GetById(id);
        }

        // POST api/Flights
        [HttpPost]
        public ActionResult<DepartureDto> Post([FromBody] DepartureDto entity)
        {
            return _departuresSrvice.Make(entity);
        }

        // PUT api/Flights/2
        [HttpPut("{id}")]
        public DepartureDto Put(int id, [FromBody] DepartureDto entity)
        {
            return _departuresSrvice.Update(entity);
        }

        // DELETE api/Flights/2
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if(_departuresSrvice.Delete(id))
            {
                return Ok();
            }
            return NotFound();
        }
    }
}
