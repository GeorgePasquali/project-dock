using Abp.Authorization;
using ProjectDock.Authorization.Roles;
using ProjectDock.Authorization.Users;

namespace ProjectDock.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
