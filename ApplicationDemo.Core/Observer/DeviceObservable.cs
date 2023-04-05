using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationDemo.Core.Observer
{
    public class DeviceObservable : IObservable
    {
        private readonly List<Subscriber> _subscribers = new List<Subscriber>();
        public DeviceObservable( List<Subscriber> subscribers)
        {
            _subscribers = subscribers;
        }

        //Add Users to subscribe 
        public bool AddSubscriber(Subscriber subscriber)
        {
            _subscribers.Add(subscriber);
            return true;
        }

        public void NotifySubscribers()
        {
            foreach (var subscriber in _subscribers)
            {
                subscriber.Update(this);
            }
        }

        public bool UpdateStatus(Guid deviceId, bool available)
        {
            //Get Device

            //Update Device Status

            NotifySubscribers();
            return true;
        }
    }
}
