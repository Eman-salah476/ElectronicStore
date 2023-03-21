using ApplicationDemo.Core.Dtos.LookUp;
using ApplicationDemo.Core.Services.Interfaces;
using ApplicationDemo.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ApplicationDemo.Controllers
{
    [ApiController]
    [Route("api/Brand")]
    public class BrandController : Controller
    {
        private readonly ILookUpService<Brand> _lookUpService;
        public BrandController(ILookUpService<Brand> lookUpService)
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
                var fetchedBrands = _lookUpService.GetLookUps();
                return Ok(fetchedBrands);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
