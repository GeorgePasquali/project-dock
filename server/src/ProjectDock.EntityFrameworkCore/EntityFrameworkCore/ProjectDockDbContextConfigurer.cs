using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace ProjectDock.EntityFrameworkCore
{
    public static class ProjectDockDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<ProjectDockDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<ProjectDockDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}