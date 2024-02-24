using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        [Range(1888, int.MaxValue)]
        public required int year { get; set; }
        
        public string? director { get; set; }
        
        [ForeignKey("categoryID")]
        public int? categoryID { get; set; }
        public Category? Category { get; set; }

        
        public string? rating { get; set; }
        [Required]
        public bool edited {  get; set; }
        [Required]
        public bool copiedToPlex { get; set; }
        public string? lentTo { get; set; }
        [MaxLength(25)]
        public string? notes { get; set; }

    }
}
