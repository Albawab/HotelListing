using Microsoft.EntityFrameworkCore;

namespace HotelListing.Data
{
    public class DatabaseContext :DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        { }

        // Fluent Api
        // لايمكن حذف اي جدول بدون هذا
        protected override void OnModelCreating(ModelBuilder builder)
        {
            // التحديد
            // Seed
            builder.Entity<Country>().HasData(
                new Country
                {
                    Id =1,
                    Name = "Jamaica",
                    ShortName ="JM"
                     
                },
                new Country
                {
                    Id = 2,
                    Name = "Bahamas",
                    ShortName = "BS"
                }
                );
            
            builder.Entity<Hotel>().HasData(
                new Hotel
                {
                    Id =1,
                    Name = "Sandals",
                    Address ="Negril",
                    CountryId=1,
                    Rating = 4.5
                     
                },
                new Hotel
                {
                    Id = 2,
                    Name = "Grand Palldium",
                    Address = "Nassua",
                    CountryId = 2,
                    Rating = 5
                }
                );
        }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Hotel> Hotels{ get; set; }
    }
}
