using AirportRESRfulApi.BLL.Interfaces;
using AirportRESRfulApi.Shared.DTO;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace AirportRESRfulApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlaneTypesController : ControllerBase
    {
        private IPlaneTypesService _planeTypesService;
        public PlaneTypesController(IPlaneTypesService planeTypesService)
        {
            _planeTypesService = planeTypesService;
        }

        // GET api/Flights
        [HttpGet]
        public ActionResult<IEnumerable<PlaneTypeDto>> Get()
        {
            return _planeTypesService.Get().ToList();
        }

        // GET api/Flights/2
        [HttpGet("{id}")]
        public ActionResult<PlaneTypeDto> Get(int id)
        {
            var ticket = _planeTypesService.GetById(id);

            if (ticket == null) return NotFound();

            return _planeTypesService.GetById(id);
        }

        // POST api/Flights
        [HttpPost]
        public ActionResult<PlaneTypeDto> Post([FromBody] PlaneTypeDto entity)
        {
            return _planeTypesService.Make(entity);
        }

        // PUT api/Flights/2
        [HttpPut("{id}")]
        public PlaneTypeDto Put(int id, [FromBody] PlaneTypeDto entity)
        {
            return _planeTypesService.Update(entity);
        }

        // DELETE api/Flights/2
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if(_planeTypesService.Delete(id))
            {
                return Ok();
            }
            return NotFound();
        }
    }
}
