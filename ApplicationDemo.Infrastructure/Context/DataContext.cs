using ApplicationDemo.Domain.Entities;
using ApplicationDemo.Infrastructure.DataSeeder;
using Microsoft.EntityFrameworkCore;

namespace ApplicationDemo.Infrastructure.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
         : base(options)
        {
        }

        public DbSet<Device> Devices { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<CategoryBrands> CategoryBrands { get; set; }
        public DbSet<CategoryProps> CategoryProps { get; set; }
        public DbSet<Property> Properties { get; set; }
        public DbSet<DeviceProps> DeviceProps { get; set; }
        public DbSet<Offer> Offers { get; set; }
        public DbSet<Order> Orders { get; set; }

        


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategorySeeder());
        }
    }
}
