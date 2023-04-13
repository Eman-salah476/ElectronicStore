using ApplicationDemo.Core.Dtos.Device;

namespace ApplicationDemo.Core.Services.Interfaces
{
    public interface IDeviceService
    {
        bool AddDevice(DeviceToAddDto deviceToAddDto);
        List<DeviceToDisplayDto> GetDevices(FilterationCriteria filterationCriteria);
        DeviceToDisplayDto GetDevice(Guid id);
        bool UpdatePrice(DevicePriceToUpdateDto devicePriceToUpdate);
    }
}
