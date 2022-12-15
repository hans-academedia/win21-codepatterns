namespace _03_FRONTEND.Models
{
    public class Product
    {
        string Category { get; set; }
        string Description { get; set; }
        Guid Id { get; set; }
        string Name { get; set; }
        decimal Price { get; set; }
    }
}
