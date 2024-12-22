namespace Blazor.NET9.Models
{
    public class Product
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public bool IsActive { get; set; }

        public double Price { get; set; }
    }
}
