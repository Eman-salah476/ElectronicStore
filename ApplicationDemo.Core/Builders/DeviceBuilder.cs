using ApplicationDemo.Domain.Entities;

namespace ApplicationDemo.Core.Builders
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
            var priceAfterDiscount = _device.Price - (_device.Price * discount / 100);
            _device.HasDiscount = true;
            _device.DiscountPrice = priceAfterDiscount;
            return this;
        }

        public Device Build()
        {
            return _device;
        }
    }
}
