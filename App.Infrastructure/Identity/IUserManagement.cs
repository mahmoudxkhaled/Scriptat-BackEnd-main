
using App.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace App.Infrastructure
{
    public interface IUserManagement
    {
        IEnumerable<IdentityUser> GetAllUsers();
        Task<ApiResult> Login(LoginDto Input);
        Task<ApiResult> Register(RegisterDto Input);
        Task<UserDto> GetCurrentUser();


        Task<SignInResult> UserLogin(LoginDto Input);

        Task<IdentityUser> GetUserByName(LoginDto Input);

        ClaimsPrincipal GetPrincipal(string token);

        string GenerateToken(string UserId);

        string ValidateToken(string token);

        bool IsValid(HttpRequestMessage request);

        string GetUserId(HttpContext request);
    }
}
