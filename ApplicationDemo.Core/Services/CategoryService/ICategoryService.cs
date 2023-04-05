using ApplicationDemo.Core.Dtos.LookUps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationDemo.Core.Services.CategoryService
{
    public interface ICategoryService
    {
        bool AddCatgory(CategoryToAddDto categoryToAddDto);
    }
}
