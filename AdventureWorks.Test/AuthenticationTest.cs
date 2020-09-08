using AdventureWorks.Business.Mapping;
using AdventureWorks.Business.Services;
using AdventureWorks.Common.Configuration;
using AdventureWorks.Common.Interface;
using AdventureWorks.Common.Model;
using AdventureWorks.Data.Entity;
using AdventureWorks.Data.Repositories;
using AutoMapper;
using Microsoft.Extensions.Options;
using Moq;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace AdventureWorks.Test
{
    public class AuthenticationTest
    {
        private readonly IAuthenticationService _authenticationService;

        public AuthenticationTest()
        {
            //auto mapper configuration
            var mockMapper = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(typeof(MapperProfile));
            });
            var mapper = mockMapper.CreateMapper();

            var appSettings = new AppSettings
            {
                SecretKey = "AdventureWorksSecretMockedKey",
                MinutesToExpireToken = 15
            };

            Mock<IOptions<AppSettings>> mockOptions = new Mock<IOptions<AppSettings>>();
            mockOptions.Setup(s => s.Value).Returns(appSettings);

            const int id = 1;
            const string password = "password@123";
            const string email = "sanchez.franco@gmail.com";

            var person =
                new Person
                {
                    BusinessEntityId = id,
                    Rowguid = Guid.NewGuid(),
                    FirstName = "Jorge",
                    LastName = "Sanchez",
                    Password = new Password
                    {
                        BusinessEntityId = id,
                        PasswordSalt = password
                    },
                    EmailAddress = new List<EmailAddress>
                    {
                        new EmailAddress
                        {
                            BusinessEntityId = id,
                            EmailAddress1 = email
                        }
                    }
                };

            Mock<IPersonRepository> mockPersonRepository = new Mock<IPersonRepository>();
            mockPersonRepository.Setup(s => s.GetPerson(email, password)).Returns(Task.FromResult(person));

            _authenticationService = new AuthenticationService(mapper, mockOptions.Object, mockPersonRepository.Object);
        }

        [Fact]
        public void Authenticate_Valid()
        {
            var authenticateRequest = new AuthenticateRequest
            {
                Email = "sanchez.franco@gmail.com",
                Password = "password@123"
            };

            var response = _authenticationService.Authenticate(authenticateRequest).Result;

            Assert.NotNull(response);
            Assert.NotNull(response.JwtToken);
        }

        [Fact]
        public void Authenticate_Invalid()
        {
            var authenticateRequest = new AuthenticateRequest
            {
                Email = "sanchez.franco@gmail.com",
                Password = "password@12345"
            };

            var response = _authenticationService.Authenticate(authenticateRequest).Result;

            Assert.Null(response);
        }
    }
}
