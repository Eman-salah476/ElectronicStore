namespace ApplicationDemo.Application.Decorators.OfferDecorator
{
    public abstract class OfferDecorator : IOffer
    {
        protected IOffer _offer;
        public OfferDecorator(IOffer offer)
        {
            _offer = offer;
        }

        public virtual double ApplyOffer(double price)
        {
            return _offer.ApplyOffer(price);       
        }
    }
}
