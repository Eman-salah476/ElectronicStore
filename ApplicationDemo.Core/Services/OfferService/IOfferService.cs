using ApplicationDemo.Core.Dtos.Offer;

namespace ApplicationDemo.Core.Services.OfferService
{
    public interface IOfferService
    {
        bool AddOffer(OfferToAddDto offerToAddDto);
    }
}
