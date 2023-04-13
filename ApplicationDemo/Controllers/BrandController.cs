using ApplicationDemo.Application.Dtos.LookUp;
using ApplicationDemo.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ApplicationDemo.Controllers
{
    [ApiController]
    [Route("api/Brand")]
    public class BrandController : Controller
    {
        private readonly ILookUpService _lookUpService;
        public BrandController(ILookUpService lookUpService)
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

    }
}
