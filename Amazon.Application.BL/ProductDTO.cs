namespace Amazon.Application.BL
{
    public class ProductDTO
    {
        public int Id { get; set; }
        public string ProductName { get; set; } = null!;
        public string? Description { get; set; }
        public string Code { get; set; } = null!;
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        public int BrandId { get; set; }
    }
}
