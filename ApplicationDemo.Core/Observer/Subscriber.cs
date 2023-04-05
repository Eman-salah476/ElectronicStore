namespace ApplicationDemo.Core.Observer
{
    public class Subscriber : IObserver
    {
        //Send Notifications to users with the produc updates
        public void Update(IObservable observable )
        {
            Console.WriteLine($"The Device is available now");
        }
    }
}
