using AdventureWorks.Common.Model;
using AdventureWorks.Data.Entity;
using AutoMapper;
using System.Linq;

namespace AdventureWorks.Business.Mapping
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Person, AuthenticateResponse>()
                .ForMember(a => a.Id, p => p.MapFrom(l => l.BusinessEntityId))
                .ForMember(a => a.UserId, p => p.MapFrom(l => l.Rowguid))
                .AfterMap((p, a) =>
                {
                    var email = p.EmailAddress.FirstOrDefault();
                    if(email != null)
                    {
                        a.UserName = email.EmailAddress1;
                    }
                });

            CreateMap<BusinessEntity, PersonDetail>()
                .ForMember(p => p.FirstName, b => b.MapFrom(l => l.Person.FirstName))
                .ForMember(p => p.MiddleName, b => b.MapFrom(l => l.Person.MiddleName))
                .ForMember(p => p.LastName, b => b.MapFrom(l => l.Person.LastName))
                .AfterMap((b, p) =>
                {
                    var businessEntityAddress = b.BusinessEntityAddress.FirstOrDefault();
                    if (businessEntityAddress != null)
                    {
                        var address = businessEntityAddress.Address;
                        if (address != null)
                        {
                            p.AddressLine1 = address.AddressLine1;
                            p.AddressLine2 = address.AddressLine2;
                            p.City = address.City;
                            p.ZipCode = address.PostalCode;
                            p.State = address.StateProvince?.Name;
                        }

                        p.AddressType = businessEntityAddress.AddressType?.Name;
                    }
                });
        }
    }
}
