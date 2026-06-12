using ECommerce.Business.DTOs; 

namespace ECommerce.Business.Interfaces
{
    public interface IAuthService
    {
            Task<AuthResponseDto> RegisterAsync(RegisterRequestDto request);
        Task<AuthResponseDto> LoginAsync(LoginRequestDto request);
    }
}