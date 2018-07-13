using AirportRESRfulApi.Shared.DTO;
using System.Collections.Generic;

namespace AirportRESRfulApi.BLL.Interfaces
{
    public interface ICrewsService
    {
        IEnumerable<CrewDto> Get();
        CrewDto GetById(int id);
        CrewDto Make(CrewDto entity);
        CrewDto Update(CrewDto entity);
        bool Delete(int id);
    }
}
