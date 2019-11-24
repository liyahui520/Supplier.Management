using System.Threading.Tasks;
using Abp.Application.Services;
using Supplier.Management.Authorization.Accounts.Dto;

namespace Supplier.Management.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
