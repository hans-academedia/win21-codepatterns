using _03_ISP.Interfaces;

namespace _03_ISP.Models
{
    public class Dress : IDress
    {
        public int Width { get; set; }
        public int Length { get; set; }
        public string ArticleNumber { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
    }
}
