using System.ComponentModel.DataAnnotations.Schema;

namespace ApplicationDemo.Domain.Entities
{
    public class Device
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public double Price { get; set; }
        public bool HasDiscount { get; set; } = false;
        public double DiscountRatio { get; set; }
        public double ShippmentPrice { get; set; }
        public int Code { get; set; }
        public bool Available { get; set; }
        public string Details { get; set; }
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        [ForeignKey("Brand")]
        public int BrandId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public Category Category { get; set; }
        public Brand Brand { get; set; }
        public List<DeviceProps> DeviceProps { get; set; }
        public List<Offer> Offers { get; set; } = new List<Offer>();


    }
}
