using ApplicationDemo.Domain.Entities;

namespace ApplicationDemo.Domain.State
{
    public class ProcessingOrderState : IOrderState
    {
        private readonly Order _order;
        public ProcessingOrderState(Order order)
        {
            _order = order;
        }

        public void ProcessOrder()
        {
            _order.Status = Enums.OrderStatus.Processing;
            _order._state = new ShippedOrderState(_order);
        }
    }
}
