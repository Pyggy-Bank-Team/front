using System.Threading.Tasks;
using Funtik.Models.Services;
using Funtik.Models.Services.Responses;

namespace Funtik.Interfaces
{
    public interface IIdentityService
    {
        Task<bool> RegistrationUser(UserModel user);

        Task<TokenResponse> GetToken(UserModel user);
    }
}