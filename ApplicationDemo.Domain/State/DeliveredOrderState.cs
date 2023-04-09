using ApplicationDemo.Domain.Entities;

namespace ApplicationDemo.Domain.State
{
    public class DeliveredOrderState : IOrderState
    {
        private readonly Order _order;
        public DeliveredOrderState(Order order)
        {
            _order = order;
        }

        public void ProcessOrder()
        {
            _order.Status = Enums.OrderStatus.Delivered;
        }
    }
}
