namespace ApplicationDemo.Application.Observer
{
    public interface IObserver
    {
        void Update(IObservable observable);
    }
}