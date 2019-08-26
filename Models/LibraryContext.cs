using Microsoft.EntityFrameworkCore;

namespace LibraryApi.Models
{
    public class LibraryContext : DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Copy> Copies { get; set; }
        // public DbSet<Checkout> Checkouts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder
                .UseMySql(@"server=localhost;user id=root;password=epicodus;port=3306;database=library_api;");

        public LibraryContext(DbContextOptions options) : base(options)
        {

        }

        public LibraryContext()
        {

        }
    }
}