using AirportRESRfulApi.BLL.Interfaces;
using AirportRESRfulApi.DAL.Interfaces;
using AirportRESRfulApi.DAL.Models;
using AirportRESRfulApi.Shared.DTO;
using AutoMapper;
using System.Collections.Generic;

namespace AirportRESRfulApi.BLL.Services
{
    public class PlaneTypesService : IPlaneTypesService
    {
        private IRepository<PlaneType> _repository;
        private IMapper _mapper;

        public PlaneTypesService(IRepository<PlaneType> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public bool Delete(int id)
        {
            return _repository.Delete(id);
        }

        public IEnumerable<PlaneTypeDto> Get()
        {
            var entity = _repository.GetAll();
            return _mapper.Map<IEnumerable<PlaneType>, IEnumerable<PlaneTypeDto>>(entity);
        }

        public PlaneTypeDto GetById(int id)
        {
            var entity = _repository.GetById(id);
            return _mapper.Map<PlaneType, PlaneTypeDto>(entity);
        }

        public PlaneTypeDto Make(PlaneTypeDto entity)
        {
            var makedEntity = _mapper.Map<PlaneTypeDto, PlaneType>(entity);
            return _mapper.Map<PlaneType, PlaneTypeDto>(_repository.Create(makedEntity));
        }

        public PlaneTypeDto Update(PlaneTypeDto entity)
        {
            var updatedEntity = _mapper.Map<PlaneTypeDto, PlaneType>(entity);
            return _mapper.Map<PlaneType, PlaneTypeDto>(_repository.Update(updatedEntity));
        }
    }
}
