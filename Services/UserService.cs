using DataAccessLayer.Interfaces;
using Models;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccessLayer;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using GlobalHelpers.Helpers;
using SharedConfig.Messages;
using SharedConfig.Constants;
using Models.ViewModels;
using System.Security.Claims;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using SharedConfig.Config;

namespace Services
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ISecurityService _securityService;
        private readonly AppConfig _config;
        public UserService(IUnitOfWork UnitOfWork, ISecurityService securityService, AppConfig config)
        {
            _unitOfWork = UnitOfWork;
            _securityService = securityService;
            _config = config;
        }

        public async Task<User> CreateUser(VmUserCreate vmUserCreate)
        {
            #region Validate Username
            User similerUser = await _unitOfWork.UsersRepository.Where(user => user.Username == vmUserCreate.Username).FirstOrDefaultAsync();
            if (similerUser != null)
                throw new AppException(Errors.E_USERNAME_IS_TAKEN, new { vmUserCreate.Username }, AppObjects.USERNAME);
            #endregion

            User user = new()
            {
                Name = vmUserCreate.Name,
                Username = vmUserCreate.Username,
                Email = vmUserCreate.Email,
                MobileNumber = vmUserCreate.MobileNumber,
                Language = vmUserCreate.Language,
                MerchantId = Guid.Parse("4D2E60C5-0843-442D-8FCB-9D620501CF81"),
                UserTypeId = Guid.Parse("9CE8EE94-6C0A-4393-8482-DBECEF2F3190"),
            };
            user.Password = _securityService.CreatePasswordHash(vmUserCreate.Password);
            await _unitOfWork.UsersRepository.AddAsync(user);
            await _unitOfWork.SaveChangesAsync();
            return user;
        }

        public async Task<User> ValidateUserToLogin(string username, string password)
        {
            byte[] passwordHash = _securityService.CreatePasswordHash(password);
            User user = await _unitOfWork.UsersRepository.GetUserByUsernameAndPassword(username, passwordHash);
            
            if (user == null)
                throw new AppException(Errors.E_INVALID_USERNAME_OR_PASSWORD);

            if (!user.IsActive)
                throw new AppException(Errors.E_USER_IS_INACTIVE);

            return user;
        }

        public string GenerateUserToken(User user)
        {
            List<Claim> authClaims = new()
            {
                new Claim(ClaimTypes.Name, user.Username),
                new Claim(JwtRegisteredClaimNames.Jti, user.Id.ToString()),
                new Claim(ClaimTypes.NameIdentifier, user.MerchantId.ToString()),
                new Claim(ClaimTypes.Locality, user.Language.ToString())
                // TODO: inject role here, add list of roles here
                //new Claim(ClaimTypes.Role, user.Role.ToString()),
            };

            SymmetricSecurityKey authSigningKey = new(Encoding.UTF8.GetBytes(_config.JWTConfig.Secret));

            JwtSecurityToken token = new(
                issuer: _config.JWTConfig.ValidIssuer,
                audience: _config.JWTConfig.ValidAudience,
                expires: DateTime.Now.AddHours(_config.JWTConfig.Expires),
                claims: authClaims,
                signingCredentials: new SigningCredentials(authSigningKey, SecurityAlgorithms.HmacSha256)
                );

            string JWTToken = new JwtSecurityTokenHandler().WriteToken(token);
            return JWTToken;
        }
    }
}
