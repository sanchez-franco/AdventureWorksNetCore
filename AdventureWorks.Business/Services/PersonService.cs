using AdventureWorks.Common.Interface;
using AdventureWorks.Common.Model;
using AdventureWorks.Data.Repositories;
using AutoMapper;
using System.Threading.Tasks;

namespace AdventureWorks.Business.Services
{
    public class PersonService : BaseService, IPersonService
    {
        private readonly IPersonRepository _personRepository;

        public PersonService(IMapper mapper, IPersonRepository personRepository) : base(mapper)
        {
            _personRepository = personRepository;
        }

        public async Task<PersonDetail> GetPersonDetail(int personId)
        {
            var businessEntity = await _personRepository.GetPersonDetail(personId);
            // return null if user not found
            if (businessEntity == null) return null;

            return Mapper.Map<PersonDetail>(businessEntity);
        }
        public async Task<PersonDetail[]> GetPersonDetails()
        {
            var businessEntities = await _personRepository.GetPersonDetails();
            // return null if user not found
            if (businessEntities == null) return null;

            return Mapper.Map<PersonDetail[]>(businessEntities);
        }
    }
}