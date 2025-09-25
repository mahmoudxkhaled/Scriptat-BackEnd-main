using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace App.Infrastructure
{
    public class UserTokenService
    {
        private static string Secret = "ERMN05OPLoDvbTTa/QkqLNMI7cPLguaRyHzyg7n5qNBVjQmtBhz4SzYh4NBVCXi3KJHlSXKP+oi2+bXr6CUYTR==";

        private readonly IConfiguration _configuration;

        public UserTokenService(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public string CreateToken(ApplicationUser applicationUser)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name,applicationUser.UserName),
                new Claim(ClaimTypes.NameIdentifier, applicationUser.Id),
                new Claim(ClaimTypes.Email, applicationUser.Email),
            };
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["keyjwt"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.UtcNow.AddMinutes(10),
                SigningCredentials = creds
            };

            var tokenHandler = new JwtSecurityTokenHandler();

            var token = tokenHandler.CreateToken(tokenDescriptor);

            return tokenHandler.WriteToken(token);
        }
        public ClaimsPrincipal GetPrincipal(string token)
        {
            try
            {
                JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();
                JwtSecurityToken jwtToken = (JwtSecurityToken)tokenHandler.ReadToken(token);
                if (jwtToken == null) return null;
                byte[] key = Convert.FromBase64String(Secret);
                TokenValidationParameters parameters = new TokenValidationParameters()
                {
                    ValidateLifetime = true,
                    RequireExpirationTime = true,
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    IssuerSigningKey = new SymmetricSecurityKey(key)
                };
                SecurityToken securityToken;
                ClaimsPrincipal principal = tokenHandler.ValidateToken(token, parameters, out securityToken);
                return principal;
            }
            catch
            {
                return null;
            }
        }

        public string GenerateToken(ApplicationUser applicationUser)
        {
            SymmetricSecurityKey key = new SymmetricSecurityKey(Convert.FromBase64String(Secret));
            SecurityTokenDescriptor tokenDescriptor = new SecurityTokenDescriptor()
            {
                Subject = new ClaimsIdentity((IEnumerable<Claim>)new Claim[1]
              {
          new Claim("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name", applicationUser.Id)
              }),
                Expires = new DateTime?(DateTime.UtcNow.AddDays(15.0)),
                SigningCredentials = new SigningCredentials((SecurityKey)key, "http://www.w3.org/2001/04/xmldsig-more#hmac-sha256"),
                Issuer = "self",
                Audience = "https://scriptat.org"
            };
            JwtSecurityTokenHandler securityTokenHandler = new JwtSecurityTokenHandler();
            return securityTokenHandler.WriteToken((SecurityToken)securityTokenHandler.CreateJwtSecurityToken(tokenDescriptor));
        }

        public string ValidateToken(string token)
        {
            ClaimsPrincipal principal = this.GetPrincipal(token);
            if (principal == null)
                return (string)null;
            ClaimsIdentity identity;
            try
            {
                identity = (ClaimsIdentity)principal.Identity;
            }
            catch (NullReferenceException ex)
            {
                return (string)null;
            }
            return identity.FindFirst("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name").Value;
        }
        public bool IsValid(HttpRequestMessage request)
        {
            bool isvalid = false;
            var headers = request.Headers;
            if (headers.Contains("EmpToken"))
            {
                string token = headers.GetValues("EmpToken").First();
                if (string.IsNullOrEmpty(ValidateToken(token)))
                    isvalid = false;
                else isvalid = true;
            }
            else
            {
                isvalid = false;
            }
            return isvalid;

        }
        public string GetUserId(HttpContext context)
        {
            string header = (string)context.Request.Headers["Authorization"];
            string userId = (string)null;
            if (!string.IsNullOrEmpty(this.ValidateToken(header)))
                userId = this.ValidateToken(header);
            return userId;
        }
        public AspNetUserDevices GenerateUserToken()
        {
            var randomNumber = new byte[32];
            using var rng = RandomNumberGenerator.Create();
            rng.GetBytes(randomNumber);
            return new AspNetUserDevices { TokenKey = Convert.ToBase64String(randomNumber) };
        }
    }
}
