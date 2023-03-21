using ApplicationDemo.Core.Dtos.Device;
using ApplicationDemo.Core.Dtos.LookUp;
using ApplicationDemo.Domain.Entities;
using AutoMapper;

namespace ApplicationDemo.Core.Helpers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Category, LookUpDto>().ReverseMap();
            CreateMap<Brand, LookUpDto>().ReverseMap();
            CreateMap<Property, LookUpDto>().ReverseMap();

            CreateMap<DeviceToAddDto, Device>();
            CreateMap<Device, DeviceToDisplayDto>();
        }
    }
}
