using ApplicationDemo.Core.Dtos.LookUp;
using ApplicationDemo.Core.Services.Interfaces;
using ApplicationDemo.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ApplicationDemo.Controllers
{
    [ApiController]
    [Route("api/Property")]
    public class PropertyController : Controller
    {
        private readonly ILookUpService<Property> _lookUpService;
        public PropertyController(ILookUpService<Property> lookUpService)
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
                var fetchedProperties = _lookUpService.GetLookUps();
                return Ok(fetchedProperties);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
