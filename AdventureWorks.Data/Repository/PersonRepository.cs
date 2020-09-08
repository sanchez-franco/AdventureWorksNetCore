using AdventureWorks.Common.Interface;
using AdventureWorks.Data.Context;
using AdventureWorks.Data.Entity;
using AdventureWorks.Data.Repository;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdventureWorks.Data.Repositories
{
    public interface IPersonRepository : IRepository<Person>
    {
        Task<BusinessEntity> GetPersonDetail(int personId);
        Task<IList<BusinessEntity>> GetPersonDetails();
        Task<Person> GetPerson(string emailAddress, string passwordSalt);
        Task<IList<BusinessEntityAddress>> GetPersonAddresses(int personId);
    }

    public class PersonRepository : Repository<Person>, IPersonRepository
    {
        public PersonRepository(AdventureWorksContext dbContext) : base(dbContext)
        {
        }

        //Let's assume that we "encrypt" to match the password in the DB
        public async Task<Person> GetPerson(string emailAddress, string passwordSalt)
        {
            var entity = await DbContext.Set<EmailAddress>()
                .Include(r => r.BusinessEntity)
                .SingleOrDefaultAsync(r => r.EmailAddress1 == emailAddress && r.BusinessEntity.Password.PasswordSalt == passwordSalt);

            return entity?.BusinessEntity;
        }

        public async Task<BusinessEntity> GetPersonDetail(int personId)
        {
            return await DbContext.Set<BusinessEntity>()
                .Include(r => r.Person)
                .Include(r => r.BusinessEntityAddress)
                    .ThenInclude(r => r.Address)
                    .ThenInclude(r => r.StateProvince)
                .Include(r => r.BusinessEntityAddress)
                    .ThenInclude(r => r.AddressType)
                .SingleOrDefaultAsync(r => r.Person.BusinessEntityId == personId);
        }

        public async Task<IList<BusinessEntity>> GetPersonDetails()
        {
            return await DbContext.Set<BusinessEntity>()
                .Include(r => r.Person)
                .Include(r => r.BusinessEntityAddress)
                    .ThenInclude(r => r.Address)
                    .ThenInclude(r => r.StateProvince)
                .Include(r => r.BusinessEntityAddress)
                    .ThenInclude(r => r.AddressType)
                .Take(10)
                .ToListAsync();
        }

        public async Task<IList<BusinessEntityAddress>> GetPersonAddresses(int personId)
        {
            return await DbContext.Set<BusinessEntityAddress>()
                .Include(r => r.Address)
                .Include(r => r.Address.StateProvince)
                .Include(r => r.AddressType)
                .Where(r => r.BusinessEntityId == personId)
                .ToListAsync();
        }
    }
}
