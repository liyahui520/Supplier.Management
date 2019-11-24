using Abp.Authorization;
using Supplier.Management.Authorization.Roles;
using Supplier.Management.Authorization.Users;

namespace Supplier.Management.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
