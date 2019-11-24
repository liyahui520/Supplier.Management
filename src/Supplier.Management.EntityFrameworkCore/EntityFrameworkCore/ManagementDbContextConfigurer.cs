using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Supplier.Management.EntityFrameworkCore
{
    public static class ManagementDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<ManagementDbContext> builder, string connectionString)
        {
            builder.UseMySql(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<ManagementDbContext> builder, DbConnection connection)
        {
            builder.UseMySql(connection);
        }
    }
}
