namespace ApplicationDemo.Core.Observer
{
    public interface IObserver
    {
        void Update(IObservable observable);
    }
}