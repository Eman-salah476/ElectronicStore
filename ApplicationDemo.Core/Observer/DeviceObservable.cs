using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationDemo.Core.Observer
{
    public class DeviceObservable : IObservable
    {
        public bool AddSubscriber()
        {
            throw new NotImplementedException();
        }

        public void NotifySubscribers(Guid id)
        {
            throw new NotImplementedException();
        }

        public bool UpdateStatus(Guid deviceId, bool available)
        {
            throw new NotImplementedException();
        }
    }
}
