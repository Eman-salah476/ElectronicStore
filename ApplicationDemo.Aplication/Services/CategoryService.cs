using ApplicationDemo.Application.Dtos.LookUp;
using ApplicationDemo.Application.Dtos.LookUps;
using ApplicationDemo.Application.Services.Interfaces;
using ApplicationDemo.Domain.Entities;
using ApplicationDemo.Domain.Repositories;
using AutoMapper;

namespace ApplicationDemo.Application.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly IGenericRepository<Category> _genericRepository;
        private readonly IMapper _mapper;
        public CategoryService(IGenericRepository<Category> genericRepository, IMapper mapper)
        {
            _genericRepository = genericRepository;
            _mapper = mapper;
        }

        public bool AddCatgory(CategoryToAddDto categoryToAddDto)
        {
            var category = _mapper.Map<Category>(categoryToAddDto);
            return _genericRepository.Add(category);
        }

        public List<LookUpDto> GetLookUps()
        {
            var fetchedCategories = _genericRepository.GetAll();
            return _mapper.Map<List<LookUpDto>>(fetchedCategories);
        }
    }
}
