using ProjectDock.Configuration;
using ProjectDock.Web;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace ProjectDock.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class ProjectDockDbContextFactory : IDesignTimeDbContextFactory<ProjectDockDbContext>
    {
        public ProjectDockDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<ProjectDockDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            ProjectDockDbContextConfigurer.Configure(builder, configuration.GetConnectionString(ProjectDockConsts.ConnectionStringName));

            return new ProjectDockDbContext(builder.Options);
        }
    }
}