using Antra.MoviesCRM.Core.Models;
using Microsoft.AspNetCore.Identity;

namespace Antra.MoviesCRM.Core.Contracts.Services
{
    public interface IUserService
    {
        Task<IdentityResult> SignUp(UserSignUpModel model);
        Task<SignInResult> Login(UserLoginModel model);
    }
}
