namespace RocketseatAuction.API.UseCases.Auction.GetCurrent;

using Microsoft.EntityFrameworkCore;
using RocketseatAuction.API.Entities;
using RocketseatAuction.API.Repositories;

public class GetCurrentAuctionUseCase
{
    public Auction? Execute()
    {
        var repository = new RocketseatAuctionDbContext();

        var today = new DateTime(2024, 05, 01);

        return repository
            .Auctions
            .Include(auction => auction.Items)
            .FirstOrDefault(auction => today >= auction.Starts && today <= auction.Ends);
    }
}

