using lesson1.Models;
using Microsoft.EntityFrameworkCore;

namespace lesson1.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions options): base(options) 
        { 

        }
        public DbSet<Shirt> Shirts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //data seeding
            modelBuilder.Entity<Shirt>().HasData(
                new Shirt() { ShirtId = 1, Brand = "Nike", Color = "Red", Size = 42, Gender = "Men", price = 3 },
                new Shirt() { ShirtId = 2, Brand = "Nike", Color = "Blue", Size = 42, Gender = "Men", price = 33 },
                new Shirt() { ShirtId = 3, Brand = "Nike", Color = "Pink", Size = 42, Gender = "Men", price = 23 },
                new Shirt() { ShirtId = 4, Brand = "Nike", Color = "Yello", Size = 42, Gender = "Men", price = 63 }
                );
        }
    }
}
