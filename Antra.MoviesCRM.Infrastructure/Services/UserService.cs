using Antra.MoviesCRM.Core.Contracts.Repository;
using Antra.MoviesCRM.Core.Contracts.Services;
using Antra.MoviesCRM.Core.Models;
using Microsoft.AspNetCore.Identity;

namespace Antra.MoviesCRM.Infrastructure.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository;

        public UserService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }
        public Task<SignInResult> Login(UserLoginModel model)
        {
            return this.userRepository.Login(model);
        }

        public Task<IdentityResult> SignUp(UserSignUpModel model)
        {
            return userRepository.SignUp(model);
        }
    }
}
