using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace ProjectDock.Controllers
{
    public abstract class ProjectDockControllerBase: AbpController
    {
        protected ProjectDockControllerBase()
        {
            LocalizationSourceName = ProjectDockConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}