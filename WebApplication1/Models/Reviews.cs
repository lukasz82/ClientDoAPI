using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public partial class Reviews
    {
        public int ReviewId { get; set; }
        public int MovieId { get; set; }
        public string Review { get; set; }
        public int Rate { get; set; }

        public virtual Movie Movie { get; set; }
    }
}
