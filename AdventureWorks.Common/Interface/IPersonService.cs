using AdventureWorks.Common.Model;
using System.Threading.Tasks;

namespace AdventureWorks.Common.Interface
{
    public interface IPersonService
    {
        Task<PersonDetail> GetPersonDetail(int personId);
        Task<PersonDetail[]> GetPersonDetails();
    }
}
