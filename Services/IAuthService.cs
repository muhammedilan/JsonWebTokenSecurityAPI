using JsonWebTokenSecurityAPI.Entities;
using JsonWebTokenSecurityAPI.Models;

namespace JsonWebTokenSecurityAPI.Services
{
    public interface IAuthService
    {
        Task<User?> RegisterAsync(UserDto request);
        Task<TokenResponseDto?> LoginAsync(UserDto request);
        Task<TokenResponseDto?> RefreshTokenAsync(RefreshTokenRequestDto request);
    }
}
