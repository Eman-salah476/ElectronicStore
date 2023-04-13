using ApplicationDemo.Application.Dtos.LookUps;

namespace ApplicationDemo.Application.Services.Interfaces
{
    public interface ICategoryService
    {
        bool AddCatgory(CategoryToAddDto categoryToAddDto);
    }
}
