using API_Training_WFM.Abstractions;
using API_Training_WFM.Models;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;

namespace API_Training_WFM.Services
{
    public class UsersService : IUsersService
    {
        private readonly WFMDbContext _wfmDbContext;
        public UsersService(WFMDbContext wfmDbContext)
        {
            _wfmDbContext = wfmDbContext;
        }

        public AuthenticateResponse Authenticate(AuthenticateRequest model)
        {
            var user = _wfmDbContext.Users.SingleOrDefault(x => x.username == model.Username && x.password == model.Password);
            if (user == null) return null;
            var token = generateJwtToken(user);
            return new AuthenticateResponse(user, token);
        }

        public Users GetByUsername(string username)
        {
            var result = _wfmDbContext.Users.FirstOrDefault(x => x.username == username);
            return result;
        }

        private string generateJwtToken(Users user)
        {
            // generate token that is valid for 7 days
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes("This is my first Security key and hope this is enough to create jwt token");
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[] { new Claim("id", user.username) }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}
