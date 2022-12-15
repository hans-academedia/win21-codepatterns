using _03_ISP.Interfaces;

namespace _03_ISP.Models
{
    public class Watch : IWatch
    {
        public bool IsDigital { get; set; }
        public bool WatherProof { get; set; }
        public string ArticleNumber { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
    }
}
