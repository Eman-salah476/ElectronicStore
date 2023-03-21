using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace ApplicationDemo.Core.Dtos.Device
{
    public class DeviceToAddDto
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public IFormFile Image { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public int Code { get; set; }
        public bool Available { get; set; } = true;
        public string Details { get; set; }
        [Required]
        public int CategoryId { get; set; }
        [Required]
        public int BrandId { get; set; }
        public List<DevicePropsDto> DeviceProps { get; set; }
    }
}
