using ProjectDockAPP.data.Models;
using ProjectDockAPP.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectDockAPP.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ProjectContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Projects.Any())
            {
                return;   // DB has been seeded
            }

            var projects = new Project[]
            {
            new Project{Name="Carson",Manager="Alexander",DateCreated=DateTime.Parse("2005-09-01")},
            new Project{Name="Meredith",Manager="Alonso",DateCreated=DateTime.Parse("2002-09-01")},
            new Project{Name="Arturo",Manager="Anand",DateCreated=DateTime.Parse("2003-09-01")},
            new Project{Name="Gytis",Manager="Barzdukas",DateCreated=DateTime.Parse("2002-09-01")},
            new Project{Name="Yan",Manager="Li",DateCreated=DateTime.Parse("2002-09-01")},
            new Project{Name="Peggy",Manager="Justice",DateCreated=DateTime.Parse("2001-09-01")},
            new Project{Name="Laura",Manager="Norman",DateCreated=DateTime.Parse("2003-09-01")},
            new Project{Name="Nino",Manager="Olivetto",DateCreated=DateTime.Parse("2005-09-01")}
            };
            foreach (Project p in projects)
            {
                context.Projects.Add(p);
            }
            context.SaveChanges();

        }

    }
}
