using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using TouchHope.Business.StringInfos;
using TouchHope.Entities.Concrete;

namespace TouchHope.Business.Utilities.Jwt
{
    public class JwtManager : IJwtService
    {
        public JwtToken GenerateToken(Kullanici kullanici, List<Rol> roller)
        {
            SymmetricSecurityKey securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(JwtInfo.SecurityKey));

            SigningCredentials signingCredentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            JwtSecurityToken token = new JwtSecurityToken(issuer: JwtInfo.Issuer, audience: JwtInfo.Audience,
                notBefore: DateTime.Now, expires: DateTime.Now.AddMinutes(JwtInfo.TokenExpiration),
                signingCredentials: signingCredentials, claims: SetClaims(kullanici, roller));

            JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();

            JwtToken jwtToken = new JwtToken();
            jwtToken.Token = handler.WriteToken(token);

            return jwtToken;
        }

        private List<Claim> SetClaims(Kullanici kullanici, List<Rol> roller)
        {
            List<Claim> claims = new List<Claim>();

            claims.Add(new Claim(ClaimTypes.NameIdentifier, kullanici.Id.ToString()));
            claims.Add(new Claim(ClaimTypes.Name, kullanici.KullaniciAd));

            if(roller!=null)
            {
                foreach (var rol in roller)
                {
                    claims.Add(new Claim(ClaimTypes.Role, rol.Ad));
                }
            }

            return claims;
        }
    }
}
