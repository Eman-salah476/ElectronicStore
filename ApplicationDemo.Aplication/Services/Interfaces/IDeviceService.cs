using ApplicationDemo.Application.Dtos.Device;

namespace ApplicationDemo.Application.Services.Interfaces
{
    public interface IDeviceService
    {
        bool AddDevice(DeviceToAddDto deviceToAddDto);
        List<DeviceToDisplayDto> GetDevices(FilterationCriteria filterationCriteria);
        DeviceToDisplayDto GetDevice(Guid id);
        bool UpdatePrice(DevicePriceToUpdateDto devicePriceToUpdate);
    }
}
