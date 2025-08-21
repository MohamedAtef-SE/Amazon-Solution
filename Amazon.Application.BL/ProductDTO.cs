namespace Amazon.Application.BL
{
    public class ProductDTO
    {
        public int Id { get; set; }
        public string ProductName { get; set; } = null!;
        public string? Description { get; set; }
        public string Code { get; set; } = null!;
        public decimal Price { get; set; }
    }
}
