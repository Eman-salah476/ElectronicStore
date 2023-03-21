using ApplicationDemo.Domain.Entities.Base;

namespace ApplicationDemo.Domain.Entities
{
    public class Property : ILookUpBase
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
       
        public List<CategoryProps> CategoryProps { get; set; }
        public List<DeviceProps> DeviceProps { get; set; }


    }
}
