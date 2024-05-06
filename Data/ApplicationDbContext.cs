using Microsoft.EntityFrameworkCore;
using MyFirstProject.Models;

namespace MyFirstProject.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
            
        }
        public DbSet<Book> Book { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasData(
                new Book { Id=1, Author="ajith", Description="this is science book", Title="dynamics"},
                new Book { Id = 2, Author = "pathmanathan", Description = "this is physics book", Title = "mechanics" },
                new Book { Id = 3, Author = "kumaran", Description = "this is chemistry book", Title = "organnic" },
                new Book { Id = 4, Author = "kenthiran", Description = "this is arts book", Title = "shadow" },
                new Book { Id = 5, Author = "lathusan", Description = "this is mathematics book", Title = "frame" });
        }
    }
}
