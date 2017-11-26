using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectDockAPP.Entities
{
    
    public class Project
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProjectID { get; set; }
        public string Name { get; set; }
        public string Manager { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
