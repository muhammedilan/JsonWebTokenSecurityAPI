using JsonWebTokenSecurityAPI.Entities;
using JsonWebTokenSecurityAPI.Models;

namespace JsonWebTokenSecurityAPI.Services
{
    public interface IAuthService
    {
        Task<User?> RegisterAsync(UserDto request);
        Task<string?> LoginAsync(UserDto Request);
    }
}
