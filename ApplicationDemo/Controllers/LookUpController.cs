using ApplicationDemo.Core.Dtos.LookUp;
using ApplicationDemo.Core.Services;
using ApplicationDemo.Core.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ApplicationDemo.Controllers
{
    [ApiController]
    [Route("api/LookUp")]
    public class LookUpController : Controller
    {
        public ActionResult Add(LookUpToAdd lookUpToAdd)
        {
            try
            {
                ILookUpService lookUpService = null;
     
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
