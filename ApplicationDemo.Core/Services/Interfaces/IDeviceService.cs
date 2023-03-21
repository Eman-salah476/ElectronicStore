using ApplicationDemo.Core.Dtos.Device;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationDemo.Core.Services.Interfaces
{
    public interface IDeviceService
    {
        bool AddDevice(DeviceToAddDto deviceToAddDto);
        List<DeviceToDisplayDto> GetDevices(FilterationCriteria filterationCriteria);
        DeviceToDisplayDto GetDevice(Guid id);
    }
}
