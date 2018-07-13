using AirportRESRfulApi.Shared.DTO;
using System.Collections.Generic;

namespace AirportRESRfulApi.BLL.Interfaces
{
    public interface IStewardessesService
    {
        IEnumerable<StewardessDto> Get();
        StewardessDto GetById(int id);
        StewardessDto Make(StewardessDto entity);
        StewardessDto Update(StewardessDto entity);
        bool Delete(int id);
    }
}
