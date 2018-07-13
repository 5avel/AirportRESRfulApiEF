using AirportRESRfulApi.BLL.Interfaces;
using AirportRESRfulApi.Shared.DTO;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace AirportRESRfulApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlanesController : ControllerBase
    {
        private IPlanesService _planesSrvice;
        public PlanesController(IPlanesService planesSrvice)
        {
            _planesSrvice = planesSrvice;
        }

        // GET api/Flights
        [HttpGet]
        public ActionResult<IEnumerable<PlaneDto>> Get()
        {
            return _planesSrvice.Get().ToList();
        }

        // GET api/Flights/2
        [HttpGet("{id}")]
        public ActionResult<PlaneDto> Get(int id)
        {
            var ticket = _planesSrvice.GetById(id);

            if (ticket == null) return NotFound();

            return _planesSrvice.GetById(id);
        }

        // POST api/Flights
        [HttpPost]
        public ActionResult<PlaneDto> Post([FromBody] PlaneDto entity)
        {
            return _planesSrvice.Make(entity);
        }

        // PUT api/Flights/2
        [HttpPut("{id}")]
        public PlaneDto Put(int id, [FromBody] PlaneDto entity)
        {
            return _planesSrvice.Update(entity);
        }

        // DELETE api/Flights/2
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if(_planesSrvice.Delete(id))
            {
                return Ok();
            }
            return NotFound();
        }
    }
}
