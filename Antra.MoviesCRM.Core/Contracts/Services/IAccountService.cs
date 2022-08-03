using Antra.MoviesCRM.Core.Models;
using Microsoft.AspNetCore.Identity;

namespace Antra.MoviesCRM.Core.Contracts.Services
{
    public interface IAccountService
    {
        Task<IdentityResult> SignUpAsync(UserSignUpModel model);
    }
}
