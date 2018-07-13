using AirportRESRfulApi.Shared.DTO;
using System.Collections.Generic;

namespace AirportRESRfulApi.BLL.Interfaces
{
    public interface IPlanesService
    {
        IEnumerable<PlaneDto> Get();
        PlaneDto GetById(int id);
        PlaneDto Make(PlaneDto entity);
        PlaneDto Update(PlaneDto entity);
        bool Delete(int id);
    }
}
