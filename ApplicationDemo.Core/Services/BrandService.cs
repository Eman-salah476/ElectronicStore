using ApplicationDemo.Core.Dtos.LookUp;
using ApplicationDemo.Core.Services.Interfaces;
using ApplicationDemo.Domain.Entities;
using ApplicationDemo.Infrastructure.Repositories.GenericRepository;
using AutoMapper;

namespace ApplicationDemo.Core.Services
{
    public class BrandService : ILookUpService<Brand>
    {
        private readonly IGenericRepository<Brand> _genericRepository;
        private readonly IMapper _mapper;
        public BrandService(IGenericRepository<Brand> genericRepository, IMapper mapper)
        {
            _genericRepository = genericRepository;
            _mapper = mapper;
        }


        public bool AddLookUp(LookUpToAdd lookUpToAdd)
        {
            var brand = _mapper.Map<Brand>(lookUpToAdd);
            return _genericRepository.Add(brand);
        }

        public List<LookUpDto> GetLookUps()
        {
            var fetchedBrands = _genericRepository.GetAll();
            return _mapper.Map<List<LookUpDto>>(fetchedBrands);
        }
    }
}
