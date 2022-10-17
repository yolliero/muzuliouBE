using Muzuliou.DTOs;

namespace Muzuliou.Services.Interface
{
    public interface IAuthenticationService
    {
        Task<string> Register(RegisterRequest request);
        Task<string> Login(LoginRequest request);
    }
}
