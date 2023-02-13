using System.Security.Claims;

namespace JwtWebApiTut.Services.UserService
{
    public class UserService : IUserService
    {
        private readonly IHttpContextAccessor _httpContext;

        //we need the http context for this
        public UserService(IHttpContextAccessor httpContext)
        {
            _httpContext = httpContext;
        }
        public string GetMyName()
        {
            string result=string.Empty;
            if (_httpContext.HttpContext != null) {
                result = _httpContext.HttpContext.User.FindFirstValue(ClaimTypes.Name);
            }
            return result;
        }
    }
}
