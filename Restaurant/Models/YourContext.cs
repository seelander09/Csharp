using Microsoft.EntityFrameworkCore;

namespace Restaurant.Models
{
    public class YourContext : DbContext
    {
        // base() calls the parent class' constructor passing the "options" parameter along
        public DbSet<Review> reviews { get; set; }
        public YourContext(DbContextOptions<YourContext> options) : base(options) { }
    }
}
