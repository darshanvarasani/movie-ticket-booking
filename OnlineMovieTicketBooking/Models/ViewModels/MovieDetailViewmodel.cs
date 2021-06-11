using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMovieTicketBooking.Models.ViewModels
{
    public class MovieDetailViewmodel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DateofMovie { get; set; }
        public string MoviePicture { get; set; }
    }
}
