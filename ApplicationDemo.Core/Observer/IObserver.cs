namespace ApplicationDemo.Core.Observer
{
    public interface IObserver
    {
        void Update(Guid deviceId);
    }
}