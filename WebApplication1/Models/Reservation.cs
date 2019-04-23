using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public partial class Reservation
    {
        public int ReservationId { get; set; }
        public bool IsReserved { get; set; }
        public int MovieId { get; set; }
        public DateTime ReservedDate { get; set; }
        public int ReservedDays { get; set; }

        public virtual Movie Movie { get; set; }
    }
}
