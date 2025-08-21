using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon.Application.BL.Contracts
{
    public interface IProductService
    {
        Task<List<ProductDTO>> GetAllProductsAsync();
        Task<ProductDTO> GetProductAsync(int productId);
        Task<ProductDTO> GetProductAsync(string productCode);
        Task<int> CreateProductAsync(ProductDTO newProductDTO);
        Task<ProductDTO> UpdateProductAsync(ProductDTO productDTO);
        Task<int> DeleteProductAsync(int productId);

    }
}
