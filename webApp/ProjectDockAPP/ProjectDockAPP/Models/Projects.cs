using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectDockAPP.data.Models
{
    public class Projects
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateCreated { get; set; }
        public string Manager { get; set; }
        // public ICollection<User> Users { get; set; }
    }
}
