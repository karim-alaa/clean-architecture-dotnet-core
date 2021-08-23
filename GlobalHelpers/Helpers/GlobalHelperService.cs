using GlobalHelpers.Interfaces;
using Microsoft.AspNetCore.Http;
using SharedConfig.Constants;
using SharedConfig.Records;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace GlobalHelpers.Helpers
{
    public class GlobalHelperService : IGlobalHelperService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        public GlobalHelperService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }
        public LocalUser GetUserData()
        {
            Guid Id = Guid.Parse(_httpContextAccessor.HttpContext.User.FindFirst(JwtRegisteredClaimNames.Jti).Value.ToString());
            Guid MerchantId = Guid.Parse(_httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value.ToString());
            _ = Enum.TryParse(_httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.Locality).Value.ToString(), out AppLanguages userLang);
            AppLanguages Language = userLang;
            //string Role = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.Role).Value;
            LocalUser localUser = new(Id, MerchantId, Language);
            return localUser;
        }

        public Guid GetUserId()
        {
            return Guid.Parse(_httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value.ToString());
        }
    }
}
