namespace ApplicationDemo.Application.Observer
{
    public interface IObservable
    {
        bool UpdateStatus(Guid deviceId, bool available);
        void NotifySubscribers();
        bool AddSubscriber(Subscriber subscriber);

    }
}
