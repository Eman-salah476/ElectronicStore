using ApplicationDemo.Application.Dtos.Offer;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace ApplicationDemo.Application.Dtos.Device
{
    public class DeviceToAddDto
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public double Price { get; set; }
        public bool HasDiscount { get; set; }
        public double DiscountRatio { get; set; }
        [Required]
        public double ShippmentPrice { get; set; }
        [Required]
        public int Code { get; set; }
        public bool Available { get; set; } = true;
        public string Details { get; set; }
        [Required]
        public Guid CategoryId { get; set; }
        [Required]
        public Guid BrandId { get; set; }
        public List<DevicePropsDto> DeviceProps { get; set; }
        public List<DeviceOffersDto> Offers { get; set; }
    }
}
