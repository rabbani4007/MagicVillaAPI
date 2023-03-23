using MagicVilla_VillaAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace MagicVilla_VillaAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        public DbSet<Villa> Villas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Villa>().HasData(
                new Villa() { 
                Id=1,
                Name="Royal Villa",
                Details ="details",
                ImageUrl="",
                Rate=20,
                Occupancy=20,
                Sqft=300,
                Amenity="",
                CreatedDate = DateTime.Now,

                },
                new Villa()
                {
                    Id = 2,
                    Name = "Beach Villa",
                    Details = "details beach villas",
                    ImageUrl = "",
                    Rate = 10,
                    Occupancy = 10,
                    Sqft = 100,
                    Amenity = "",
                    CreatedDate = DateTime.Now,

                }
                );
        }

    }
}
