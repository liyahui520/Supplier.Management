using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Supplier.Management.Authorization.Roles;
using Supplier.Management.Authorization.Users;
using Supplier.Management.MultiTenancy;
using Supplier.Management.Test;

namespace Supplier.Management.EntityFrameworkCore
{
    public class ManagementDbContext : AbpZeroDbContext<Tenant, Role, User, ManagementDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public ManagementDbContext(DbContextOptions<ManagementDbContext> options)
            : base(options)
        {
        }
        public DbSet<test> Test { get; set; }
    }
}
