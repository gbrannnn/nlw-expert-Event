using RocketseatAuction.API.Entities;

namespace RocketseatAuction.API.Contarcts;

public interface IUserRepository
{
    bool ExistUserWithEmail(string email);
    User GetUserByEmail(string email);
}
