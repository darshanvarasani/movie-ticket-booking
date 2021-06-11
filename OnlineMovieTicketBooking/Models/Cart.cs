using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMovieTicketBooking.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public string SeatNo { get; set; }
        public string UserId { get; set; }
        public DateTime date { get; set; }
        public int Amount { get; set; }
        public int MovieId { get; set; }

    }
}
