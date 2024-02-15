using RocketseatAuction.API.Entities;

namespace RocketseatAuction.API.Contarcts;

public interface IAuctionRepository
{
    Auction? GetCurrent();
}
