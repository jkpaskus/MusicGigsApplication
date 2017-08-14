using System;
using System.ComponentModel.DataAnnotations;

namespace MusicGigApplication.Models
{
    public class Gig
    {
        //Properties gathered from requirements document.
        public int ID { get; set; }

        [Required]
        public ApplicationUser Artist { get; set; }

        public DateTime DateTime { get; set; }

        [Required]
        [StringLengthAttribute(255)]
        public string Venue { get; set; }

        [Required]
        public Genre Genre { get; set; }


    }
}