using Amazon.DL.Contracts;
using Amazon.DL.Entites;
using Microsoft.EntityFrameworkCore;

namespace Amazon.DL.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public ProductRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<Product>> GetAllProductsAsync()
        {
            var products = await _dbContext.Products.ToListAsync();
            return products;
        }

        public Task<Product> GetProductAsync(int productId)
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetProductAsync(string productCode)
        {
            throw new NotImplementedException();
        }

        public Task<int> CreateProductAsync(Product newProduct)
        {
            throw new NotImplementedException();
        }

        public Task<Product> UpdateProductAsync(Product product)
        {
            throw new NotImplementedException();
        }
        public Task<int> DeleteProductAsync(int productId)
        {
            throw new NotImplementedException();
        }

    }
}
