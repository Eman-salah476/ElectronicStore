using ApplicationDemo.Core.Dtos.Device;
using ApplicationDemo.Core.Services.Interfaces;
using ApplicationDemo.Domain.Builders;
using ApplicationDemo.Domain.Entities;
using ApplicationDemo.Infrastructure.Repositories.GenericRepository;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace ApplicationDemo.Core.Services
{
    public class DeviceService : IDeviceService
    {
        private readonly IGenericRepository<Device> _genericRepository;
        private readonly IMapper _mapper;
        public DeviceService(IGenericRepository<Device> genericRepository, IMapper mapper)
        {
            _genericRepository = genericRepository;
            _mapper = mapper;
        }

        public bool AddDevice(DeviceToAddDto deviceToAddDto)
        {
            var device = _mapper.Map<Device>(deviceToAddDto);
            if (deviceToAddDto.HasDiscount)
            {
                var deviceBuilder = new DeviceBuilder(device);
                device = deviceBuilder.SetDiscount(deviceToAddDto.DiscountRatio)
                                      .Build();
            }
            var isAdded = _genericRepository.Add(device);
            return isAdded;
        }

        public DeviceToDisplayDto GetDevice(Guid id)
        {
            var fetchedDevice = _genericRepository.GetById(id);
            //var fetchedDevice2 = _genericRepository.FindByCondition(x=>x.Id == id, 
            //     i => i.Include(a => a.DeviceProps).ThenInclude(f => f.Property));
            if (fetchedDevice is null)
                return null;
            var devicetoDisplay = _mapper.Map<DeviceToDisplayDto>(fetchedDevice);
            return devicetoDisplay;
        }

        public List<DeviceToDisplayDto> GetDevices(FilterationCriteria filterationCriteria)
        {
            var fetchedDeviced = _genericRepository.GetAll();
            if (fetchedDeviced is null)
                return null;
            var devicesToDisplay = _mapper.Map<List<DeviceToDisplayDto>>(fetchedDeviced);
            return devicesToDisplay;
        }

        public bool UpdatePrice(DevicePriceToUpdateDto devicePriceToUpdate)
        {
            var fetchedDevice = _genericRepository.GetById(devicePriceToUpdate.Id);
            if (fetchedDevice is null)
                return false;


            if (devicePriceToUpdate.SetDiscount)
            {
                var deviceBuilder = new DeviceBuilder(fetchedDevice);
                fetchedDevice = deviceBuilder.SetDiscount(devicePriceToUpdate.DiscountRatio)
                                             .Build();
            }
            else
            {
                fetchedDevice.Price = devicePriceToUpdate.Price;
            }

            var isUpdated = _genericRepository.Update(fetchedDevice);
            return isUpdated;
        }

    }
}
