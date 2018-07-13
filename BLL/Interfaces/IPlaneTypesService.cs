using AirportRESRfulApi.Shared.DTO;
using System.Collections.Generic;

namespace AirportRESRfulApi.BLL.Interfaces
{
    public interface IPlaneTypesService
    {
        IEnumerable<PlaneTypeDto> Get();
        PlaneTypeDto GetById(int id);
        PlaneTypeDto Make(PlaneTypeDto entity);
        PlaneTypeDto Update(PlaneTypeDto entity);
        bool Delete(int id);
    }
}
