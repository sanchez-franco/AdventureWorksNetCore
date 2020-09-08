using AdventureWorks.Common.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AdventureWorks.Common.Interface
{
    public interface IPersonService
    {
        Task<PersonDetail> GetPersonDetail(int personId);
        Task<IList<PersonDetail>> GetPersonDetails();
    }
}
