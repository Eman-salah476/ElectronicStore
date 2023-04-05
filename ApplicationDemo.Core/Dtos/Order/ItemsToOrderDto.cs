namespace ApplicationDemo.Core.Dtos.Order
{
    public class ItemsToOrderDto
    {
        public List<Item> Items { get; set; }

    }

    public class Item
    {
        public Guid ItemId { get; set; }
        public int ItemNumber { get; set; }
    }
}
