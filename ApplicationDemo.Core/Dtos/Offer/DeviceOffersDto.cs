using ApplicationDemo.Core.Common.Validations;
using ApplicationDemo.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace ApplicationDemo.Core.Dtos.Offer
{
    public class DeviceOffersDto
    {
        [Required]
        public OfferType Type { get; set; }
        
        [Required]
        [ExpireDateAttribute(ErrorMessage ="Enter date after today")]
        public DateTime ExpireDate { get; set; }
    }
}
