using ApplicationDemo.Application.Dtos.LookUp;
using ApplicationDemo.Application.Services.Interfaces;
using ApplicationDemo.Domain.Entities;
using ApplicationDemo.Domain.Repositories;
using AutoMapper;

namespace ApplicationDemo.Application.Services
{
    public class BrandService : ILookUpService
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
