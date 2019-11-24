using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Supplier.Management.Configuration.Dto;

namespace Supplier.Management.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : ManagementAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
