namespace RocketseatAuction.API.UseCases.Offers.CreateOffer;

using RocketseatAuction.API.Communication.Requests;
using RocketseatAuction.API.Contarcts;
using RocketseatAuction.API.Entities;
using RocketseatAuction.API.Srevices;

public class CreateOfferUseCase
{
    private readonly ILoggedUser _loggedUser;
    private readonly IOfferRepository _repository;

    public CreateOfferUseCase(ILoggedUser loggedUser, IOfferRepository repository) 
    { 
        _loggedUser = loggedUser;
        _repository = repository;
    }

    public int Execute(int itemId, RequestCreatOfferJson requet)
    {
    
        var user = _loggedUser.User();

        var offer = new Offer
        {
            CreatedOn = DateTime.Now,
            ItemId = itemId,
            Price = requet.Price,
            UserId = user.Id,
        };

        _repository.Add(offer);

        return offer.Id;
    }
}
