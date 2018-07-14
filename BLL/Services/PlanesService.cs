using AirportRESRfulApi.BLL.Interfaces;
using AirportRESRfulApi.DAL.Interfaces;
using AirportRESRfulApi.DAL.Models;
using AirportRESRfulApi.Shared.DTO;
using AutoMapper;

namespace AirportRESRfulApi.BLL.Services
{
    public class PlanesService : Service<Plane, PlaneDto>, IPlanesService
    {
        public PlanesService(IUnitOfWork repository, IMapper mapper) : base(repository, mapper)
        {

        }

    }
}
