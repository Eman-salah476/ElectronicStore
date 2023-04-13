using ApplicationDemo.Domain.Entities;

namespace ApplicationDemo.Domain.State
{
    public class NewOrderState : IOrderState
    {
        private readonly Order _order;
        public NewOrderState(Order order)
        {
            _order = order;
        }

        public void ProcessOrder()
        {
            _order.Status = Enums.OrderStatus.New;
            _order._state = new ProcessingOrderState(_order);
        }
    }
}
