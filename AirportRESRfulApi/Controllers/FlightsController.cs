using AirportRESRfulApi.BLL.Interfaces;
using AirportRESRfulApi.Shared.DTO;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace AirportRESRfulApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlightsController : ControllerBase
    {
        private IFlightsService _flightsSrvice;
        public FlightsController(IFlightsService flightsSrvice)
        {
            _flightsSrvice = flightsSrvice;
        }

        // GET api/Flights
        [HttpGet]
        public ActionResult<IEnumerable<FlightDto>> Get()
        {
            return _flightsSrvice.Get().ToList();
        }

        // GET api/Flights/2
        [HttpGet("{id}")]
        public ActionResult<FlightDto> Get(int id)
        {
            var ticket = _flightsSrvice.GetById(id);

            if (ticket == null) return NotFound();

            return _flightsSrvice.GetById(id);
        }

        // POST api/Flights
        [HttpPost]
        public ActionResult<FlightDto> Post([FromBody] FlightDto entity)
        {
            return _flightsSrvice.Make(entity);
        }

        // PUT api/Flights/2
        [HttpPut("{id}")]
        public FlightDto Put(int id, [FromBody] FlightDto ticket)
        {
            return _flightsSrvice.Update(ticket);
        }

        // DELETE api/Flights/2
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if(_flightsSrvice.Delete(id))
            {
                return Ok();
            }
            return NotFound();
        }
    }
}
