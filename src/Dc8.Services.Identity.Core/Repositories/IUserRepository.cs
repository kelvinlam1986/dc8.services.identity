using Dc8.Services.Identity.Core.Entities;
using System;
using System.Threading.Tasks;

namespace Dc8.Services.Identity.Core.Repositories
{
    public interface IUserRepository
    {
        Task<User> GetAsync(Guid id);
        Task<User> GetAsync(string email);
        Task AddAsync(User user);
    }
}
