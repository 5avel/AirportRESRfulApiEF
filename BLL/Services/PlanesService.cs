using AirportRESRfulApi.BLL.Interfaces;
using AirportRESRfulApi.DAL.Interfaces;
using AirportRESRfulApi.DAL.Models;
using AirportRESRfulApi.Shared.DTO;
using AutoMapper;
using System.Collections.Generic;

namespace AirportRESRfulApi.BLL.Services
{
    public class PlanesService : IPlanesService
    {
        private IRepository<Plane> _repository;
        private IMapper _mapper;

        public PlanesService(IRepository<Plane> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public bool Delete(int id)
        {
            return _repository.Delete(id);
        }

        public IEnumerable<PlaneDto> Get()
        {
            var entity = _repository.GetAll();
            return _mapper.Map<IEnumerable<Plane>, IEnumerable<PlaneDto>>(entity);
        }

        public PlaneDto GetById(int id)
        {
            var entity = _repository.GetById(id);
            return _mapper.Map<Plane, PlaneDto>(entity);
        }

        public PlaneDto Make(PlaneDto entity)
        {
            var makedEntity = _mapper.Map<PlaneDto, Plane>(entity);
            return _mapper.Map<Plane, PlaneDto>(_repository.Create(makedEntity));
        }

        public PlaneDto Update(PlaneDto entity)
        {
            var updatedEntity = _mapper.Map<PlaneDto, Plane>(entity);
            return _mapper.Map<Plane, PlaneDto>(_repository.Update(updatedEntity));
        }
    }
}
