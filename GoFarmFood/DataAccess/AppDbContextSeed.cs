using GoFarmFood.DataAccess.Context;
using GoFarmFood.Web.DataAccess.Entities.Common.Enums;
using GoFarmFood.Web.DataAccess.Entities.FarmerAggregate;
using GoFarmFood.Web.DataAccess.Entities.OrderAggregate;
using GoFarmFood.Web.DataAccess.Entities.ProductAggregate;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microsoft.eShopWeb.Infrastructure.Data
{
    public class AppDbContextSeed
    {
        public static Guid farmerId = Guid.NewGuid();
        public static Guid farmerId1 = Guid.NewGuid();
        private static Guid itemId1 = Guid.NewGuid();
        private static Guid itemId2  = Guid.NewGuid();
        private static Guid itemId = Guid.NewGuid();

        public static async Task SeedAsync(AppDbContext appDBContext,
            ILoggerFactory loggerFactory, int? retry = 0)
        {
            int retryForAvailability = retry.Value;
            try
            {
                // TODO: Only run this if using a real database
                // context.Database.Migrate();

                if (!appDBContext.Farmers.Any())
                {
                    appDBContext.Farmers.AddRange(
                        GetPreconfiguredFarmers());

                    await appDBContext.SaveChangesAsync();
                }

                if (!appDBContext.Products.Any())
                {
                    appDBContext.Products.AddRange(
                        GetPreconfiguredItems());

                    await appDBContext.SaveChangesAsync();
                }

                if (!appDBContext.AvailableItems.Any())
                {
                    appDBContext.AvailableItems.AddRange(
                        GetPreconfiguredAvailableItems());

                    await appDBContext.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                if (retryForAvailability < 10)
                {
                    retryForAvailability++;
                    var log = loggerFactory.CreateLogger<AppDbContextSeed>();
                    log.LogError(ex.Message);
                    await SeedAsync(appDBContext, loggerFactory, retryForAvailability);
                }
            }
        }

        static IEnumerable<Farmer> GetPreconfiguredFarmers()
        {
            return new List<Farmer>()
            {
                new Farmer() { FirstName = "Dinesh" , LastName = "C O", Id = farmerId, Address = new GoFarmFood.Web.DataAccess.Entities.Common.Address{ Id = Guid.NewGuid(), ZipCode = 517503 }, LastModifiedOn = DateTime.UtcNow },
                new Farmer() { FirstName = "Harish" , LastName = "C O", Id = farmerId1, Address = new GoFarmFood.Web.DataAccess.Entities.Common.Address{ Id = Guid.NewGuid(), ZipCode = 517503 }, LastModifiedOn = DateTime.UtcNow },
            };
        }

        static IEnumerable<Product> GetPreconfiguredItems()
        {
            return new List<Product>()
            {
                new Product() {
                    Id = itemId,
                    Category = Category.BuffalloMilk,
                    Name = "Buffallo Milk"
                },

                 new Product() {
                    Id = itemId1,
                    Category = Category.CowGhee,
                    Name = "Cow Ghee",
                },

                  new Product() {
                    Id = itemId2,
                    Category = Category.CowMilk,
                    Name = "Cow Milk",
                },
            };
        }

        static IEnumerable<AvailableItem> GetPreconfiguredAvailableItems()
        {
            return new List<AvailableItem>()
            {
                new AvailableItem() {
                    Id = Guid.NewGuid(),
                    FarmerId = farmerId,
                    CapacityPerDay = 10,
                    ProductItemId = itemId
                },

                new AvailableItem() {
                    Id = Guid.NewGuid(),
                    FarmerId = farmerId,
                    CapacityPerDay = 10,
                    ProductItemId = itemId1
                },

                new AvailableItem() {
                    Id = Guid.NewGuid(),
                    FarmerId = farmerId1,
                    CapacityPerDay = 10,
                    ProductItemId = itemId1
                },

                new AvailableItem() {
                    Id = Guid.NewGuid(),
                    FarmerId = farmerId1,
                    CapacityPerDay = 10,
                    ProductItemId = itemId2
                },

                new AvailableItem() {
                    Id = Guid.NewGuid(),
                    FarmerId = farmerId1,
                    CapacityPerDay = 10,
                    ProductItemId = itemId
                },
            };
        }
    }
}
