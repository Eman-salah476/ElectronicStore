using ApplicationDemo.Domain.Command;
using ApplicationDemo.Domain.Enums;

namespace ApplicationDemo.Domain.Entities
{
    public class Order
    {
        public Guid Id { get; set; }
        public int UserId { get; set; }
        public OrderStatus Status { get; set; }
        public string Address { get; set; }
        public DateTime CretaedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public void Cancel()
        {
            this.Status = OrderStatus.Cancelled;
        }

        public void UndoCancel()
        {
            this.Status = OrderStatus.Pending;
        }

        public void ExcuteCommand(IOrderCommand command)
        {
            command.Execute();
        }
    }
}
