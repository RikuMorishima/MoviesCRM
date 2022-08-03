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

        public Task<IdentityResult> SignUpAsync(UserSignUpModel model)
        {
            return accountRepository.SignUp(model);
        }
    }
}
