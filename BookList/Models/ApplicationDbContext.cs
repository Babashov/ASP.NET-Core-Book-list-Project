using Microsoft.EntityFrameworkCore;

namespace BookList.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<Users> Userss { get; set; }
    }
}
