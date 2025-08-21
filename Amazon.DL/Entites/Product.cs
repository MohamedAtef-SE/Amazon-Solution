namespace Amazon.DL.Entites
{
    public class Product
    {
        public int Id { get; set; }
       
        public string ProductName { get; set; } = null!;
        public string? Description { get; set; }
        public string Code { get; set; } = null!;
        public decimal Price { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int SeUserId { get; set; }
    }
}
