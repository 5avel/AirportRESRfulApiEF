using AirportRESRfulApi.Shared.DTO;
using System.Collections.Generic;

namespace AirportRESRfulApi.BLL.Interfaces
{
    public interface IDeparturesService
    {
        IEnumerable<DepartureDto> Get();
        DepartureDto GetById(int id);
        DepartureDto Make(DepartureDto entity);
        DepartureDto Update(DepartureDto entity);
        bool Delete(int id);
    }
}
