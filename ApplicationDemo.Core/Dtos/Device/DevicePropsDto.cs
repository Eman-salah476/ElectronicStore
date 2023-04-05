using System.ComponentModel.DataAnnotations;

namespace ApplicationDemo.Core.Dtos.Device
{
    public class DevicePropsDto
    {
        [Required]
        public Guid PropertyId { get; set; }
        public string PropertyName { get; set; }
        [Required]
        public string Value { get; set; }
    }
}
