namespace _03_ISP.Interfaces
{
    public interface IProductItem
    {
        public string ArticleNumber { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
    }
}
