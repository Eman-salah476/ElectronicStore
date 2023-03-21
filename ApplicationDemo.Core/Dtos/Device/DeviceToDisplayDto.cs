namespace ApplicationDemo.Core.Dtos.Device
{
    public class DeviceToDisplayDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public double Price { get; set; }
        public int Code { get; set; }
        public bool Available { get; set; }
        public string Details { get; set; }
        public string BrandName { get; set; }

        public List<DevicePropsDto> DeviceProps { get; set; }
    }
}
