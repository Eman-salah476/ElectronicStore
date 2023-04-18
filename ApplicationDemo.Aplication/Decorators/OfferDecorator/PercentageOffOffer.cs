namespace ApplicationDemo.Application.Decorators.OfferDecorator
{
    public class PercentageOffOffer : OfferDecorator
    {
        private double percentage;
        public PercentageOffOffer(IOffer offer, double percentage) : base(offer)
        {
            this.percentage = percentage;
        }

        public override double ApplyOffer(double price)
        {
            return base.ApplyOffer(price) * (1 - percentage / 100);
        }


    }
}
