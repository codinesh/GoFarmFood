using GoFarmFood.Web.DataAccess.Entities.ConsumerAggregate;
using GoFarmFood.Web.DataAccess.Entities.FarmerAggregate;
using GoFarmFood.Web.DataAccess.Entities.OrderAggregate;
using GoFarmFood.Web.DataAccess.Entities.ProductAggregate;
using Microsoft.EntityFrameworkCore;

namespace GoFarmFood.DataAccess.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Farmer> Farmers { get; set; }
        public DbSet<Rider> Riders { get; set; }
        public DbSet<Consumer> Consumers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductItem> ProductItems { get; set; }
        public DbSet<ProductPrice> ProductPrice { get; set; }
        public DbSet<AvailableItem> AvailableItems { get; set; }
        public DbSet<PreferredFarmer> PreferredFarmer { get; set; }
        public DbSet<PaymentInformation> PaymentInformation { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Consumer>().HasMany(c => c.Orders).WithOne().OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Rider>().HasMany(c => c.Orders).WithOne().OnDelete(DeleteBehavior.Restrict);
        }
    }
}
