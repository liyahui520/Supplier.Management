using System.Threading.Tasks;
using Supplier.Management.Configuration.Dto;

namespace Supplier.Management.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
