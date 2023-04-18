using ApplicationDemo.Domain.Entities;

namespace ApplicationDemo.Domain.State
{
    public class ShippedOrderState : IOrderState
    {
        private readonly Order _order;
        public ShippedOrderState(Order order)
        {
            _order = order;
        }
        public void ProcessOrder()
        {
            _order.Status = Enums.OrderStatus.Shipped;
            _order._state = new DeliveredOrderState(_order);
        }
    }
}
