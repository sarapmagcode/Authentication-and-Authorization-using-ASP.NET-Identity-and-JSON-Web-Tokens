using AuthDemo.Models;

namespace AuthDemo.Services
{
    public interface IAuthService
    {
        Task<bool> Login(LoginUser user);
        Task<bool> RegisterUser(LoginUser user);
        string GenerateTokenService(LoginUser user);
    }
}