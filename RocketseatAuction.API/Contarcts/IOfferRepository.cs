using RocketseatAuction.API.Entities;

namespace RocketseatAuction.API.Contarcts;

public interface IOfferRepository
{
    void Add(Offer offer);
}
