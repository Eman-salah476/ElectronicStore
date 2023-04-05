namespace ApplicationDemo.Core.Observer
{
    public interface IObservable
    {
        bool UpdateStatus(Guid deviceId, bool available);
        void NotifySubscribers(Guid id);
        bool AddSubscriber();

    }
}
