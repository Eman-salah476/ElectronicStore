using ApplicationDemo.Core.Decorators.OfferDecorator;
using ApplicationDemo.Core.Dtos.Order;
using ApplicationDemo.Core.Services.Interfaces;
using ApplicationDemo.Domain.Command;
using ApplicationDemo.Domain.Entities;
using ApplicationDemo.Domain.Enums;
using ApplicationDemo.Infrastructure.Repositories.GenericRepository;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace ApplicationDemo.Core.Services
{
    public class OrderService : IOrderService
    {
        private readonly IGenericRepository<Device> _deviceRepository;
        private readonly IGenericRepository<Order> _orderRepository;
        private readonly IMapper _mapper;
        public OrderService(IGenericRepository<Device> deviceRepository, IGenericRepository<Order> orderRepository,
                            IMapper mapper)
        {
            _deviceRepository = deviceRepository;
            _orderRepository = orderRepository;
            _mapper = mapper;
        }

        public bool Add(OrderToAddDto orderToAddDto)
        {
            var order = _mapper.Map<Order>(orderToAddDto);
            return _orderRepository.Add(order);
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

        //Call Command for order status
        public bool UpdateOrder(Guid id)
        {
            var fetchedOrder = _orderRepository.GetById(id);
            if (fetchedOrder is null)
                return false;

            IOrderCommand command = new CancelOrderCommand(fetchedOrder);
            fetchedOrder.ExcuteCommand(command);

            var isUpdated = _orderRepository.Update(fetchedOrder);
            return isUpdated;
        }


        #region Helpers
        //Decorator
        private double CalculateItemFinalPrice(Device device, int itemNumber)
        {
            var itemPrice = device.Price * itemNumber + device.ShippmentPrice;
            IOffer offer = new BaseOffer();

            foreach (var deviceOffer in device.Offers)
            {
                if (IsOfferValid(deviceOffer))
                {
                    switch (deviceOffer.Type)
                    {
                        case OfferType.BuyOneGetOneOffer:
                            offer = new BuyOneGetOneOffer(offer);
                            break;
                        case OfferType.FreeShippingOffer:
                            offer = new FreeShippingOffer(offer, device.ShippmentPrice);
                            break;
                        case OfferType.PercentageOffOffer:
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
