using ApplicationDemo.Domain.Enums;

namespace ApplicationDemo.Application.Dtos.Order
{
    public class OrderToAddDto
    {
        public int UserId { get; set; }
        public OrderStatus Status { get; set; }
        public string Address { get; set; }
    }
}
