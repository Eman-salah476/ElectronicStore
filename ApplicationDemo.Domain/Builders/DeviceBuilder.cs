using ApplicationDemo.Domain.Entities;

namespace ApplicationDemo.Domain.Builders
{
    public class DeviceBuilder
    {
        private Device _device;

        public DeviceBuilder(Device device)
        {
            _device = device;
        }

        public DeviceBuilder SetDiscount(double discount)
        {
            _device.HasDiscount = true;
            _device.DiscountRatio = discount;
            _device.Offers.Add(new Offer
            {
                Active = true,
                Type = Enums.OfferType.PercentageOffOffer,
                CreatedAt = DateTime.Now
            });
            return this;
        }

        public Device Build()
        {
            return _device;
        }
    }
}
