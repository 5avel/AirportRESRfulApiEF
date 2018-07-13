using AirportRESRfulApi.BLL.Interfaces;
using AirportRESRfulApi.DAL.Interfaces;
using AirportRESRfulApi.DAL.Models;
using AirportRESRfulApi.Shared.DTO;
using AutoMapper;
using System.Collections.Generic;


namespace AirportRESRfulApi.BLL.Services
{
    public class CrewsService : ICrewsService
    {
        private IRepository<Crew> _repository;
        private IMapper _mapper;

        public CrewsService(IRepository<Crew> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public bool Delete(int id)
        {
            return _repository.Delete(id);
        }

        public IEnumerable<CrewDto> Get()
        {
            var entity = _repository.GetAll();
            return _mapper.Map<IEnumerable<Crew>, IEnumerable<CrewDto>>(entity);
        }

        public CrewDto GetById(int id)
        {
            var entity = _repository.GetById(id);
            return _mapper.Map<Crew, CrewDto>(entity);
        }

        public CrewDto Make(CrewDto entity)
        {
            var makedEntity = _mapper.Map<CrewDto, Crew>(entity);
            return _mapper.Map<Crew, CrewDto>(_repository.Create(makedEntity));
        }

        public CrewDto Update(CrewDto entity)
        {
            var updatedEntity = _mapper.Map<CrewDto, Crew>(entity);
            return _mapper.Map<Crew, CrewDto>(_repository.Update(updatedEntity));
        }
    }
}
