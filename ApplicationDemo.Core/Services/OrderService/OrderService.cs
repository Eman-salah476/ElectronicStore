using ApplicationDemo.Core.Decorators.OfferDecorator;
using ApplicationDemo.Core.Dtos.Order;
using ApplicationDemo.Domain.Entities;
using ApplicationDemo.Infrastructure.Repositories.GenericRepository;
using Microsoft.EntityFrameworkCore;

namespace ApplicationDemo.Core.Services.OrderService
{
    public class OrderService : IOrderService
    {
        private readonly IGenericRepository<Device> _deviceRepository;
        public OrderService(IGenericRepository<Device> deviceRepository)
        {
            _deviceRepository = deviceRepository;
        }

        //Apply Offers Decorators and calculate total price
        public double CalculateTotalPrice(ItemsToOrderDto itemsToOrderDto)
        {
            double totalPrice = 0;
            var itemsIds = itemsToOrderDto.Items.Select(i => i.ItemId).ToList();
            var fetchedDevices = _deviceRepository.FindByCondition(d => itemsIds.Contains(d.Id),
                                                                    d => d.Include(o => o.Offers));
            foreach (var device in fetchedDevices)
            {
                var itemNumber = itemsToOrderDto.Items.FirstOrDefault(x => x.ItemId == device.Id)?.ItemNumber ?? 1;
                var itemFinalPrice = CalculateItemFinalPrice(device, itemNumber);
                totalPrice += itemFinalPrice;
            }
            return totalPrice;
        }

        #region Helpers
        private double CalculateItemFinalPrice(Device device, int itemNumber)
        {
            var itemPrice = (device.Price * itemNumber) + device.ShippmentPrice;
            IOffer offer = new BaseOffer();

            foreach (var deviceOffer in device.Offers)
            {
                if (IsOfferValid(deviceOffer))
                {
                    switch (deviceOffer.Type)
                    {
                        case Domain.Enums.OfferType.BuyOneGetOneOffer:
                            offer = new BuyOneGetOneOffer(offer);
                            break;
                        case Domain.Enums.OfferType.FreeShippingOffer:
                            offer = new FreeShippingOffer(offer, device.ShippmentPrice);
                            break;
                        case Domain.Enums.OfferType.PercentageOffOffer:
                            offer = new PercentageOffOffer(offer, device.DiscountRatio);
                            break;
                    }
                }
            }
            var itemFinalPrice = offer.ApplyOffer(itemPrice);
            return itemFinalPrice;
        }

        //Validate Offer Proxy
        private bool IsOfferValid(Offer offer)
        {
            if (offer.Active && offer.ExpireDate > DateTime.Now)
                return true;
            return false;
        }
        #endregion



    }
}
