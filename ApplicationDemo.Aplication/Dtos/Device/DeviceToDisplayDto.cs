﻿namespace ApplicationDemo.Application.Dtos.Device
{
    public class DeviceToDisplayDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public bool HasDiscount { get; set; }
        public double DiscountRatio { get; set; }
        public double ShippmentPrice { get; set; }
        public int Code { get; set; }
        public bool Available { get; set; }
        public string Details { get; set; }
        public string BrandName { get; set; }

        public List<DevicePropsDto> DeviceProps { get; set; }
    }
}
