using Amazon.Application.BL;
using Amazon.Application.BL.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace Amazon.WebAPI.PL.Controllers
{
    [Route("api/[controller]")] // {{BaseURL}}/api/Products
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("GetAllProducts")] // GET: {{BaseURL}}/api/Products
        public async Task<ActionResult<List<ProductDTO>>> GetAllProductsAsync()
        {
            var products = await _productService.GetAllProductsAsync();
            return products is not null ? Ok(products) : NotFound("no products found.");
        }

        [HttpGet("{productId}")] // GET: {{BaseURL}}/api/Products/10
        public async Task<ActionResult<ProductDTO>> GetProductAsync([FromRoute] int productId)
        {
            var product = await _productService.GetProductAsync(productId);
            return product is not null ? Ok(product) : BadRequest($"product not found with Id: {productId}");
        }

        [HttpGet] // GET: {{BaseURL}}/api/Products?productCode=10AB20
        public async Task<ActionResult<ProductDTO>> GetProductAsync([FromQuery] string productCode)
        {
            var product = await _productService.GetProductAsync(productCode);
            return product is not null ? Ok(product) : BadRequest();
        }

        [HttpPost("CreateProduct")] // POST: {{BaseURL}}/api/Products/CreateProduct
        public async Task<ActionResult<int>> CreateProductAsync([FromBody] ProductDTO newProductDTO)
        {
            var productId = await _productService.CreateProductAsync(newProductDTO);
            return productId != 0 ?
                Ok(new { StatusCode = 201, ProductId = productId, Message = "Created Successfully" })
                :
                BadRequest("Something went wrong during creating product.");
        }

        [HttpPut] // PUT: {{BaseURL}}/api/Products
        public async Task<ActionResult<ProductDTO>> UpdateProductAsync([FromBody] ProductDTO productDTO)
        {
            var updatedProduct = await _productService.UpdateProductAsync(productDTO);
            return updatedProduct != null ?
               Ok(new { StatusCode = 201, Product = updatedProduct, Message = "Updated Successfully" })
               :
               BadRequest("Something went wrong during updating product.");
        }

        [HttpDelete("Id/{productId}")] // DELETE:{{BaseURL}}/api/Products/Id/10
        public async Task<ActionResult<int>> DeleteProductAsync([FromRoute] int productId)
        {
            var numberOfRowsEffected = await _productService.DeleteProductAsync(productId);

            if (numberOfRowsEffected > 0)
                return Ok(new { StatusCode = 200, Message = "Deleted Successfully" });
            else
                return BadRequest("Something went wrong during deleting product.");

        }
    }
}
