using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectDock.Models
{
    public class KanBanBoard
    {   

        public int Id { get; set; }
        public string Url { get; set; }

        public List<KanBanCard> Cards { get; set; }
    }
}
