using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Supplier.Management.Configuration;

namespace Supplier.Management.Web.Host.Startup
{
    [DependsOn(
       typeof(ManagementWebCoreModule))]
    public class ManagementWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public ManagementWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ManagementWebHostModule).GetAssembly());
        }
    }
}
