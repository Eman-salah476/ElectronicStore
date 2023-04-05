namespace ApplicationDemo.Core.Observer
{
    public class Subscriber : IObserver
    {
        //Send Notifications to users with the produc updates
        public void Update(Guid deviceId)
        {
            Console.WriteLine($"The Device is available now");
        }
    }
}
