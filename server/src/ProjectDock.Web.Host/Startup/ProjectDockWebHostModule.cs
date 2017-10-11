using System.Reflection;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ProjectDock.Configuration;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace ProjectDock.Web.Host.Startup
{
    [DependsOn(
       typeof(ProjectDockWebCoreModule))]
    public class ProjectDockWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public ProjectDockWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ProjectDockWebHostModule).GetAssembly());
        }
    }
}
