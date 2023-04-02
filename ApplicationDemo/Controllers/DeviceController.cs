using ApplicationDemo.Core.Dtos.Device;
using ApplicationDemo.Core.Services.DeviceService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace ApplicationDemo.Controllers
{
    [ApiController]
    [Route("api/Device")]
    public class DeviceController : Controller
    {
        private readonly IDeviceService _deviceService;
        public DeviceController(IDeviceService deviceService)
        {
            _deviceService = deviceService;
        }


        [HttpPost("GetAll")]
        public ActionResult Get(FilterationCriteria filterationCriteria)
        {
            try
            {
                var fetchedDevices = _deviceService.GetDevices(filterationCriteria);
                if (fetchedDevices == null)
                    return BadRequest();

                return Ok(fetchedDevices);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public ActionResult GetDevice(Guid id)
        {
            try
            {
                var fetchedDevice = _deviceService.GetDevice(id);
                if (fetchedDevice is null)
                    return BadRequest();

                return Ok(fetchedDevice);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public ActionResult AddDevice([FromForm] DeviceToAddDto deviceToAddDto)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState.Select(x => x.Value.Errors).ToList());

                var isAdded = _deviceService.AddDevice(deviceToAddDto);
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
