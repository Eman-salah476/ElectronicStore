using System.ComponentModel.DataAnnotations.Schema;

namespace ApplicationDemo.Domain.Entities
{
    public class DeviceProps
    {
        public Guid Id { get; set; }
        public Guid DeviceId { get; set; }
        public Guid PropertyId { get; set; }
        public string Value { get; set; }

        public Device Device { get; set; }
        public Property Property { get; set; }
    }
}
