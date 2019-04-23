using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public partial class Author
    {
        public Author()
        {
            Movie = new HashSet<Movie>();
        }

        public int AuthorId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public virtual ICollection<Movie> Movie { get; set; }
    }
}
