using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectDock.Models;

namespace ProjectDock.Controllers
{
    [Produces("application/json")]
    [Route("api/Projects")]
    public class ProjectsController : Controller
    {
        // private readonly
        static List<Project> projects = new List<Project>{
                new Project
                {
                    name = "GitHub",
                    description = "The Sourse storage website."
                },
                new Project
                {
                    name = "Electron",
                    description = "Cross platform for web applications..."
                }

            };

        [HttpGet]
        public IEnumerable<Project> Get()
        {
            return projects;
            
        }

        [HttpGet("{name}")]
        public IEnumerable<Project> Get(string name)
        {
            return projects.FindAll(projects => projects.name == name);

        }

        [HttpPost]
        public Project Post([FromBody] Project project)
        {
            projects.Add(project);
            return project;
        }
    }
}