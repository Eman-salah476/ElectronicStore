namespace ApplicationDemo.Core.Decorators.OfferDecorator
{
    public class BaseOffer : IOffer
    {
        public double ApplyOffer(double price)
        {
            return price;
        }
    }
}
