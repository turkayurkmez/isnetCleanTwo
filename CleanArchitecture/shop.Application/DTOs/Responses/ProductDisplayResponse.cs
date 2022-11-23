namespace shop.Application.DTOs.Responses
{
    public class ProductDisplayResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal? Price { get; set; }
        public double? Discount { get; set; }
        public string? Description { get; set; }

    }
}