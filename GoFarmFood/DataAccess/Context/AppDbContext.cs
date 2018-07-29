using GoFarmFood.Web.DataAccess.Entities.ConsumerAggregate;
using GoFarmFood.Web.DataAccess.Entities.FarmerAggregate;
using GoFarmFood.Web.DataAccess.Entities.OrderAggregate;
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
        public DbSet<Consumer> Consumers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<AvailableItem> AvailableItems { get; set; }
        public DbSet<PreferredFarmer> PreferredFarmer { get; set; }
        public DbSet<PaymentInformation> PaymentInformation { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
