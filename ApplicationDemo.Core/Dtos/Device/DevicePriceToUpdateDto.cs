namespace ApplicationDemo.Core.Dtos.Device
{
    public class DevicePriceToUpdateDto
    {
        public Guid Id { get; set; }
        public double Price { get; set; }
        public bool SetDiscount { get; set; }
        public double DiscountRatio { get; set; }
    }
}
