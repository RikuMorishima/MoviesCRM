using Antra.MoviesCRM.Core.Contracts.Repository;
using Antra.MoviesCRM.Core.Contracts.Services;
using Antra.MoviesCRM.Core.Models;
using Microsoft.AspNetCore.Identity;

namespace Antra.MoviesCRM.Infrastructure.Services
{
    public class AccountService : IAccountService
    {
        private readonly IUserRepository accountRepository;

        public AccountService(IUserRepository accountRepository)
        {
            this.accountRepository = accountRepository;
        }

        public Task<SignInResult> Login(UserLoginModel model)
        {
            return this.accountRepository.Login(model);
        }

        public Task<IdentityResult> SignUp(UserSignUpModel model)
        {
            return this.accountRepository.SignUp(model);
        }


    }
}
