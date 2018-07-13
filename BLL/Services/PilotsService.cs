using AirportRESRfulApi.BLL.Interfaces;
using AirportRESRfulApi.DAL.Interfaces;
using AirportRESRfulApi.DAL.Models;
using AirportRESRfulApi.Shared.DTO;
using AutoMapper;
using System.Collections.Generic;

namespace AirportRESRfulApi.BLL.Services
{
    public class PilotsService : IPilotsService
    {
        private IRepository<Pilot> _repository;
        private IMapper _mapper;
        public PilotsService(IRepository<Pilot> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public bool Delete(int id)
        {
            return _repository.Delete(id);
        }

        public IEnumerable<PilotDto> Get()
        {
            var entity = _repository.GetAll();
            return _mapper.Map<IEnumerable<Pilot>, IEnumerable<PilotDto>>(entity);
        }

        public PilotDto GetById(int id)
        {
            var entity = _repository.GetById(id);
            return _mapper.Map<Pilot, PilotDto>(entity);
        }

        public PilotDto Make(PilotDto entity)
        {
            var makedEntity = _mapper.Map<PilotDto, Pilot>(entity);
            return _mapper.Map<Pilot, PilotDto>(_repository.Create(makedEntity));
        }

        public PilotDto Update(PilotDto entity)
        {
            var updatedEntity = _mapper.Map<PilotDto, Pilot>(entity);
            return _mapper.Map<Pilot, PilotDto>(_repository.Update(updatedEntity));
        }
    }
}
