namespace _03_ISP.Interfaces
{
    public interface IDress : IProductItem
    {
        public int Width { get; set; }
        public int Length { get; set; }
    }
}
