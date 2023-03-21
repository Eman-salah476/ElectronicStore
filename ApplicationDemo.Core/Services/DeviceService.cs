using ApplicationDemo.Core.Dtos.Device;
using ApplicationDemo.Core.Services.Interfaces;
using ApplicationDemo.Domain.Entities;
using ApplicationDemo.Infrastructure.Repositories.GenericRepository;
using AutoMapper;

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

            var isAdded = _genericRepository.Add(device);
            return isAdded;
        }

        public DeviceToDisplayDto GetDevice(Guid id)
        {
            var fetchedDevice = _genericRepository.GetById(id);
            if (fetchedDevice is null)
                return null;
            var devicetoDisplay = _mapper.Map<DeviceToDisplayDto>(fetchedDevice);
            return devicetoDisplay;
        }

        public List<DeviceToDisplayDto> GetDevices(FilterationCriteria filterationCriteria)
        {
            var fetchedDeviced = _genericRepository.GetAll();
            if (fetchedDeviced is null || fetchedDeviced.Count == 0)
                return null;
            var devicesToDisplay = _mapper.Map<List<DeviceToDisplayDto>>(fetchedDeviced);
            return devicesToDisplay;
        }
    }
}
