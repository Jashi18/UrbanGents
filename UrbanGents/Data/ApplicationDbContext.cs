using Microsoft.EntityFrameworkCore;
using UrbanGents.Models;

namespace UrbanGents.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Shoes"},
                new Category { Id = 2, Name = "T-Shirt" },
                new Category { Id = 3, Name = "Sweater" },
                new Category { Id = 4, Name = "Trousers" }
                );
        }
    }
}
