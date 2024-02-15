namespace RocketseatAuction.API.UseCases.Auction.GetCurrent;

using RocketseatAuction.API.Contarcts;
using RocketseatAuction.API.Entities;

public class GetCurrentAuctionUseCase
{
    private readonly IAuctionRepository _repository;

    public GetCurrentAuctionUseCase(IAuctionRepository repository) => _repository = repository;

    public Auction? Execute()
    {
        return _repository.GetCurrent();    
    }
}

