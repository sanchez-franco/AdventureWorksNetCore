using AdventureWorks.Business.Mapping;
using AdventureWorks.Business.Services;
using AdventureWorks.Common.Interface;
using AdventureWorks.Data.Entity;
using AdventureWorks.Data.Repositories;
using AutoMapper;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace AdventureWorks.Test
{
    public class PersonTest
    {
        private readonly IPersonService _personService;

        public PersonTest()
        {
            //auto mapper configuration
            var mockMapper = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(typeof(MapperProfile));
            });
            var mapper = mockMapper.CreateMapper();

            const int id = 1;
            IList<BusinessEntity> entities = new List<BusinessEntity>();

            for(int i = 0; i < 10; i++)
            {
                var internalId = id + i;

                var businessEntity = new BusinessEntity
                                    {
                                        BusinessEntityId = internalId,
                                        Rowguid = Guid.NewGuid(),
                                        Person = new Person
                                        {
                                            BusinessEntityId = internalId,
                                            FirstName = $"Jorge ({internalId})",
                                            MiddleName = "Ivan",
                                            LastName = "Sanchez"
                                        },
                                        BusinessEntityAddress = new List<BusinessEntityAddress>
                                        {
                                            new BusinessEntityAddress
                                            {
                                                Address =
                                                    new Address
                                                    {
                                                        AddressLine1 = "Line 1",
                                                        AddressLine2 = "Line 2",
                                                        City = "Tijuana",
                                                        PostalCode = "22200",
                                                        StateProvince = new StateProvince
                                                        {
                                                            Name = "Baja California"
                                                        }
                                                    },
                                                AddressType =
                                                    new AddressType
                                                    {
                                                        Name = "Home"
                                                    }
                                            }
                                        }
                                    };

                entities.Add(businessEntity);
            }

            Mock<IPersonRepository> mockPersonRepository = new Mock<IPersonRepository>();
            mockPersonRepository.Setup(s => s.GetPersonDetail(id)).Returns(Task.FromResult(entities.SingleOrDefault(b => b.BusinessEntityId == id)));
            mockPersonRepository.Setup(s => s.GetPersonDetails()).Returns(Task.FromResult(entities));

            _personService = new PersonService(mapper, mockPersonRepository.Object);
        }

        [Fact]
        public void GetPersonDetail_Valid()
        {
            const int personId = 1;

            var response = _personService.GetPersonDetail(personId).Result;

            Assert.NotNull(response);
        }

        [Fact]
        public void GetPersonDetail_Invalid()
        {
            const int personId = 0;

            var response = _personService.GetPersonDetail(personId).Result;

            Assert.Null(response);
        }

        [Fact]
        public void GetPersonDetails_Valid()
        {
            var response = _personService.GetPersonDetails().Result;

            Assert.NotNull(response);
        }
    }
}
