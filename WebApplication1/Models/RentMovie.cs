using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public partial class RentMovie
    {
        public int RentMovieId { get; set; }
        public float DayRentPrice { get; set; }
        public bool IsRent { get; set; }
        public int MovieId { get; set; }
        public DateTime RentDate { get; set; }
        public int RentDays { get; set; }

        public virtual Movie Movie { get; set; }
    }
}
