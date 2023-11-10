using Abp.Authorization;
using projet.Authorization.Roles;
using projet.Authorization.Users;

namespace projet.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
