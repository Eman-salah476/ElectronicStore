namespace ApplicationDemo.Core.Decorators.OfferDecorator
{
    public class BuyOneGetOneOffer : OfferDecorator
    {
        public BuyOneGetOneOffer(IOffer offer) : base(offer)
        {
        }

        public override double ApplyOffer(double price)
        {
            return base.ApplyOffer(price) * 0.5;
        }
    }
}
