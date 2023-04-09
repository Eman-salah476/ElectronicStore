using ApplicationDemo.Domain.Command;
using ApplicationDemo.Domain.Enums;
using ApplicationDemo.Domain.State;
using System.ComponentModel.DataAnnotations.Schema;

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
       
        //Command
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

        //State 
        [NotMapped]
        public IOrderState _state;
        public Order()
        {
            _state = new NewOrderState(this);
        }

        public void Process()
        {
            _state.ProcessOrder();
        }

        public void SetState(IOrderState state)
        {
            _state = state;
        }


    }
}
