namespace ApplicationDemo.Core.Decorators.OfferDecorator
{
    public class FreeShippingOffer : OfferDecorator
    {
        private double shippmentPrice;
        public FreeShippingOffer(IOffer offer, double shippmentPrice) : base(offer)
        {
            this.shippmentPrice = shippmentPrice;
        }

        public override double ApplyOffer(double price)
        {
            return base.ApplyOffer(price) - shippmentPrice;
        }

    }
}
