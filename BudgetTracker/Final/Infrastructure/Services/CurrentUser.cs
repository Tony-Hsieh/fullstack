using System;
using System.Linq;
using System.Security.Claims;
using Microsoft.AspNetCore.Http;
using ApplicationCore.ServiceInterfaces;

namespace Infrastructure.Services
{
    
    public class CurrentUser: ICurrentUserService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        public CurrentUser(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }
        public int UserId => Convert.ToInt32(_httpContextAccessor.HttpContext?.User?.FindFirst(ClaimTypes.NameIdentifier)?.Value);
        public bool IsAuthenticated => _httpContextAccessor.HttpContext.User.Identity.IsAuthenticated;
        public string FullName => _httpContextAccessor.HttpContext?.User?.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Surname)?.Value;
        public string Email => _httpContextAccessor.HttpContext?.User?.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Email).Value;
        
    }
}