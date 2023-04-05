using ApplicationDemo.Domain.Enums;

namespace ApplicationDemo.Core.Dtos.Offer
{
    public class OfferToAddDto
    {
        public Guid DeviceId { get; set; }
        public OfferType Type { get; set; }
        public DateTime ExpireDate { get; set; }
    }
}
