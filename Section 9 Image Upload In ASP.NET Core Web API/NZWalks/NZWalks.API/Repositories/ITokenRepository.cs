using Microsoft.AspNetCore.Identity;

namespace NZWalks.API.Repositories
{
    public interface ITokenRepository
    {
        string CreateJWT(IdentityUser user, List<string> roles);
    }
}
