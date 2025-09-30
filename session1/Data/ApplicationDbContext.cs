using Microsoft.EntityFrameworkCore;
using session1.Models;

namespace session1.Data
{
    public class ApplicationDbContext:DbContext
    {
        public DbSet<Category> Categories { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=DESKTOP-PBMMBBC; Database=CRUD; TrustServerCertificate=True; Trusted_connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "category 1"},
                new Category { Id = 2, Name = "category 2" },
                new Category { Id = 3, Name = "category 3" },
                new Category { Id = 4, Name = "category 4" },
                new Category { Id = 5, Name = "category 5" }
                );
        }
    }
}
