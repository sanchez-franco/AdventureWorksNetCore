using AdventureWorks.Common.Configuration;
using AdventureWorks.Common.Interface;
using AdventureWorks.Common.Model;
using AdventureWorks.Data.Entity;
using AdventureWorks.Data.Repositories;
using AutoMapper;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace AdventureWorks.Business.Services
{
    public class AuthenticationService : BaseService, IAuthenticationService
    {
        private readonly IPersonRepository _personRepository;
        private readonly AppSettings _appSettings;

        public AuthenticationService(IMapper mapper, IOptions<AppSettings> appSettings, IPersonRepository personRepository) : base(mapper)
        {
            _appSettings = appSettings.Value;
            _personRepository = personRepository;
        }

        public async Task<AuthenticateResponse> Authenticate(AuthenticateRequest authenticateRequest)
        {
            var person = await _personRepository.GetPerson(authenticateRequest.Email, authenticateRequest.Password);

            // return null if user not found
            if (person == null) return null;

            // authentication successful so generate jwt and refresh tokens
            var jwtToken = GenerateJwtToken(person);

            var authenticateResponse = Mapper.Map<AuthenticateResponse>(person);
            authenticateResponse.JwtToken = jwtToken;

            return authenticateResponse;
        }

        private string GenerateJwtToken(Person person)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.SecretKey);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.NameIdentifier, person.BusinessEntityId.ToString()),
                    new Claim(ClaimTypes.NameIdentifier, person.FullName)
                }),
                Expires = DateTime.UtcNow.AddMinutes(_appSettings.MinutesToExpireToken),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);

            return tokenHandler.WriteToken(token);
        }
    }
}
