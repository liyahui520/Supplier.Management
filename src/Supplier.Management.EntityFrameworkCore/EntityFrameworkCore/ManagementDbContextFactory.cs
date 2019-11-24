using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Supplier.Management.Configuration;
using Supplier.Management.Web;

namespace Supplier.Management.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class ManagementDbContextFactory : IDesignTimeDbContextFactory<ManagementDbContext>
    {
        public ManagementDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<ManagementDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            ManagementDbContextConfigurer.Configure(builder, configuration.GetConnectionString(ManagementConsts.ConnectionStringName));

            return new ManagementDbContext(builder.Options);
        }
    }
}
