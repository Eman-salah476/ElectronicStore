using ApplicationDemo.Core.Dtos.Offer;

namespace ApplicationDemo.Core.Services.Interfaces
{
    public interface IOfferService
    {
        bool AddOffer(OfferToAddDto offerToAddDto);
    }
}
