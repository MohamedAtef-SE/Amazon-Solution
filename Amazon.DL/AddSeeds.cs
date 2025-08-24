using Amazon.DL.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Text.Json;

namespace Amazon.DL
{
    public static class AddSeeds
    {
        public static async Task AddSeedData(ApplicationDbContext _dbContext)
        {
            var pendingMigrations = await _dbContext.Database.GetPendingMigrationsAsync();
            if (pendingMigrations.Any())
            {
                await _dbContext.Database.MigrateAsync();
            }

            if(await _dbContext.Products.AnyAsync()) return;
            var productsAsJson = await File.ReadAllTextAsync("../Amazon.DL/Data/DataSeeds/products.json");
            var products = JsonSerializer.Deserialize<List<Product>>(productsAsJson);

            if (products is not null) await _dbContext.AddRangeAsync(products);
            else throw new Exception("products not found");

            var  numberofrows = await _dbContext.SaveChangesAsync();

        }


    }
}
