using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Supplier.Management.Roles.Dto;
using Supplier.Management.Users.Dto;

namespace Supplier.Management.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
