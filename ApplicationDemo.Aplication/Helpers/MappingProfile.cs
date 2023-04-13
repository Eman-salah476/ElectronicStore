using ApplicationDemo.Application.Dtos.Device;
using ApplicationDemo.Application.Dtos.LookUp;
using ApplicationDemo.Application.Dtos.LookUps;
using ApplicationDemo.Application.Dtos.Offer;
using ApplicationDemo.Application.Dtos.Order;
using ApplicationDemo.Domain.Entities;
using AutoMapper;

namespace ApplicationDemo.Application.Helpers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CategoryToAddDto,Category>();
            CreateMap<Category, LookUpDto>().ReverseMap();
            CreateMap<Brand, LookUpDto>().ReverseMap();
            CreateMap<LookUpToAdd, Brand>();
            CreateMap<Property, LookUpDto>().ReverseMap();

            CreateMap<DeviceToAddDto, Device>()
                .AfterMap((src, dest) => dest.CreatedAt = DateTime.Now);
            CreateMap<Device, DeviceToDisplayDto>();
            CreateMap<DevicePropsDto, DeviceProps>();

            CreateMap<OfferToAddDto, Offer>()
                .AfterMap((src, dest) => dest.CreatedAt = DateTime.Now);
            CreateMap<DeviceOffersDto, Offer>()
                     .AfterMap((src, dest) => dest.CreatedAt = DateTime.Now);

            CreateMap<OrderToAddDto, Order>()
                  .AfterMap((src, dest) => dest.CretaedAt = DateTime.Now);

        }
    }
}
