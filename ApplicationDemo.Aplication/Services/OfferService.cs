using ApplicationDemo.Application.Dtos.Offer;
using ApplicationDemo.Application.Services.Interfaces;
using ApplicationDemo.Domain.Entities;
using ApplicationDemo.Domain.Repositories;
using AutoMapper;

namespace ApplicationDemo.Application.Services
{
    public class OfferService : IOfferService
    {
        private readonly IGenericRepository<Offer> _offerRepository;
        private readonly IMapper _mapper;
        public OfferService(IGenericRepository<Offer> offerRepository, IMapper mapper)
        {
            _offerRepository = offerRepository;
            _mapper = mapper;
        }

        public bool AddOffer(OfferToAddDto offerToAddDto)
        {
            var offer = _mapper.Map<Offer>(offerToAddDto);
            if (offer is null)
                return false;
            var isAdded = _offerRepository.Add(offer);
            return isAdded;
        }
    }
}
