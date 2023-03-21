using ApplicationDemo.Domain.Entities.Base;

namespace ApplicationDemo.Domain.Entities
{
    public class Brand : ILookUpBase
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public List<Device> Devices { get; set; }
        public List<CategoryBrands> CategoryBrands { get; set; }

    }
}
