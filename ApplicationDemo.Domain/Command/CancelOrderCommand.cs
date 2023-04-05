using ApplicationDemo.Domain.Entities;

namespace ApplicationDemo.Domain.Command
{
    public class CancelOrderCommand : IOrderCommand
    {
        private readonly Order _order;
        public CancelOrderCommand(Order order)
        {
            _order = order;
        }

        public void Execute()
        {
            _order.Cancel();
        }

        public void Undo()
        {
            _order.UndoCancel();
        }
    }
}
