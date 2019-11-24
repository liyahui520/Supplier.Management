using System.Threading.Tasks;
using Abp.Application.Services;
using Supplier.Management.Sessions.Dto;

namespace Supplier.Management.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
