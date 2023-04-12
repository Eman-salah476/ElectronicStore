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
            modelBuilder.Entity<Device>()
                .HasOne<Category>(d => d.Category)
                .WithMany(c => c.Devices).HasForeignKey(d => d.CategoryId);
            
            modelBuilder.Entity<Device>()
                .HasOne<Brand>(d => d.Brand)
                .WithMany(b => b.Devices).HasForeignKey(d => d.BrandId);

            modelBuilder.Entity<DeviceProps>()
                .HasKey(x => x.Id);
            
            modelBuilder.Entity<DeviceProps>()
                .HasOne<Device>(x => x.Device)
                .WithMany(d => d.DeviceProps).HasForeignKey(x => x.DeviceId);
           
            modelBuilder.Entity<DeviceProps>()
                .HasOne<Property>(x => x.Property)
                .WithMany(d => d.DeviceProps).HasForeignKey(x => x.PropertyId);

            modelBuilder.Entity<Offer>()
                .HasOne<Device>(o => o.Device)
                .WithMany(d => d.Offers).HasForeignKey(o => o.DeviceId);

            modelBuilder.Entity<CategoryBrands>()
                .HasKey(x => x.Id);
           
            modelBuilder.Entity<CategoryBrands>()
                .HasOne<Category>(x => x.Category)
                .WithMany(c => c.CategoryBrands).HasForeignKey(x => x.CatgoryId);
           
            modelBuilder.Entity<CategoryBrands>()
                .HasOne<Brand>(x => x.Brand)
                .WithMany(c => c.CategoryBrands).HasForeignKey(x => x.BrandId);

            modelBuilder.Entity<CategoryProps>()
               .HasKey(x => x.Id);
           
            modelBuilder.Entity<CategoryProps>()
                .HasOne<Category>(x => x.Category)
                .WithMany(c => c.CategoryProps).HasForeignKey(x => x.CatgoryId);
           
            modelBuilder.Entity<CategoryProps>()
                .HasOne<Property>(x => x.Property)
                .WithMany(c => c.CategoryProps).HasForeignKey(x => x.PropertyId);


            //Seeding
            modelBuilder.ApplyConfiguration(new CategorySeeder());
        }
    }
}
