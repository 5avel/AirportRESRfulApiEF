using AirportRESRfulApi.BLL.Interfaces;
using AirportRESRfulApi.DAL.Interfaces;
using AirportRESRfulApi.DAL.Models;
using AirportRESRfulApi.Shared.DTO;
using AutoMapper;

namespace AirportRESRfulApi.BLL.Services
{
    public class DeparturesService : Service<Departure, DepartureDto>, IDeparturesService
    {
        public DeparturesService(IUnitOfWork repository, IMapper mapper) : base(repository, mapper)
        {

        }
    }
}
