using AirportRESRfulApi.BLL.Interfaces;
using AirportRESRfulApi.Shared.DTO;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace AirportRESRfulApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StewardessesController : ControllerBase
    {
        private IStewardessesService _stewardessesSrvice;
        public StewardessesController(IStewardessesService stewardessesSrvice)
        {
            _stewardessesSrvice = stewardessesSrvice;
        }

        // GET api/Stewardesses
        [HttpGet]
        public ActionResult<IEnumerable<StewardessDto>> Get()
        {
            return _stewardessesSrvice.Get().ToList();
        }

        // GET api/Stewardesses/2
        [HttpGet("{id}")]
        public ActionResult<StewardessDto> Get(int id)
        {
            var entity = _stewardessesSrvice.GetById(id);

            if (entity == null) return NotFound();

            return entity;
        }

        // POST api/Stewardesses
        [HttpPost]
        public ActionResult<StewardessDto> Post([FromBody] StewardessDto entity)
        {
            return _stewardessesSrvice.Make(entity);
        }

        // PUT api/Stewardesses/2
        [HttpPut("{id}")]
        public StewardessDto Put(int id, [FromBody] StewardessDto entity)
        {
            return _stewardessesSrvice.Update(entity);
        }

        // DELETE api/Stewardesses/2
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if(_stewardessesSrvice.Delete(id))
            {
                return Ok();
            }
            return NotFound();
        }
    }
}
