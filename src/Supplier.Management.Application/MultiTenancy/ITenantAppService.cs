using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Supplier.Management.MultiTenancy.Dto;

namespace Supplier.Management.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

