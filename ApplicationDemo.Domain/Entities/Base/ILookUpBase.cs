namespace ApplicationDemo.Domain.Entities.Base
{
    public interface ILookUpBase
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
