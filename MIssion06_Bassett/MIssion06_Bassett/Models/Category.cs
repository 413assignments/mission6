using System.ComponentModel.DataAnnotations;

namespace MIssion06_Bassett.Models
{
    public class Category
    {
        [Key]
        [Required]
        public int categoryID { get; set; }

        public string categoryName { get; set; }
    }
}
