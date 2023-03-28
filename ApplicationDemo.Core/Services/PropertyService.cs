using ApplicationDemo.Core.Dtos.LookUp;
using ApplicationDemo.Core.Services.Interfaces;
using ApplicationDemo.Domain.Entities;
using ApplicationDemo.Infrastructure.Repositories.GenericRepository;
using AutoMapper;

namespace ApplicationDemo.Core.Services
{
    public class PropertyService : ILookUpService
    {
        private readonly IGenericRepository<Property> _genericRepository;
        private readonly IMapper _mapper;
        public PropertyService(IGenericRepository<Property> genericRepository, IMapper mapper)
        {
            _genericRepository = genericRepository;
            _mapper = mapper;
        }


        public bool AddLookUp(LookUpToAdd lookUpToAdd)
        {
            var property = _mapper.Map<Property>(lookUpToAdd);
            return _genericRepository.Add(property);
        }

        public List<LookUpDto> GetLookUps()
        {
            var fetchedProperties = _genericRepository.GetAll();
            return _mapper.Map<List<LookUpDto>>(fetchedProperties);
        }
    }
}
