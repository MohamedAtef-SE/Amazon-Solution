using Amazon.Application.BL.Contracts;
using Amazon.DL.Contracts;
using Amazon.DL.Entites;
using Amazon.DL.Repositories;
using System.Threading.Tasks;

namespace Amazon.Application.BL.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository)
        {
            this._productRepository = productRepository;
        }
        public  async Task<List<ProductDTO>> GetAllProductsAsync()
        {
            List<ProductDTO> productsDTOList = new List<ProductDTO>();

            var products = await  _productRepository.GetAllProductsAsync();

            foreach (Product product in products)
            {
                ProductDTO productDTO = new ProductDTO()
                {
                    Id = product.Id,
                    Code = product.Code,
                    Description = product.Description,
                    Price = product.Price,
                    ProductName = product.ProductName 
                };
                productsDTOList.Add(productDTO);
            }

            return productsDTOList;
        }


        public Task<ProductDTO> GetProductAsync(int productId)
        {
            throw new NotImplementedException();
        }


        public Task<ProductDTO> GetProductAsync(string productCode)
        {
            throw new NotImplementedException();
        }


        public Task<int> CreateProductAsync(ProductDTO newProductDTO)
        {
            throw new NotImplementedException();
        }


        public Task<ProductDTO> UpdateProductAsync(ProductDTO productDTO)
        {
            throw new NotImplementedException();
        }


        public Task<int> DeleteProductAsync(int productId)
        {
            throw new NotImplementedException();
        }
    }
}
