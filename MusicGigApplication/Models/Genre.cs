using System.ComponentModel.DataAnnotations;

namespace MusicGigApplication.Models
{
    public class Genre
    {
        public byte ID { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }
    }
}