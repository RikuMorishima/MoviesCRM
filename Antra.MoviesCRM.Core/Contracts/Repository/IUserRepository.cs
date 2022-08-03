using Antra.MoviesCRM.Core.Entities;
using Antra.MoviesCRM.Core.Models;
using Microsoft.AspNetCore.Identity;

namespace Antra.MoviesCRM.Core.Contracts.Repository
{
    public interface IUserRepository : IRepositoryAsync<User>
    {
        Task<IdentityResult> SignUp(UserSignUpModel model);

    }
}
