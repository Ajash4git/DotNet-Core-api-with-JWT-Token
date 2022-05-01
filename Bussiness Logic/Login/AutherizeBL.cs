using Bussines_Entity.Login.Modal;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness_Logic.Login
{
    public class AutherizeBL:IAutherizeBL
    {
        private string appkey;

        public AutherizeBL(string key)
        {
            this.appkey = key;
        }

        public tokenCard CreateJwtToken(userLogin userData)
        {
            try
            {
                var tokenHandler = new JwtSecurityTokenHandler();
                var tokenKey = Encoding.ASCII.GetBytes(appkey);
                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(new Claim[]
                    {
                    new Claim(ClaimTypes.Name, userData.userName)
                    }),
                    Expires = DateTime.UtcNow.AddHours(1),
                    SigningCredentials = new SigningCredentials(
                        new SymmetricSecurityKey(tokenKey),
                        SecurityAlgorithms.HmacSha256Signature
                        )
                };

                var token = tokenHandler.CreateToken(tokenDescriptor);

                return new tokenCard() { jwtToken = tokenHandler.WriteToken(token), refreshToken = "Hardcoded refresh Token", isValid = true };
            }
            catch
            {
                return CreateUnAuthorizedJwtToken();
            }
        }
        public tokenCard CreateUnAuthorizedJwtToken()
        {
            tokenCard tokencrd = new tokenCard();
            tokencrd.jwtToken = "Un Autherized Token";
            tokencrd.refreshToken = "Un Autherized Token";
            tokencrd.isValid = false;
            return tokencrd;
        }
    }
}
