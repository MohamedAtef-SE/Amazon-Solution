using Amazon.DL.Entites;

namespace Amazon.DL.Contracts
{
    public interface IProductRepository
    {
        Task<List<Product>> GetAllProductsAsync();
        Task<Product> GetProductAsync(int productId);
        Task<Product> GetProductAsync(string productCode);
        Task<int> CreateProductAsync(Product newProduct);
        Task<Product> UpdateProductAsync(Product product);
        Task<int> DeleteProductAsync(int productId);
    }
}
