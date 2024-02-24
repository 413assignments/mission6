using Microsoft.EntityFrameworkCore;

namespace MIssion06_Bassett.Models
{
    public class MoviesContext : DbContext
    {
        public MoviesContext(DbContextOptions<MoviesContext> options) : base (options) 
        {
        }

        public DbSet<Movie> Movies { get; set; } 

        public DbSet<Category> Categories { get; set; }


        
    }
}
