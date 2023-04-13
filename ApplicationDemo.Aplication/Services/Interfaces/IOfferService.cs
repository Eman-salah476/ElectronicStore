using ApplicationDemo.Application.Dtos.Offer;

namespace ApplicationDemo.Application.Services.Interfaces
{
    public interface IOfferService
    {
        bool AddOffer(OfferToAddDto offerToAddDto);
    }
}
