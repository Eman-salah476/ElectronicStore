using ApplicationDemo.Application.Dtos.LookUps;
using ApplicationDemo.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ApplicationDemo.Controllers
{
    [ApiController]
    [Route("api/Category")]
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
        _categoryService = categoryService;
        }
        [HttpPost]
        public ActionResult Add(CategoryToAddDto categoryToAddDto)
        {
            try
            {
                var isAdded = _categoryService.AddCatgory(categoryToAddDto);
                if (!isAdded)
                    return BadRequest();

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


    }
}
