using AutoMapper;
namespace AdventureWorks.Business.Services
{
    public class BaseService
    {
        protected readonly IMapper Mapper;

        public BaseService(IMapper mapper)
        {
            Mapper = mapper;
        }
    }
}
