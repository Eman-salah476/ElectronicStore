using ApplicationDemo.Core.Dtos.LookUp;
using ApplicationDemo.Core.Services.Interfaces;
using ApplicationDemo.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ApplicationDemo.Controllers
{
    [ApiController]
    [Route("api/Category")]
    public class CategoryController : Controller
    {
        private readonly ILookUpService<Category> _lookUpService;
        public CategoryController(ILookUpService<Category> lookUpService)
        {
            _lookUpService = lookUpService;
        }
        [HttpPost]
        public ActionResult Add(LookUpToAdd lookUpToAdd)
        {
            try
            {
                var isAdded = _lookUpService.AddLookUp(lookUpToAdd);
                if (!isAdded)
                    return BadRequest();

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public ActionResult Get()
        {
            try
            {
                var fetchedCategories = _lookUpService.GetLookUps();
                return Ok(fetchedCategories);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


    }
}
