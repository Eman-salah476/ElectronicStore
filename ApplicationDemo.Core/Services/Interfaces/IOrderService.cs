using ApplicationDemo.Core.Dtos.Order;

namespace ApplicationDemo.Core.Services.Interfaces
{
    public interface IOrderService
    {
        double CalculateTotalPrice(ItemsToOrderDto itemsToOrderDto);
        bool UpdateOrder(Guid id);
        bool Add(OrderToAddDto orderToAddDto);
    }
}
