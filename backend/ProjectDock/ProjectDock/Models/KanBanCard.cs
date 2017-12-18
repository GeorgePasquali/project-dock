using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectDock.Models
{
    public class KanBanCard
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public int BoardId { get; set; }
        public KanBanBoard Board { get; set; }
    }
}
