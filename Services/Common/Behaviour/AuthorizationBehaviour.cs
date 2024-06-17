
using Microsoft.AspNetCore.Http;
using Services.IService;
using System.Security.Claims;

namespace Services.Common.Behaviour
{
    public class AuthorizationBehaviour : ICurrentUserService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        public AuthorizationBehaviour(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public string UserId => _httpContextAccessor.HttpContext?.User?.FindFirst(ClaimTypes.NameIdentifier)?.Value;

        public string UserName => _httpContextAccessor.HttpContext?.User?.Identity?.Name;

        public async Task<bool> IsInRoleAsync(string role)
        {
            return _httpContextAccessor.HttpContext?.User?.IsInRole(role) ?? false;
        }

        public async Task<bool> AuthorizeAsync(string policy)
        {
            // Implement policy-based authorization if needed
            return true;
        }
    }
}