using System;
using System.ComponentModel.DataAnnotations;

namespace MusicGigApplication.Models
{
    public class Gig
    {
        //Properties gathered from requirements document.
        public int ID { get; set; }

        
        public ApplicationUser Artist { get; set; }

        [Required]
        public string ArtistId { get; set; }

        public DateTime DateTime { get; set; }

        [Required]
        [StringLengthAttribute(255)]
        public string Venue { get; set; }

        
        public Genre Genre { get; set; }

        [Required]
        public byte GenreId { get; set; }


    }
}