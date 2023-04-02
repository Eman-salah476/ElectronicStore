using ApplicationDemo.Core.Dtos.Order;

namespace ApplicationDemo.Core.Services.OrderService
{
    public interface IOrderService
    {
        double CalculateTotalPrice(ItemsToOrderDto itemsToOrderDto);
    }
}
