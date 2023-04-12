using ApplicationDemo.Domain.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApplicationDemo.Domain.Entities
{
    public class Offer
    {
        public Guid Id { get; set; }
        public Guid DeviceId { get; set; }
        public OfferType Type { get; set; }
        public bool Active { get; set; } = true;
        public DateTime ExpireDate { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public Device Device { get; set; }
    }
}
