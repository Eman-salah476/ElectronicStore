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

            CreateMap<DeviceToAddDto, Device>()
                .AfterMap((src, dest) => dest.CreatedAt = DateTime.Now);
            CreateMap<Device, DeviceToDisplayDto>();
        }
    }
}
