using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace projet.Controllers
{
    public abstract class projetControllerBase: AbpController
    {
        protected projetControllerBase()
        {
            LocalizationSourceName = projetConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
