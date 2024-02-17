using System.ComponentModel.DataAnnotations;

namespace MIssion06_Bassett.Models
{
    public class Movie
    {
        [Key]
        [Required]
        public int movieID { get; set;  }
        [Required]
        public required string title { get; set; }
        [Required]
        public required int year { get; set; }
        [Required]
        public required string director { get; set; }
        [Required]
        public required string category { get; set; }
        [Required]
        public required string rating { get; set; }

        public bool edited {  get; set; }

        public string? lentTo { get; set; }
        [MaxLength(25)]
        public string? notes { get; set; }

    }
}
