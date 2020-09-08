using AdventureWorks.Common.Model;
using System.Threading.Tasks;

namespace AdventureWorks.Common.Interface
{
    public interface IAuthenticationService
    {
        Task<AuthenticateResponse> Authenticate(AuthenticateRequest authenticateRequest);
    }
}
