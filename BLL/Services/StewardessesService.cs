using AirportRESRfulApi.BLL.Interfaces;
using AirportRESRfulApi.DAL.Interfaces;
using AirportRESRfulApi.DAL.Models;
using AirportRESRfulApi.Shared.DTO;
using AutoMapper;
using System.Collections.Generic;

namespace AirportRESRfulApi.BLL.Services
{
    public class StewardessesService : IStewardessesService
    {
        private IRepository<Stewardess> _repository;
        private IMapper _mapper;
        public StewardessesService(IRepository<Stewardess> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public bool Delete(int id)
        {
            return _repository.Delete(id);
        }

        public IEnumerable<StewardessDto> Get()
        {
            var entity = _repository.GetAll();
            return _mapper.Map<IEnumerable<Stewardess>, IEnumerable<StewardessDto>>(entity);
        }

        public StewardessDto GetById(int id)
        {
            var entity = _repository.GetById(id);
            return _mapper.Map<Stewardess, StewardessDto>(entity);
        }

        public StewardessDto Make(StewardessDto entity)
        {
            var makedEntity = _mapper.Map<StewardessDto, Stewardess>(entity);
            return _mapper.Map<Stewardess, StewardessDto>(_repository.Create(makedEntity));
        }

        public StewardessDto Update(StewardessDto entity)
        {
            var updatedEntity = _mapper.Map<StewardessDto, Stewardess>(entity);
            return _mapper.Map<Stewardess, StewardessDto>(_repository.Update(updatedEntity));
        }
    }
}
