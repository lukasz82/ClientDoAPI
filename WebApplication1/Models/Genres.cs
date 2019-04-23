using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public partial class Genres
    {
        public Genres()
        {
            Movie = new HashSet<Movie>();
        }

        public int GenreId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Movie> Movie { get; set; }
    }
}
