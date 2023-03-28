using ApplicationDemo.Core.Dtos.LookUp;
using ApplicationDemo.Core.Services.Interfaces;
using ApplicationDemo.Domain.Entities;
using ApplicationDemo.Infrastructure.Repositories.GenericRepository;
using AutoMapper;

namespace ApplicationDemo.Core.Services
{
    public class CategoryService : ILookUpService
    {
        private readonly IGenericRepository<Category> _genericRepository;
        private readonly IMapper _mapper;
        public CategoryService(IGenericRepository<Category> genericRepository, IMapper mapper)
        {
            _genericRepository = genericRepository;
            _mapper = mapper;
        }

        public bool AddLookUp(LookUpToAdd lookUpToAdd)
        {
            var category = _mapper.Map<Category>(lookUpToAdd);
            return _genericRepository.Add(category);
        }

        public List<LookUpDto> GetLookUps()
        {
            var fetchedCategories = _genericRepository.GetAll();
            return _mapper.Map<List<LookUpDto>>(fetchedCategories);
        }
    }
}
