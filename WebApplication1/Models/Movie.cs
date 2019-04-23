using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Models
{
    public partial class Movie
    {
        public Movie()
        {
            Reservation = new HashSet<Reservation>();
            Reviews = new HashSet<Reviews>();
        }

        public int MovieId { get; set; }
        public int AuthorId { get; set; }
        public int GenreId { get; set; }
        public string MovieDescription { get; set; }
        public DateTime ProductionDate { get; set; }
        public string Title { get; set; }

        public virtual Author Author { get; set; }
        public virtual Genres Genre { get; set; }
        public virtual RentMovie RentMovie { get; set; }
        public virtual ICollection<Reservation> Reservation { get; set; }
        public virtual ICollection<Reviews> Reviews { get; set; }
    }
}