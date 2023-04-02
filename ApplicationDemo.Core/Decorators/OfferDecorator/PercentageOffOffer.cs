namespace ApplicationDemo.Core.Decorators.OfferDecorator
{
    public class PercentageOffOffer : OfferDecorator
    {
        private double percentage;
        public PercentageOffOffer(IOffer offer, double percentage) : base(offer)
        {
            this.percentage = percentage;
        }

        public double ApplyOffer(double price)
        {
            return base.ApplyOffer(price) * (1 - percentage / 100);
        }


    }
}
