using Abp.Application.Services.Dto;

namespace Supplier.Management.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

