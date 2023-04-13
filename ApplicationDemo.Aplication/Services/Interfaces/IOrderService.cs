using ApplicationDemo.Application.Dtos.Order;

namespace ApplicationDemo.Application.Services.Interfaces
{
    public interface IOrderService
    {
        double CalculateTotalPrice(ItemsToOrderDto itemsToOrderDto);
        bool UpdateOrder(Guid id);
        bool Add(OrderToAddDto orderToAddDto);
    }
}
