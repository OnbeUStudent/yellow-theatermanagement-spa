using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FakeTheaterBff.Data
{
    public class Movie
    {
        public Guid MovieId { get; set; }

        public virtual ICollection<Booking> Bookings { get; set; }

        public MovieMetadata MovieMetadata { get; set; }

        [Required]
        public string Title { get; set; }
    }
}
