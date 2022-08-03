using Antra.MoviesCRM.Core.Contracts.Repository;
using Antra.MoviesCRM.Core.Entities;
using Antra.MoviesCRM.Core.Models;
using Microsoft.AspNetCore.Identity;

namespace Antra.MoviesCRM.Infrastructure.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly UserManager<User> _userManager;
        public UserRepository(UserManager<User> userManager)
        {
            _userManager = userManager;
        }

        public Task<int> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<User>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<User> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public int GetCount()
        {
            throw new NotImplementedException();
        }

        public Task<int> InsertAsync(User entity)
        {
            throw new NotImplementedException();
        }

        public Task<IdentityResult> SignUp(UserSignUpModel model)
        {
            User user = new()
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Email = model.Email,
                UserName = model.Email
            };

            return _userManager.CreateAsync(user, model.Password);
        }

        public Task<int> UpdateAsync(User entity)
        {
            throw new NotImplementedException();
        }
    }
}
