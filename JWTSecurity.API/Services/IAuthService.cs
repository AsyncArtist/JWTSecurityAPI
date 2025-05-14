
using JWTSecurity.API.Entities;
using JWTSecurity.API.Models;

namespace JWTSecurity.API.Services;
public interface IAuthService
{
    Task<User?> RegisterAsync(UserDto request);
    Task<TokenResponseDto?> LoginAsync(UserDto request);
    Task<TokenResponseDto?> RefreshTokenAsync(RefreshTokenRequestDto request);
}